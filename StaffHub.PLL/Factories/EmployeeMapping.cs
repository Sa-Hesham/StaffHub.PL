using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffHub.PLL.Factories;

public static class EmployeeMapping
{

    public static GetEmployeeVM MapToGetEmployeeVM(this Employee employee)
    {

        return new GetEmployeeVM
        {
            Id = employee.Id,
            Name = employee.Name,
            Age = employee.age,
            Salary = employee.salary,
            IsActive = employee.IsActive,
            Email = employee.Email,
            Gender = employee.Gendar.ToString(),
            EmployeeType = employee.EmployeeType.ToString()




        };
    }
}
