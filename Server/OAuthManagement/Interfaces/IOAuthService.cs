using OAuthManagement.Models.Requests;
using OAuthManagement.Models.ViewModels;
using System.Threading.Tasks;

namespace OAuthManagement.Interfaces
{
    public interface IOAuthService
    {
        Task<ClientViewModel> GetDetails(SearchDetailsRequest request);
        Task UpdateOAuthDb(OAuthDbUpdateRequest request);
    }
}
