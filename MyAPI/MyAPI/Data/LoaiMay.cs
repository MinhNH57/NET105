﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Db_Watch_and_Ring.Models
{
    public class LoaiMay
    {
        public Guid ID { get; set; }
        public string TenLoaiMay { get; set; }
        public string? TenMay { get; set; }
        public virtual DongHo? dongho { get; set; }
    }
}
