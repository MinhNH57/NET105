namespace Lab03_04.Models
{
    public class LopHocModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<SinhVienModel>? SinhViens { get; set; }
    }
}
