using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary
{
    public class Movie
    {
        public string Name { get; private set; }
        public string Genre { get; private set; }
        public string Description{ get; private set; }
        public string Director { get; private set; }
        public string Language { get; private set; }

        public Movie(string name, string genre, string description, string director, string language)
        {
            Name = name;
            Genre = genre;
            Description = description;
            Director = director;
            Language = language;
        }

        public void ShowInformation()
        {
            Console.WriteLine("Name: " + Name);
            //Console.WriteLine("Genero: " + Genre);
            //Console.WriteLine("Descricao: " + Description);
            //Console.WriteLine("Diretor: " + Director);
            //Console.WriteLine("Linguagem: " + Language);
            Console.WriteLine();
        }
    }
}
