using System;
using day2.Models;

namespace day2.Repository
{
	public interface IStudentRepo
	{
		Task<IEnumerable<Student>> GetStudents();
		Task<Student> AddStudent(Student student);
		Task<Student> UpdateStudent(Student student);
		Task<Student> DeleteStudent(int id);
	}
}

