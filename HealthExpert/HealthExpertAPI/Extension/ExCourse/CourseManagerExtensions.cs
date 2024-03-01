using BussinessObject.Model.ModelCourse;
using HealthExpertAPI.DTO.DTOCourse;

namespace HealthExpertAPI.Extension.ExCourse
{
    public static class CourseManagerExtensions
    {
        public static CourseManagerDTO ToCourseManagerDTO(this CourseManagement courseManager)
        {
            if(courseManager == null)
            {
                return null;
            }
            return new CourseManagerDTO
            {
                courseManagerId = courseManager.courseManagerId,
                courseId = courseManager.courseId
            };
        }

        public static CourseManagement ToCreateCourseManager(this CourseManagerDTO courseManagerDTO)
        {
            return new CourseManagement
            {
                courseManagerId = courseManagerDTO.courseManagerId,
                courseId = courseManagerDTO.courseId
            };
        }
    }
}
