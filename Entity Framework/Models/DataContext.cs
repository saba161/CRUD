using Entity_Framework.Migrations;
using Entity_Framework.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity_Framework.Models
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost; Initial Catalog=Test; Integrated Security=true; User ID=TestUser; Password=1s1");
        }

        public DbSet<Pets> pets { get; set; }

        public DbSet<Owners> owners { get; set; }
    }
}
