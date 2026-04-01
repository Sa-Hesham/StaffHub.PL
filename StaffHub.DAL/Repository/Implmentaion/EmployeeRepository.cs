using StaffHub.DAL.Data.DataBase;

namespace StaffHub.DAL.Repository.Implmentaion;

public class EmployeeRepository : GenaricRepository<Employee>, IEmployeeRepository
{
    public EmployeeRepository(ApplicationDBContext db) : base(db)
    {
        
    }

}


   