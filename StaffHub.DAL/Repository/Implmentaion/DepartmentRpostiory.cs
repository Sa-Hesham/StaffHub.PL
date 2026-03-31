using Microsoft.Extensions.DependencyInjection;
using StaffHub.DAL.Data.DataBase;
using StaffHub.DAL.Repository.Abstract;


namespace StaffHub.DAL.Repository.Implmentaion;

public class DepartmentRpostiory : IDepartmentRpostiory
{
    private readonly ApplicationDBContext _db;

    public DepartmentRpostiory(ApplicationDBContext db)
    {
       _db = db;
    }
    public bool Create(Department department)
    {
       
            _db.Departments.Add(department);  
            return _db.SaveChanges() > 0;   

      
      
    }

    public bool Delete(int Id)
    {

      var result = _db.Departments.SingleOrDefault(d => d.Id == Id);
        if(result == null)
        {
            return false;
        }
        else
        {
            result.IsDeleted = true;
            result.DeletedOn = DateTime.UtcNow;
            result.DeletedBy = "Sayed";
            _db.SaveChanges();  
            return true;    
        }




    }

    public IEnumerable<Department> GetAllDepartments(Expression<Func<Department, bool>>? filter = null)
    {
            var result = _db.Departments.AsNoTracking().ToList();    

        if (filter != null)
            return _db.Departments.Where(filter).ToList();

      
           return result;   


    }
	

    public Department ?GetById(int Id)
    {
       
           var result = _db.Departments.Find(Id);
           if(result == null)
            {
                return null;
            }

           return result;

     
      
       
    }

    public bool Update(Department department)
    {
      var entity =  _db.Departments.SingleOrDefault(d => d.Id == department.Id);
        if(entity == null)
        {
            return false;
        }
        entity .Name  = department.Name;  
        entity.Description = department.Description;    
        entity.code = department.code;  
        entity.ModifiedOn = DateTime.UtcNow;    
        return _db.SaveChanges() > 0;
       
       
    }
}
