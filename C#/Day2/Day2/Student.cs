using System;
namespace Day2
{
	public class Student
	{
		private int id;
		private string name;
		private float mark;
		public Student()
		{

		}
		public Student(int id, string name, float mark)
		{
			this.id = id;
			this.name = name;
			this.mark = mark;
		}

		public void input()
		{
			Console.WriteLine("Input id: ");
			id = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Input name: ");
			name = Convert.ToString(Console.ReadLine());
			Console.WriteLine("Input mark: ");
			mark = float.Parse(Console.ReadLine());
		}

        public void DisplayDetails()
        {
            Console.WriteLine("Student ID: " + id);
            Console.WriteLine("Student Name: " + name);
            Console.WriteLine("Student Mark: " + mark);
        }

		public void Add()
		{

		}

    }
}

