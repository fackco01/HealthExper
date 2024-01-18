namespace HealthExpertAPI.DTO.DTOPost
{
    public class PostEditDTO
    {
        public string postTitle { get; set; } = string.Empty;
        public string postContent { get; set; } = string.Empty;
        public DateTime postDate { get; set; } = DateTime.Now;
    }
}
