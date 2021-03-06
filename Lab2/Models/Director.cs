using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab2.Models
{
    public class Director
    {
        public Director()
        {
            DirectorsFilms = new List<DirectorsFilms>();
        }

        public int Id { get; set; }

        public string Name { get; set; }
        
        public virtual ICollection<DirectorsFilms> DirectorsFilms { get; set; }

    }
}
