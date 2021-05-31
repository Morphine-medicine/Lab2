using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab2.Models
{
    public class Film
    {
        public Film()
        {
            DirectorsFilms = new List<DirectorsFilms>();
            FilmsGenres = new List<FilmsGenres>();
            Sessions = new List<Session>();
        }
        public int Id { get; set; }

        public string Name { get; set; }

        public int Duration { get; set; }

        public string PosterUrl { get; set; }

        public virtual ICollection<FilmsGenres> FilmsGenres { get; set; }

        public virtual ICollection<DirectorsFilms> DirectorsFilms { get; set; }


        public virtual ICollection<Session> Sessions { get; set; }
    }
}
