using BussinessObject.Model.ModelCourse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.IRepository
{
    //Create ICourseRepository
    public interface ICourseRepository
    {
        void AddCourse(Course course);
        void DeleteCourse(string courseId);
        List<Course> GetCourses();
        Course GetCourseById(string courseId);
        void UpdateCourse(Course course);
        void AddCourseManagerByEmail(string email, string courseId);
    }
}
