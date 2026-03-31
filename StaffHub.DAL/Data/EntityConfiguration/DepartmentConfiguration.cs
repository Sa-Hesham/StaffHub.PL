using StaffHub.DAL.Entities;

namespace StaffHub.DAL.Data.EntityConfiguration;

internal class DepartmentConfiguration : IEntityTypeConfiguration<Department>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Department> builder)
    {
        builder.Property(d => d.Id)
             .UseIdentityColumn(10, 10);


        builder.Property(d => d.Name)
        .HasColumnType("varchar(20)");


        builder.Property(d => d.code)
            .HasColumnType("varchar(20)");



        builder.Property(d => d.Description)
            .HasColumnType("varchar(200)");



        builder.Property(d => d.CreatedOn).HasDefaultValueSql("GETDATE()");
    }
}
