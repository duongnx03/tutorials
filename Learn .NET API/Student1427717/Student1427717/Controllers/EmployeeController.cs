using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Student1427717.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Student1427717.Controllers
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

        [HttpGet("checkLogin/{employeeId}/{password}")]
        public async Task<bool> checkLogin(string employeeId, string password)
        {
            var emp = await db.Employees.FirstOrDefaultAsync(e => e.EmployeeId == employeeId && e.Password == password);
            if(emp != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        [HttpGet("findAll")]
        public async Task<List<Employee>> findAll()
        {
            var list = await db.Employees.ToListAsync();
            return list;
        }
    }
}

