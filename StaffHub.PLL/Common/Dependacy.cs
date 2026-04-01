
using Microsoft.Extensions.DependencyInjection;
using StaffHub.PLL.Mapping;
using StaffHub.PLL.Service.Implement;

namespace StaffHub.PLL.Common;
 public static class Dependacy
{
    public static IServiceCollection AddPllServices(this IServiceCollection services)
    {
        services.AddScoped<IDepartmentServices,DepartmentServices>();
        services.AddScoped<IEmployeeService,EmployeeService>();
        //services.AddAutoMapper(typeof(MappingProfile).Assembly);
        services.AddAutoMapper(Mapping=>Mapping.AddProfile(new MappingProfile()));
        return services;
    }   
}
