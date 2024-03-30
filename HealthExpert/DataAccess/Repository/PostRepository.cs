using BussinessObject.Model.ModelPost;
using DataAccess.DAO;
using DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    //PostRepository
    public class PostRepository : IPostRepository
    {
        public void AddPost(Post post)
        {
            PostDAO.AddPost(post);
        }

        public void DeletePost(int postId)
        {
            PostDAO.DeletePost(postId);
        }

        public List<Post> GetPosts()
        {
            return PostDAO.GetPosts();
        }

        public Post GetPostById(int postId)
        {
            return PostDAO.GetPostById(postId);
        }

        public void UpdatePost(Post post)
        {
            PostDAO.UpdatePost(post);
        }

        public void LikePost(int postId, string userName)
        {
            PostDAO.LikePost(postId, userName);
        }
    }
}
