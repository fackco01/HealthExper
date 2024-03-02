using BussinessObject.Model.ModelSession;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace HealthExpertAPI.DTO.DTOSession
{
    public class SessionDTO
    {
        public string sessionId { get; set; }
        [Required] public string sessionName { get; set; }
        [JsonIgnore] public DateTime dateStart { get; set; }
        [JsonIgnore] public DateTime dateEnd { get; set; }
        public string description { get; set; }
        [Required] public bool learnProgress { get; set; }
        //[Required] public string courseId { get; set; }
    }
}
