using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    public class Pelicula
    {
        public int Id { get; set; }
        public static int UltimoId { get; set; } = 1;
        public string Titulo { get; set; }
        public Genero Genero { get; set; }
        public DateTime FechaLanzamiento { get; set; }
        public int Duracion { get; set; }//en minutos
        // las listas siempre privada y sin set
        private List<Director> Directores  = new List<Director>();

        public Pelicula()
        {
            Id = UltimoId++;
        }

        public Pelicula(string titulo, Genero genero, DateTime fechaLanzamiento, int duracion/*, Director director*/)
        {
            Id = UltimoId++;
            Titulo = titulo;
            Genero = genero;
            FechaLanzamiento = fechaLanzamiento;
            Duracion = duracion;
            //Director = director;
        }

        //La fecha de baja del catálogo, sabiendo que es
        //exactamente 3 meses después de su fecha de
        //lanzamiento. 
        public DateTime FechaBajaCatalogo()
        {
            return FechaLanzamiento.AddMonths(3);
        }

        //Saber si es apta para todo público teniendo en cuenta
        //que los géneros terror, suspenso y thriller son
        //para mayores de 13. 
        public bool EsApta()
        {
            if (Genero == Genero.Terror || Genero == Genero.Suspenso || Genero == Genero.Thriller)
            {
                return false;
            }
            return true;
        }

        //public override string ToString()
        //{
        //    return $"La pelicula {Titulo} es del genero {Genero} y es dirigida por el director {Director.NombreCompleto}";
        //}


        public void AgregarDirector(Director dir)
        {
            //dir.Validar();
            if (dir != null)
            {
                Directores.Add(dir);

            }
        }

        public List<Director> GetDirectores()
        {
            return Directores;
        }

    }
}
