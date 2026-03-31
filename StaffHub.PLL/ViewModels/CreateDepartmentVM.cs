

using System.ComponentModel.DataAnnotations;

namespace StaffHub.PLL.ViewModels;

public class CreateDepartmentVM
{
    [Required (ErrorMessage = "Department name is required.")]
    [StringLength(20, MinimumLength = 2, ErrorMessage = "Department name must be between 2 and 20 characters.")]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "Department name is required.")]
    [StringLength(120, MinimumLength = 3, ErrorMessage = "Department Description must be between 3 and 120 characters.")]
    public string Description { get; set; } = string.Empty;



    [Required(ErrorMessage = "Department code is required.")]
    public string code { get; set; } = string.Empty;    


    public DateOnly ?dateOfCreation { get; set; }    

}
