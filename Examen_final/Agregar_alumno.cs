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
    public partial class Agregar_alumno : Form
    {
        public Agregar_alumno()
        {
            InitializeComponent();

        }

        private void Agregar_alumno_Load(object sender, EventArgs e)
        {

        }

        private void agregar_alumno_btn_Click(object sender, EventArgs e)
        {
            TextBox dni = dni_alumno;
            TextBox apellido = apellido_alumno;
            TextBox nombre = nombre_alumno;
            TextBox nota = nota_alumno; // Convierte correctamente el string a int


            List<TextBox> listaTextBox = new List<TextBox> { dni, apellido, nombre, nota };
            if (Utilidades.validarTextBox(listaTextBox) != null)// si hay campos vacios
            {
                MessageBox.Show($"Todos los campos son obligatorios", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (Crud_calificaciones.existeAlumno(dni.Text))//valido para evitar duplicados
            {
                MessageBox.Show($"El alumno con el DNI :  {dni.Text} ya existe", "Alerta!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Utilidades.validarNota(nota.Text))//valido nota
            {
                MessageBox.Show($"La nota {nota.Text} es invalida.\n" +
                    $"Solo se permiten notas del 0 al 10 ", "Alerta!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            // Creo el objeto Alumno
            Alumno alumno = new Alumno(dni.Text, apellido.Text, nombre.Text, int.Parse(nota.Text));

            // Agrego el alumno a la lista estática
            Crud_calificaciones.agregarAlumno(alumno);

            DialogResult respuesta =  MessageBox.Show($"Alumno {dni.Text} agregado.\n" +
                 $"Desea agregar otro  alumno ?", "Exito!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                Utilidades.limpiarEditText(listaTextBox);
            }
            else
            {
                this.Close();
            }


        }



    }
}
