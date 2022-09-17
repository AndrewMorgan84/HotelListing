using Microsoft.EntityFrameworkCore;

namespace HotelListing.Data
{
    public class HotelListingDbContext : DbContext
    {
        public HotelListingDbContext(DbContextOptions options) 
            : base(options)
        {
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Hotel> Hotels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>().HasData(
                    new Country()
                    {
                        Id = 1,
                        Name = "England",
                        ShortName = "EN",

                    },
                    new Country()
                    {
                        Id = 2,
                        Name = "Scotland",
                        ShortName = "SC",
                    },
                    new Country()
                    {
                        Id = 3,
                        Name = "Wales",
                        ShortName = "WS",
                    },
                    new Country()
                    {
                        Id = 4,
                        Name = "Ireland",
                        ShortName = "IE",
                    }
                );
            modelBuilder.Entity<Hotel>().HasData(
                    new Hotel()
                    {
                        Id = 1,
                        Name = "Savoy",
                        Address = "Lorem Ipsum",
                        CountryId = 1,
                        Rating = 5
                    },
                    new Hotel()
                    {
                        Id = 2,
                        Name = "Ritz",
                        Address = "Lorem Ipsum",
                        CountryId = 1,
                        Rating = 4.5
                    },
                    new Hotel()
                    {
                        Id = 3,
                        Name = "St Andrews",
                        Address = "Lorem Ipsum",
                        CountryId = 2,
                        Rating = 5
                    },
                    new Hotel()
                    {
                        Id = 4,
                        Name = "The Lodge",
                        Address = "Lorem Ipsum",
                        CountryId = 2,
                        Rating = 4
                    },
                    new Hotel()
                    {
                        Id = 5,
                        Name = "St Davids",
                        Address = "Lorem Ipsum",
                        CountryId = 3,
                        Rating = 4.5
                    },
                    new Hotel()
                    {
                        Id = 6,
                        Name = "Dragon Inn",
                        Address = "Lorem Ipsum",
                        CountryId = 3,
                        Rating = 3.5
                    },
                    new Hotel()
                    {
                        Id = 7,
                        Name = "St Patricks",
                        Address = "Lorem Ipsum",
                        CountryId = 4,
                        Rating = 5
                    },
                    new Hotel()
                    {
                        Id = 8,
                        Name = "Three Harps",
                        Address = "Lorem Ipsum",
                        CountryId = 4,
                        Rating = 3.5
                    }
                );
        }
    }
}
