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
    public class FilmLanguageMap : IEntityTypeConfiguration<FilmLanguage>
    {
        public void Configure(EntityTypeBuilder<FilmLanguage> builder)
        {
            builder.HasKey(x => new { x.FilmId, x.LanguageId });
        }
    }
}
