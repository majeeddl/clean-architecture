using AutoMapper;
using DotNetCleanTemplate.Api.Controllers.v1.Users.Requests;
using DotNetCleanTemplate.Application.Users.Command.CreateUser;
using DotNetCleanTemplate.Application.Users.Command.Login;
using DotNetCleanTemplate.Application.Users.Command.RefreshToken;

namespace DotNetCleanTemplate.Api.AutoMapperProfiles.Users
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<SingUpRequest, CreateUserCommand>();

            CreateMap<LoginRequest, LoginCommand>();
            CreateMap<RefreshTokenRequest, RefreshTokenCommand>();
        }
    }
}
