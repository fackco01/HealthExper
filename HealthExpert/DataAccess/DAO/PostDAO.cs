using BussinessObject.ContextData;
using BussinessObject.Model.ModelPost;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    //PostDAO
    public class PostDAO
    {
        public static void AddPost(Post post)
        {
            using (var context = new HealthExpertContext())
            {
                context.posts.Add(post);
                context.SaveChanges();
            }
        }

        public static void DeletePost(int postId)
        {
            using (var context = new HealthExpertContext())
            {
                var post = context.posts.Find(postId);
                context.posts.Remove(post);
                context.SaveChanges();
            }
        }

        public static List<Post> GetPosts()
        {
            using (var context = new HealthExpertContext())
            {
                return context.posts.ToList();
            }
        }

        public static Post GetPostById(int postId)
        {
            using (var context = new HealthExpertContext())
            {
                return context.posts.Find(postId);
            }
        }

        public static void UpdatePost(Post post)
        {
            using (var context = new HealthExpertContext())
            {
                var existingPost = context.posts.Find(post.postId);
                if(existingPost == null)
                {
                    throw new Exception("Post not found!!!");
                }
                existingPost.title = post.title;
                existingPost.content = post.content;
                existingPost.updatedAt = post.updatedAt;
                existingPost.publishAt = post.publishAt;
                existingPost.imageFile = post.imageFile;
                context.posts.Update(existingPost);
                context.SaveChanges();
            }
        }

        //PostLike method
        public static void LikePost(int postId, string userName)
        {
            using (var context = new HealthExpertContext())
            {
                var post = context.posts.FirstOrDefault(p => p.postId == postId);
                //var existingUser = context.accounts.FirstOrDefault(a => a.userName == userName);
                if(post != null)
                {
                    var existingLike = context.post_Likes.FirstOrDefault(pl => 
                    pl.postId == postId && pl.userName == userName);

                    if(existingLike == null)
                    {
                        Post_Like postLike = new Post_Like
                        {
                            postId = postId,
                            userName = userName,
                            createdAt = DateTime.Now
                        };
                        context.post_Likes.Add(postLike);
                        post.likeCount++;
                        context.SaveChanges();
                    }
                    else
                    {
                        context.post_Likes.Remove(existingLike);
                        post.likeCount--;
                        context.SaveChanges();
                    }
                }
                else
                {
                    throw new Exception("Post not found!!");
                }
            }
        }
    }
}
