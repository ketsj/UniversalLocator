using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UniversalLocator.Models;

namespace UniversalLocator.Data
{
    // DbContext class for Locator app
    public class LocatorContext : DbContext
    {
        public LocatorContext(DbContextOptions<LocatorContext> options): base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Place>().HasKey(x => new { x.Zipcode });
        }

        // Places entity in Sqllite db
        public DbSet<Place> Places { get; set; }
    }
}
