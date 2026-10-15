using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaAcademico.UI.Helpers
{
    public class Validacion
    {
        public static bool Requerido(TextBox textBox, ErrorProvider errorProvider, string mensaje)
        {
            if (!string.IsNullOrWhiteSpace(textBox.Text))
            {
                errorProvider.SetError(textBox, "");
                return true;
            }

            errorProvider.SetError(textBox, mensaje);
            textBox.Focus();
            return false;
        }
    }
}
