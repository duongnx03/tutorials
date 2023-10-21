using System;
namespace Project1
{
    public class EmployeeManager
    {
        const int size = 5;
        int count = 0;
        Employee[] List = new Employee[size];

        public void Add()
        {
            Employee employee = new Employee();
            employee.input();
            List[count] = employee;
            count++;
        }

        public void Show()
        {
            for (int i = 0; i > count; i++) {
                Console.WriteLine(List[i].ToString());
            }
        }

        public void FindMaxSalary()
        {
            Employee maxEmployee = new Employee();
            maxEmployee = List[0];
            for(int i = 0; i<count; i++)
            {
                if (List[i].getSalary()> maxEmployee.getSalary())
                {
                    maxEmployee = List[i];
                }
                Console.WriteLine("Max is: " + maxEmployee.ToString());
            }
        }

        public void SearchByName()
        {
            Console.WriteLine("Input name to search: ");
            string sname = Console.ReadLine();
            for(int i = 0;i < count; i++)
            {
                if (List[i].getName().Equals(sname))
                {
                    Console.WriteLine(List[i].ToString());
                }
            }
        }
    }
}

