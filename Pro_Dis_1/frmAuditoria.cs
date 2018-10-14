using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;

namespace Pro_Dis_1
{
    public partial class frmAuditoria : Form
    {
        OracleConnection ora = new OracleConnection("DATA SOURCE = orcl; PASSWORD=Emora; USER ID = Emora");


        public frmAuditoria()
        {
            InitializeComponent();
            OracleDataAdapter dtaa = new OracleDataAdapter("SELECT * from auditoria", ora);
            DataSet ds = new DataSet();
            dtaa.Fill(ds, "auditoria");
            dGVAuditoria.DataSource = ds;
            dGVAuditoria.DataMember = "auditoria";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
