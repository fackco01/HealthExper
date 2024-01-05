using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BussinessObject.Model
{
    public class BMI
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int bmiId { get; set; }
        [Required] public string value { get; set; }
        [Required] public string photoBefore { get; set; }
        [Required] public string photoAfter { get; set; }
        [Required] public string height { get; set; }
        [Required] public string weight { get; set; }
        [Required] public DateTime captureDate { get; set; } = DateTime.Now;

        [Required] public Guid userId { get; set; }

        [JsonIgnore]
        public virtual User? User { get; set; }
    }
}
