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
	public partial class frmJugueterias : Form
	{

		OracleConnection ora = new OracleConnection("DATA SOURCE = orcl; PASSWORD=Emora; USER ID = Emora");

		public frmJugueterias()
		{
			InitializeComponent();
			actDGV();
		}

		public void limpiar()
		{
			textBoxDir.Text = "";
			textBoxId.Text = "";
			textBoxNom.Text = "";
			textBoxTel.Text = "";
			textBoxLoc.Text = "";
		}

	private void frmJugueterias_Load(object sender, EventArgs e)
		{

		}

		public void actDGV()
		{
			OracleDataAdapter dtaa = new OracleDataAdapter("SELECT * from jugueteria", ora);
			DataSet ds = new DataSet();
			dtaa.Fill(ds, "jugueteria");
			dGVJugueterias.DataSource = ds;
			dGVJugueterias.DataMember = "jugueteria";
		}

		private void dGVJugueterias_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int index = e.RowIndex;// get the Row Index
			DataGridViewRow selectedRow = dGVJugueterias.Rows[index];

			textBoxId.Text = selectedRow.Cells[0].Value.ToString();
			textBoxNom.Text = selectedRow.Cells[1].Value.ToString();
			textBoxDir.Text = selectedRow.Cells[2].Value.ToString();
			textBoxTel.Text = selectedRow.Cells[3].Value.ToString();
			textBoxLoc.Text = selectedRow.Cells[4].Value.ToString();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void btnLimpiar_Click(object sender, EventArgs e)
		{
			limpiar();
			actDGV();
		}

		private void btnActualizar_Click(object sender, EventArgs e)
		{
			ora.Open();
			try
			{
				OracleCommand sqlc = new OracleCommand("UPDATE jugueteria SET "
					+ "id_jugueteria = " + int.Parse(textBoxId.Text.Trim())
					+ ", nombre_jugueteria = '" + textBoxNom.Text.Trim()
					+ "', direccion_jugueteria = '" + textBoxDir.Text.Trim()
					+ "', telefono_jugueteria = '" + textBoxTel.Text.Trim()
					+ "', localizacon_jugueteria = '" + textBoxLoc.Text.Trim()
					+ "' WHERE id_jugueteria = " + int.Parse(textBoxId.Text.Trim()), ora);
				OracleDataAdapter dtaa = new OracleDataAdapter();
				dtaa.InsertCommand = sqlc;
				dtaa.InsertCommand.ExecuteNonQuery();
				MessageBox.Show("Registro Actualizado");
				actDGV();
			}
			catch (OracleException a)
			{
				MessageBox.Show(a.Message);
			}
			ora.Close();
			limpiar();
		}

		private void btnRegistrar_Click(object sender, EventArgs e)
		{

			ora.Open();
			try
			{
				OracleCommand sqlc = new OracleCommand("INSERT INTO jugueteria VALUES("
				    + int.Parse(textBoxId.Text.Trim())
					+ ", '" + textBoxNom.Text.Trim()
					+ "','" + textBoxDir.Text.Trim()
					+ "','" + textBoxTel.Text.Trim()
					+ "','" + textBoxLoc.Text.Trim()
					+ "')", ora);
				OracleDataAdapter dtaa = new OracleDataAdapter();
				dtaa.InsertCommand = sqlc;
				dtaa.InsertCommand.ExecuteNonQuery();
				MessageBox.Show("Jugueteria Registrada");
				actDGV();

			}
			catch (OracleException a)
			{
				MessageBox.Show(a.Message);
			}
			ora.Close();

			limpiar();
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			ora.Open();
			try
			{
				OracleCommand sqlc = new OracleCommand("DELETE FROM jugueteria  "
				+ " WHERE id_jugueteria = " + int.Parse(textBoxId.Text.Trim()), ora);
				OracleDataAdapter dtaa = new OracleDataAdapter();
				dtaa.InsertCommand = sqlc;
				dtaa.InsertCommand.ExecuteNonQuery();
				MessageBox.Show("Registro Eliminado");
				actDGV();
			}
			catch (OracleException a)
			{
				MessageBox.Show(a.Message);
			}
			ora.Close();
			limpiar();
		}
	}
}
