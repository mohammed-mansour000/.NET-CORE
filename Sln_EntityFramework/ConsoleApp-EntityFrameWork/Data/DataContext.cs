using ConsoleApp_EntityFrameWork.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_EntityFrameWork.Data
{
    class DataContext : DbContext
    {
        public DbSet<student> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer(@"Data Source=DESKTOP-FI4HSGV\MANSURSQL;Initial Catalog=Test;Integrated Security=True");
        }
    }
}
