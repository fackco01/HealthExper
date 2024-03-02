using BussinessObject.Model.Authen;
using BussinessObject.Model.ModelCourse;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BussinessObject.Model.ModelUser
{
    public class Account
    {
        [Key]
        public Guid accountId { get; set; }
        [Required] public string userName { get; set; }
        [Required] public string fullName { get; set; }
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
        [Required] public string birthDate { get; set; }
        public DateTime createDate { get; set; } = DateTime.Now;
        [Required] public bool isActive { get; set; }

        [Required] public int roleId { get; set; }

        // Additional properties
        public byte[]? passwordHash { get; set; } = new byte[32];
        public byte[]? passwordSalt { get; set; } = new byte[32];
        public string? verificationToken { get; set; }
        public DateTime? verifiedAt { get; set; }
        public string? passwordResetToken { get; set; }
        public DateTime? resetTokenExpires { get; set; }
        public virtual Role? role { get; set; }
        public ICollection<Enrollment>? enrollments { get; set; }
        public ICollection<Feedback>? feedbacks { get; set; }
        public virtual CourseAdmin? courseAdmin { get; set; }
        public virtual CourseManagement? courseManager { get; set; }
    }
}
