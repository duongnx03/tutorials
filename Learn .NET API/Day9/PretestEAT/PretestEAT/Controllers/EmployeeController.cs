using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PretestEAT.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PretestEAT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly DatabaseContext db;

        public EmployeeController(DatabaseContext db)
        {
            this.db = db;
        }

        [HttpGet]
        public async Task<ActionResult> getEmployee()
        {
            var list = await db.Employees.ToListAsync();
            return Ok(list);
        }

        [HttpGet("checkLogin/{empId}/{password}")]
        public async Task<bool> checkLogin(string empId, string password)
        {
            var emp = await db.Employees
                .FirstOrDefaultAsync(e => e.EmpID == empId && e.Password == password);

            if(emp != null)
            {
                return true;
            }
            return false;
        }

        [HttpGet("findAll/{min}/{max}")]
        public async Task<IEnumerable<Employee>> FindAll(float min, float max)
        {
            var list = await db.Employees
                .Where(e => e.Salary >= min && e.Salary <= max)
                .ToListAsync();

            return list;
        }

        [HttpGet("update/{empId}/{salary}")]
        public async Task<bool> UpdateSalary(string empId, float salary)
        {
            var employee = await db.Employees.FirstOrDefaultAsync(e => e.EmpID == empId);

            if (employee != null)
            {
                employee.Salary = salary;
                await db.SaveChangesAsync();
                return true;
            }

            return false;
        }
    }
}

