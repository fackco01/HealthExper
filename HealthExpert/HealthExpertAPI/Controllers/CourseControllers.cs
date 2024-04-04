using AutoMapper;
using BussinessObject.ContextData;
using BussinessObject.Model.ModelCourse;
using DataAccess.Repository;
using DataAccess.Repository.IRepository;
using HealthExpertAPI.DTO.DTOCourse;
using HealthExpertAPI.DTO.DTOEnrollment;
using HealthExpertAPI.Extension.ExCourse;
using HealthExpertAPI.Extension.ExEnrollment;
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
        public IActionResult AddCourseManagers(List<CourseManagerDTO> courseManagers)
        {
            try
            {
                List<string> messages = new List<string>();

                foreach (var manager in courseManagers)
                {
                    var course = _context.courses.Find(manager.courseId);
                    if (course == null)
                    {
                        messages.Add($"Course with ID {manager.courseId} not found!!");
                        continue;
                    }

                    foreach (var email in manager.accountEmails)
                    {
                        var user = _context.accounts.FirstOrDefault(x => x.email.Equals(email));
                        if (user == null)
                        {
                            messages.Add($"User with email {email} not found!!");
                            continue;
                        }

                        //Check if user is already a course manager
                        var isManager = _repository.IsCourseManager(email, manager.courseId);
                        if (isManager)
                        {
                            messages.Add($"User with email {email} is already a Course Manager for course {manager.courseId}");
                        }
                        else
                        {
                            var courseManager = manager.ToCreateCourseManager();
                            _repository.AddCourseManagerByEmail(email, manager.courseId);
                            messages.Add($"User with email {email} added as a Course Manager for course {manager.courseId}");
                        }
                    }
                }

                return Ok(messages);
            }
            catch (Exception ex)
            {
                return BadRequest("Failed to add course managers: " + ex.Message);
            }
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

            var courseManagers = _context.courseManagements
                .Where(c => c.courseId == courseId)
                .Select(c => c.ToCourseManagerDTO())
                .ToList();

            var courseDTO = new CourseWithManagersDTO
            {
                courseId = course.courseId,
                courseName = course.courseName,
                price = course.price,
                rating = course.rating,
                description = course.description,
                studentNumber = course.studentNumber,
                certificate = course.certificate,
                createBy = course.createBy,
                dateUpdate = course.dateUpdate,
                language = course.language,
                bmiMin = course.bmiMin,
                bmiMax = course.bmiMax,
                typeId = course.typeId,

                managers = courseManagers
            };

            return Ok(courseDTO);
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

            var courseManagers = _context.courseManagements.Where(
                cm => cm.accounts.Any(a => a.email.Equals(email))).ToList();
            if (courseManagers == null)
            {
                return NotFound($"User with email {email} is not a course manager!!");
            }

            foreach (var courseManager in courseManagers)
            {
                _context.courseManagements.Remove(courseManager);
            }
            user.roleId = 4; // Assuming the role id for user is 4
            _context.SaveChanges();
            return Ok();
        }

        //Enroll in Course
        //[HttpPost("enroll")]
        //[AllowAnonymous]
        //public IActionResult EnrollInCourse(EnrollmentDTO enrollmentDTO)
        //{
        //    var course = _context.courses.Find(enrollmentDTO.courseId);
        //    if (course == null)
        //    {
        //        return BadRequest("Course not found!!");
        //    }

        //    var user = _context.accounts.FirstOrDefault(x => x.accountId.Equals(enrollmentDTO.accountId));
        //    if (user == null)
        //    {
        //        return BadRequest("User not found!!");
        //    }

        //    var enrollment = _context.enrollments.FirstOrDefault(e => e.accountId == enrollmentDTO.accountId && e.courseId == enrollmentDTO.courseId);
        //    if (enrollment != null)
        //    {
        //        return BadRequest("User is already enrolled in this course!!");
        //    }

        //    var newEnrollment = enrollmentDTO.ToEnrollment();
        //    _context.enrollments.Add(newEnrollment);
        //    _context.SaveChanges();
        //    return Ok();
        //}

            //Enroll by billId
            [HttpPost("enroll/{billId}")]
        //[AllowAnonymous]
        //public IActionResult EnrollInCourse(Guid billId)
        //{
        //    var bill = _context.bills.Find(billId);
        //    if (bill == null)
        //    {
        //        return BadRequest("Bill not found!!");
        //    }

        //    var course = _context.courses.Find(bill.order.courseId);
        //    if (course == null)
        //    {
        //        return BadRequest("Course not found!!");
        //    }

        //    var user = _context.accounts.Find(bill.accountId);
        //    if (user == null)
        //    {
        //        return BadRequest("User not found!!");
        //    }

        //    var enrollment = _context.enrollments.FirstOrDefault(e => e.accountId == bill.accountId && e.courseId == bill.order.courseId);
        //    if (enrollment != null)
        //    {
        //        return BadRequest("User is already enrolled in this course!!");
        //    }

        //    var newEnrollment = new Enrollment
        //    {
        //        accountId = bill.accountId,
        //        courseId = bill.order.courseId,
        //        enrollDate = DateTime.Now,
        //        enrollStatus = true
        //    };

        //    _context.enrollments.Add(newEnrollment);
        //    _context.SaveChanges();
        //    return Ok();
        //}

        //Enroll in course by accountId and courseId
        [HttpPost("enroll/{accountId}/{courseId}")]
        [AllowAnonymous]
        public IActionResult EnrollInCourse(Guid accountId, string courseId)
        {
            var course = _context.courses.Find(courseId);
            if (course == null)
            {
                return BadRequest("Course not found!!");
            }

            var user = _context.accounts.Find(accountId);
            if (user == null)
            {
                return BadRequest("User not found!!");
            }

            var enrollment = _context.enrollments.FirstOrDefault(e => e.accountId == accountId && e.courseId == courseId);
            if (enrollment != null)
            {
                return BadRequest("User is already enrolled in this course!!");
            }

            var newEnrollment = new Enrollment
            {
                accountId = accountId,
                courseId = courseId,
                enrollDate = DateTime.Now,
                enrollStatus = true
            };

            _context.enrollments.Add(newEnrollment);
            _context.SaveChanges();
            return Ok();
        }

        //Get List of Enrollments
        [HttpGet("enrollments")]
        [AllowAnonymous]
        public IActionResult GetEnrollments()
        {
            var enrollments = _repository.GetEnrollments().Select(enrollments => enrollments.ToEnrollmentDTO());
            return Ok(enrollments);
        }

        //Update enrollStatus of Enrollment by accountId and courseId
        [HttpPut("enrollments/{accountId}/{courseId}")]
        [AllowAnonymous]
        public IActionResult UpdateEnrollStatus(Guid accountId, string courseId, EnrollmentDTOUpdate enrollmentDTO)
        {
            var enrollment = _context.enrollments.FirstOrDefault(e => e.accountId == accountId && e.courseId == courseId);
            if (enrollment == null)
            {
                return NotFound("Enrollment not found!!");
            }

            enrollment.enrollStatus = enrollmentDTO.enrollStatus;
            _context.SaveChanges();
            return Ok();
        }

        //Get courseId by orderId
        [HttpGet("order/{orderId}")]
        [AllowAnonymous]
        public IActionResult GetCourseIdByOrderId(Guid orderId)
        {
            var order = _context.orders.FirstOrDefault(c => c.orderId == orderId);
            if (order == null)
            {
                return NotFound("Course not found!!");
            }
            return Ok(order.courseId);
        }
    }
}
