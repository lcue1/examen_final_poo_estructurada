using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_final
{
    internal class Persona//clase padre
    {
        //definicion atributos
        public String DNI { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }

        public Persona(String dni, String nombre, String apellido) { //constructor
            //inicializar variables
            DNI = dni;
            Nombre = nombre;
            Apellido = apellido;
        }

    }
}
