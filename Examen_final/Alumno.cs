using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Examen_final
{
    internal class Alumno : Persona
    {
        //atributs
        private int Nota { get; set; }
        private int Calificacion { get; set; }
        //creo constructor y llamo al constructor padre
        public Alumno(string dni, string nombre, string apellido, int nota) : base(dni, nombre, apellido)
        {
            Nota = nota;//inicializo atributo
        }
    }
}
