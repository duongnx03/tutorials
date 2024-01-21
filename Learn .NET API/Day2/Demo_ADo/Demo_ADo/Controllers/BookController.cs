using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Demo_ADo.Models;
using Microsoft.AspNetCore.Mvc;

namespace Demo_ADo.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        [HttpGet]
        public ActionResult GetList()
        {
            string conStr = "Server=.;Database=DemoADO;User=sa;Password=Password.1;TrustServerCertificate=true";
            SqlConnection con = new SqlConnection(conStr);
            string query = "Select * from Book";
            SqlCommand conCmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader reader = conCmd.ExecuteReader();
            List<Book> books = new List<Book>();
            while (reader.Read())
            {
                Book book = new Book();
                book.Id = (int)reader["id"];
                book.Title = (string)reader["title"];
                book.Author = (string)reader["author"];
                book.Edition = (int)reader["edition"];
                book.Price = (int)reader["price"];
                books.Add(book);
            }
            con.Close();

            return Ok(books);
        }
    }
}

