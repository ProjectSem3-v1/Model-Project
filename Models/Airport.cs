namespace Mini_Project.Models
{
    public class Airport
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public int FlightRouteId { get; set; }
        public FlightRoute FlightRoute { get; set; }
    }
}
