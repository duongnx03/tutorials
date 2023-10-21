using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public class BookManage : IEnumerable<Book>
    {
        private List<Book> books;

        public BookManage()
        {
            books = new List<Book>();
        }

        public void CreateBook()
        {
            Book newBook = new Book();

            Console.Write("Enter the title: ");
            newBook.Title = Console.ReadLine();

            bool validPrice = false;
            while (!validPrice)
            {
                try
                {
                    Console.Write("Enter the price: $");
                    newBook.Price = double.Parse(Console.ReadLine());
                    validPrice = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid price format. Please enter a valid numeric value.");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.Write("Is it on sale? (true/false): ");
            bool isSale;
            while (!bool.TryParse(Console.ReadLine(), out isSale))
            {
                Console.WriteLine("Invalid input. Please enter true or false.");
                Console.Write("Is it on sale? (true/false): ");
            }
            newBook.IsSale = isSale;

            books.Add(newBook);
        }

        public void FindByIsSale()
        {
            var saleBooks = books.Where(book => book.IsSale);
            if (saleBooks.Any())
            {
                Console.WriteLine("Books on sale:");
                foreach (var book in saleBooks)
                {
                    Console.WriteLine($"Title: {book.Title}, Price: ${book.Price}");
                }
            }
            else
            {
                OnEmptyListEvent();
            }
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return books.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public event EventHandler EmptyListEvent;

        protected virtual void OnEmptyListEvent()
        {
            EmptyListEvent?.Invoke(this, EventArgs.Empty);
        }
    }
}

