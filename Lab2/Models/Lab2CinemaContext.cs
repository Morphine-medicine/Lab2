using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab2.Models;

namespace Lab2.Models
{
    public class Lab2CinemaContext : DbContext
    {
        public virtual DbSet<Film> Films { get; set; }

        public virtual DbSet<Director> Directors { get; set; }

        public virtual DbSet<DirectorsFilms> DirectorsFilms { get; set; }

        public virtual DbSet<Genre> Genres { get; set; }

        public virtual DbSet<Room> Rooms { get; set; }

        public virtual DbSet<Session> Sessions { get; set; }

        public virtual DbSet<Ticket> Tickets { get; set; }

        public virtual DbSet<FilmsGenres> FilmsGenres { get; set; }

        public Lab2CinemaContext(DbContextOptions<Lab2CinemaContext> options)
            :base(options)
        {
            Database.EnsureCreated();
        }




    }
}
