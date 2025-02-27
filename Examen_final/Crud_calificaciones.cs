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

        public static void buscarAlumnoPorDNI(string DNIAlumno)
        {
            Alumno alumno = alumnos.Find(a => a.DNI == DNIAlumno);
            if (alumno == null)
            {
                MessageBox.Show("El alumno no existe"); ;
            }
            else
            {
                MessageBox.Show($"DNI: {alumno.DNI}\n" +
                    $"Apellido: {alumno.Apellido}" +
                    $"Nombre: {alumno.Nombre}\n" +
                    $"Nota: {alumno.Nota}\n" +
                    $"Calificacion: {alumno.Calificacion}"); ;
            }
        }
    }
    
}
