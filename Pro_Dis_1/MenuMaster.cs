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
    public partial class MenuMaster : Form
    {
        


        public MenuMaster()
        {
            InitializeComponent();
        }

        private void MenuMaster_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form VentanaPrincipal = new VentanaPrincipal();
            VentanaPrincipal.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frmAuditoria = new frmAuditoria();
            frmAuditoria.Show();
        }
    }
}
