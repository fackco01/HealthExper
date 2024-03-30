namespace HealthExpertAPI.DTO.DTOPost
{
    public class PostDTOUpdate
    {
        public int postId { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public string imageFile { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public DateTime publishAt { get; set; }
    }
}
