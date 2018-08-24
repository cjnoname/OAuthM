using System.Collections.Generic;
using System.Threading.Tasks;
using OAuthManagement.Interfaces;
using OAuthManagement.Models.OAuthDb;
using OAuthManagement.Models.Requests;
using Microsoft.EntityFrameworkCore;
using OAuthManagement.Models.LotusDb;
using System.Linq;
using OAuthManagement.Models.ViewModels;
using AutoMapper;
using System;

namespace OAuthManagement.Services
{
    public class OAuthService : IOAuthService
    {
        private readonly OAuthContext _oAuthContext;
        private readonly LotusContext _lotusContext;
        private readonly IMapper _mapper;

        public OAuthService(
            OAuthContext oAuthContext,
            LotusContext lotusContext,
            IMapper mapper)
        {
            _oAuthContext = oAuthContext;
            _lotusContext = lotusContext;
            _mapper = mapper;
        }

        public async Task<ClientViewModel> GetDetails(SearchDetailsRequest request)
        {
            var clientId = (!string.IsNullOrWhiteSpace(request.Token)
                ? (await _oAuthContext.AccessToken.SingleOrDefaultAsync(x => x.Token == request.Token))?.ClientId
                : request.ClientId)?.Trim();

            if (string.IsNullOrWhiteSpace(clientId))
            {
                return null;
            }

            var client = _mapper.Map<ClientViewModel>(await _oAuthContext.Client.SingleOrDefaultAsync(x => x.ClientId == clientId));
            client.ClientImpersonations1 = await _oAuthContext.ClientImpersonation.Where(x => x.ImpersonateClientId == clientId).ToListAsync();
            client.ClientImpersonations2 = await _oAuthContext.ClientImpersonation.Where(x => x.ClientId == clientId).ToListAsync();
            client.ClientGrantTypes = await _oAuthContext.ClientGrantType.Where(x => x.ClientId == clientId).ToListAsync();
            client.ClientIdentities = await _oAuthContext.ClientIdentity.Where(x => x.ClientId == clientId).ToListAsync();
            client.ClientParameters = await _oAuthContext.ClientParameter.Where(x => x.ClientId == clientId).ToListAsync();
            client.ClientAccessParameters = await _oAuthContext.ClientAccessParameter.Where(x => x.ClientId == clientId).ToListAsync();
            client.ClientResourceAccesses = await _oAuthContext.ClientResourceAccess.Where(x => x.ClientId == clientId).ToListAsync();

            var place = (clientId.Length == 6 && char.IsNumber(clientId[5])) ? clientId.Substring(0, 5) : null;
            if (place != null)
            {
                client.TblSysUsers = await _lotusContext.TblSysUser.Where(x => x.UserName.StartsWith(place)).ToListAsync();
                using (var reader = (await _oAuthContext.Database.ExecuteSqlCommandAsync($"SELECT * FROM dbo.OriginPromoter WHERE Place='{place}'")).DbDataReader)
                {
                    client.OriginPromoters = reader.Select(row => new OriginPromoter
                    {
                        // didn't check null due to the restrictions of database which is secure
                        Place = row[0].ToString(),
                        Promoter = row[1].ToString(),
                        CanSell = (Boolean)row[2],
                        CanReport = (Boolean)row[3]
                    }).ToList();
                }
            }

            return client;
        }

        public async Task UpdateOAuthDb(OAuthDbUpdateRequest request)
        {
            // Create client basic information
            await _oAuthContext.Client.AddAsync(new Client
            {
                ClientId = request.ClientId,
                Secret = request.ClientSecret,
                Name = request.ClientName
            });

            // Configure standard token expiry 
            await _oAuthContext.ClientConfig.AddAsync(new ClientConfig
            {
                ClientId = request.ClientId,
                MaxActiveAccessTokens = 50,
                MaxTokenExpirySeconds = 8000,
                ExpireOldestTokenOnExceedMax = true
            });

            // Configure the NewClient to be able access the resources of the defined seller
            await _oAuthContext.ClientAccessParameter.AddRangeAsync(new List<ClientAccessParameter>
            {
                new ClientAccessParameter
                {
                    ResourceId = "product_content",
                    ClientId = request.ClientId,
                    Key = "organisation_ids",
                    Value = "[0]",
                    IncludeInResponse = true
                },

                new ClientAccessParameter
                {
                    ClientId = request.ClientId,
                    Key = "permission_level",
                    Value = "4",
                    IncludeInResponse = true
                },

                new ClientAccessParameter
                {
                    ClientId = request.ClientId,
                    Key = "place_code",
                    Value = request.PlaceCode,
                    IncludeInResponse = true
                },

                new ClientAccessParameter
                {
                    ClientId = request.ClientId,
                    Key = "place_code",
                    Value = request.PlaceCode,
                    IncludeInResponse = true
                },

                new ClientAccessParameter
                {
                    ClientId = request.ClientId,
                    Key = "chain_code",
                    Value = request.ChainCode,
                    IncludeInResponse = true
                },

                new ClientAccessParameter
                {
                    ClientId = request.ClientId,
                    Key = "performance_code",
                    Value = request.PlaceCode,
                    AccessProviderId = "OriginPromMatch",
                    IncludeInResponse = false
                }
            });

            await _oAuthContext.ClientParameter.AddAsync(new ClientParameter
            {
                ClientId = request.ClientId,
                Key = "username",
                Value = request.ClientId
            });

            // Allow MobileAppServices to impersonate the new client
            await _oAuthContext.ClientImpersonation.AddAsync(new ClientImpersonation
            {
                ClientId = "MobileAppServices",
                ImpersonateClientId = request.ClientId,
                Scope = "product_content.read customers.read prices.read"
            });

            // Confiugre the resources the client has access
            await _oAuthContext.ClientResourceAccess.AddRangeAsync(
                new List<ClientResourceAccess>
                {
                    new ClientResourceAccess
                    {
                        ClientId = request.ClientId,
                        ResourceId = "mobile_app_services",
                        Access = "*"
                    }
                }
            );

            await _oAuthContext.SaveChangesAsync();
        }
    }
}
