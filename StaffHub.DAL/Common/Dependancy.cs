

namespace StaffHub.DAL.Common;

public  static class Dependancy 
{
    
    public  static IServiceCollection AddDalServices(this IServiceCollection services)
    {
        services.AddScoped<IDepartmentRpostiory, DepartmentRpostiory>();
        return services;
    }
}
