using System.ComponentModel.DataAnnotations;

namespace Lab01_Lab02.Models
{
    public class Event
    {
        public Guid Id { get; set; }
        [Required]
        [MaxLength(100)]
        [MinLength(2)]
        public string Name { get; set; }
        public DateTime Date { get; set; }
        [Required]
        public string Location { get; set; }
        public virtual List<Ticket> Tickets { get; set; }
    }
}
