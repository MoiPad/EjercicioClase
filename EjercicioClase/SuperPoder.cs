using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase
{
    internal class SuperPoder
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Nivel { get; set; }
        public SuperPoder(string nombre , string descripcion, int nivel ) 
        {
            Nombre = nombre;
            Descripcion = descripcion;
            Nivel = nivel;
        }

        public SuperPoder()
        {
        }
    }
    
}
