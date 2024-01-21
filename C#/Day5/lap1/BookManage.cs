using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lap1
{
    delegate void MyDelegate();
    internal class BookManage
    {
        List<Book> books = new List<Book>();
        public event MyDelegate MyEvent;

        public void createBook()
        {
            Book book = new Book();
            while (true)
            {
                try
                {
                    Console.WriteLine("Input title: ");
                    book.Title = Console.ReadLine();
                    break;
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

            while (true)
            {
                try
                {
                    Console.WriteLine("Input price: ");
                    book.Price = double.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

            while(true)
            {
                try
                {
                    Console.WriteLine("Input isSale: ");
                    book.IsSale = Boolean.Parse(Console.ReadLine());
                    break;
                }
                catch( Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            books.Add(book);
        }

        public void findByIsSale()
        {
            foreach(Book book in books)
            {
                if(book.IsSale == true)
                {
                    book.bookInfo();
                }
            }
        }

        public void Show()
        {
            if(books.Count == 0)
            {
                MyDelegate myDelegate = MyEvent;
                if(myDelegate != null)
                {
                    MyEvent();
                }
            }
            foreach (Book book in books)
            {
                book.bookInfo();
            }
                
        }

       
    }
}
