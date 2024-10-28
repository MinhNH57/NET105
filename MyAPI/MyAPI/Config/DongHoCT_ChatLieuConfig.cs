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
    internal class DongHoCT_ChatLieuConfig : IEntityTypeConfiguration<DongHoCT_ChatLieu>
    {
        public void Configure(EntityTypeBuilder<DongHoCT_ChatLieu> builder)
        {
            builder.HasKey(x => x.ID);
        }
    }
}
