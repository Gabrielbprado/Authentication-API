using Authentication_API.Data.Dtos;
using Authentication_API.Models;
using AutoMapper;

namespace Authentication_API.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile() 
        {
            CreateMap<CreatedUserDto, User>();
        }
    }
}
