using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgencyApp.Model
{
    [Table("Reservation", Schema = "dbo")]

    public class Reservation
    {
        [Key]
        public int ReservationId { get; set; }

        [ForeignKey("Voyage")]
        public int VoyageId { get; set; }
        public virtual Voyage Voyage { get; set; }

        [ForeignKey("Client")]
        public int ClientId { get; set; }
        public virtual Client Client { get; set; }

        [Required]
        public DateTime DateReservation { get; set; }
    }
}
