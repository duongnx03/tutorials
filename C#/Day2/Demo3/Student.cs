using System;
namespace Demo3
{
	internal class Student : Human
	{
		public new string name = "Nguyen Van D";
		public string getName()
		{
			return name;
		}


		public void setName(string name)
		{
			this.name = name;
		}

		public override void sayHello()
		{
            base.SayHello(); // goi lai noi dung cua lop cha
            Console.WriteLine("Hello from student class");
		}

	}
}

