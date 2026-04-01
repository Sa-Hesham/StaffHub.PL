



namespace StaffHub.PLL.Service.Abstract;

public interface IEmployeeService
{

    public IEnumerable<GetEmployeeVM> GetAll();    

    public EmployeeDetailsVM ? GetById(int id);  

    public bool Create(CreateEmployeeVM employee);  

    public bool Update(UpdateEmployeeVM employee);

    public bool Delete(int Id);
}
