using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.AddControllers{
    [ApiController]
    [Route("[controller]s")]
    public class BookController: ControllerBase
    {
        private static List<Book> BookList = new List<Book>()
        {
            new Book{
                Id = 1,
                Title = "Lean Startup",
                GenreId = 1, //PersonalGrowth
                PageCount = 220,
                PublishDate = new DateTime(2000,10,10) 
            },    
             new Book{
                Id = 2,
                Title = "Herland",
                GenreId = 2, //PersonalGrowth
                PageCount = 320,
                PublishDate = new DateTime(2010,05,10) 
            }, 
               new Book{
                Id = 3,
                Title = "Dune",
                GenreId = 2, //PersonalGrowth
                PageCount = 720,
                PublishDate = new DateTime(2003,05,30) 
            }, 
        }; 
        [HttpGet]
        public List<Book>GetBooks()
        {
            var bookList = BookList.OrderBy(x=>x.Id).ToList<Book>();
            return bookList;
        }


    }
}