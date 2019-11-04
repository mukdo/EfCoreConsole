using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;


namespace efcore
{
    class shoppingContext : DbContext
    {


        private string _connectionString;

        public shoppingContext()
        {
            _connectionString = "Server=DESKTOP-DI5GUDV;Database=Leaning;Integrated Security=True";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_connectionString);
            }

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            base.OnModelCreating(builder);
        }
        public DbSet<Product> Products { get; set; }
        //public DbSet<Customer> Customers { get; set; }
    }

}