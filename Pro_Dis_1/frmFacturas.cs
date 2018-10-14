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
    public partial class frmFacturas : Form
    {
        public frmFacturas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frmNuevaFactura = new frmNuevaFactura();
            frmNuevaFactura.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frmGestionFactura = new frmGestionFactura();
            frmGestionFactura.Show();
        }
    }
}
