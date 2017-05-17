using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary
{
    public class Movie
    {
        string Name;
        string Genre;
        string Description;
        string Director;
        string Language;

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

        public string GetGenre()
        {
            return Genre;
        }

        public string GetName()
        {
            return Name;
        }

        public string GetDescription()
        {
            return Description;
        }

        public string GetDirector()
        {
            return Director;
        }

        public string GetLanguage()
        {
            return Language;
        }
    }
}
