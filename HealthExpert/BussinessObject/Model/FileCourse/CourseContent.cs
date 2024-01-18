using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BussinessObject.Model.FileCourse
{
    /// <summary>
    /// Chinh sua lai Database
    /// </summary>
    public class CourseContent
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int contentId {  get; set; }
        [Required]
        public int coursesId { get; set; }
        [Required] public string video { get; set; }
        [Required] public string title { get; set; }
        [Required] public bool isActive { get; set; }

        [JsonIgnore]
        public virtual Course? Courses { get; set; }
    }
}
