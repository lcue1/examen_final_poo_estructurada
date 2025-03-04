using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void introducir_alumno_Click(object sender, EventArgs e)
        {
            //abre la ventana de agregar alumno
            Agregar_alumno agregar_Alumno = new Agregar_alumno();
            agregar_Alumno.Show();
        }

        private void mostrar_alumnos_Click(object sender, EventArgs e)
        {
            List<Alumno> alumnos = Crud_calificaciones.obtenerAlumnos();//lllamo metodo estatico para  obtener alumnos 

            if (alumnos.Count == 0)//la lista esta vacia
            {
                MessageBox.Show("No hay alumnos registrados.", "Información");
                return;
            }

            string mensaje = "Lista de Alumnos:\n";
            foreach (Alumno alumno in alumnos)//imprimo alumnos en la lista
            {
                mensaje += $"DNI : {alumno.DNI} " +
                    $"Apellido:  {alumno.Apellido}, Nombre: {alumno.Nombre} " +
                    $"Nota: {alumno.Nota}-> Calificacion : {alumno.Calificacion}\n";
            }

            MessageBox.Show(mensaje, "Alumnos Registrados");

        }

        private void editar_eliminar_alumno_Click(object sender, EventArgs e)
        {
            String dniAlumno = buscar_editar_eliminar_btn.Text;
            if (Crud_calificaciones.obtenerAlumno(dniAlumno)==null)//no existe alumno en la lista
            {//muestra mensaje
                mostrarMensajeError(dniAlumno);
                return;
            }
            
            new Editar_alumno(dniAlumno).Show();//abre formulario y le paso un parametro  con el dni
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buscar_alumno_btn_Click(object sender, EventArgs e)
        {
            String dniAlumno = buscar_editar_eliminar_btn.Text;

            Alumno alumnoBuscado = Crud_calificaciones.obtenerAlumno(dniAlumno);

            if (alumnoBuscado==null)
            {
                mostrarMensajeError(dniAlumno);
            }
            else
            {
                MessageBox.Show($"DNI: {alumnoBuscado.DNI}\n" +
                $"Apellido: {alumnoBuscado.Apellido}\n" +
                $"Nombre: {alumnoBuscado.Nombre}\n" +
                $"Nota: {alumnoBuscado.Nota}\n" +
                $"Calificación: {alumnoBuscado.Calificacion}",
                "Información del Alumno",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }

        }

        private void eliminar_alumno_btn_Click(object sender, EventArgs e)
        {

            String dniAlumno = buscar_editar_eliminar_btn.Text;
            Alumno alumno = Crud_calificaciones.obtenerAlumno(dniAlumno);//busco alumno
            if (alumno == null)
            {
                mostrarMensajeError(dniAlumno);
                return;
            }
            String mensaje = $"Desea eliminar al alumno:\n" +
                $"DNI : {alumno.DNI}\n" +
                $"Apellido : {alumno.Apellido}\n" +
                $"Nombre: {alumno.Nombre}\n" +
                $"Nota: {alumno.Nota} \n" +
                $"Calificacion: {alumno.Calificacion}";
            DialogResult respueste = MessageBox.Show(mensaje,"Eliminar",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (respueste == DialogResult.Yes)
            {
                Crud_calificaciones.eliminarAlumno(alumno);
            }
        }

        private void mostrarMensajeError(String dni)
        {
            MessageBox.Show($"El alumno con DNI: {dni} no existe", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void alumnosSuspensos_btn_Click(object sender, EventArgs e)
        {
            List<Alumno> suspensos = Crud_calificaciones.obtenerSuspensos();
            if (suspensos.Count == 0)
            {
                MessageBox.Show("No hay registros", "Alumnos suspensos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            String mensaje = "Suspendidos\n";
            foreach(Alumno a in suspensos)
            {
                mensaje += generarMensaje("Suspendidos", a.DNI, a.Apellido, a.Nombre, a.Nota.ToString(), a.Calificacion);

            }
            MessageBox.Show(mensaje,"Alumnos suspensos",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private String generarMensaje(String titulo,String dni,String apellido, String nombre, String nota, String calificacion)
        {
            return $"DNI : {dni} Apellido : {apellido} Nombre: {nombre} Nota: {nota}  Calificacion: {calificacion}\n";
        }

        private void alumnosAprobado_btn_Click(object sender, EventArgs e)
        {

            List<Alumno> aprobados = Crud_calificaciones.obtenerAprobados();
            if (aprobados.Count == 0)
            {
                MessageBox.Show("No hay registros", "Alumnos aprobados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            String mensaje = "Suspendidos\n";
            foreach (Alumno a in aprobados)
            {
                mensaje += generarMensaje("Suspendidos", a.DNI, a.Apellido, a.Nombre, a.Nota.ToString(), a.Calificacion);

            }
            MessageBox.Show(mensaje, "Alumnos suspensos", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
