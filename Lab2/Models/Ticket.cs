using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Lab2.Models
{
    public class Ticket
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int SessionId { get; set; }


        [ForeignKey("SessionId")]
        public virtual Session Session { get; set; }
    }
}
