using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase
{
    internal class SuperHeroe
    {

        public string Nombre { get; set; }
        public string IdentidadSecreta { get; set; }
        public string Ciudad { get; set; }
        public bool PuedeVolar { get; set; }
        public SuperPoder Poder { get; set; }
        public SuperHeroe(string nombre, string identidadsecreta, string ciudad, bool puedevolar, SuperPoder poder)
        {
            Nombre = nombre;
            IdentidadSecreta = identidadsecreta;
            Ciudad = ciudad;
            PuedeVolar = puedevolar;
        }

        public SuperHeroe()
        {
           Poder = new SuperPoder();
        }
     

        public void Imprimir() 
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Identidad Secreta: {IdentidadSecreta}");
            Console.WriteLine($"Ciudad: {Ciudad}");
            Console.WriteLine($"Puede volar: {PuedeVolar}");
            Console.WriteLine($"Super Poder: {Poder.Nombre}");
            Console.WriteLine($"Descripcion: {Poder.Descripcion}");
            Console.WriteLine($"Nivel: {Poder.Nivel}");
        }
    }
}
