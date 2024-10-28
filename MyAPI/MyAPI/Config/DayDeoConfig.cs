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
    internal class DayDeoConfig : IEntityTypeConfiguration<DayDeo>
    {
        public void Configure(EntityTypeBuilder<DayDeo> builder)
        {
            builder.HasKey(x => x.ID);
        }
    }
}
