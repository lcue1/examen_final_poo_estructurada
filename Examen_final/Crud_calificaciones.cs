using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_final
{
    internal class Crud_calificaciones//implemento interfaz
    {

        private static List<Alumno> alumnos = new List<Alumno>();

        // Método para obtener la lista de alumnos
        public static List<Alumno> obtenerAlumnos()
        {
            return alumnos;
        }

        // Método para agregar alumnos a la lista
        public static void agregarAlumno(Alumno alumno)
        {
            alumnos.Add(alumno);
        }

        //comprueba si existe el alumno por dni
        public static bool existeAlumno(String DNIAlumno)
        {
            return alumnos.Find(alumno => alumno.DNI == DNIAlumno)==null?false:true;
        }


        public static Alumno obtenerAlumno(String dni)
        {
            return alumnos.Find(a => a.DNI == dni);
        }
        internal static void eliminarAlumno(Alumno alumno)
        {
                alumnos.Remove(alumno);
        }

        internal static void actualizarAlumno(String dniAEditar, Alumno alumno)
        {
            Alumno alumnoBuscado = obtenerAlumno(dniAEditar);
            alumnos.Remove(alumnoBuscado);//slimina de la lista
            alumnos.Add(alumno);//agrega a la lista el actualizado
            
            
        }

        internal static List<Alumno> obtenerSuspensos()
        {
            return alumnos.FindAll(a => a.Calificacion.Equals("SS"));
        }

        internal static List<Alumno> obtenerAprobados()
        {
            return alumnos.FindAll(a => a.Nota>=7);
        }
    }
    
}
