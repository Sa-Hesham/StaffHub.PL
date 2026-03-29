using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffHub.PLL.ViewModels;

public class GetDepartmentVM
{
    public string Name { get; set; } = null!;

     public int Id { get; set; }    
    public string CreatedOn { get; set; } = null!;  

    public string Description { get; set; } = null!;

    public string code { get; set; } = null!;

}
