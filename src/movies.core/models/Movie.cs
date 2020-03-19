using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace movies.core.models
{ 
    public class Movie
    {
        public int MovieId { get; set; }
        public string Name { get; set; }

        public List<Actor> Actors { get; } = new List<Actor>();
    }
}