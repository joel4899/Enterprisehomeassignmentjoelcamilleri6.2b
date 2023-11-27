using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
namespace Domain
{
    public class Flight
    {
        [Key]
        public Guid Id { get; set; }

        public DateTime DepartureDate { get; set; }
        public DateTime ArrivalDate { get; set; }
        public string Rows { get; set; }

        public string Columns { get; set; }
        public double WholesalePrice { get; set; }
        public double ComissionRate { get; set; }

    }
}