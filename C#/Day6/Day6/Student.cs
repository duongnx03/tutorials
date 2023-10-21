using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
	public class Student
	{
        private string studentId;
        private string fullName;
        private int age;


        public string StudentId
    {
        get { return studentId; }
        set { studentId = value; }
    }

    public string FullName
    {
        get { return fullName; }
        set { fullName = value; }
    }

    public int Age
    {
        get { return age; }
        set
        {
            if (value >= 18 && value <= 90)
                age = value;
            else
                throw new ArgumentException("Age must be between 18 and 90.");
        }
    }
        public void Input()
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter Student ID (sxx): ");
                    string inputId = Console.ReadLine();

                    // Kiểm tra định dạng StudentId và trùng lặp
                    if (Regex.IsMatch(inputId, @"^s\d{2}$") && !StudentManager.StudentIds.Contains(inputId))
                    {
                        StudentId = inputId;
                        StudentManager.StudentIds.Add(inputId);
                        break;
                    }
                    else
                    {
                        if (StudentManager.StudentIds.Contains(inputId))
                        {
                            Console.WriteLine("Student ID already exists. Please choose a different one.");
                        }
                        else
                        {
                            throw new FormatException("Invalid Student ID format. Please use 'sxx' format.");
                        }
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }


            while (true)
            {
                try
                {
                    Console.Write("Enter Full Name: ");
                    string inputName = Console.ReadLine();

                    // Kiểm tra tên không chứa số và không để trống
                    if (!string.IsNullOrWhiteSpace(inputName) && !inputName.Any(char.IsDigit))
                    {
                        FullName = inputName;
                        break; // Thoát khỏi vòng lặp nếu hợp lệ
                    }
                    else
                    {
                        throw new FormatException("Invalid Full Name. Please enter a non-empty name without digits.");
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            while (true)
            {
                try
                {
                    Console.Write("Enter Age (18 <= age <= 90): ");
                    Age = int.Parse(Console.ReadLine());

                    if (Age >= 18 && Age <= 90)
                        break; // Thoát khỏi vòng lặp nếu hợp lệ
                    else
                        throw new ArgumentException("Age must be between 18 and 90.");
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public override string ToString()
        {
            return $"Student ID: {StudentId}, Full Name: {FullName}, Age: {Age}";
        }


    }
}

