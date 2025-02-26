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

                //Obtengo informacion
                String dni = dni_alumno.ToString();
                String apellido = apellido_alumno.ToString();
                String nombre = nombre_alumno.ToString();
                int nota = int.Parse(nota_alumno.ToString());

            }catch(Exception ex)
            {
                MessageBox.Show("Informacion invalida","Error");
            }


        }
    }
}
