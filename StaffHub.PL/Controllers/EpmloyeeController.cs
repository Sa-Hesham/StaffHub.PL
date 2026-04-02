using StaffHub.DAL.Entities.EmployeeModule;
using StaffHub.DAL.Entities.Shared;
using StaffHub.PLL.ViewModels.EmployeeVM;

namespace StaffHub.PL.Controllers;

public class EmployeeController : Controller
{
    private readonly IEmployeeService _employee;

    public EmployeeController(IEmployeeService employee)
    {
        _employee = employee;
    }
    [HttpGet]
    public IActionResult Index()
    {
        var employee = _employee.GetAll();

        return View(employee);
    }

    [HttpGet]
    public IActionResult Create()
    {



        return View();

    }


    [HttpPost]
    public IActionResult Create(CreateEmployeeVM employee)
    {
        if (!ModelState.IsValid)
        {
            return View(nameof(Create), employee);
        }
        var result = _employee.Create(employee);
        if (!result)
        {
            ModelState.AddModelError("", "Failed to create employee. Please try again.");
            return View(nameof(Create), employee);
        }
        return RedirectToAction("Index");
    }


    [HttpGet]

    public IActionResult Details(int? Id)
    {
        if (!Id.HasValue) return BadRequest();
        var employee = _employee.GetById(Id.Value);
        if (employee == null)
            return NotFound();




        return View(employee);



    }




    [HttpGet]
    public IActionResult Edit(int? Id)
    {
        if (!Id.HasValue) return BadRequest();
        var employee = _employee.GetById(Id.Value);
        if (employee == null)
            return NotFound();
        var EditEmployee = new UpdateEmployeeVM
        {
           Id=Id.Value, 
           Name=employee.Name,  
           Address=employee.Address,    
           Email=employee.Email,    
           Age=employee.Age,
           IsActive=employee.IsActive,  
           Salary=employee.Salary,  
           HiringDate=employee.HiringDate,  
           Gender=Enum.Parse<Gendar> (employee.Gender),   
           EmployeeType=Enum.Parse<EmployeeType>(employee.EmployeeType) ,
           PhoneNumber=employee.PhoneNumber,

        }; 
        return View(EditEmployee);  
    }


    [HttpPost]
    public IActionResult Edit(UpdateEmployeeVM employee)
    {
        if (!ModelState.IsValid)
        {
            return View(nameof(Edit), employee);
        }
        var result = _employee.Update(employee);
        if (!result)
        {
            ModelState.AddModelError("", "Failed to update employee. Please try again.");
            return View(nameof(Edit), employee);
        }
        return RedirectToAction("Index");
    }

   public IActionResult Delete(int? Id)
    {
        if (!Id.HasValue) return BadRequest();
        var result = _employee.Delete(Id.Value);
        if (!result)
        {
            return NotFound();
        }
        return RedirectToAction("Index");
    }
}
