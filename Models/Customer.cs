namespace Mini_Project.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public int CMND { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }


        public FlightTicket FlightTicketId { get; set; }

        public int BillId { get; set; }
        public Bill Bill { get; set; }
    }
}
