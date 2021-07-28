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
    public class ProductionYearMap : IEntityTypeConfiguration<ProductionYear>
    {
        public void Configure(EntityTypeBuilder<ProductionYear> builder)
        {
            builder.HasData(
                new ProductionYear { ProductionYearId = 1, Year = 2000 },
                new ProductionYear { ProductionYearId = 2, Year = 2001 },
                new ProductionYear { ProductionYearId = 3, Year = 2002 },
                new ProductionYear { ProductionYearId = 4, Year = 2003 },
                new ProductionYear { ProductionYearId = 5, Year = 2004 },
                new ProductionYear { ProductionYearId = 6, Year = 2005 },
                new ProductionYear { ProductionYearId = 7, Year = 2006 },
                new ProductionYear { ProductionYearId = 8, Year = 2007 },
                new ProductionYear { ProductionYearId = 9, Year = 2008 },
                new ProductionYear { ProductionYearId = 10, Year = 2009 },
                new ProductionYear { ProductionYearId = 11, Year = 2010 },
                new ProductionYear { ProductionYearId = 12, Year = 2011 },
                new ProductionYear { ProductionYearId = 13, Year = 2012 },
                new ProductionYear { ProductionYearId = 14, Year = 2013 },
                new ProductionYear { ProductionYearId = 15, Year = 2014 },
                new ProductionYear { ProductionYearId = 16, Year = 2015 },
                new ProductionYear { ProductionYearId = 17, Year = 2016 },
                new ProductionYear { ProductionYearId = 18, Year = 2017 },
                new ProductionYear { ProductionYearId = 19, Year = 2018 },
                new ProductionYear { ProductionYearId = 20, Year = 2019 },
                new ProductionYear { ProductionYearId = 21, Year = 2020 },
                new ProductionYear { ProductionYearId = 22, Year = 2021 }
                );
        }
    }
}
