using Layers_DI.Services;
using Layers_DI.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Layers_DI.Controllers
{
    public class EmployeeController : Controller
    {
        private IEmployeeServics employeeServics;
        private  IDepartmentService departmentService;

        public EmployeeController(IEmployeeServics employeeServics, IDepartmentService departmentService) 
        {
           this.employeeServics=employeeServics;
            this.departmentService = departmentService;
        } 
        public IActionResult Index()
        {
            List<EmployeeVM>employees=employeeServics.GetAll();

            return View(employees);
        }
        public IActionResult GetById(int id)
        {
            EmployeeVM employeeVM = employeeServics.GetById(id);
            return View(employeeVM);
        }

        public IActionResult Add()
        {
            List<EmployeeVM> employeeVMs = employeeServics.GetAll();
            List<DepartmentVM> departmentVMs = departmentService.GetAll();

            ViewBag.emps = new SelectList(employeeVMs, "SSN", "Fname");
            ViewBag.depts = new SelectList(departmentVMs, "Number", "Name");
            return View();
        }
        public IActionResult AddDb(EmployeeVM employeeVM)
        {
           
            employeeServics.Add(employeeVM);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id)
        {
            List<EmployeeVM> employeeVMs = employeeServics.GetAll();
            List<DepartmentVM> departmentVMs = departmentService.GetAll();
            EmployeeVM employeeVM = employeeServics.GetById(id);

            ViewBag.emps = new SelectList(employeeVMs, "SSN", "Fname");
            ViewBag.depts = new SelectList(departmentVMs, "Number", "Name");
            return View(employeeVM);
        }
        public IActionResult EditDb(EmployeeVM employeeVM)
        {
            employeeServics.Edit(employeeVM);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            employeeServics.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
