using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tree.Models
{
    public class TreeDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost; Initial Catalog=Test; Integrated Security=true; User ID=TestUser; Password=11");
        }

        public DbSet<Person> Persons { get; set; }
    }
}
