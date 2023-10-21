using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace lap7
{
    public delegate void StudentDelegate(string message);

    internal class Student
    {
        public static List<Student> list = new List<Student>();
        public static event StudentDelegate StudentEvent;
        public string id;
        public string name;
        public int mark;

        public string Id
        {
            get { return id; }
            set
            {
                if (Regex.IsMatch(value, @"^s\d{2}$"))
                {
                    id = value;
                }
                else
                {
                    throw new ArgumentException("Invalid ID format. Please use sxx format (x is a number).");
                }
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length >= 3)
                {
                    name = value;
                }
                else
                {
                    throw new ArgumentException("Name must be at least 3 characters.");
                }
            }
        }

        public int Mark
        {
            get { return mark; }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    mark = value;
                }
                else
                {
                    throw new ArgumentException("Invalid mark. Please enter a number between 0 and 100.");
                }
            }
        }

        public Student() { }

        public Student(string id, string name, int mark)
        {
            this.id = id;
            this.name = name;
            this.mark = mark;
        }

        public override string ToString()
        {
            return $"ID: {id}, Name: {name}, Mark: {mark}";
        }



        public static void AddStudent()
        {
            string idn;
            string namen;
            int markn;

            while (true)
            {
                try
                {
                    Console.Write("Enter Student ID (sxx format): ");
                    idn = Console.ReadLine();
                    new Student().Id = idn;
                    break; // Thoát khỏi vòng lặp nếu ID hợp lệ
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            while (true)
            {
                try
                {
                    Console.Write("Enter Student Name (at least 3 characters): ");
                    namen = Console.ReadLine();
                    new Student().Name = namen;
                    break; // Thoát khỏi vòng lặp nếu Name hợp lệ
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            while (true)
            {
                try
                {
                    Console.Write("Enter Student Mark (0-100): ");
                    markn = int.Parse(Console.ReadLine());
                    new Student().Mark = markn;
                    break; // Thoát khỏi vòng lặp nếu Mark hợp lệ
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input format. Please enter valid data.");
                }
            }

            // Sau khi nhập đúng dữ liệu cho tất cả các trường, tạo và thêm sinh viên
            StudentDelegate studentDelegate = StudentEvent;
            if (studentDelegate != null)
            {
                StudentEvent("Add new student successfully!");
            }
            Student student = new Student(idn, namen, markn);
            list.Add(student);
        }

        public static void FindAllStudents()
        {
            if (list.Count == 0)
            {
                StudentDelegate studentDelegate = StudentEvent;
                if (studentDelegate != null)
                {
                    StudentEvent("List Emptyo!");
                }
            }
            else
            {
                Console.WriteLine("All Students:");
                foreach (Student student in list)
                {
                    Console.WriteLine(student);
                }
            }
        }
    }
}

