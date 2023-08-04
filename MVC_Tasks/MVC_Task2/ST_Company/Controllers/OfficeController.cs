using Microsoft.AspNetCore.Mvc;
using ST_Company.Models;

namespace ST_Company.Controllers
{
    public class OfficeController : Controller
    {
        Company_Context context;
        public OfficeController()
        {
            context = new Company_Context();

        }
        public IActionResult Index()
        {
            List<Office> offices = context.Offices.ToList();
            return View(offices);
        }

        public IActionResult GetById(int id)
        {
            Office office = context.Offices.SingleOrDefault(e=>e.ID==id);
            if (office == null)
            {
                return Content("office not valid");
            }
            return View(office);
        }

        public IActionResult AddForm()
        {
            return View();
        }

        public IActionResult AddToDB(Office office)
        {
            try
            {
                context.Offices.Add(office);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return Content($"Something went wrong\n{ex}");
            }
        }

        public IActionResult EditForm(Office office)
        {
            Office offices= context.Offices.SingleOrDefault(e=>e.ID==office.ID);
            return View(office);
        }

        public IActionResult EditToDB(Office office)
        {
            Office OldOffice = context.Offices.SingleOrDefault(e => e.ID == office.ID);
            OldOffice.Name= office.Name;
            OldOffice.Location= office.Location;
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            try
            {
                Office office = context.Offices.SingleOrDefault(o => o.ID == id);
                context.Offices.Remove(office);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return Content("Something went wrong");
            }
        }
    }
}
