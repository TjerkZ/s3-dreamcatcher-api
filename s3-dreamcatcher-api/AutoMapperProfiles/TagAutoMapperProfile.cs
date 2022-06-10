using AutoMapper;
using s3_dreamcatcher_api.logic.Models;
using s3_dreamcatcher_api.dto;

namespace s3_dreamcatcher_api.AutoMapperProfiles
{
    public class TagAutoMapperProfile : Profile 
    {
        public TagAutoMapperProfile()
        {
            CreateMap<TagDTO, Tag>();
        }
    }
}
