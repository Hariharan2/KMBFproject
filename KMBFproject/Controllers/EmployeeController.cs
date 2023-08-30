using KMBFproject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace KMBFproject.Controllers
{
    public class EmployeeController : Controller
    {
        Employee _context;

        public EmployeeController(Employee context) 
        { 
        _context = context;
        }

        public IActionResult Index()
        {
            var employee =new Employee();
            List<Employee> Employeelist = _context.Employee.ToList();
            return View(Employeelist);
        }
        [HttpGet]
        public IActionResult create() { 
            return View();
        
        }
        [HttpPost]
        public IActionResult create(Employee employee) {
            if(ModelState.IsValid) {
                _context.Employee.Add(employee);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }
        
    }
}
