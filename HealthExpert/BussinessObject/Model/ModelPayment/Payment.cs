using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace BussinessObject.Model.ModelPayment
{
    public class Payment
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int paymentId { get; set; }
        public string? provider { get; set; }
        public int? accountNumber { get; set; }
        public DateTime? expiryDate { get; set; }
        public bool? isPaid { get; set; }
        [Required]public Guid? orderId { get; set; }

        //VnPaymentResponseModel
        public string? orderDescription { get; set; } 
        public string? transactionId { get; set; }
        public string? token { get; set; }
        public string? vnPayResponseCode { get; set; }
        public string? paymentMethod { get; set; }

        [JsonIgnore]
        public virtual Order? order { get; set; }
    }

    public class PaymentRequest
    {
        public Guid? orderId { get; set; }
        public string? fullName { get; set; }
        public string? description { get; set; }
        public double? amount { get; set; }
        public DateTime createdDate { get; set; }

        [JsonIgnore]
        public virtual Order? order { get; set; }
    }
}
