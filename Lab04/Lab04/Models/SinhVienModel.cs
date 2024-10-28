namespace Lab03_04.Models
{
    public class SinhVienModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Major { get; set; }
        public Guid ClassId { get; set; }
        public virtual LopHocModel? LopHoc { get; set; }
    }
}
