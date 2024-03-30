using System.Text.Json.Serialization;

namespace HealthExpertAPI.DTO.DTOCourse
{
    public class CourseManagerDTO
    {
        public string courseId { get; set; }
        public int courseManagerId { get; set; }
        [JsonIgnore]
        public List<string> accountEmails { get; set; }
    }
}
