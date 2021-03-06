using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace WebApi.DBOperations
{
    public class DataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BookStoreDbContext(serviceProvider.GetRequiredService<DbContextOptions<BookStoreDbContext>>()))
            {
                if(context.Books.Any())
                {
                    return;
                }

                context.Books.AddRange(
                    new Book{
                        
                Title = "Lean Startup",
                GenreId = 1, //PersonalGrowth
                PageCount = 220,
                PublishDate = new DateTime(2000,10,10) 
            },    
             new Book{

                Title = "Herland",
                GenreId = 2, //PersonalGrowth
                PageCount = 320,
                PublishDate = new DateTime(2010,05,10) 
            }, 
               new Book{

                Title = "Dune",
                GenreId = 2, //PersonalGrowth
                PageCount = 720,
                PublishDate = new DateTime(2003,05,30) 
            }
            );

            context.SaveChanges(); 
            }
        }
    }
}