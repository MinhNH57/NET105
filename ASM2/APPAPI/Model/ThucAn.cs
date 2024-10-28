﻿namespace APPAPI.Model
{
    public class ThucAn
    {
        public Guid ID { get; set; }
        public string Ten { get; set; }
        public string Loai { get; set; }
        public int SoLuongTonKho { get; set; }
        public decimal DonGia { get; set; }
        public DateTime NgayNhapKho { get; set; }
        public bool TinhTrang { get; set; }
    }
}
