using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab2.Models
{
    public class Genre
    {
        public Genre()
        {
            FilmsGenres = new List<FilmsGenres>();
        }
        public int Id { get; set; }

        public string Name { get; set; }

        public string Info { get; set; }


        public virtual ICollection<FilmsGenres> FilmsGenres { get; set; }
    }
}
