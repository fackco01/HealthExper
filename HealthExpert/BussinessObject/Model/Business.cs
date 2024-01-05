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
    public class Business
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int businessId { get; set; }
        [Required] public string businessName { get; set; }
        [Required] public string address { get; set; }
        public DateTime createDate { get; set; } = DateTime.Now;
        [Required]
        [DataType(DataType.EmailAddress)]
        public string email {  get; set; }
        [Required] public bool isActive {  get; set; }


        [Required] public Guid userId { get; set; }

        [JsonIgnore]
        public virtual ICollection<User>? Users { get; set;}
    }
}
