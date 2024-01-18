namespace HealthExpertAPI.DTO.DTOPost
{
    public class PostDTO
    {
        public int postId { get; set; }
        public string postTitle { get; set; } = string.Empty;
        public string postContent { get; set; } = string.Empty;
        public DateTime postDate { get; set; } = DateTime.Now;
    }
}
