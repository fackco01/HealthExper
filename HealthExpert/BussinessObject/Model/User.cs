using BussinessObject.Model.Authen;
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
    public class User
    {
        [Key]
        public Guid userId { get; set; }
        [Required] public string userName { get; set; }
        [Required] public string firstName { get; set; }
        [Required] public string lastName { get; set; }
        [Required] public string phone { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }
        [Required]
        [StringLength(100)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$")]
        [DataType(DataType.Password)]
        public string password { get; set; }
        [Required] public bool gender { get; set; }
        public DateTime createDate { get; set; } = DateTime.Now;
        [Required] public int roleId { get; set; }

        [JsonIgnore]
        public virtual Role Role { get; set; }
    }
}
