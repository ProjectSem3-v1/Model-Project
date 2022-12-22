namespace Mini_Project.Models
{
    public class FlightClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int FlightClassId { get; set; }


        public FlightTicket FlightTicketId { get; set; }
    }
}
