using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BussinessObject.Model.FilePost
{
    public class PostComment
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int commentId { get; set; }
        [Required] public string commentText { get; set;}
        [Required] public DateTime commentDate { get; set; } = DateTime.Now;

        [Required] public int postId { get; set; }
        //[Required] public Guid userId { get;set;}

        [JsonIgnore]
        public virtual User? Users { get; set; }
        [JsonIgnore]
        public virtual Post? Post { get; set; }
    }
}
