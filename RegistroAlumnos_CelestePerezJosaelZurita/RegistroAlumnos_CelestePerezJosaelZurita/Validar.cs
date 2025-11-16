using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroAlumnos_CelestePerezJosaelZurita
{
    internal class Validar 
    {
        public bool ValidarCampos(TextBox textNombre, TextBox textCedu, TextBox textCon, 
            TextBox textCon2, CheckBox check1, ComboBox combo1, 
            ComboBox combo2, RadioButton rbtMat, RadioButton rbtVis, CheckBox check2)
        {
            //validar que todos los campos esten completos
         if (textNombre.Text.Trim() == "" || textCedu.Text.Trim() == "" ||
         combo1.SelectedIndex == -1 || combo2.SelectedIndex == -1 ||
         (!rbtMat.Checked && !rbtVis.Checked) ||textCon.Text.Trim() == "" ||
         textCon2.Text.Trim() == "" ||check1.Checked == false || check2.Checked == false)
            {
                MessageBox.Show("Se necesita llenar todos los campos .",
                    "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!SoloLetras(textNombre.Text))
            {
                MessageBox.Show("El nombre solo permite letras.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textNombre.Focus();
                return false;
            }

            if (!SoloNumeros(textCedu.Text))
            {
                MessageBox.Show("La cédula solo permite números.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textCedu.Focus();
                return false;
            }

            //Validar logitu de la cédula
            if (textCedu.Text.Trim().Length < 5)
            {
                MessageBox.Show("La cédula no es válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validar confirmación de contraseña
            if (textCon.Text != textCon2.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }//fin método validarcampos

        private bool SoloLetras(string texto)
        {
            foreach (char c in texto)
            {
                if (!char.IsLetter(c) && c != ' ')
                    return false;
            }
            return true;
        }

        private bool SoloNumeros(string texto)
        {
            foreach (char c in texto)
            {
                if (!char.IsDigit(c))
                    return false;
            }
            return true;
        }



    }//fin
}
