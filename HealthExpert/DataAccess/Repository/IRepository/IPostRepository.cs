using BussinessObject.Model.ModelPost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.IRepository
{
    public interface IPostRepository
    {
        void AddPost(Post post);
        void DeletePost(int postId);
        List<Post> GetPosts();
        Post GetPostById(int postId);
        void UpdatePost(Post post);
        void LikePost(int postId, string userName);
    }
}
