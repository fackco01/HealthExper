//using BussinessObject.Model.Authen;
//using DataAccess.Repository;
//using HealthExpertAPI.Services;
//using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Cors;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using System.Security.Claims;

//namespace HealthExpertAPI.Controllers
//{
//    [EnableCors("AllowAllHeaders")]
//    [Route("api/[controller]/[action]")]
//    [ApiController]
//    public class AuthController : ControllerBase
//    {
//        private readonly UserRepository userRepository = new UserRepository();
//        private readonly RoleRepository roleRepository = new RoleRepository();
//        private readonly HealthServices service = new HealthServices();

//        private readonly IConfiguration _configuration;

//        public AuthController(IConfiguration configuration)
//        {
//            _configuration = configuration;
//        }

//        //LOGIN

//        [AllowAnonymous]
//        [HttpPost]
//        public IActionResult Login([FromBody] UserLogin login)
//        {
//            var user = userRepository.Authenticate(login);
//            var role = roleRepository.GetAllRoles();
//            if (user != null && user.isActive)
//            {
//                var claims = new List<Claim>
//                {
//                    new Claim(ClaimTypes.Name, user.userName),
//                    new Claim(ClaimTypes.Role, role.First(role => role.roleId == user.roleId).roleName)
//                };

//                string token = service.CreateToken(claims, _configuration);

//                SetCookie("access_token", token, true);
//                SetCookie("uid", service.EncryptString(user.userId.ToString(), _configuration), false);
//                return Ok(token);
//            }

//            return BadRequest("User not found!!!");
//        }

//        //LOGOUT
//        [HttpPost, Authorize]
//        public IActionResult Logout()
//        {
//            foreach (var cookie in Request.Cookies.Keys)
//            {
//                System.Diagnostics.Debug.Write("Cookie: " + cookie);
//                Response.Cookies.Delete(cookie, new CookieOptions()
//                {
//                    IsEssential = true,
//                    SameSite = SameSiteMode.None,
//                    Secure = true
//                });
//            }

//            return Ok();
//        }

//        //Set Cookie
//        private void SetCookie(string name, string value, bool httpOnly)
//        {
//            Response.Cookies.Append(name, value, new CookieOptions()
//            {
//                IsEssential = true,
//                Expires = DateTime.Now.AddHours(3),
//                Secure = true,
//                HttpOnly = httpOnly,
//                SameSite = SameSiteMode.None
//            });
//        }
//    }
//}
