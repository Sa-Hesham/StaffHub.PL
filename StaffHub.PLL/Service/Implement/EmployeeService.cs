
using AutoMapper;

namespace StaffHub.PLL.Service.Implement;

public class EmployeeService : IEmployeeService
{
    private readonly IEmployeeRepository _emprepo;
    private readonly IMapper _mapper;

    public EmployeeService(IEmployeeRepository emprepo ,IMapper mapper)
    {
        _emprepo = emprepo;
        _mapper = mapper;
    }
    public bool Create(CreateEmployeeVM employee)
    {
      var dbemployee = _mapper.Map<Employee>(employee);
       
      return  _emprepo.Create(dbemployee);    
    }

    public bool Delete(int id)
    {
       
        
        return _emprepo.Delete(id);
        



    }

    public IEnumerable<GetEmployeeVM> GetAll()
    {   // map from Ienumerable<Employee>  (source)to IEnumerable<GetEmployeeVM>(destnation)
        var employees = _emprepo.GetAll().ToList();

       var map =  _mapper.Map<IEnumerable<Employee>,IEnumerable<GetEmployeeVM>>(employees);

       return map;
    }

    public EmployeeDetailsVM? GetById(int id)
    {
       var result = _emprepo.GetById(id);
        if (result == null) { 
            return null;
        }


        return _mapper.Map<EmployeeDetailsVM>(result);    

      
           
        
    }

    public bool Update(UpdateEmployeeVM employee)
    {
        var dbemployee = _emprepo.GetById(employee.Id); 
        if (dbemployee == null)
        {
            return false;
        }
        
        var updatedemployee = _mapper.Map<UpdateEmployeeVM,Employee>(employee); 
        
        return _emprepo.Update(updatedemployee);    
    }
}
