using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    internal class Program
    {
        static void Noti(string message)
        {
            Console.WriteLine(message);
        }
        static void Main(string[] args)
        {
            //tao class Employee
            //bien: name(not empty), workHour(>0)
            //method: void input(): su dung try catch
            //method int getSalary: tra ve salary = workHour * 20
            //method void Display(): in thong tin Employee

            //tao class EmployeeManage
            //bien: List<Employee> list
            //method: Add, Show, SearchBySalary, DeleteByName
            //dung event de thong bao khi co Employee duoc add vao hoac
            //              xoa di

            //trong main:
            //viet menu co 5 chuc nang: 
            //  1.Add, 2.Show, 3.SearchBySalary, 4.DeleteByName, 5.Exit

            EmployeeManager em = new EmployeeManager();
            em.MyEvent += Noti;

            string option = "";
            while(option != "5")
            {
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Show");
                Console.WriteLine("3. SearchBySalary");
                Console.WriteLine("4. DeleteByName");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Input your option: ");
                option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        em.Add();
                        break; 
                    case "2":
                        em.Show();
                        break;
                    case "3":
                        em.SearchBySalary();
                        break;
                    case "4":
                        em.DeleteByName();
                        break;
                    case "5":
                        Console.WriteLine("Exit program!");
                        break;
                    default:
                        Console.WriteLine("Invalid option!");
                        break;
                }
            }

        }
    }
}
