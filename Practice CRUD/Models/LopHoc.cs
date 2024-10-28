namespace Practice_CRUD.Models
{
    public class LopHoc
    {
        public Guid ID { get; set; }
        public string NameClass { get; set; }
        public virtual ICollection<SInhVien> sInhviens { get; set; }
    }
}
