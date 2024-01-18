using BussinessObject.ContextData;
using BussinessObject.Model.FilePost;
using DataAccess.DAO;
using DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class PostRepository : IPostRepository
    {
        public void CreatePost(Post post, string userId) => PostDAO.AddPost(post, userId);
        public void DeletePost(Post post) => PostDAO.DeletePost(post);
        public List<Post> GetAllPosts() => PostDAO.GetListPosts();
        public Post GetPostById(int id) => PostDAO.GetPost(id);
        public void UpdatePost(int id, Post post) => PostDAO.UpdatePost(id, post);

    }
}
