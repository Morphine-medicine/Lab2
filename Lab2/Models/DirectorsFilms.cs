using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Lab2.Models
{
    public class DirectorsFilms
    {
        public int Id { get; set; }
        public int DirectorId { get; set; }

        public int FilmId { get; set; }
    }
}
