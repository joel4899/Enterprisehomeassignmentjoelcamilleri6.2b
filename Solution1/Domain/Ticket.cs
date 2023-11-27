using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    public class Ticket
    {
        [Key]
        public Guid Id { get; set; }

        public string Row { get; set; }

        public string Column { get; set; }

        [ForeignKey("Flight")]
        public int FlightIdFk { get; set; }

        public virtual Flight Flight { get; set; }
        public double Passport { get; set; }
        public double PricePaid { get; set; }

        public bool Cancelled { get; set; }

    }
}   