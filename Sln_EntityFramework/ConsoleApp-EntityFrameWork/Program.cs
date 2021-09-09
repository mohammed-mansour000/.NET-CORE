using ConsoleApp_EntityFrameWork.Data;
using ConsoleApp_EntityFrameWork.Models;
using System;
using System.Linq;

namespace ConsoleApp_EntityFrameWork
{
    class Program
    {
        static void Main(string[] args)
        {
            DataContext ctx = new DataContext();
            student st = new student();
            //st.fname = "mhmd";
            //st.lname = "mansur";
            //ctx.Students.Add(st);
            //ctx.SaveChanges();

            var query = ctx.Students.Where(x => x.fname.StartsWith("M"));
            foreach (var item in query)
            {
                Console.WriteLine(item.fname);
            }
        }
    }
}
