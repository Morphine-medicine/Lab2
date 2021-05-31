using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Lab2.Models
{
    public class FilmsGenres
    {
        public int Id { get; set; }
        public int GenreId { get; set; }

        public int FilmId { get; set; }


        [ForeignKey("GenreId")]
        public virtual Genre Genre { get; set; }


        [ForeignKey("FilmId")]
        public virtual Film Film { get; set; }
    }
}
