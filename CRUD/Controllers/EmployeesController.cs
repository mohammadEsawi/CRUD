using CRUD.data;
using CRUD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CRUD.Controllers
{
    public class EmployeesController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        public IActionResult Index()
        {
            var employees = context.employees.ToList();
            return View("Index", employees);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Store(Employee emp)
        {
            context.employees.Add(emp);
            context.SaveChanges();
            return RedirectToAction("Index");


        }

    }
}
