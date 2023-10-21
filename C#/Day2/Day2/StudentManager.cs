using System;
namespace Day2
{
	public class StudentManager
	{
		const int size = 5;
		int count = 0;
		Student[] List = new Student[size];

		public void Add()
		{
			Student student = new Student();
			student.input();
			List[count] = student;
			count++;
		}

		public void Show()
		{
			for(int i =0; i > count; i++) { }
			List[i].show();
		}
	}
}

