namespace HealthExpertAPI.DTO.DTOUser
{
    public class UserUpdateDTO
    {
        public string userName { get; set; } = string.Empty;
        public string password { get; set; }
        public string firstName { get; set; } = string.Empty;
        public string lastName { get; set; } = string.Empty;
        public string phone { get; set; } = string.Empty;
        public string email { get; set; } = string.Empty;
        public bool gender { get; set; }
        public string birthDate { get; set; }
        public string avatar { get; set; } = string.Empty;
        public string wallpaper { get; set; } = string.Empty;
        public int roleId { get; set; }
        public bool isActive { get; set; } = true;
    }
}
