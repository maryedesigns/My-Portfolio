using AutoMapper;
using maryedesigns.Models;
using maryedesigns.ViewModel;

namespace maryedesigns.Settings
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Project, ListOfProjectViewModel>().ReverseMap();
            CreateMap<Skill, ListOfSkillsViewModel>().ReverseMap();
            CreateMap<Experience, ListOfExperiencesViewModel>().ReverseMap();

        }
    }
}
