using BussinessObject.ContextData;
using BussinessObject.Model.FileCourse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    /// <summary>
    /// Created by Ho Trong Duan
    /// </summary>
    public class CourseDAO
    {
        //Get list of courses
        public static List<Course> GetListCourses()
        {
            List<Course> coursesList = new List<Course>();
            try
            {
                using (var ctx = new HealthExpertContext())
                {
                    coursesList = ctx.Courses.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return coursesList;
        }
        //Get Course

        //Get Course by ID
        public static Course GetCourseByID(int id)
        {
            var course = new Course();
            try
            {
                using (var ctx = new HealthExpertContext())
                {
                    course = ctx.Courses.FirstOrDefault(x => x.courseId == id);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return course;
        }

        //Add Course
        public static void AddCourse(Course course)
        {
            try
            {
                using (var ctx = new HealthExpertContext())
                {
                    ctx.Courses.Add(course);
                    ctx.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Update Course
        public static void UpdateCourse(int id, Course course)
        {
            try
            {
                using (var ctx = new HealthExpertContext())
                {
                    if (GetCourseByID(id) != null)
                    {
                        ctx.Courses.Add(course);
                        ctx.Entry(course).State =
                            Microsoft.EntityFrameworkCore.EntityState.Modified;
                        ctx.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Delete Course
        public static void DeleteCourse(Course course)
        {
            try
            {
                using (var ctx = new HealthExpertContext())
                {
                    var p1 = ctx.Courses.SingleOrDefault(
                        x => x.courseId == course.courseId);
                    ctx.Courses.Remove(p1);
                    ctx.SaveChanges();
                }
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}