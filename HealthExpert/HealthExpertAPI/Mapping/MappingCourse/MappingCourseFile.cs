using AutoMapper;
using BussinessObject.Model.FileCourse;
using HealthExpertAPI.DTO.DTOCourse;

namespace HealthExpertAPI.Mapping.MappingCourse
{
    /// <summary>
    /// Class mapping
    /// </summary>
    public class MappingCourseFile : Profile
    {
        public MappingCourseFile()
        {
            CreateMap<Course, CourseDTO>();
            CreateMap<CreateCourseDTO, Course>();
            CreateMap<(int, CourseUpdateDTO), Course>()
                .ForMember(e => e.courseId, d => d.MapFrom(src => src.Item1))
                .ForMember(e => e.courseName, d => d.MapFrom(src => src.Item2.courseName))
                .ForMember(e => e.title, d => d.MapFrom(src => src.Item2.title))
                .ForMember(e => e.price, d => d.MapFrom(src => src.Item2.price))
                .ForMember(e => e.rate, d => d.MapFrom(src => src.Item2.rate))
                .ForMember(e => e.createDate, d => d.MapFrom(src => src.Item2.createDate))
                .ForMember(e => e.isActive, d => d.MapFrom(src => src.Item2.isActive))
                .ForMember(e => e.businessId, d => d.MapFrom(src => src.Item2.businessId))
                ;
        }
    }
}
