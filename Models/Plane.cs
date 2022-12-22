namespace Mini_Project.Models
{
    public class Plane
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int FlightId { get; set; }
        public Flight Flight { get; set; }
    }
}
