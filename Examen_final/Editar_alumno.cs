using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_final
{
    public partial class Editar_alumno : Form
    {
        private String dniAEditar;
        public Editar_alumno(String dni)
        {
            InitializeComponent();
            this.dniAEditar = dni;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            cargarDatosUI();
        }

        private void cargarDatosUI()
        {
            Alumno alumno = Crud_calificaciones.obtenerAlumno(this.dniAEditar);//consulto el alumno
            if (alumno != null)///solo si se encuentra el alumno lo carga
            {
                dni_alumno_editar.Text = alumno.DNI;
                apellido_alumno_editar.Text = alumno.Apellido;
                nombre_alumno_editar.Text = alumno.Nombre;
                nota_alumnoeditar.Text = alumno.Nota.ToString();
                return;
            }
            //muestra mensaje
            DialogResult respuesta = MessageBox.Show("El alumno no existe", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Close();// ciera el formulario


        }

        private void editar_alumno_btn_Click(object sender, EventArgs e)
        {
            //obtengo los texbox porque necesito validarlos
            TextBox nuevoDni = dni_alumno_editar;
            TextBox apellido = apellido_alumno_editar;
            TextBox nombre = nombre_alumno_editar;
            TextBox nota = nota_alumnoeditar;
            List<TextBox> listaTextBox =new List<TextBox> {nuevoDni, apellido,nombre,nota};
            if (Utilidades.validarTextBox(listaTextBox) != null)// si hay campos vacios
            {
                MessageBox.Show($"Todos los campos son obligatorios", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            bool dniDiferente = dniAEditar!=nuevoDni.Text;
            bool dniYaExiste = Crud_calificaciones.existeAlumno(nuevoDni.Text);
            if (dniDiferente &&  dniYaExiste)// comprueba si el nuevo dni ingresado es diferente y si es asi si ese dni no existe en la lista
            {
                MessageBox.Show($"Este DNI: {nuevoDni.Text} ya existe.\n" +
                    $"Elija otro.", "¡Atención!",
                                MessageBoxButtons.OK, MessageBoxIcon.Information); 
                return;
             }


            Alumno alumno = new Alumno(nuevoDni.Text,apellido.Text,nombre.Text,int.Parse(nota.Text));
            Crud_calificaciones.actualizarAlumno(dniAEditar,alumno);

            MessageBox.Show($"Alumno actualizado exitosamente.", "¡Actalizacion!",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }


        
    }
}
