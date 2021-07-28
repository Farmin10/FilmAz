using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Mappings
{
    public class FilmCountryMap : IEntityTypeConfiguration<FilmCountry>
    {
        public void Configure(EntityTypeBuilder<FilmCountry> builder)
        {
            builder.HasData(
                new FilmCountry { FilmCountryId = 1, CountryName = "America" },
                new FilmCountry { FilmCountryId = 2, CountryName = "Turkey" },
                new FilmCountry { FilmCountryId = 3, CountryName = "Hindu" },
                new FilmCountry { FilmCountryId = 4, CountryName = "Columbia" }
                );
        }
    }
}
