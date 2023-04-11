using Clase4MVC.Models;

namespace Clase4MVC.Services;



public static class MovieService{
    static List<Movie> Movies { get; set; }

    static MovieService(){
        Movies = new List<Movie>
        {
            new Movie { Name = "Back to the Future", Code = "BTS", Category = "Ciencia Ficcion", Minutes = 110},
            new Movie { Name = "Avatar", Code = "AVT", Category = "Ciencia Ficcion", Minutes = 500},
            new Movie { Name = "Argentina 1985", Code = "ARG", Category = "Drama", Minutes = 147},
            new Movie { Name = "El Padrino", Code = "ELP", Category = "Drama", Minutes = 185},
            new Movie { Name = "Hannibal", Code = "HNL", Category = "Terror", Minutes = 180},
            new Movie { Name = "Toy Story", Code = "TST", Category = "Animado", Minutes = 115},
            new Movie { Name = "Los Vengadores, La dinastia de Kang", Code = "LVG", Category = "Accion", Minutes = 160},
            new Movie { Name = "Rapidos y Furiosos", Code = "RYF", Category = "Accion", Minutes = 143},
            new Movie { Name = "Casablanca", Code = "CSB", Category = "Drama", Minutes = 170},
            new Movie { Name = "Thor, Amor y Trueno", Code = "TAT", Category = "Superheroe", Minutes = 130}
        };
    }

    public static List<Movie> GetAll() => Movies;//vamos a necesitar un metodo para traer todos los datos y todas las peliculas para listarlas
    //ADD
    //DELETE
    //Update
    public static void Add(Movie obj){
        if(obj == null){
            return;
        }
        Movies.Add(obj);
    }


public static Movie? Get(string code) => Movies.FirstOrDefault(x => x.Code.ToLower() == code.ToLower());// Me trae el primer elemento que me encuentra bajo la condicion que nosotros le pasamos

   public static void Delete(string code)
{
    var movieToDelete= Get(code);
    if(movieToDelete !=null)
    {
        Movies.Remove(movieToDelete);
    }
}
}