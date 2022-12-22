namespace Mini_Project.Models
{
    public class FlightTicket
    {
        public int Id { get; set; }
        public int FlightId { get; set; }
        public int FlightClassId { get; set; }
        public int CustomerId { get; set; }
        public int BillId { get; set; }
        public int FareId { get; set; }
        public int CMND { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }

        public ICollection<Flight> Flights { get; set; }
       
        public Customer Customer { get; set; }
        public Bill Bill { get; set; }
        public FlightClass FlightClass { get; set; }
        public Fare Fare { get; set; }
    }
}
