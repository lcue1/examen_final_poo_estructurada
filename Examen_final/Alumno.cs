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
        public int Nota { get; set; }
        public String Calificacion { get; set; }
        //creo constructor y llamo al constructor padre
        public Alumno(string dni, string apellido, string nombre, int nota) : base(dni, nombre, apellido)
        {
            Nota = nota;//inicializo atributo
            asignarCalificacion();
        }

        private void asignarCalificacion()
        {
            Calificacion = "SB";
            if (Nota < 5)
            {
                Calificacion = "SS";
            }
            else if (Nota >= 5 && Nota < 7)
            {
                Calificacion = "AP";
            }
            else if (Nota >= 7 && Nota < 9)
            {
                Calificacion = "NT";
            }


        }
    }
}
