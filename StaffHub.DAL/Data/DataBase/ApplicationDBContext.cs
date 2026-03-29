using StaffHub.DAL.Data.EntityConfiguration;
using System.Reflection;

namespace StaffHub.DAL.Data.DataBase;

public class ApplicationDBContext :DbContext  
{
    public ApplicationDBContext(DbContextOptions<ApplicationDBContext>options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
       // modelBuilder.ApplyConfiguration<Department>(new DepartmentConfiguration());
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
       // modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDBContext).Assembly);

    }
    public DbSet<Department> Departments { get; set; }
}