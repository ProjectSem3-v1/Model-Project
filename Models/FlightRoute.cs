namespace Mini_Project.Models
{
    public class FlightRoute
    {
        public int Id { get; set; }
        public string FlightLocation { get; set; }
        public string ParkingLocation { get; set; }

        public int FlightId { get; set; }

        public Flight Flight { get; set; }
        public ICollection<Airport> Airports { get; set;}
    }
}
