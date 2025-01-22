using DatabaseTask.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatabaseTask.Controllers
{
    public class BuildingCompanyController : Controller
    {
        private readonly DatabaseTaskDbContext _context;

        public BuildingCompanyController(DatabaseTaskDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetEmployees()
        {
            var employees = _context.Employee
                                    .FromSqlRaw("GetAllEmployees")
                                    .ToList();

            return View("Index", employees);
        }
    }
}
