using System;
using day2.Data;
using day2.Models;
using day2.Repository;
using Microsoft.EntityFrameworkCore;

namespace day2.Service
{
	public class StudentService : IStudentRepo
	{
        private readonly DatabaseContext db;

        public StudentService(DatabaseContext db)
        {
            this.db = db;
        }

        public async Task<Student> AddStudent(Student student)
        {
            db.Students.Add(student);
            await db.SaveChangesAsync();
            return student;
        }

        public async Task<Student> DeleteStudent(int id)
        {
            var stuId = await db.Students.SingleOrDefaultAsync(s => s.Id == id);
            db.Students.Remove(stuId);
            await db.SaveChangesAsync();
            return stuId;
        }

        public async Task<IEnumerable<Student>> GetStudents()
        {
            var list = await db.Students.ToListAsync();
            return list;
        }

        public async Task<Student> UpdateStudent(Student student)
        {
            var stu = await db.Students.SingleOrDefaultAsync(s => s.Id == student.Id);
            stu.Email = student.Email;
            stu.Mark = student.Mark;
            stu.Name = student.Name;
            await db.SaveChangesAsync();
            return stu;
        }
    }
}

