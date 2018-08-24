using AutoMapper;
using OAuthManagement.Models.OAuthDb;
using OAuthManagement.Models.ViewModels;

namespace OAuthManagement.Models.MappingProfiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Client, ClientViewModel>();
        }
    }
}
