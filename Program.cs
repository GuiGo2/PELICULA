using System;
using System.Collections.Generic;

namespace Peliculas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> nombresDePelicula = new List<string>();
            nombresDePelicula.Add("Toy Story");
            nombresDePelicula.Add("Avengers");
            nombresDePelicula.Add("Bicentennial Man");
            nombresDePelicula.Add("Beetlejuice");
            nombresDePelicula.Add("Silence of the Lambs");
            nombresDePelicula.Add("Bad Boys");
            nombresDePelicula.Add("Bad Boys");
            nombresDePelicula.Add("Aladdin");
            nombresDePelicula.Add("Aladdin");

            HashSet<String> nombresDePeliculaSet = new HashSet<string>();
            nombresDePeliculaSet.Add("Toy Story");
            nombresDePeliculaSet.Add("Avengers");
            nombresDePeliculaSet.Add("Bicentennial Man");
            nombresDePeliculaSet.Add("Beetlejuice");
            nombresDePeliculaSet.Add("Silence of the Lambs");
            nombresDePeliculaSet.Add("Bad Boys");
            nombresDePeliculaSet.Add("Bad Boys");
            nombresDePeliculaSet.Add("Aladdin");
            nombresDePeliculaSet.Add("Aladdin");



            Console.WriteLine("Cant. de peliculas en nombresDePelicula: " + nombresDePelicula.Count);
            Console.WriteLine("Cant. de peliculas en nombresDePeliculaSet: " + nombresDePeliculaSet.Count);

            HashSet<Pelicula> peliculasSet = new HashSet<Pelicula>();
            peliculasSet.Add(new Pelicula("Bad Boys", 1995));
            PeliculasSet.Add(new Pelicula("Nad Boys", 1983));
            peliculasSet.Add(new Pelicula("Aladdin", 2019));
            PeliculasSet.Add(new Pelicula("Aladdin", 1992)); 
            Console.WriteLine("Cant. de peliculas en peliculasSet: " + peliculasSet.count);

            Dictionary<string, string> nombresDePeliculaFavoritas = new Dictionary<string, string>();
            nombresDePeliculaFavoritas.Add("Pablo", "Titanic");
            nombresDePeliculaFavoritas.Add("Esteban", "Fast and Furious: Tokyo Drift");
            nombresDePeliculaFavoritas.Add("Octavio", "Baribie in the 12 Dancing Princesses");

           string nombrePeliculaFavoritaPablo = nombresDePeliculaFavoritas.GetValueOrDefault("Pablo");
           Console.WriteLine("nombrePeliculaFavoritaPablo: " + nombrePeliculaFavoritaPablo);

           string nombrePeliculaFavoritaRamiro = nombresDePeliculaFavoritas.GetValueOrDefault("Ramiro");
           Console.WriteLine("nombrePeliculaFavoritaRamiro: " + nombrePeliculaFavoritaRamiro);

           nombrePeliculaFavoritaRamiro = nombresDePeliculaFavoritas.GetValueOrDefault("Ramiro", "(Ninguna)");
           Console.WriteLine("nombrePeliculaFavoritaRamiro: " + nombrePeliculaFavoritaRamiro); //ninguna

           nombresDePeliculaFavoritas.Add("Ramiro", "Avatar");

           nombrePeliculaFavoritaRamiro = nombresDePeliculaFavoritas.GetValueOrDefault("Ramiro", "(Ninguna)");
           Console.WriteLine("nombrePeliculaFavoritaRamiro: " + nombrePeliculaFavoritaRamiro); //Avatar

           //uso real de obtener valores de un Dictionary
           if (nombresDePeliculaFavoritas.TryGetValue("Maria", out string nombrePeliculaFavoritaMaria))
           {
               Console.WriteLine("nombrePeliculaFavoritaMaria", out string nombrePeliculaFavoritaMaria);
           }
        else
        {
            Console.WriteLine("Maria no tiene Pelicula favorita.");
        }

        //lista
        Console.WriteLine("---------");
        Console.WriteLine("Lista");
        for (int i = 0; i < nombresDePeliculaFavoritas.Count; i++)
        {
            Console.WriteLine(nombresDePelicula[i]);
        }

        // HashSet
        Console.WriteLine("-------");
        Console.WriteLine("set");
       for (string nombresDePelicula in nombresDePeliculaSet)
       {
           Console.WriteLine(nombresDePelicula);
       }

       // Dictionary
        Console.WriteLine("-------");
        Console.WriteLine("set");
       foreach (var item in nombresDePeliculaFavoritas.keys);
       {
           Console.WriteLine(key);
       }
       foreach (var item in nombresDePeliculaFavoritas.Values)
       {
           Console.WriteLine(value);
       }


    }
}
