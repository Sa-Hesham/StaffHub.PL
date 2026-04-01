using Microsoft.Extensions.DependencyInjection;
using StaffHub.DAL.Data.DataBase;
using StaffHub.DAL.Repository.Abstract;


namespace StaffHub.DAL.Repository.Implmentaion;

public class DepartmentRpostiory : GenaricRepository<Department>,IDepartmentRpostiory
{
  

    public DepartmentRpostiory(ApplicationDBContext db) : base(db)  
    {
       
    }
   
}
