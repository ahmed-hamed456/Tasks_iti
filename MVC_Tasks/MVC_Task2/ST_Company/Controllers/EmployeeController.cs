using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ST_Company.Models;

namespace ST_Company.Controllers
{
    public class EmployeeController : Controller
    {
        Company_Context Context;
        public EmployeeController()
        {
            Context = new Company_Context();
        }
        public IActionResult Index()
        {
            List<Employee> employees = Context.Employees.ToList();

            return View(employees);
        }

        public IActionResult GetById(int id)
        {
            Employee employee = Context.Employees.SingleOrDefault(e => e.ID == id);
            if (employee == null)
            {
                return Content("Employee not valid");
            }
            return View(employee);
        }

        public IActionResult AddForm(int id)
        {
            List<Office> offices=Context.Offices.ToList();
            ViewBag.Offices = new SelectList(offices,"ID","Name");
            return View();
        }

        public IActionResult AddToDB(Employee employee)
        {
            try
            {
                Context.Employees.Add(employee);
                Context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return Content($"Something went wrong\n{ex}");
            }
        }

        public IActionResult EditForm(int id)
        {
            Employee employee=Context.Employees.SingleOrDefault(e=>e.ID== id);
            List<Office> offices = Context.Offices.ToList();
            ViewBag.Offices = offices;
            return View(employee);
        }

        public IActionResult EditInDB(Employee employee)
        {
            Employee OldEmployee=Context.Employees.SingleOrDefault(e=>e.ID== employee.ID);
            OldEmployee.Name= employee.Name;
            OldEmployee.Email= employee.Email;
            OldEmployee.Age= employee.Age;
            OldEmployee.Password= employee.Password;
            OldEmployee.Office_id= employee.Office_id;
            Context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            try
            {
                Employee Employee=Context.Employees.SingleOrDefault(e=>e.ID== id);
                Context.Employees.Remove(Employee);
                Context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return Content("Something went wrong");
            }

        }
    }
}
