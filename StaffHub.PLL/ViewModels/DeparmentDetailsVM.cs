using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffHub.PLL.ViewModels;

 public class DeparmentDetailsVM
{
    public int Id { get;  set; }

    public string CreatedOn { get; set; } = null!;
    public string CreatedBy { get; set; } = null!;

    public DateOnly ModifiedOn { get; set; }
    public string ModifiedBy { get; set; } = null!; 

    public string IsActive { get; set; } = null !;  
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;

    public string code { get; set; } = null!;

}
