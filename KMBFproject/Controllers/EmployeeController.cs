using KMBFproject.Models;
using KMBFproject.Data;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace KMBFproject.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeeDbContext _context;

        public EmployeeController(EmployeeDbContext context) 
        { 
        _context = context;
        }

        public IActionResult Index()
        {
            var employee =new Employee();
             List<Employee> Employeelist = _context.Employees.ToList();
                return View(Employeelist);
        }
        [HttpGet]
        public IActionResult create() { 
            return View();

        }


        [HttpPost]
        public IActionResult create (Employee employee) {
            if(ModelState.IsValid) {
                _context.Add(employee);
                _context.SaveChanges();
                return View();
            }
            
            return RedirectToAction("Index");
        }
        
    }
}
