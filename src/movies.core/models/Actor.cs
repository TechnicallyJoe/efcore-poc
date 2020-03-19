using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace movies.core.models
{ 
    public class Actor
    {
        public int ActorId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public int MovieId { get; set; }
        public Movie Movie { get; set; }
    }
}