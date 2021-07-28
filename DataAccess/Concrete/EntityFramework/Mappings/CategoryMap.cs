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
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            //builder.HasData(
            //    new Category {CategoryId=1,CategoryName="Family"},
            //    new Category {CategoryId=2,CategoryName="Comedy"},
            //    new Category {CategoryId=3,CategoryName="Horror"},
            //    new Category {CategoryId=4,CategoryName="Animation"}
            //    );
        }
    }
}
