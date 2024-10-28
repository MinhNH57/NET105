namespace Lab01_Lab02.Models
{
    public class Ticket
    {
        public Guid Id { get; set; }
        public string SeatNumber { get; set; }
        public decimal Price { get; set; }

        public Guid IDEvent { get; set; }
        public virtual Event Event { get; set; }
    }
}
