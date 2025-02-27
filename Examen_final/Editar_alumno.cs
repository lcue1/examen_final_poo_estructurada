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
        private String dni;
        public Editar_alumno(String dni)
        {
            InitializeComponent();
            this.dni = dni;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            cargarDatosUI();
        }

        private void cargarDatosUI()
        {
            Alumno alumno = Crud_calificaciones.obtenerAlumno(this.dni);//consulto el alumno
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
    }
}
