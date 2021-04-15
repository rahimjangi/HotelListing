using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing.Data
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext(DbContextOptions options):base(options)
        {

        }
       
        public DbSet<Country>Countries{ get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Country>().HasData(
                    new Country
                    {
                        Id = 1,
                        Name = "Italy",
                        ShortName = "IT"
                    },
                    new Country
                    {
                        Id = 2,
                        Name = "Germany",
                        ShortName = "GM"
                    },
                    new Country
                    {
                        Id = 3,
                        Name = "The united state",
                        ShortName = "USA"
                    }
                );
            builder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "hotel1",
                    CountryId = 1,
                    Address = "Fake Address",
                    Rating = 4.5

                },
                new Hotel
                {
                    Id = 2,
                    Name = "hotel2",
                    CountryId = 2,
                    Address = "Fake Address",
                    Rating = 4.5

                },
                new Hotel
                {
                    Id = 3,
                    Name = "hotel3",
                    CountryId = 3,
                    Address = "Fake Address",
                    Rating = 4.5

                }

                );
        }
    }
}
