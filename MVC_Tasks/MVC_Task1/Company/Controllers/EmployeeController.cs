using Company.Models;
using Microsoft.AspNetCore.Mvc;

namespace Company.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult GetById(int id)
        {
            Employee? employee = SampleData.Employees.Where((s)=>s.ID== id).SingleOrDefault();
            if(employee==null)
            {
                return Content("Employee is not Avialable");
            }
            return View("GetById",employee);
        }

        public IActionResult GetAll()
        {
            List<Employee> employees=SampleData.Employees;
            return View("GetAll",employees);
        }
    }
}
