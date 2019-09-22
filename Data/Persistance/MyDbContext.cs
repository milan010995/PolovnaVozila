using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Domain;

namespace Data.Persistance
{
    public class MyDbContext : DbContext
    {
        public DbSet<Make> Makes { get; set; }

        public DbSet<Model> Models { get; set; }

        public MyDbContext(DbContextOptions<MyDbContext> dbContextOptions)
        : base(dbContextOptions)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=Auto;User Id=milan;Password=milan010;");
        }
    }
}
