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
    public class FamousActorMap : IEntityTypeConfiguration<FamousActor>
    {
        public void Configure(EntityTypeBuilder<FamousActor> builder)
        {
            builder.HasData(
                new FamousActor { FamousActorId = 1, ActorName = "Farmin" },
                new FamousActor { FamousActorId = 2, ActorName = "Zaur" },
                new FamousActor { FamousActorId = 3, ActorName = "Hasan" }
                );
        }
    }
}
