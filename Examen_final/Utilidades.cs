using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_final
{
    internal class Utilidades
    {
        public static TextBox validarTextBox(List<TextBox> listaTextBox)
        {
            return listaTextBox.Find(l => l.Text.Equals(""));

        }
    }
    
}
