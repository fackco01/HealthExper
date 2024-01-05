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
    public class Enrollment
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int enrollmentId { get; set; }
        [Required]
        public DateTime enrollmentDate { get; set; } = DateTime.Now;

        [Required] public Guid userId { get; set;}
        [Required] public int courseId { get; set; }

        [JsonIgnore]
        public virtual User? User { get; set; }
        [JsonIgnore]
        public virtual Course? Course { get; set; }
    }
}
