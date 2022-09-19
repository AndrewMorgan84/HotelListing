using HotelListing.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListing.Configurations.Entities
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasData(
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
        }
    }
}
