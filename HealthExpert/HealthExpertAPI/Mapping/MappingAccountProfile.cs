using AutoMapper;
using BussinessObject.Model.Authen;
using BussinessObject.Model.ModelUser;
using HealthExpertAPI.DTO.DTOAccount;

namespace HealthExpertAPI.Mapping
{
    public class MappingAccountProfile : Profile
    {
        public MappingAccountProfile()
        {
            CreateMap<Account, AccountDTO>();
            CreateMap<AccountRegistrationDTO, Account>();
        }
    }
}
