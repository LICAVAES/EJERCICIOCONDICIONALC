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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void PbxEdad_Click(object sender, EventArgs e)
        {
            Edad edad = new Edad();
            edad.Show(); 
            this.Hide(); 
        }

        private void PbxNotas_Click(object sender, EventArgs e)
        {
            Notas notas = new Notas();
            notas.Show();
            this.Hide(); 
        }

        private void PbxDescuentos_Click(object sender, EventArgs e)
        {
            Descuentos descuentos = new Descuentos();
            descuentos.Show();
            this.Hide(); 
        }
    }
}
