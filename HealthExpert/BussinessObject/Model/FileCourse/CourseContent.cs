using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BussinessObject.Model.FileCourse
{
    public class CourseContent
    {
        [Required]
        public int courseId {  get; set; }
        [Required] public string video { get; set; }
        [Required] public string title { get; set; }

        [JsonIgnore]
        public virtual Course? Course { get; set; }
    }
}
