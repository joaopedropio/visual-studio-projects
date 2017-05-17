using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary
{
    public class MovieLibrary
    {
        List<Movie> movies = new List<Movie>();

        public List<Movie> Movies { get { return movies; } set { } }

        public void AddMovie(Movie movie)
        {
            movies.Add(movie);
        }

        public void RemoveMovie(Movie movie)
        {
            movies.Remove(movie);
        }

        public Movie GetMovieBy(string parameter, string search)
        {
            CompareInfo comp = CultureInfo.InvariantCulture.CompareInfo;
            switch(parameter)
            {
                case "nome":
                    {
                        return movies.Find(x => String.Equals(x.Name, search, StringComparison.InvariantCultureIgnoreCase));
                    }
                case "diretor":
                    {
                        return movies.Find(x => x.Director == search);
                    }
                 case "genero":
                    {
                        return movies.Find(x => x.Genre == search);
                    }
                 case "linguagem":
                    {
                        return movies.Find(x => x.Language== search);
                    }
                default:
                    {
                        return null;
                    }
            }
        }

        public void ListMovies()
        {
            foreach (Movie movie in this.movies)
            {
                movie.ShowInformation();
            }
        }
    }
}
