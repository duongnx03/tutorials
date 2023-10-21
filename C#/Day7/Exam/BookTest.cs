    using System;
    using System.Collections.Generic;

    namespace Exam
    {
        internal class BookTest
        {
            public static void Main()
            {
            BookEvent bookEvent = new BookEvent();
            BookController bookController = new BookController();
            bookEvent.BookCheck += bookController.ShowMessage;

            while (true)
                {
                    Console.WriteLine("Menu:");
                    Console.WriteLine("1. Create new");
                    Console.WriteLine("2. Display all");
                    Console.WriteLine("3. Find by issue year");
                    Console.WriteLine("4. Exit");

                    Console.Write("Enter your choice: ");
                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            bookController.SaveBook();
                            break;

                        case "2":
                            Console.WriteLine("All Books:");
                            foreach (BookController book in BookController.bookList)
                            {
                                Console.WriteLine($"ISBN: {book.Isbn}, Title: {book.Title}, Price: {book.Price:C}, Issue Year: {book.IssueYear}");
                            }
                            break;

                        case "3":
                            Console.Write("Enter issue year to search: ");
                            int searchYear = int.Parse(Console.ReadLine());
                            bookController.FindByIssueYear(searchYear);
                            break;

                        case "4":
                            Environment.Exit(0);
                            break;

                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
            Console.ReadLine();
        }
             
        }
    }