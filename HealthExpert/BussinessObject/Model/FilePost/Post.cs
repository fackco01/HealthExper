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
    public class Post
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int postId { get; set; }
        [Required] public string postTitle { get; set;}
        [Required] public string postContent { get; set;}
        [Required] public DateTime postDate { get; set;} = DateTime.Now;

        [Required] public Guid userId { get; set; }

        [JsonIgnore]
        public virtual User? User { get; set; }
        [JsonIgnore]
        public virtual ICollection<PostComment> PostComments { get; set; }
    }
}
