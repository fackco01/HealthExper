namespace HealthExpertAPI.DTO.DTOUser
{
    public class UserRegistrationDTO
    {
        public string userName { get; set; } = string.Empty;
        public string password { get; set; } 
        public string firstName { get; set; } = string.Empty;
        public string lastName { get; set; } = string.Empty;
        public string phone { get; set; } = string.Empty;
        public string email { get; set; } = string.Empty;
        public bool gender { get; set; }
        public string birthDate { get; set; } = string.Empty;
    }
}
