using AutoMapper;
using SegundaAPI.Domain.DTOs;
using SegundaAPI.Domain.Model.EmployeeAggregate;

namespace SegundaAPI.Application.Mapper
{
    public class DomainToDTOMapping : Profile
    {
        public DomainToDTOMapping() 
        {
            CreateMap<Employee, EmployeeDTO>()
                .ForMember(dest => dest.NameEmployee, m => m.MapFrom(orig => orig.name));
        }
    }
}
