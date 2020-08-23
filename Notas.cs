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
    public partial class Notas : Form
    {
        public Notas()
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
            TxtNota1.Text = String.Empty;
            TxtNota2.Text = String.Empty;
            TxtNota3.Text = String.Empty;
            TxtNota4.Text = String.Empty;
            TxtNota5.Text = String.Empty;
            label7.Visible = false;
            lblPromedio.Text = "0";
            lblPromedio.Visible = false;
            TxtNota1.Focus();
        }

        private void BtnValidar_Click(object sender, EventArgs e)
        {
            double nota1, nota2, nota3, nota4, nota5, promedio = 0;

            nota1 = double.Parse(TxtNota1.Text);
            nota2 = double.Parse(TxtNota2.Text);
            nota3 = double.Parse(TxtNota3.Text);
            nota4 = double.Parse(TxtNota4.Text);
            nota5 = double.Parse(TxtNota5.Text);

            promedio = (nota1 + nota2 + nota3 + nota4 + nota5) / 5;

            if (promedio >= 0 && promedio <= 1)
            {

                label7.Visible = true;
                lblPromedio.Visible = true;
                lblPromedio.Text = Convert.ToString(promedio);
                MessageBox.Show("Reprueba materia sin lograr realizar " +
                    "proceso de recuperación", "Mensaje del Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else if (promedio >= 1.1 && promedio <= 2.9)
            {
                label7.Visible = true;
                lblPromedio.Visible = true;
                lblPromedio.Text = Convert.ToString(promedio);
                MessageBox.Show("Reprueba materia y puede hacer la habilitación", "Mensaje del Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else if (promedio >= 3 && promedio <= 3.9)
            {
                label7.Visible = true;
                lblPromedio.Visible = true;
                lblPromedio.Text = Convert.ToString(promedio);
                MessageBox.Show("Aprueba la materia con Plan de mejora", "Mensaje del Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else if (promedio >= 4 && promedio <= 4.5)
            {
                label7.Visible = true;
                lblPromedio.Visible = true;
                lblPromedio.Text = Convert.ToString(promedio);
                MessageBox.Show("Buen rendimiento", "Mensaje del Sistema",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            }
            else if (promedio >= 4.6 && promedio <= 4.9)
            {
                label7.Visible = true;
                lblPromedio.Visible = true;
                lblPromedio.Text = Convert.ToString(promedio);
                MessageBox.Show("Excelente", "Mensaje del Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                label7.Visible = true;
                lblPromedio.Visible = true;
                lblPromedio.Text = Convert.ToString(promedio);
                MessageBox.Show("Graduado con honores", "Mensaje del Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}
