using BankHandWatch.DataAccessLayer.Domains;
using BankHandWatch.DataAccessLayer.Domains.SysDomains;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankHandWatch.DataAccessLayer.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Bank> Banks { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Watch> Watches { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
            .HasOne<Account>(s => s.Account)
            .WithOne(ad => ad.Customer)
            .HasForeignKey<Account>(ad => ad.CustomerId);

            modelBuilder.Entity<Branch>()
            .HasOne<Location>(s => s.Location)
            .WithOne(ad => ad.Branch)
            .HasForeignKey<Branch>(ad => ad.LocationId);

            modelBuilder.Entity<Customer>()
            .HasOne<Watch>(s => s.Watch)
            .WithOne(ad => ad.Customer)
            .HasForeignKey<Watch>(ad => ad.CustomerId);

        }
    }
}
