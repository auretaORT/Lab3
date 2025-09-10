namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pais p1 = new Pais("Uruguay", "UYU");
            Director d1 = new Director(p1, "Juan Perez");
            Pelicula pel1 = new Pelicula("The Jocker", Genero.Thriller, new DateTime(2020, 10, 01), 120, d1);

            Console.WriteLine(pel1);
            Console.WriteLine($"El pais del director de la pelicula {pel1.Titulo} es {pel1.Director.GetNombrePais()}");
            //Prueba desde GITHUB
            //Prueba conflicto
            Console.WriteLine("Prueba GITHUB");

            Console.ReadKey();
        }
    }
}
