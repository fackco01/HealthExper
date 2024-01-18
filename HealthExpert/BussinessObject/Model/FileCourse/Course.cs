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
    public class Course
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int courseId { get; set; }
        [Required] public string courseName { get; set; }
        [Required] public string title { get; set; }
        [Required] public string price { get; set; }
        [Required] public string rate { get; set; }
        [Required] public DateTime createDate { get; set; } = DateTime.Now;
        [Required] public bool isActive { get; set; }

        //[Required] public Guid userId { get; set; }
        [Required] public int businessId { get; set; }

        //[JsonIgnore]
        //public virtual User? User { get; set; }
        [JsonIgnore]
        public virtual Business? Business { get; set; }
        [JsonIgnore]
        public virtual ICollection<Enrollment>? Enrollments { get; set; }
        [JsonIgnore]
        [NotMapped]
        public ICollection<CourseContent>? CourseContents { get; set; }
    }
}
