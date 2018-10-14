using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pro_Dis_1
{
    public partial class VentanaPrincipal : Form
    {


        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frmJuguete = new frmJuguetes();
            frmJuguete.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frmClientes = new frmClientes();
            frmClientes.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form frmEmpleados = new frmEmpleados();
            frmEmpleados.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form frmFacturas = new frmFacturas();
            frmFacturas.Show();
        }

		private void button6_Click(object sender, EventArgs e)
		{
			Form frmCategoriaJuguete = new frmCategoriaJuguete();
			frmCategoriaJuguete.Show();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			Form frmJugueterias = new frmJugueterias();
			frmJugueterias.Show();
		}
	}
}
