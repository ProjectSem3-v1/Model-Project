namespace Mini_Project.Models
{
    public class Flight
    {
        public int Id { get; set; }
        public int PlaneId { get; set; }
        public int FlightRouteId { get; set; }

        public int AirlineId { get; set; }
        public DateTime FlightDate { get; set; }
        public DateTime FlightTime { get; set; }
        public int Status { get; set; }
        public int FareId { get; set; }
        public int FlightTicketId { get; set; }
        public Plane Plane { get; set; }
        public Fare Fare { get; set; }
        public FlightTicket FlightTicket { get; set; }
        public ICollection<Airline> Airlines { get; set; }
        public ICollection<FlightRoute> FlightRoutes { get; set; }

    }
}
