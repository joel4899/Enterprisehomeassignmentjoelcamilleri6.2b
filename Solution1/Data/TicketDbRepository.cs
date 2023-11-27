namespace Data
{
    public class TicketDBRepository
    {
        private readonly AirlineDbContext _context;

        public TicketDBRepository(AirlineDbContext context)
        {
            _context = context;
        }

        public bool Book(int flightId, int row, int column, string passport)
        {
            // Check if the flight exists
            var flight = _context.Flights.FirstOrDefault(f => f.Id == flightId);
            if (flight == null)
            {
                // Handle the case where the flight does not exist
                return false;
            }

            // Check for existing booking for the same seat on this flight
            var existingTicket = _context.Tickets.FirstOrDefault(t => t.FlightIdFk == flightId && t.Row == row && t.Column == column);
            if (existingTicket != null)
            {
                // Seat is already booked
                return false;
            }

            // Create a new ticket
            var newTicket = new Ticket
            {
                FlightIdFk = flightId,
                Row = row,
                Column = column,
                Passport = passport,
                Cancelled = false // Initially, the ticket is not cancelled
            };

            // Add the new ticket to the context
            _context.Tickets.Add(newTicket);

            // Save changes to the database
            _context.SaveChanges();

            return true; // Booking successful
        }
    }

}