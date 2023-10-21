using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace Exam
{
    internal class BookController
    {
        public static List<BookController> bookList = new List<BookController>();
        private string isbn;
        private string title;
        private int price;
        private int issue_year;

        public event DelegBook BookCheck;

        public string Isbn
        {
            get { return isbn; }
            set
            {
                if (Regex.IsMatch(value, @"^ISBN\d{4}$"))
                {
                    isbn = value;
                }
                else
                {
                    throw new ArgumentException("Invalid ISBN format. Please use ISBNxxxx format (x is a number).");
                }
            }
        }

        public string Title
        {
            get { return title; }
            set
            {
                if (value.Length >= 3 && value.Length <= 50)
                {
                    title = value;
                }
                else
                {
                    throw new ArgumentException("Invalid title format. Title must be >= 3 and <=50 characters.");
                }
            }
        }

        public int Price
        {
            get { return price; }
            set
            {
                if (value > 0)
                {
                    price = value;
                }
                else
                {
                    throw new ArgumentException("Invalid Price. Please enter price > 0.");
                }
            }
        }

        public int IssueYear
        {
            get { return issue_year; }
            set
            {
                if (value > 0)
                {
                    issue_year = value;
                }
                else
                {
                    throw new ArgumentException("Invalid Issue Year. Please enter a positive value.");
                }
            }
        }

        public void SaveBook()
        {
            BookController book = new BookController();
            while (true)
            {
                try
                {
                    Console.WriteLine("Input ISBN: ");
                    book.Isbn = Console.ReadLine();
                    break;
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
                    Console.WriteLine("Input Title: ");
                    book.Title = Console.ReadLine();
                    break;
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
                    Console.WriteLine("Input Price: ");
                    book.Price = Int32.Parse(Console.ReadLine());
                    break;
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
                    Console.WriteLine("Input Issue Year: ");
                    book.IssueYear = Int32.Parse(Console.ReadLine());
                    break;
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            bookList.Add(book);

            DelegBook delegBook =  BookCheck;
            if (delegBook != null)
            {
                delegBook("Book added successfully!");
            }
        }

        public void FindByIssueYear(int year)
        {
            foreach (BookController book in bookList)
            {
                if (book.IssueYear == year)
                {
                    book.Show();
                }
            }
        }

        public void Show()
        {
            if (bookList.Count == 0)
            {
                DelegBook bookCheckDelegate = BookCheck;
                if (bookCheckDelegate != null)
                {
                    bookCheckDelegate("List is empty.");
                }
            }
            else
            {
                foreach (BookController book in bookList)
                {
                    Console.WriteLine($"ISBN: {book.Isbn}, Title: {book.Title}, Price: {book.Price}, Issue Year: {book.IssueYear}");
                }
            }
        }

        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
