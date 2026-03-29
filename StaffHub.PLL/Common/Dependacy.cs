
using Microsoft.Extensions.DependencyInjection;
using StaffHub.PLL.Service.Implement;

namespace StaffHub.PLL.Common;
 public static class Dependacy
{
    public static IServiceCollection AddPllServices(this IServiceCollection services)
    {
        services.AddScoped<IDepartmentServices,DepartmentServices>();
        return services;
    }   
}
