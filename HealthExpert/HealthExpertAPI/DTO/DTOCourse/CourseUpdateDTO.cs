namespace HealthExpertAPI.DTO.DTOCourse
{
    public class CourseUpdateDTO
    {
        public string courseName { get; set; } = string.Empty;
        public string title { get; set; } = string.Empty;
        public string price { get; set; } = string.Empty;
        public string rate { get; set; } = string.Empty; 
        public DateTime createDate { get; set; } = DateTime.Now;
        public bool isActive { get; set; } = true;
        public int businessId { get; set; }     
    }
}
