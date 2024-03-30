using AutoMapper;
using BussinessObject.ContextData;
using BussinessObject.Model.ModelPost;
using DataAccess.Repository;
using DataAccess.Repository.IRepository;
using HealthExpertAPI.DTO.DTOPost;
using HealthExpertAPI.Extension.ExPost;
using HealthExpertAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HealthExpertAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly HealthExpertContext _context = new HealthExpertContext();
        private readonly HealthServices service = new HealthServices();
        private readonly IPostRepository _repository = new PostRepository();

        private readonly IConfiguration _configuration;
        private readonly IMapper _mapper;

        public PostController(IConfiguration configuration, IMapper mapper, HealthExpertContext context)
        {
            _configuration = configuration;
            _mapper = mapper;
            _context = context;
        }

        //Create Post
        [HttpPost]
        [AllowAnonymous]
        public IActionResult CreatePost(PostDTO postDTO)
        {
            var user = _context.accounts.Find(postDTO.accountId);
            if (user == null)
            {
                return BadRequest("User not found!!");
            }
            Post post = postDTO.ToCreatePost();
            _repository.AddPost(post);
            return Ok();
        }

        //Get Posts
        [HttpGet]
        [AllowAnonymous]
        public IActionResult GetPosts()
        {
            var posts = _repository.GetPosts();
            return Ok(posts);
        }

        //Get Post by Id
        [HttpGet("{postId}")]
        [AllowAnonymous]
        public IActionResult GetPostById(int postId)
        {
            var post = _repository.GetPostById(postId);
            if (post == null)
            {
                return BadRequest("Post not found!!");
            }
            return Ok(post);
        }

        //Update Post
        [HttpPut]
        [AllowAnonymous]
        public IActionResult UpdatePost(PostDTOUpdate postDTO)
        {
            Post post = postDTO.ToUpdatePost();
            _repository.UpdatePost(post);
            return Ok();
        }

        //Delete Post
        [HttpDelete("{postId}")]
        [AllowAnonymous]
        public IActionResult DeletePost(int postId)
        {
            _repository.DeletePost(postId);
            return Ok();
        }

        //Like Post
        [HttpPost("like")]
        [AllowAnonymous]
        public IActionResult LikePost(int postId, string userName)
        {
            var post = _repository.GetPostById(postId);
            if (post == null)
            {
                return BadRequest("Post not found!!");
            }
            _repository.LikePost(postId, userName);
            return Ok();
        }
    }
}
