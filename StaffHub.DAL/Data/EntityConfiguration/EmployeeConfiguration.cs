


namespace StaffHub.DAL.Data.EntityConfiguration;

public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        builder.Property(e => e.Email)
             .HasColumnType("varchar(100)");

        builder.Property(e => e.Address)
             .HasColumnType("varchar(50)"); 

        builder.Property(e => e.phoneNumber)
             .HasColumnType("varchar(20)"); 

        builder.Property(e => e.salary)
             .HasColumnType("decimal(10,2)");

        builder.Property(e=> e.CreatedOn)
            .HasDefaultValueSql("GETDATE()");


        builder.Property(e => e.Gendar)
            .HasConversion<string>()
            
            .HasColumnType("varchar(20)");


        builder.Property(e => e.EmployeeType)
            .HasConversion<string>()
            .HasColumnType("varchar(30)");    


    }
}
