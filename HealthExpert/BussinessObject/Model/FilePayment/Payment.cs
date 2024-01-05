using BussinessObject.Model.FileCourse;
using BussinessObject.Model.FilePayment;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BussinessObject.Model.FilePayment
{
    public class Payment
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int paymentId { get; set; }
        [Required] public DateTime paymentDate { get; set; } = DateTime.Now;
        [Required] public decimal paymentAmount { get; set; }
        [Required] public PaymentStatus paymentStatus {  get; set; }

        [Required] public int courseId { get; set; }
        [Required] public Guid userId { get; set; }

        [JsonIgnore]
        public virtual User? User { get; set; }
        [JsonIgnore]
        public virtual Course? Course { get; set; }
    }
}
