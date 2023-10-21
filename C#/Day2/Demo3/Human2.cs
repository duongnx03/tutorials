using System;
namespace Demo3
{
	internal abstract class Human2
	{
		public string name2;
		public int age2;

		//lop abstract chua duoc method abstract
		//method abstract la method khong co phan than
		//khi ke thua no phai implement cac method abstract
		public abstract void SayHello2();

		public void PrintAge()
		{
			Console.WriteLine("I'm " + age2);
		}
	}
}

