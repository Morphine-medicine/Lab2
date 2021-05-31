using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Lab2.Models
{
    public class Session
    {
        public Session()
        {
            Tickets = new List<Ticket>();
        }
        public int Id { get; set; }

        public int Cost { get; set; }

        public int FilmId { get; set; }

        public int RoomId { get; set; }

        public DateTime StartDate { get; set; }


        [ForeignKey("FilmId")]
        public virtual Film Film { get; set; }


        [ForeignKey("RoomId")]
        public virtual Room Room { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
