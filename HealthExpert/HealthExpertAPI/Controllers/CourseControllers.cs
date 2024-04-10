﻿using AutoMapper;
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
        private readonly IBillRepository _billRepository = new BillRepository();

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
                if (courseManagers == null)
                {
                    return BadRequest("No course managers provided.");
                }

                List<string> messages = new List<string>();

                foreach (var manager in courseManagers)
                {
                    if (manager.accountEmails == null)
                    {
                        messages.Add($"No account emails provided for course manager with courseId {manager.courseId}");
                        continue;
                    }

                    var course = _context.courses.Find(manager.courseId);
                    if (course == null)
                    {
                        messages.Add($"Course with ID {manager.courseId} not found!!");
                        continue;
                    }

                    foreach (var email in manager.accountEmails)
                    {
                        //check if users dont have roled=4
                        var roleUser = _context.accounts.FirstOrDefault(x => x.email.Equals(manager.accountEmails) && x.roleId == 4);
                        if (roleUser == null)
                        {
                            messages.Add($"User with email is not a normal User!!");
                            continue;
                        }
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
                .Include(cm => cm.accounts) // Ensure accounts are included
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

        [HttpPost("increase-student-number/{courseId}")]
        [AllowAnonymous]
        public IActionResult IncreaseStudentNumber(string courseId)
        {
            var course = _context.courses.Find(courseId);
            if (course == null)
            {
                return NotFound("Course not found!!");
            }

            // Kiểm tra xem có enrollment mới nào được tạo ra không
            var newEnrollment = _context.enrollments.Any(e => e.courseId == courseId && e.enrollStatus);

            if (newEnrollment)
            {
                // Tăng giá trị studentNumber lên một
                course.studentNumber++;

                // Lưu các thay đổi vào cơ sở dữ liệu
                _context.SaveChanges();

                return Ok("Student number increased successfully.");
            }
            else
            {
                return BadRequest("No new enrollments found for this course.");
            }
        }

        [HttpGet("count-student-number/{courseId}")]
        [AllowAnonymous]
        public IActionResult CountStudentNumber(string courseId)
        {
            var course = _context.courses.Find(courseId);
            if (course == null)
            {
                return NotFound("Course not found!!");
            }

            // Đếm số lượng enrollments cho khóa học này
            var enrollmentCount = _context.enrollments.Count(e => e.courseId == courseId && e.enrollStatus);

            return Ok(enrollmentCount);
        }

        // Get Course Name by Id
        [HttpGet("name/{courseId}")]
        [AllowAnonymous]
        public IActionResult GetCourseNameById(string courseId)
        {
            var course = _repository.GetCourseById(courseId);
            if (course == null)
            {
                return NotFound("Course not found!!");
            }

            return Ok(course.courseName);
        }

        [HttpGet("{courseId}/users")]
        [AllowAnonymous]
        public IActionResult GetUsersInCourse(string courseId)
        {
            try
            {
                var course = _repository.GetCourseById(courseId);
                if (course == null)
                {
                    return NotFound("Course not found!!");
                }

                var usersInCourse = _context.enrollments
                    .Where(e => e.courseId == courseId && e.enrollStatus)
                    .Select(e => new
                    {
                        accountId = e.accountId,
                        enrollDate = e.enrollDate
                    })
                    .ToList();

                var userDetails = _context.accounts
                    .Where(a => usersInCourse.Select(u => u.accountId).Contains(a.accountId))
                    .Select(a => new
                    {
                        accountId = a.accountId,
                        userName = a.userName,
                        email = a.email
                    })
                    .ToList();

                var usersWithEnrollDate = userDetails.Select(u => new
                {
                    userName = u.userName,
                    email = u.email,
                    enrollDate = usersInCourse.FirstOrDefault(e => e.accountId == u.accountId)?.enrollDate
                }).ToList();

                return Ok(usersWithEnrollDate);
            }
            catch (Exception ex)
            {
                return BadRequest("Failed to retrieve users in course: " + ex.Message);
            }
        }
    }
}
