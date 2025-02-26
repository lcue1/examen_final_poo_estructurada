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

        }
    }
}
