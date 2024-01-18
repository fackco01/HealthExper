using BussinessObject.ContextData;
using BussinessObject.Model.FilePost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    public class PostDAO
    {
        //GET POST
        public static Post GetPost(int id)
        {
            var post = new Post();
            try
            {
                using (var ctx = new HealthExpertContext())
                {
                    post = ctx.Posts.FirstOrDefault(o => o.postId == id);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return post;
        }

        //GET LIST OF POST
        public static List<Post> GetListPosts()
        {
            List<Post> postList = new List<Post>();
            try
            {
                using (var ctx = new HealthExpertContext())
                {
                    postList = ctx.Posts.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return postList;
        }

        //DELETE POST
        public static void DeletePost(Post post)
        {
            try
            {
                using (var ctx = new HealthExpertContext())
                {
                    ctx.Posts.Remove(post);
                    ctx.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //ADD POST
        public static void AddPost(Post post, string userId)
        {
            try
            {
                using (var ctx = new HealthExpertContext())
                {
                    var user = ctx.Users.FirstOrDefault(o => o.userId == new Guid(userId));
                    post.userId = user.userId;
                    ctx.Posts.Add(post);
                    ctx.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //UPDATE POST
        public static void UpdatePost(int id, Post post)
        {
            try
            {
                using (var ctx = new HealthExpertContext())
                {
                    var postToUpdate = ctx.Posts.FirstOrDefault(o => o.postId == id);
                    postToUpdate.postTitle = post.postTitle;
                    postToUpdate.postContent = post.postContent;
                    postToUpdate.postDate = post.postDate;
                    //postToUpdate.userId = post.userId;
                    ctx.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
