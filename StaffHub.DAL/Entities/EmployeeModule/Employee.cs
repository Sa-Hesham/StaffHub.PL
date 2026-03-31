

namespace StaffHub.DAL.Entities.EmployeeModule;

public class Employee :BaseEntity
{
    public string Name { get; set; } = null!;
    public int age { get; set; }    

    public string ? Address { get; set; } 


    public decimal salary { get; set; }
     

    public bool IsActive { get; set; } = false;


    public string  ?phoneNumber { get; set; } 

     public string ?Email { get; set; } 


    public DateTime HiringDate { get; set; } 

    public EmployeeType EmployeeType { get; set; }  


    public Gendar Gendar { get; set; }  


}
