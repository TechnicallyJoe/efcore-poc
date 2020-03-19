using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace movies.core.models
{
    public class MoviesContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor> Actors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer("Server=localhost;Database=Movies;User Id=sa;Password=Test1234!;");
    }
}