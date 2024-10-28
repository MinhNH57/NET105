using Db_Watch_and_Ring.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Db_Watch_and_Ring.Configurations
{
    internal class DongHoConfig : IEntityTypeConfiguration<DongHo>
    {
        public void Configure(EntityTypeBuilder<DongHo> builder)
        {
            builder.HasKey(x => x.ID);

            builder.HasOne(x => x.loaimay).WithOne(x => x.dongho)
                .HasForeignKey<DongHo>(x => x.LoaiMayID);
            builder.HasOne(x => x.matkinh).WithOne(x => x.dongho)
                .HasForeignKey<DongHo>(x => x.MatKinhID);
        }
    }
}
