

namespace StaffHub.PLL.ViewModels.EmployeeVM;

public class UpdateEmployeeVM
{
    public int Id { get; set; }
    [Required(ErrorMessage = "Name Can't Be Null")]
    [MaxLength(50, ErrorMessage = "Max length should be 50 character")]
    [MinLength(5, ErrorMessage = "Min length should be 5 characters")]
    public string Name { get; set; } = null!;

    [Range(22, 35)]
    public int? Age { get; set; }

    [RegularExpression(@"^[1-9]{1,3}-[a-zA-Z]{5,10}-[a-zA-Z]{5,10}-[a-zA-Z]{5,10}$",
        ErrorMessage = "Address must be like 123-Street-City-Country")]
    public string? Address { get; set; }

    [DataType(DataType.Currency)]
    public decimal Salary { get; set; }

    [Display(Name = "Status")]
    public bool IsActive { get; set; }

    [EmailAddress(ErrorMessage = "Invalid Email Address")]
    public string? Email { get; set; }

    [Display(Name = "Phone Number")]
    [RegularExpression(@"^(?:\+20|0)1[0-25][0-9]{8}$",
    ErrorMessage = "Invalid phone number")]
    public string? PhoneNumber { get; set; }

    [Display(Name = "Hiring Date")]
    public DateOnly HiringDate { get; set; }

    public Gendar Gender { get; set; }

    public EmployeeType EmployeeType { get; set; }
}

