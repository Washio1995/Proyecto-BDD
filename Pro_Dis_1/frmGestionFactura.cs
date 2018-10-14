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
    public partial class frmGestionFactura : Form
    {
        OracleConnection ora = new OracleConnection("DATA SOURCE = orcl; PASSWORD=Emora; USER ID = Emora");

        public frmGestionFactura()
        {
            InitializeComponent();

			actDGV();
            LlenarCombo();
			comboBox2.SelectedIndex = -1;


        }

        private void LlenarCombo()
        {
            comboBox2.Items.Add("SUR");
            comboBox2.Items.Add("NORTE");

			DataSet ds2 = new DataSet();
			OracleDataAdapter da2 = new OracleDataAdapter("SELECT COD_CLIENTE,CEDULA_CLIENTE FROM CLIENTE", ora);
			//se indica el nombre de la tabla
			da2.Fill(ds2, "CLIENTE");
			comboBox2.DataSource = ds2.Tables[0].DefaultView;
			//se especifica el campo de la tabla
			comboBox2.ValueMember = "COD_CLIENTE";
			comboBox2.DisplayMember = "CEDULA_CLIENTE";

		}

		public void limpiar()
		{
			textBoxCodFac.Text = "";
			textBoxId.Text = "";
			textBoxCodCli.Text = "";
			textBoxDet.Text = "";
		}

		public void actDGV()
		{
			OracleDataAdapter dtaa = new OracleDataAdapter("SELECT * from factura", ora);
			DataSet ds = new DataSet();
			dtaa.Fill(ds, "factura");
			dGVFacturas.DataSource = ds;
			dGVFacturas.DataMember = "factura";
		}


		private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
			

			
		}

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
			if (comboBox2.SelectedIndex == -1)
			{

			}
			else
			{

				int valor;
			bool parseOK = Int32.TryParse(comboBox2.SelectedValue.ToString(), out valor);

			for (int i = 1; i < 20; i++)
			{
				if (valor == i)
				{
					OracleDataAdapter dtaa = new OracleDataAdapter("SELECT * from factura where cod_cliente=" + i, ora);
					DataSet ds = new DataSet();
					dtaa.Fill(ds, "factura");
					dGVFacturas.DataSource = ds;
					dGVFacturas.DataMember = "factura";
				}
			}
			}
		}

		private void label1_Click(object sender, EventArgs e)
		{
			
		}

		private void dGVFacturas_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int index = e.RowIndex;// get the Row Index
			DataGridViewRow selectedRow = dGVFacturas.Rows[index];

			textBoxCodFac.Text = selectedRow.Cells[0].Value.ToString();
			textBoxId.Text = selectedRow.Cells[1].Value.ToString();
			textBoxCodCli.Text = selectedRow.Cells[2].Value.ToString();
			textBoxDet.Text = selectedRow.Cells[3].Value.ToString();

	


		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			ora.Open();
			try
			{
				OracleCommand sqlc = new OracleCommand("DELETE FROM factura  "
				+ " WHERE cod_factura = " + int.Parse(textBoxCodFac.Text.Trim()), ora);
				OracleDataAdapter dtaa = new OracleDataAdapter();
				dtaa.InsertCommand = sqlc;
				dtaa.InsertCommand.ExecuteNonQuery();
				

				OracleCommand sqlc2 = new OracleCommand("DELETE FROM detalle_factura  "
				+ " WHERE cod_detalle = " + int.Parse(textBoxDet.Text.Trim()), ora);
				OracleDataAdapter dtaa2 = new OracleDataAdapter();
				dtaa2.InsertCommand = sqlc2;
				dtaa2.InsertCommand.ExecuteNonQuery();
				MessageBox.Show("Factura Eliminada");


				actDGV();
			}
			catch (OracleException a)
			{
				MessageBox.Show(a.Message);
			}
			ora.Close();


			limpiar();
		}

		private void btnLimpiar_Click(object sender, EventArgs e)
		{
			limpiar();
		}
	}
}
