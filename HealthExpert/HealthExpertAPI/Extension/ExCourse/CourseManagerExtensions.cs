using BussinessObject.Model.ModelCourse;
using BussinessObject.Model.ModelUser;
using HealthExpertAPI.DTO.DTOCourse;
using System.Linq;

namespace HealthExpertAPI.Extension.ExCourse
{
    public static class CourseManagerExtensions
    {
        public static CourseManagerDTO ToCourseManagerDTO(this CourseManagement courseManager)
        {
            if (courseManager == null)
            {
                return null;
            }

            var dto = new CourseManagerDTO
            {
                courseManagerId = courseManager.courseManagerId,
                courseId = courseManager.courseId
            };

            // Get the courseManager's accountEmails by using courseManagerId
            if (courseManager.accounts != null)
            {
                dto.accountEmails = courseManager.accounts.Select(a => a.email).ToList();
            }

            return dto;
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
