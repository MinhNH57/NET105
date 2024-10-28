namespace Practice_CRUD.Models
{
    public class SInhVien
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public Guid IDLopHoc { get; set; }
        public virtual LopHoc lophoc { get; set; }
    }
}
