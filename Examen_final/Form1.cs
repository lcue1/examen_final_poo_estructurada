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
                MessageBox.Show("El alumno no existe","Atencion",MessageBoxButtons.OK,MessageBoxIcon.Error); 
                return;
            }
            
            new Editar_alumno(dniAlumno).Show();//abre formulario
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buscar_alumno_btn_Click(object sender, EventArgs e)
        {
            String dniAlumno = buscar_editar_eliminar_btn.Text;
            Crud_calificaciones.buscarAlumnoPorDNI(dniAlumno);
        }

        private void eliminar_alumno_btn_Click(object sender, EventArgs e)
        {

            String dniAlumno = buscar_editar_eliminar_btn.Text;
            Alumno alumno = Crud_calificaciones.obtenerAlumno(dniAlumno);//busco alumno
            if (alumno == null)
            {
                MessageBox.Show($"El alumno con DNI: {dniAlumno} no existe", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
