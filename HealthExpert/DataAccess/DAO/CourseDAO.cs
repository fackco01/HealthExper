using BussinessObject.ContextData;
using BussinessObject.Model.ModelCourse;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    //Create CourseDAO
    public class CourseDAO
    {
        public static void AddCourse(Course course)
        {
            using (var context = new HealthExpertContext())
            {
                context.courses.Add(course);
                context.SaveChanges();
            }
        }

        public static void DeleteCourse(string courseId)
        {
            using (var context = new HealthExpertContext())
            {
                var course = context.courses.Find(courseId);
                context.courses.Remove(course);
                context.SaveChanges();
            }
        }

        public static List<Course> GetCourses()
        {
            using (var context = new HealthExpertContext())
            {
                return context.courses.ToList();
            }
        }

        public static Course GetCourseById(string courseId)
        {
            using (var context = new HealthExpertContext())
            {
                return context.courses.Find(courseId);
            }
        }

        public static void UpdateCourse(Course course)
        {
            using (var context = new HealthExpertContext())
            {
                if (!context.courses.Local.Any(c => c.courseId == course.courseId))
                {
                    context.courses.Attach(course);
                    context.Entry(course).State = EntityState.Modified;
                }
                context.SaveChanges();
            }
        }

        public static void AddCourseManagerByEmail(string email, string courseId)
        {
            using (var context = new HealthExpertContext())
            {
                var user = context.accounts.FirstOrDefault(x => x.email == email);
                if (user != null)
                {
                    var courseManager = new CourseManagement
                    {
                       courseManagerId = GenerateUniqueCourseManagerId(),
                       courseId = courseId
                    };
                    context.courseManagements.Add(courseManager);
                    context.SaveChanges();
                }
            }
        }
        private static int GenerateUniqueCourseManagerId()
        {
            using (var context = new HealthExpertContext())
            {
                int existingCount = context.courseManagements.Count();
                return existingCount + 1;
            }
        }
    }
}
