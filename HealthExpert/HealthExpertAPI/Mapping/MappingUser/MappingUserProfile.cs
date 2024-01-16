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
                .ForMember(e => e.userName, d => d.MapFrom(src => src.Item2.userName))
                .ForMember(e => e.password, d => d.MapFrom(src => src.Item2.password))
                .ForMember(e => e.firstName, d => d.MapFrom(src => src.Item2.firstName))
                .ForMember(e => e.lastName, d => d.MapFrom(src => src.Item2.lastName))
                .ForMember(e => e.phone, d => d.MapFrom(src => src.Item2.phone))
                .ForMember(e => e.email, d => d.MapFrom(src => src.Item2.email))
                .ForMember(e => e.gender, d => d.MapFrom(src => src.Item2.gender))
                .ForMember(e => e.birthDate, d => d.MapFrom(src => src.Item2.birthDate))
                .ForMember(e => e.avatar, d => d.MapFrom(src => src.Item2.avatar))
                .ForMember(e => e.wallpaper, d => d.MapFrom(src => src.Item2.wallpaper))
                .ForMember(e => e.roleId, d => d.MapFrom(src => src.Item2.roleId))
                .ForMember(e => e.isActive, d => d.MapFrom(src => src.Item2.isActive));
        }
    }
}
