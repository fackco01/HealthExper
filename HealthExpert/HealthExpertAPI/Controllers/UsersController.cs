using AutoMapper;
using BussinessObject.Model;
using DataAccess.DAO;
using DataAccess.Repository;
using DataAccess.Repository.IRepository;
using HealthExpertAPI.DTO.DTOUser;
using HealthExpertAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HealthExpertAPI.Controllers
{
    //[Authorize(Roles = "Administration")] //Có thể chỉnh sửa lại sau
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository _repository = new UserRepository();
        private readonly HealthServices services = new HealthServices();
        private readonly IMapper _mapper;

        private readonly IConfiguration _configuration;

        /// <summary>
        /// Config IConfiguration
        /// </summary>
        /// <param name="configuration, mapper"></param>
        public UsersController(IConfiguration configuration, IMapper mapper)
        {
            _configuration = configuration;
            _mapper = mapper;
        }


        // GET: api/Users/5
        [AllowAnonymous]
        [HttpGet("{id}")]
        public ActionResult GetUserById(string id)
        {
            var user = _repository.GetUserById(new Guid(id));
            var userDTO = _mapper.Map<UserDTO>(user);
            return Ok(userDTO);
        }

        // GET: api/Users
        [AllowAnonymous]
        [HttpGet]
        public ActionResult<List<User>> GetUserList()
        {
            var users = _repository.GetAllUsers().Where(u => u.isActive);
            var userDTOs = _mapper.Map<List<UserDTO>>(users);
            return Ok(userDTOs);

            //var activeUsers = _repository.GetAllUsers().Where(u => u.isActive);
            //return Ok(activeUsers);
        }

        // PUT: api/Users/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[Authorize(Roles = "Administration, Customer")]
        [HttpPut("{id}")]
        public void UpdateUser(string id, UserUpdateDTO userDTO)
        {
            var userId = _repository.GetUserById(new Guid(id)).roleId;
            userDTO.roleId = userId;
            var user = _mapper.Map<User>((Guid.Parse(id), userDTO));
            //userId = new Guid(services.DecryptString(Uri.UnescapeDataString(id), _configuration)),


            _repository.UpdateUser(user.userId, user);
        }

        // POST: api/Users
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [AllowAnonymous]
        [HttpPost]
        public IActionResult Register(UserRegistrationDTO userDTO)
        {
            var user = _mapper.Map<User>(userDTO);
            user.roleId = 3;
            user.isActive = true;

            _repository.CreateUser(user);
            return Ok();
        }

        // DELETE: api/Users/5
        //[Authorize(Roles = "Administration")] Test
        [HttpDelete("{id}")]
        public IActionResult DeleteUser(Guid id)
        {
            var user = _repository.GetUserById(id);
            if (user == null)
            {
                return NotFound();
            }
            //_repository.DeleteUser(user);
            user.isActive = false;
            _repository.UpdateUser(id, user);

            return NoContent();
        }

        //GET SPECIFIC ENTERPRISE BY NAME
        [AllowAnonymous]
        [HttpGet("{name}")]
        public ActionResult GetEnterpriseByName(string name)
        {
            try
            {
                var users = _repository.GetAllUsers().Where(
                    u => u.isActive && u.userName.Contains(name) && u.roleId == 2).ToList();

                if (users.Count == 0)
                {
                    return NotFound("Enterprise not found!");
                }

                var userDTOs = _mapper.Map<List<UserDTO>>(users);
                return Ok(userDTOs);
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }

        //GET CUSTOMER BY NAME
        [AllowAnonymous]
        [HttpGet("{name}")]
        public ActionResult GetCustomerByName(string name)
        {
            try
            {
                var users = _repository.GetAllUsers().Where(
                    u => u.isActive && u.userName.Contains(name) && u.roleId == 3).ToList();

                if (users.Count == 0)
                {
                    return NotFound("Customer not found!");
                }

                var userDTOs = _mapper.Map<List<UserDTO>>(users);
                return Ok(userDTOs);
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }
    }
}
