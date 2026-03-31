
using StaffHub.DAL.Entities;
using StaffHub.PLL.ViewModels;

namespace StaffHub.PL.Controllers;

public class DepartmentController : Controller
{
    private readonly IDepartmentServices _service;

    public DepartmentController(IDepartmentServices service)
    {
        _service = service;
    }
    [HttpGet]
    public IActionResult Index()
    {
        var departments = _service.GetAllDepartments();
        return View(departments);
    }

    [HttpGet]
    public IActionResult Create()
    {



        return View();
    }




    [HttpPost]
    public IActionResult Create(CreateDepartmentVM department)
    {

        if (!ModelState.IsValid)
        {
            return View(nameof(Create), department);

        }
        var result = _service.Create(department);

        if (!result)
        {
            ModelState.AddModelError("", "Failed to create department. Please try again.");
            return View(nameof(Create), department);
        }

        return RedirectToAction("Index");
    }



    [HttpGet]
    public IActionResult Details(int? Id)
    {
        if (!Id.HasValue) return BadRequest();

        var result = _service.GetById(Id.Value);

        return View(result);
    }



    [HttpGet]
    public IActionResult Edit(int? id)
    {

        if (!id.HasValue) return BadRequest();

        var result = _service.GetById(id.Value);
        if (result is null || result.IsHasErrorOrNo || result.Result is null)
        {
            return NotFound();
        }

        var departmentVM = new UpdateDepartmentVM
        {
            Id = result.Result.Id,
            Name = result.Result.Name,
            code = result.Result.code,
            Description = result.Result.Description,


        };


        return View(departmentVM);



    }

    [HttpPost]
    public IActionResult Edit(UpdateDepartmentVM department)
    {

        if (ModelState.IsValid)
        {
            var result = _service.Update(department);
            if (result)
            {
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("", "Failed to update department. Please try again.");
                return View(nameof(Edit), department);
            }
        }
        else
        {
            return View(nameof(Edit), department);

        }


    }



    public IActionResult Delete(int? id)

    {
        if (!id.HasValue) return BadRequest();
        var result = _service.Delete(id.Value);
        if (!result)
        {
            return NotFound();
        }

        return RedirectToAction(nameof(Details), new {id});



    }

}
    
      







    
    
    

