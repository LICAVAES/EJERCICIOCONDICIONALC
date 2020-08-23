using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taller2Condicionales
{
    public partial class Edad : Form
    {
        public Edad()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Dispose(); 
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtEdad.Text = String.Empty;
            TxtEdad.Focus(); 
        }

        private void BtnValidar_Click(object sender, EventArgs e)
        {
            int edad = int.Parse(TxtEdad.Text);

            if (edad > 18)
            {
                MessageBox.Show("Eres mayor de edad.",
                    "Mensaje del Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Eres menor de edad.",
                    "Mensaje del Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
    }
}
