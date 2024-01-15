using AutoMapper;
using BussinessObject.Model;
using HealthExpertAPI.DTO.DTOUser;

namespace HealthExpertAPI.Mapping.MappingUser
{
    public class MappingUserProfile : Profile
    {
        /// <summary>
        /// Tạo mapping cho user
        /// </summary>
        public MappingUserProfile()
        {
            CreateMap<User, UserDTO>();
            CreateMap<UserRegistrationDTO, User>();
            CreateMap<(Guid, UserUpdateDTO), User>()
                .ForMember(e => e.userId, d => d.MapFrom(src => src.Item1))
                .ForMember(e => e, d => d.MapFrom(src => src.Item2));
        }
    }
}
