
using System.ComponentModel.DataAnnotations;

namespace StaffHub.PLL.ViewModels.EmployeeVM;

public class GetEmployeeVM
{

    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public int? Age { get; set; }
    [DataType(DataType.Currency)]
    public decimal Salary { get; set; }
    [Display(Name = "Is Active")]
    public bool IsActive { get; set; }
    [Display(Name = "Email Address")]
    public string? Email { get; set; }
    public string Gender { get; set; } = null!; 
    [Display(Name = "Employee Type")]
    public string EmployeeType { get; set; } = null!;


    

}
