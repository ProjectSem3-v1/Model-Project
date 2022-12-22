namespace Mini_Project.Models
{
    public class Airline
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int FlightId { get; set; }
        public Flight Flight { get; set; }
    }
}
