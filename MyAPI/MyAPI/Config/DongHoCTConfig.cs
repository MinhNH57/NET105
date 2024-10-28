using Db_Watch_and_Ring.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Db_Watch_and_Ring.Configurations
{
    internal class DongHoCTConfig : IEntityTypeConfiguration<DongHoCT>
    {
        public void Configure(EntityTypeBuilder<DongHoCT> builder)
        {
            builder.HasKey(x => x.ID);

            builder.HasOne(x => x.size).WithOne(x => x.donghoct)
                .HasForeignKey<DongHoCT>(x => x.SizeID);

            builder.HasOne(x => x.daydeo).WithOne(x => x.donghoct)
                .HasForeignKey<DongHoCT>(x => x.DayDeoID);
        }
    }
}
