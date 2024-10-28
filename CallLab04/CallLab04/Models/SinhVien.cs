namespace CallLab04.Models
{
    public class SinhVien
    {
        public Guid? Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Major { get; set; }
        public Guid ClassId { get; set; }
    }
}
