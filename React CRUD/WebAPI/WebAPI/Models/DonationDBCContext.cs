using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class DonationDBCContext : DbContext
    {
        public DonationDBCContext(DbContextOptions<DonationDBCContext> options) : base(options)
        {

        }
        public DbSet<Candidate> candidates { get; set; }
    }
}
