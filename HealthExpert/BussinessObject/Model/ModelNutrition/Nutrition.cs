using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject.Model.ModelSession
{
    public class Nutrition
    {
        [Key]
        public Guid nutriId { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public bool isActive { get; set; }
        public virtual ICollection<Session> Sessions { get; set; }
        
    }
}
