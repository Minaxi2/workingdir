using System.Linq;
using AutoMapper;
using jwt_api.Controllers.Resources;
using jwt_api.Core.Domain.Models;

namespace jwt_api.Mapping
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<UserCredentialsResource, User>();
        }
    }
}