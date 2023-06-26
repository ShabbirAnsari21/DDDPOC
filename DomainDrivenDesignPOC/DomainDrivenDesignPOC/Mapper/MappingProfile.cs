using AutoMapper;
using DomainDrivenDesignPOC.Api.Model.Response;
using DomainDrivenDesignPOC.Domain.Entities;

namespace DomainDrivenDesignPOC.Api.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Company, Companies>().ReverseMap();
        }
    }
}
