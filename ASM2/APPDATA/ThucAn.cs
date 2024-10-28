using System.ComponentModel.DataAnnotations;

namespace APPAPI.Model
{
    public class ThucAn
    {
        public Guid ID { get; set; }

        [Required(ErrorMessage = "Tên không được để trống.")]
        [StringLength(30, ErrorMessage = "Tên không được vượt quá 30 kí tự.")]
        public string Ten { get; set; }
        [Required(ErrorMessage = "Loại không được để trống.")]
        public string Loai { get; set; }
        [Required(ErrorMessage = "Số lượng tồn kho không được để trống.")]
        [Range(0, int.MaxValue, ErrorMessage = "Số lượng tồn kho không được nhỏ hơn 0.")]
        public int SoLuongTonKho { get; set; }
        [Required(ErrorMessage = "Đơn giá không được để trống.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Đơn giá phải là số dương.")]
        public decimal DonGia { get; set; }
        [DataType(DataType.Date)]
        public DateTime NgayNhapKho { get; set; }
        [Required(ErrorMessage = "Tình trạng không được để trống.")]
        public bool TinhTrang { get; set; }
    }
}
