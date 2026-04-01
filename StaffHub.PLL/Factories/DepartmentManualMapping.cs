


using StaffHub.PLL.ViewModels.DepartmentVM;

namespace StaffHub.PLL.Factories;

internal  static class DepartmentManualMapping
{

    public static GetDepartmentVM MapToGetDepartmentVM(this Department department)
    {
        return new GetDepartmentVM
        {
            Id = department.Id,
            Name = department.Name,
            code = department.code,
            Description = department.Description,
            CreatedOn = department.CreatedOn.ToString("dd/MM/yyyy")
        };
    }
   
    public static DeparmentDetailsVM MapToDepartMentDetailsVM(this Department department)
    {
        return new DeparmentDetailsVM
        {
            Id = department.Id,
            Name = department.Name,
            code = department.code,
            Description = department.Description,
            IsActive = department.IsDeleted ? "NotActive" : "Active",
            CreatedBy = department.CreatedBy.HasValue ? department.CreatedBy.Value : 1,
            CreatedOn = department.CreatedOn.ToString("dd/MM/yyyy"),
            ModifiedOn = department.ModifiedOn.HasValue ? DateOnly.FromDateTime(department.ModifiedOn.Value) : default,
            ModifiedBy = department.ModifiedBy is null ? 1: department.ModifiedBy.Value 


        };


    }


    public static Department MaptoEntity(this CreateDepartmentVM department) {


        return new Department
        {
            Name = department.Name,
            Description = department.Description,
            code = department.code,
            CreatedOn = department.dateOfCreation.HasValue? department.dateOfCreation.Value.ToDateTime(new TimeOnly()) : DateTime.Now,

        };
    
    
    
    
    }



    public static Department toEditEntity(this UpdateDepartmentVM department) { 
    
    
    
        return new Department
        {   Id = department.Id, 
            Name = department.Name,
            Description = department.Description,
            code = department.code,
           
        };  










    }
}
