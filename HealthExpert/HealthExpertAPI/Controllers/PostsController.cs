using AutoMapper;
using DataAccess.Repository.IRepository;
using DataAccess.Repository;
using HealthExpertAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HealthExpertAPI.DTO.DTOPost;
using BussinessObject.Model.FilePost;

namespace HealthExpertAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        //CREATE ALL METHOD FOR POSTS
        private readonly IPostRepository _repository = new PostRepository();
        private readonly IUserRepository _repositoryUser = new UserRepository();
        private readonly HealthServices services = new HealthServices();
        private readonly IMapper _mapper;

        private readonly IConfiguration _configuration;

        public PostsController(IConfiguration configuration, IMapper mapper)
        {
            _configuration = configuration;
            _mapper = mapper;
        }

        //CREATE POST
        [AllowAnonymous]
        [HttpPost]
        public ActionResult CreatePost(PostUploadDTO postUploadDTO, string userId)
        {
            var userIdRn = _repositoryUser.GetUserById(new Guid(userId));
            if(userIdRn == null)
            {
                return BadRequest("User not found");
            }
            var post = _mapper.Map<Post>(postUploadDTO);
            _repository.CreatePost(post, userId);
            return Ok();
        }

        //GET ALL POSTS
        [AllowAnonymous]
        [HttpGet]
        public ActionResult<List<Post>> GetPostList()
        {
            var posts = _repository.GetAllPosts();
            var postDTOs = _mapper.Map<List<PostDTO>>(posts);
            return Ok(postDTOs);
        }

        //GET POST BY ID
        [AllowAnonymous]
        [HttpGet("{id}")]
        public ActionResult GetPostById(int id)
        {
            var post = _repository.GetPostById(id);
            var postDTO = _mapper.Map<PostDTO>(post);
            return Ok(postDTO);
        }

        //UPDATE POST
        [AllowAnonymous]
        [HttpPut("{id}")]
        public ActionResult UpdatePost(int id, PostEditDTO postEditDTO)
        {
            var post = _mapper.Map<Post>((id, postEditDTO));
            _repository.UpdatePost(id, post);
            return Ok();
        }

        //DELETE POST
        [AllowAnonymous]
        [HttpDelete("{id}")]
        public ActionResult DeletePost(int id)
        {
            var post = _repository.GetPostById(id);
            _repository.DeletePost(post);
            return Ok();
        }
    }
}
