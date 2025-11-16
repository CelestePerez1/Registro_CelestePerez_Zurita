using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroAlumnos_CelestePerezJosaelZurita
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string codigoIngresado = textCodigo.Text.Trim();

            // Códigos válidos
            string adminCode = "admin123";
            string profesorCode = "profe123";

            if (codigoIngresado == adminCode || codigoIngresado == profesorCode)
            {
                // Abrir el formulario principal
                Form1 f1 = new Form1();
                f1.Show();
                this.Hide();
            }
            else
            {
                lblMensaje.Text = "Código incorrecto. Intente nuevamente.";
                lblMensaje.Visible = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
