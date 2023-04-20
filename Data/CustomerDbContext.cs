using System.Collections.Generic;
using System.Net;
using Data.Models;
using Microsoft.EntityFrameworkCore;


namespace Data
{
    public class CustomerDbContext : DbContext
    {
        public CustomerDbContext(DbContextOptions<CustomerDbContext> options) : base(options) { }
        
             public DbSet<Customer> Customers { get; set; }
             public DbSet<Contact> Contacts { get; set; }
             public DbSet<Address> Address { get; set; }

    }


    

}