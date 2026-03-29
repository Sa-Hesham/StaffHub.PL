

using System.ComponentModel.DataAnnotations;

namespace StaffHub.PLL.ViewModels;

public class CreateDepartmentVM
{
    [Required (ErrorMessage = "Department name is required.")]
    [Range(3, 20, ErrorMessage = "Department name must be between 3 and 20 characters.")]

    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "Department name is required.")]
    [Range(20, 120, ErrorMessage = "Department name must be between 20 and 120 characters.")]

    public string Description { get; set; } = string.Empty;
    [Required(ErrorMessage = "Department code is required.")]

    public string code { get; set; } = string.Empty;    


    public DateOnly dateOfCreation { get; set; }    

}
