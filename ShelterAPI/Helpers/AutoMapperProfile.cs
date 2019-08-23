using AutoMapper;
using ShelterAPI.Dtos;
using ShelterAPI.Models;

namespace ShelterAPI.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();
        }
    }
}