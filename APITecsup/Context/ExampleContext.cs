using APITecsup.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace APITecsup.Context
{
    public class ExampleContext : DbContext
    {
        public ExampleContext() : base("name = MyContextDB")
        {

        }

        public DbSet<Person> People  { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Detail> Details { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Song> Songs { get; set; }
        //public DbSet<Customer> Customers { get; set; }

    }
}