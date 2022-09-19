using HotelListing.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListing.Configurations.Entities
{
    public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.HasData(
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
