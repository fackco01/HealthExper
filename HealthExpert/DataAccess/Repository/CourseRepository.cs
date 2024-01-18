using BussinessObject.Model.FileCourse;
using DataAccess.DAO;
using DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class CourseRepository : ICourseRepository
    {
        public void CreateCourse(Course course) => CourseDAO.AddCourse(course);

        public void DeleteCourse(Course course) => CourseDAO.DeleteCourse(course);

        public List<Course> GetAllCourse() => CourseDAO.GetListCourses();

        public Course GetCourseById(int id) => CourseDAO.GetCourseByID(id);

        public void UpdateCourse(int id, Course course) => CourseDAO.UpdateCourse(id, course);
    }
}
