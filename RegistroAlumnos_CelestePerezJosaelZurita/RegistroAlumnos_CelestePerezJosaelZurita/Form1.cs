namespace RegistroAlumnos_CelestePerezJosaelZurita
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //centrar la ventana
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnNuevo2_Click(object sender, EventArgs e)
        { //Botón para limmpiar 
            textNombre.Clear();
            textCedu.Clear();
            combo1.SelectedIndex = -1;
            combo2.SelectedIndex = -1;
            textUser.Clear();
            textCon.Clear();
            textCon2.Clear();
            rbtMat.Checked = false;
            rbtVis.Checked = false;
            check1.Checked = false;
        }

        private void btnGua1_Click(object sender, EventArgs e)
        { //valida datos y despues debe mostrar esos datos en el listBox
            Validar v = new Validar();

            if (v.ValidarCampos(textNombre, textCedu, textCon,
                                textCon2, check1,
                                combo1, combo2,
                                rbtMat, rbtVis))
            {
                MessageBox.Show("Datos correctos.");
            }
        }



        //Salir del formulario
        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        //configuracion del botón 2 de guardar, gurda los datos como tal!!!
        private void btnGua2_Click(object sender, EventArgs e)
        {
            Validar v = new Validar();

            if (v.ValidarCampos(textNombre, textCedu, textCon,
                                textCon2, check1,
                                combo1, combo2,
                                rbtMat, rbtVis))
            {
                MessageBox.Show("Datos correctos.");
            }
        }

        //Botón de ayuda
        private void btnAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aplicación: Registro de Alumnos\n" +
                   "Versión: 1.0\n" +
                   "Autor: Celeste Pérez y Josael Zurita \n",
                   "Ayuda",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
        }

        //Configurar atajos(limpiar y guardar)
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Ctrl + S: guardar
            if (e.Control && e.KeyCode == Keys.S)
            {
                btnGua2.PerformClick();
            }

            // ESC: limpiar
            if (e.KeyCode == Keys.Escape)
            {
                btnNuevo2.PerformClick();
            }
        }

    }//fin
}
