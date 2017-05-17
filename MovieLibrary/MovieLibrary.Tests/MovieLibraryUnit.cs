using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary.Tests
{
    [TestClass]
    public class MovieLibraryTest
    {
        [TestMethod]
        public void AddMovieTest()
        {
            Movie harrypotter = new Movie("Harry Potter e a Pedra Filosofal", "Fantasia", "O pequeno rapaz com a cabeça rachada passara por varias trapalhadas no mundo magico de Hogwarts", "X", "English");
            Assert.AreEqual("Fantasia", harrypotter.GetGenre());
            Assert.AreEqual("O pequeno rapaz com a cabeça rachada passara por varias trapalhadas no mundo magico de Hogwarts", harrypotter.GetDescription());
            Assert.AreEqual("X", harrypotter.GetDirector());
            Assert.AreEqual("English", harrypotter.GetLanguage());
            Assert.AreEqual("Harry Potter e a Pedra Filosofal", harrypotter.GetName());
        }

        [TestMethod]
        public void RemoveMovie()
        {
            Movie harrypotter = new Movie("Harry Potter e a Pedra Filosofal", "Fantasia", "O pequeno rapaz com a cabeça rachada passara por varias trapalhadas no mundo magico de Hogwarts", "X", "English");
            MovieLibrary library = new MovieLibrary();
            library.AddMovie(harrypotter);

            Assert.IsNotNull(library.Movies[0]);
            library.RemoveMovie(harrypotter);
            Assert.IsNull(library.Movies);
        }
    }
}
