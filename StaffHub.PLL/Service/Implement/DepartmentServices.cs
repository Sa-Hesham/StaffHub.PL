

using StaffHub.DAL.Repository.Abstract;
using StaffHub.PLL.Factories;


namespace StaffHub.PLL.Service.Implement;

public class DepartmentServices : IDepartmentServices
{
    private readonly IDepartmentRpostiory _department;

    public DepartmentServices(IDepartmentRpostiory department)
    {
       _department = department;
    }

    public bool Create(CreateDepartmentVM department)
    {
       var result = department.MaptoEntity();
        if (result == null) { 
        
        return false;   
        
        }

        return _department.Create(result);  

    }

    public bool Delete(int Id)
    {
      var result = _department.GetById(Id);
        if(result == null)
        {
            return false;
        }
        else
        {
            return _department.Delete(Id);
        }   
    }

    public ResponseResult<List<GetDepartmentVM>> GetAllDepartments()
    {
        try
        {
            var departments = _department.GetAllDepartments();

            var result = departments.Select(d => d.MapToGetDepartmentVM()).ToList();

            return new ResponseResult<List<GetDepartmentVM>>(result, null, false);

        }
        catch (Exception ex )
        {

            return new ResponseResult<List<GetDepartmentVM>>(null, ex.Message, true);
        }
    }

    public ResponseResult<DeparmentDetailsVM> GetById(int id)
    {
        try
        {
            var result = _department.GetById(id);
            if(result != null)
            {
                var departmentDetails = result.MapToDepartMentDetailsVM();  
               

                return new ResponseResult<DeparmentDetailsVM>(departmentDetails, null, false);  

            }


            return new ResponseResult<DeparmentDetailsVM>(null, "Not Found Department", true);
        }
        catch (Exception ex )
        {

            return new ResponseResult<DeparmentDetailsVM>(null, ex.Message, true);
        }
      
    }

    public bool Update(UpdateDepartmentVM department)
    {
     var result = department.toEditEntity();
        if (result is null)
            return false;   
        return _department.Update(result);  

    }
}
