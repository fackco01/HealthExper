using AutoMapper;
using BussinessObject.Model;
using BussinessObject.Model.FilePost;
using HealthExpertAPI.DTO.DTOPost;
using HealthExpertAPI.DTO.DTOUser;

namespace HealthExpertAPI.Mapping.MappingPost
{
    public class MappingPostFile : Profile
    {
        public MappingPostFile()
        {
            CreateMap<Post, PostDTO>();
            CreateMap<PostUploadDTO, Post>();
            CreateMap<(int, PostEditDTO), Post>()
                .ForMember(e => e.postId, d => d.MapFrom(src => src.Item1))
                .ForMember(e => e.postTitle, d => d.MapFrom(src => src.Item2.postTitle))
                .ForMember(e => e.postContent, d => d.MapFrom(src => src.Item2.postContent))
                .ForMember(e => e.postDate, d => d.MapFrom(src => src.Item2.postDate));
        }
    }
}
