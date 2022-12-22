namespace Mini_Project.Models
{
    public class Fare
    {
        public int Id { get; set; }
        public int FlightId { get; set; }
        public int FlightClass { get; set; }
        public double Price { get; set; }
        public int QTY { get; set; }

        public ICollection<Flight> Flights { get; set;}
        public ICollection<FlightTicket> LightTickets { get; set;}

    }
}
