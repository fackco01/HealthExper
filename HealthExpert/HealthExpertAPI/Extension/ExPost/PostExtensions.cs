using BussinessObject.Model.ModelPost;
using HealthExpertAPI.DTO.DTOPost;

namespace HealthExpertAPI.Extension.ExPost
{
    public static class PostExtensions
    {
        public static PostDTO ToPostDTO(this Post post)
        {
            return new PostDTO
            {
                accountId = post.accountId,
                postId = post.postId,
                title = post.title,
                content = post.content,
                imageFile = post.imageFile,
                likeCount = post.likeCount,
                createdAt = post.createdAt,
                updatedAt = post.updatedAt,
                publishAt = post.publishAt
            };
        }

        public static Post ToCreatePost(this PostDTO postDTO)
        {
            return new Post
            {
                accountId = postDTO.accountId,
                title = postDTO.title,
                content = postDTO.content,
                imageFile = postDTO.imageFile,
                likeCount = postDTO.likeCount,
                createdAt = postDTO.createdAt,
                updatedAt = postDTO.updatedAt,
                publishAt = postDTO.publishAt
            };
        }

        public static Post ToUpdatePost(this PostDTOUpdate postDTO)
        {
            return new Post
            {
                title = postDTO.title,
                content = postDTO.content,
                imageFile = postDTO.imageFile,
                createdAt = postDTO.createdAt,
                updatedAt = postDTO.updatedAt,
                publishAt = postDTO.publishAt
            };
        }

    }
}
