using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary
{
    public class Menu
    {
        
        private Dictionary<int, string> itensMainMenu = new Dictionary<int, string>();
        private Dictionary<int, string> itensSearchMenu = new Dictionary<int, string>();
        
        
        public Menu()
        {
            itensMainMenu.Add(1, "Adicionar Filmes");
            itensMainMenu.Add(2, "Remover Filme");
            itensMainMenu.Add(3, "Modificar Filme");
            itensMainMenu.Add(4, "Listar filmes");
            itensMainMenu.Add(5, "Procurar filme");
            itensMainMenu.Add(6, "Sair");

            itensSearchMenu.Add(1, "nome");
            itensSearchMenu.Add(2, "diretor");
            itensSearchMenu.Add(3, "genero");
        }
       
        public int showMenu(MovieLibrary library)
        {
            Console.Clear();
            Console.WriteLine("Catalogo de filmes");
            foreach (var item in itensMainMenu)
            {
                Console.WriteLine($" { item.Key } - { item.Value }");
            }
            int itemNumber = int.Parse(Console.ReadLine());
            string value = itensMainMenu[itemNumber];
            Console.Clear();

            switch (value) {
                case "Adicionar Filmes":
                    {
                        ShowMenuAddMovie(library);
                        break;
                    }
                case "Procurar filme":
                    {
                        ShowMenuSearchMovie(library);
                        ShowMovie(ShowMenuSearchBy(itensSearchMenu[int.Parse(Console.ReadLine())], library));
                        break;
                    }
                case "Listar filmes":
                    {
                        ShowMenuListMovies(library);
                        break;
                    }
                case "Modificar Filme":
                    {
                        ShowMenuSearchMovie(library);
                        ShowMenuRemoveMovie(itensSearchMenu[int.Parse(Console.ReadLine())],library);
                        ShowMenuAddMovie(library);
                        break;
                    }
                case "Remover Filme":
                    {
                        ShowMenuSearchMovie(library);
                        ShowMenuRemoveMovie(itensSearchMenu[int.Parse(Console.ReadLine())],library);
                        break;
                    }
                case "Sair":
                default:return 0;
            }
            // retornou 1 = nao sair, retornou 0 = sair
            return 1;
        }

        private void ShowMenuModifyMovie(MovieLibrary library)
        {
            Console.Clear();
            ShowMenuSearchMovie(library);
            ShowMenuSearchBy(itensSearchMenu[int.Parse(Console.ReadLine())], library);
            Console.WriteLine("Pressione enter para sair...");
            Console.ReadLine();
        }

        private void ShowMenuRemoveMovie(string option, MovieLibrary library)
        {
            Console.Clear();
            Console.WriteLine($"{option} :");
            string search = Console.ReadLine();

            Movie movie = library.GetMovieBy(option, search);


            if (movie == null)
            {
                Console.WriteLine("Filme inexistente");
            }
            else
            {
                library.RemoveMovie(movie);
                Console.WriteLine("Filme excluido!");
            }
            Console.WriteLine("Pressione enter para sair...");
            Console.ReadLine();
        }

        public void ShowMovie(Movie movie)
        {
            if (movie == null)
            {
                Console.WriteLine("Filme inexistente");
            }
            else
            {
                movie.ShowInformation();
            }
            Console.WriteLine("Pressione enter para sair...");
            Console.ReadLine();
        }

        public Movie ShowMenuSearchBy(string option, MovieLibrary library)
        {
            Console.Clear();
            Console.WriteLine($"{option} :");
            string search = Console.ReadLine();

            return library.GetMovieBy(option, search);
        }
        private void ShowMenuSearchMovie(MovieLibrary library)
        {
            foreach (var item in itensSearchMenu)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }

        }

        private void ShowMenuListMovies(MovieLibrary library)
        {
            if (library == null)
            {
                Console.WriteLine("Nenhum filme na lista");
            }
            else
            {
                foreach (Movie movie in library.Movies)
                {
                    movie.ShowInformation();
                }
            }
            Console.WriteLine("Pressione enter para sair...");
            Console.ReadLine();
        }

        private void ShowMenuAddMovie(MovieLibrary library)
        {
            Console.WriteLine("Nome:");
            string name = Console.ReadLine();
            Console.WriteLine("Genero:");
            string genre = Console.ReadLine();
            Console.WriteLine("Linguagem:");
            string language = Console.ReadLine();
            Console.WriteLine("Descricao:");
            string description = Console.ReadLine();
            Console.WriteLine("Director");
            string director = Console.ReadLine();

            Movie movie = new Movie(name, genre, description, director, language);

            library.AddMovie(movie);
        }

    }
}
