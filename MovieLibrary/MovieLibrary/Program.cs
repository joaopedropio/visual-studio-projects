using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            MovieLibrary library = new MovieLibrary();
            SampleMovies(library);
            while(1 == menu.showMenu(library));
        }

        static void SampleMovies(MovieLibrary library)
        {
            library.AddMovie(new Movie("Mad Max", "", "","",""));
            library.AddMovie(new Movie("Harry Potter", "", "", "", ""));
            library.AddMovie(new Movie("Velozes e Furiosos", "", "", "", ""));
            library.AddMovie(new Movie("Jogos Vorazes", "", "", "", ""));
            library.AddMovie(new Movie("king kong", "", "", "", ""));
        }
    }
}
