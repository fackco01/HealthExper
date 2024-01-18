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
    public class CourseContentDAO
    {
        //Get all courses content
        public static List<CourseContent> GetListContent()
        {
            List<CourseContent> courses = new List<CourseContent>();
            try
            {
                using(var ctx = new HealthExpertContext())
                {
                    courses = ctx.CourseContents.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return courses;
        }
        //Get courses content

        //Get courses content ID
        public static CourseContent GetContentByID(int id)
        {
            var courses = new CourseContent();
            try
            {
                using(var ctx = new HealthExpertContext())
                {
                    courses = ctx.CourseContents.Where(x => x.contentId == id).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return courses;
        }

        //Add courses content
        public static void AddContent(CourseContent content)
        {
            try
            {
                using (var ctx = new HealthExpertContext())
                {
                    ctx.CourseContents.Add(content);
                    ctx.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Update courses content
        public static void UpdateContent(int id, CourseContent content)
        {
            try
            {
                using (var ctx = new HealthExpertContext())
                {
                    if (GetContentByID(id) != null)
                    {
                        ctx.CourseContents.Add(content);
                        ctx.Entry(content).State =
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

        //Delete courses content
        public static void DeleteCourse(CourseContent course)
        {
            try
            {
                using (var ctx = new HealthExpertContext())
                {
                    var p1 = ctx.CourseContents.SingleOrDefault(
                        x => x.contentId == course.contentId);
                    ctx.CourseContents.Remove(p1);
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
