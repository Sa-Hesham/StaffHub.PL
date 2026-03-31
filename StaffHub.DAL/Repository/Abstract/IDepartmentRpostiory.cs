

using System.Linq.Expressions;

namespace StaffHub.DAL.Repository.Abstract;

  public interface IDepartmentRpostiory
{
    public IEnumerable<Department> GetAllDepartments(Expression<Func<Department, bool>>? fillter = null);

    public Department ?GetById(int Id);

  public bool Create(Department department);
  public bool Update(Department department);
    
  public bool Delete(int Id);


}
