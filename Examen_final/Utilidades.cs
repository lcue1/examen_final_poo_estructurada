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

        public static bool validarNota(string nota)
        {
            try
            {
                int notaInt = int.Parse(nota);
                if (notaInt < 0 || notaInt > 10)
                { return false; }

                return true;
            }
            catch (Exception) { return false; }
        }


        public static void limpiarEditText(List<TextBox> textBoxs)
        {
            foreach (TextBox tb in textBoxs)
            {
                tb.Text = "";
            }
        }
    }
    
}
