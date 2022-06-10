using AutoMapper;
using s3_dreamcatcher_api.dto;
using s3_dreamcatcher_api.logic.Models;

namespace s3_dreamcatcher_api.AutoMapperProfiles
{
    public class DreamAutoMapperProfile : Profile
    {
        public DreamAutoMapperProfile()
        {
            CreateMap<DreamDTO, Dream>().ReverseMap();
        }
    }
}
