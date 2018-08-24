using OAuthManagement.Models.LotusDb;
using OAuthManagement.Models.OAuthDb;
using System.Collections.Generic;

namespace OAuthManagement.Models.ViewModels
{
    public class ClientViewModel
    {
        public string ClientId { get; set; }
        public string Secret { get; set; }
        public string Salt { get; set; }
        public string Name { get; set; }

        public ICollection<TblSysUser> TblSysUsers { get; set; } = new HashSet<TblSysUser>();
        public ICollection<ClientConfig> ClientConfigs { get; set; } = new HashSet<ClientConfig>();
        public ICollection<ClientGrantType> ClientGrantTypes { get; set; } = new HashSet<ClientGrantType>();
        public ICollection<ClientImpersonation> ClientImpersonations1 { get; set; } = new HashSet<ClientImpersonation>();
        public ICollection<ClientImpersonation> ClientImpersonations2 { get; set; } = new HashSet<ClientImpersonation>();
        public ICollection<ClientIdentity> ClientIdentities { get; set; } = new HashSet<ClientIdentity>();
        public ICollection<ClientParameter> ClientParameters { get; set; } = new HashSet<ClientParameter>();
        public ICollection<ClientAccessParameter> ClientAccessParameters { get; set; } = new HashSet<ClientAccessParameter>();
        public ICollection<ClientResourceAccess> ClientResourceAccesses { get; set; } = new HashSet<ClientResourceAccess>();
        public ICollection<AccessToken> AccessTokens { get; set; } = new HashSet<AccessToken>();
        public ICollection<OriginPromoter> OriginPromoters { get; set; } = new HashSet<OriginPromoter>();
    }
}
