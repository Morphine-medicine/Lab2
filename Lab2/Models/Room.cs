using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab2.Models
{
    public class Room
    {
        public Room() {
            Sessions = new List<Session>();
        }
        public int Id { get; set; }

        public string Name { get; set; }

        public int MaximunSeats { get; set; }

        public virtual ICollection<Session> Sessions { get; set; }
    }
}
