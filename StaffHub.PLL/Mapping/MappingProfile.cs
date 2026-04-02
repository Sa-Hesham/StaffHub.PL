using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffHub.PLL.Mapping;

public class MappingProfile :Profile
{
    public MappingProfile()
    {
        CreateMap<Employee, GetEmployeeVM>()
            .ForMember(dest=>dest.Gender ,options=>options.MapFrom(src=>src.Gendar.ToString()))
            .ForMember(dest=>dest.EmployeeType,option=>option.MapFrom(src=>src.EmployeeType.ToString()));

            CreateMap<Employee, EmployeeDetailsVM>() 
            .ForMember(dest => dest.Gender, options => options.MapFrom(src => src.Gendar.ToString()))
            .ForMember(dest => dest.EmployeeType, option => option.MapFrom(src => src.EmployeeType.ToString()))
            .ForMember(dest=>dest.HiringDate , opt=>opt.MapFrom(src=>DateOnly.FromDateTime(src.HiringDate)));

        CreateMap<CreateEmployeeVM, Employee>()
            .ForMember(dest=>dest.HiringDate , opt => opt .MapFrom(src=>src.HiringDate.ToDateTime(TimeOnly.MinValue)))
            .ForMember(dest => dest.Gendar, opt => opt.MapFrom(src => src.Gendar))
            .ForMember(dest => dest.EmployeeType, opt => opt.MapFrom(src => src.EmployeeType));

        CreateMap<UpdateEmployeeVM, Employee>()
            .ForMember(dest => dest.Gendar, opt => opt.MapFrom(src => src.Gender))
            .ForMember(dest => dest.EmployeeType, opt => opt.MapFrom(src => src.EmployeeType))
            .ForMember(dest => dest.HiringDate , opt =>opt.MapFrom(src=>src.HiringDate.ToDateTime(TimeOnly.MinValue)));    
    }
}
