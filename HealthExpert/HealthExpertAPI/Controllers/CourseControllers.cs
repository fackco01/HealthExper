using AutoMapper;
using BussinessObject.ContextData;
using BussinessObject.Model.ModelCourse;
using DataAccess.Repository;
using DataAccess.Repository.IRepository;
using HealthExpertAPI.DTO.DTOCourse;
using HealthExpertAPI.Extension.ExCourse;
using HealthExpertAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HealthExpertAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly HealthExpertContext _context = new HealthExpertContext();
        private readonly HealthServices service = new HealthServices();
        private readonly ICourseRepository _repository = new CourseRepository();

        private readonly IConfiguration _configuration;
        private readonly IMapper _mapper;
        
        public CourseController(IConfiguration configuration, IMapper mapper, HealthExpertContext context)
        {
            _configuration = configuration;
            _mapper = mapper;
            _context = context;
        }

        //Create Course
        [HttpPost]
        [AllowAnonymous]
        public IActionResult CreateCourse(CourseDTO courseDTO)
        {
            if (_context.courses.Any(c => c.courseName == courseDTO.courseName))
            {
                return BadRequest("Course Exist!!");
            }

            Course course = courseDTO.ToCreateCourse();
            _repository.AddCourse(course);
            return Ok();
        }

        //Get Courses
        [HttpGet]
        [AllowAnonymous]
        public IActionResult GetCourses()
        {
            var courses = _repository.GetCourses();
            return Ok(courses);
        }

        //Get Course by Id
        [HttpGet("{courseId}")]
        [AllowAnonymous]
        public IActionResult GetCourseById(string courseId)
        {
            var course = _repository.GetCourseById(courseId);
            if (course == null)
            {
                return BadRequest("Course not found!!");
            }
            return Ok(course);
        }

        //Add Managers to Course
        [HttpPost("add-manager")]
        [AllowAnonymous]
        public IActionResult AddCourseManager(CourseManagerDTO courseManagerDTO)
        {
            var course = _context.courses.Find(courseManagerDTO.courseId);
            if (course == null)
            {
                return BadRequest("Course not found!!");
            }

            foreach (var email in courseManagerDTO.accountEmails)
            {
                var user = _context.accounts.FirstOrDefault(x => x.email.Equals(email));
                if (user == null)
                {
                    return BadRequest($"User with email {email} not found!!");
                }

                var courseManager = courseManagerDTO.ToCreateCourseManager();   
                _repository.AddCourseManagerByEmail(email, courseManagerDTO.courseId); // Assuming the method now accepts a single email
            }
            return Ok();
        }

        //Update Course
        [HttpPut("{courseId}")]
        [AllowAnonymous]
        public IActionResult UpdateCourse(string courseId, CourseDTOUpdate courseDTO)
        {
            var existingCourse = _repository.GetCourseById(courseId);
            if (existingCourse == null)
            {
                return NotFound("Course not found!!");
            }

            // Update properties of existingCourse with values from courseDTO
            Course updateCourse = courseDTO.ToUpdateCourse();
            updateCourse.courseId = courseId;
            _repository.UpdateCourse(updateCourse);
            return Ok();
        }


        //Delete Course
        [HttpDelete("{courseId}")]
        [AllowAnonymous]
        public IActionResult DeleteCourse(string courseId)
        {
            var course = _repository.GetCourseById(courseId);
            if (course == null)
            {
                return NotFound("Course not found!!");
            }

            _repository.DeleteCourse(courseId);
            return Ok();
        }

        //Get Course Managers by CourseId
        [HttpGet("managers/{courseId}")]
        [AllowAnonymous]
        public IActionResult GetCourseManagers(string courseId)
        {
            var course = _repository.GetCourseById(courseId);
            if (course == null)
            {
                return NotFound("Course not found!!");
            }

            var courseManagers = _context.courseManagements.Where(c => c.courseId == courseId).ToList();
            return Ok(courseManagers);
        }

        //Get Course Managers by Email
        [HttpGet("managers/email/{email}")]
        [AllowAnonymous]
        public IActionResult GetCourseManagersByEmail(string email)
        {
            var user = _context.accounts.FirstOrDefault(x => x.email.Equals(email));
            if (user == null)
            {
                return NotFound($"User with email {email} not found!!");
            }

            var courseManagers = _context.courseManagements;
            return Ok(courseManagers);
        }

        //Delete Course Manager by Email
        [HttpDelete("managers/email/{email}")]
        [AllowAnonymous]
        public IActionResult DeleteCourseManagerByEmail(string email)
        {
            var user = _context.accounts.FirstOrDefault(x => x.email.Equals(email));
            if (user == null)
            {
                return NotFound($"User with email {email} not found!!");
            }

            var courseManagers = _context.courseManagements;
            if (courseManagers == null)
            {
                return NotFound($"User with email {email} is not a course manager!!");
            }

            foreach (var courseManager in courseManagers)
            {
                _context.courseManagements.Remove(courseManager);
            }
            _context.SaveChanges();
            return Ok();
        }
    }
}
