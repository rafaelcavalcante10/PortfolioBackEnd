using AutoMapper;
using Portfolio.Domain.Models;
using Portfolio.Services.ViewModels;

namespace Portfolio.Services.Profiles
{
    public class PortfolioProfile : Profile
    {
        public PortfolioProfile()
        {
            CreateMap<Developer, PortfolioVM>();
            CreateMap<Graduation, GraduationVM>();
            CreateMap<Experience, ExperienceVM>();
            CreateMap<ExperienceDetail, ExperienceDetailVM>();
            CreateMap<PortfolioVM, Developer>();
            CreateMap<GraduationVM, Graduation>();
            CreateMap<ExperienceVM, Experience>();
            CreateMap<ExperienceDetailVM, ExperienceDetail>();
        }
    }
}
