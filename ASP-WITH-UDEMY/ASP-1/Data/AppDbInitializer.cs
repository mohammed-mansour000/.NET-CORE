using ASP_1.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_1.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                if (!context.Books.Any())
                {
                    context.Books.AddRange(
                        new Book()
                            {
                                Title = "1st Book Title",
                                Description = "1st Book Description",
                                IsRead = true,
                                DateRead = DateTime.Now.AddDays(-10),
                                Rate = 4,
                                Genre = "Drama",
                                Author = "mohammed mansour",
                                CoverUrl = "https...",
                                DateAdded = DateTime.Now
                            },
                        new Book()
                            {
                                Title = "2nd Book Title",
                                Description = "2nd Book Description",
                                IsRead = false,
                                Rate = 4,
                                Genre = "Drama",
                                Author = "hamzi mansour",
                                CoverUrl = "https...",
                                DateAdded = DateTime.Now
                            }     
                        );
                    context.SaveChanges();
                }
            }
        }
    }
}
