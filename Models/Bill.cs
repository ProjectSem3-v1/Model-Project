namespace Mini_Project.Models
{
    public class Bill
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public DateTime Booking_date { get; set; }
        public double Price { get; set; }

        public int FlightTicketId { get; set; }
        public FlightTicket FlightTicket { get; set; }
        public ICollection<Customer> Customers { get; set; }

    }
}
