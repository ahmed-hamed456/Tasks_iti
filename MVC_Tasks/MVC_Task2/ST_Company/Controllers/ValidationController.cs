using Microsoft.AspNetCore.Mvc;
using ST_Company.Models;
using ST_Company.Models.ViewModels;

namespace ST_Company.Controllers
{
    public class ValidationController : Controller
    {
        Company_Context context;
        public ValidationController()
        {
            context = new Company_Context();
        }

        [HttpGet]
        public IActionResult AddEmployee()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddEmployee(AddEmployeeVM addEmployeeVM)
        {
            if (ModelState.IsValid) { 
            Employee employee = new Employee() {
                ID = addEmployeeVM.ID,
                Name = addEmployeeVM.Name,
                Age = addEmployeeVM.Age,
                Email = addEmployeeVM.Email,
                Password = addEmployeeVM.Password
            };
                context.Employees.Add(employee);
                context.SaveChanges();
                return RedirectToAction("Index", "Employee");
            }
            else{
                return View(addEmployeeVM);
            }

            
        }
    }
}
