using System;
using System.Collections.Generic;

#nullable disable

namespace CA_ImdbDb.Models
{
    public partial class Movie
    {
        public Movie()
        {
            Casts = new HashSet<Cast>();
            Comments = new HashSet<Comment>();
            MovieGenres = new HashSet<MovieGenre>();
            Trailers = new HashSet<Trailer>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public int RuntimeMinutes { get; set; }
        public double Rating { get; set; }
        public int Votes { get; set; }
        public decimal RevenueMillions { get; set; }
        public int Metascore { get; set; }
        public int? DirectorId { get; set; }

        public virtual Director Director { get; set; }
        public virtual Picture Picture { get; set; }
        public virtual ICollection<Cast> Casts { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<MovieGenre> MovieGenres { get; set; }
        public virtual ICollection<Trailer> Trailers { get; set; }
    }
}
