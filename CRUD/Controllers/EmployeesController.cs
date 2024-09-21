using CRUD.data;
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
    }
}
