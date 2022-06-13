using AutoMapper;
using s3_dreamcatcher_api.logic.Models;
using s3_dreamcatcher_api.ViewModels;

namespace s3_dreamcatcher_api.AutoMapperProfiles
{
    public class DreamViewAutoMapperProfile : Profile
    {
        public DreamViewAutoMapperProfile()
        {
            CreateMap<Dream, DreamViewModel>().ReverseMap();
        }
    }
}
