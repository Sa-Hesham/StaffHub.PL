using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffHub.PLL.ViewModels.DepartmentVM;

 public class DeparmentDetailsVM
{
    public int Id { get;  set; }

    public string CreatedOn { get; set; } = null!;
    public int CreatedBy { get; set; } 

    public DateOnly ModifiedOn { get; set; }
    public int ModifiedBy { get; set; } 

    public string IsActive { get; set; } = null !;  
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;

    public string code { get; set; } = null!;

}
