

namespace StaffHub.PLL.Service.Abstract;

public interface IDepartmentServices
{

    public ResponseResult<List<GetDepartmentVM>> GetAllDepartments(); 

     public ResponseResult<DeparmentDetailsVM> GetById(int id);



   public bool Create (CreateDepartmentVM department);  



    public bool Update (UpdateDepartmentVM department);




    public bool Delete (int Id);    



}
