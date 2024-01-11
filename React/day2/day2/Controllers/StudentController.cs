using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using day2.Models;
using day2.Repository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace day2.Controllers
{
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepo repo;

        public StudentController(IStudentRepo repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public async Task<ActionResult> GetStudents()
        {
            return Ok(await repo.GetStudents());
        }

        [HttpPost]
        public async Task<ActionResult> PostStudent(Student student)
        {
            return Ok(await repo.AddStudent(student));
        }

        [HttpPut]
        public async Task<ActionResult> PutStudent(Student student)
        {
            return Ok(await repo.UpdateStudent(student));
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteStudent(int id)
        {
            return Ok(await repo.DeleteStudent(id));
        }
    }
}

