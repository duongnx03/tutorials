using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    delegate void MyDelegate(string message);
    internal class EmployeeManager
    {
        List<Employee> list = new List<Employee>();
        public event MyDelegate MyEvent;

        public void Add()
        {
            Employee employee = new Employee();
            employee.input();
            list.Add(employee);
            MyDelegate myDelegate = MyEvent;
            if(myDelegate != null)
            {
                MyEvent("Add Employee successfully!");
            }
        }

        public void Show()
        {
            foreach (Employee emp in list)
            {
                emp.display();
            }
        }

        public void SearchBySalary()
        {
            Console.WriteLine("input salary to search: ");
            int sSalary = int.Parse(Console.ReadLine());
            foreach (Employee emp in list)
            {
                if(emp.getSalary() == sSalary)
                {
                    emp.display();
                }
            }
        }

        public void DeleteByName()
        {
            Console.WriteLine("input name to delete: ");
            string dName = Console.ReadLine();
            foreach (Employee emp in list)
            {
                if(emp.Name == dName)
                {
                    list.Remove(emp);
                    MyDelegate myDelegate = MyEvent;
                    if (myDelegate != null)
                    {
                        MyEvent("Delete Employee successfully!");
                    }
                    break;
                }
            }
        }
    }
}
