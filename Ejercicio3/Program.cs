namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pais p1 = new Pais("Uruguay", "UYU");
            Director d1 = new Director(p1, "Juan Perez");
            Director d2 = new Director(p1, "Ana Gonzalez");
            Pelicula pel1 = new Pelicula("The Jocker", Genero.Thriller, new DateTime(2020, 10, 01), 120/*, d1*/);

            pel1.AgregarDirector(d1);
            pel1.AgregarDirector(d2);

            //pel1.Directores.Clear();
            List<Director> directores = pel1.GetDirectores();
            foreach (Director director in directores)
            {
                Console.WriteLine(director.NombreCompleto);
            }


            //Console.WriteLine(directores);


            Console.WriteLine(pel1);
            //Console.WriteLine($"El pais del director de la pelicula {pel1.Titulo} es {pel1.Director.GetNombrePais()}");
            //Prueba desde GITHUB
            //Prueba resolver conflicto
            Console.WriteLine("Prueba GITHUB");

            Console.ReadKey();
        }
    }
}
