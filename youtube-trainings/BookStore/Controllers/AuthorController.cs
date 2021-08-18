using BookStore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        public IEnumerable<Author> Get()
        {
            using (var context = new BookStoresDBContext())
            {
                //this is all we need to return authors
                return context.Authors.ToList();

                //add an author
                //Author author = new Author();
                //author.FirstName = "hamzi";
                //author.LastName = "mansour";
                //context.Authors.Add(author);
                //context.SaveChanges();

                //update an author 
                //Author author = context.Authors.Where(auth => auth.FirstName == "hamzi").FirstOrDefault();
                //author.Phone = "70121954";
                //context.SaveChanges();

                //remove an author 
                //Author author = context.Authors.Where(auth => auth.FirstName == "hamzi").FirstOrDefault();
                //author.Authors.Remove(author);
                //context.SaveChanges();

                //get an author by id
                // return context.Authors.Where(a => a.FirstName == "hamzi").ToList();

            }
        }
    }
}
