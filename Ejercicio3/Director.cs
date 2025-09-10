using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    public class Director
    {
        public int Id { get; set; }
        public static int UltimoId { get; set; } = 1;
        public Pais Pais { get; set; }
        public string NombreCompleto { get; set; }

        public Director()
        {
            Id = UltimoId++;
        }

        public Director(Pais pais, string nombreCompleto)
        {
            Id = UltimoId++;
            Pais = pais;
            NombreCompleto = nombreCompleto;
            //Validar();
        }

        public string GetNombrePais()
        {
            return Pais.Nombre;
        }
    }
}
