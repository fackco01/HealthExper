using BussinessObject.Model;
using BussinessObject.Model.FileCourse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.IRepository
{
    public interface ICourseRepository
    {
        void CreateCourse(Course course);
        void UpdateCourse(int id, Course course);
        Course GetCourseById(int id);
        void DeleteCourse(Course course);
        List<Course> GetAllCourse();
    }
}
