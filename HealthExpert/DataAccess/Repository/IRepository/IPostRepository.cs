using BussinessObject.Model.FilePost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.IRepository
{
    public interface IPostRepository
    {
        List<Post> GetAllPosts();
        Post GetPostById(int id);
        void CreatePost(Post post, string userId);
        void UpdatePost(int id, Post post);
        void DeletePost(Post post);
    }
}
