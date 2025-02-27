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
            try
            {


                // Obtengo información de los TextBox
                String dni = dni_alumno.Text; // Antes usabas dni_alumno.ToString()
                if (Crud_calificaciones.existeAlumno(dni))
                {
                    MessageBox.Show("El alumno ya existe","Atencion");
                    return;
                }
                String apellido = apellido_alumno.Text;
                String nombre = nombre_alumno.Text;
                int nota = int.Parse(nota_alumno.Text); // Convierte correctamente el string a int


                // Creo el objeto Alumno
                Alumno alumno = new Alumno(dni, apellido, nombre, nota);

                // Agrego el alumno a la lista estática
                Crud_calificaciones.agregarAlumno(alumno);

                MessageBox.Show("Alumno agregado", "Éxito");

            }
            catch(Exception ex)
            {
                MessageBox.Show("Informacion invalida","Error");
            }


        }
    }
}
