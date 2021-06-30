using AutoMapper;
using CrudClient.Dtos;
using CrudClient.Models;

namespace CrudClient.Profiles
{
    public class UsersProfile : Profile
    {
        public UsersProfile()
        {
            CreateMap<User, UserReadDtos>();
            CreateMap<CreateUserDtos, User>();
            CreateMap<UpdateUserDtos, User>();
        }
    }
}