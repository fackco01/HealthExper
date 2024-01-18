using AutoMapper;
using DataAccess.Repository.IRepository;
using DataAccess.Repository;
using HealthExpertAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using HealthExpertAPI.DTO.DTOCourse;
using BussinessObject.Model.FileCourse;

namespace HealthExpertAPI.Controllers
{
    /// <summary>
    /// Controllers COurse
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseRepository _repository = new CourseRepository();
        private readonly HealthServices services = new HealthServices();
        private readonly IMapper _mapper;

        private readonly IConfiguration _configuration;

        public CourseController(IConfiguration configuration, IMapper mapper)
        {
            _configuration = configuration;
            _mapper = mapper;
        }

        //Get List of courses
        [AllowAnonymous]
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<List<IActionResult>> GetListCourses()
        {
            try
            {
                var course = _repository.GetAllCourse().Where(u => u.isActive);
                var courseDTO = _mapper.Map<List<CourseDTO>>(course);
                return Ok(courseDTO);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //Get List of courses by ID
        [AllowAnonymous]
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult GetCourseByID(int id)
        {
            try
            {
                var course = _repository.GetCourseById(id);
                var courseDTO = _mapper.Map<CourseDTO>(course);
                return Ok(courseDTO);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //Post of course
        [AllowAnonymous]
        [HttpPost]
        public IActionResult CreateCourse(CreateCourseDTO courseDTO)
        {
            try
            {
                var course = _mapper.Map<Course>(courseDTO);
                course.isActive = true;

                _repository.CreateCourse(course);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //Update of course
        [AllowAnonymous]
        [HttpPut("{id}")]
        public IActionResult UpdateCourse(int id, CourseUpdateDTO courseDTO)
        {
            try
            {
                var businessId = _repository.GetCourseById(id).businessId;
                courseDTO.businessId = businessId;
                var course = _mapper.Map<Course>((id, courseDTO));
                _repository.UpdateCourse(course.courseId, course);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //Delete of course
        [AllowAnonymous]
        [HttpDelete("{id}")]
        public IActionResult DeleteCourse(int id)
        {
            try
            {
                var course = _repository.GetCourseById(id);
                if (course == null)
                {
                    return NotFound();
                }
                course.isActive = false;
                _repository.UpdateCourse(id, course);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
