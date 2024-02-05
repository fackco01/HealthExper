namespace HealthExpertAPI.DTO.DTOAccount
{
    public class AccountRegistrationDTO
    {
        //public Guid accountId { get; set; }
        public string userName { get; set; } = string.Empty;
        public string password { get; set; } = string.Empty;
        public string email { get; set; } = string.Empty;
        public string phone { get; set; }
        public string fullName { get; set; } = string.Empty;
        public bool gender { get; set; }
        public string birthDate { get; set; } = string.Empty;
        public int roleId { get; set; }
        public bool isActive { get; set; }
    }
}
