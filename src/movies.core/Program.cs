using System;
using System.Linq;
using movies.core.models;

namespace movies.core
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            using (var db = new MoviesContext())
            {
                // Create
                Console.WriteLine("Inserting a new blog");
                db.Add(new Movie { Name = "The Martian" });                
                db.SaveChanges();

                // Read
                Console.WriteLine("Querying for a blog");
                var movie = db.Movies
                    .OrderBy(b => b.MovieId)
                    .First();
                Console.WriteLine(movie.Name);
                

                // Update
                Console.WriteLine("Updating the movie and adding an actor");
                //movie.Name = "The Martian";
                movie.Actors.Add(
                    new Actor
                    {
                        Name = "John",
                        Surname = "Williams"
                    });
                db.SaveChanges();
                
                // Delete
                //Console.WriteLine("Delete the blog");
                //db.Remove(blog);
                //db.SaveChanges();
            }
        }
    }
}
