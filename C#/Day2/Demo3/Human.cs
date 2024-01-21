using System;
namespace Demo3
{
	public class Human
	{
		protected string name;
		protected int age;

		public virtual void SayHello()
		{
			
			Console.WriteLine("Hello, my name is: "+name);
		}
	}
}

