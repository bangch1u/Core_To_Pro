using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Namespace.Context
{
    public class MyDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=BANGCH1U\\SQLEXPRESS;Initial Catalog=testConnec;Integrated Security=True;Trust Server Certificate=True");
            }
        }
        public DbSet<Test> Tests { get; set; }
    }
}
