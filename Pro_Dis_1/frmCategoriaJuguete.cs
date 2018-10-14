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
	public partial class frmCategoriaJuguete : Form
	{
		OracleConnection ora = new OracleConnection("DATA SOURCE = orcl; PASSWORD=Emora; USER ID = Emora");
	
		public frmCategoriaJuguete()
		{
			InitializeComponent();
			actDGV();
		}

		public void actDGV()
		{
	    OracleDataAdapter dtaa = new OracleDataAdapter("SELECT * from categoria_juguete", ora);
		DataSet ds = new DataSet();
	    dtaa.Fill(ds, "categoria_juguete");
	    dGVCat.DataSource = ds;
	    dGVCat.DataMember = "categoria_juguete";
		}

		public void limpiar()
		{
			txtBoxNomCat.Text = "";
			textBoxCodCat.Text = "";
		}

		private void btnRegistrar_Click(object sender, EventArgs e)
		{
			ora.Open();
			try
			{
				OracleCommand sqlc = new OracleCommand("INSERT INTO categoria_juguete VALUES("
				+ int.Parse(textBoxCodCat.Text.Trim())
				+ ",'" + txtBoxNomCat.Text.Trim() + "')", ora);
				OracleDataAdapter dtaa = new OracleDataAdapter();
				dtaa.InsertCommand = sqlc;
				dtaa.InsertCommand.ExecuteNonQuery();
				MessageBox.Show("Categoria de Juguete Registrada");
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
			actDGV();
		}

		private void btnActualizar_Click(object sender, EventArgs e)
		{
			ora.Open();
			try
			{
				OracleCommand sqlc = new OracleCommand("UPDATE categoria_juguete SET "
				   + "cod_categoria = " + int.Parse(textBoxCodCat.Text.Trim())
				   + ", nombre_categoria = '" + txtBoxNomCat.Text.Trim()
				   + "' WHERE cod_categoria = " + int.Parse(textBoxCodCat.Text.Trim())
				   , ora);

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
			ora.Close();			limpiar();
		}

		private void dGVCat_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int index = e.RowIndex;// get the Row Index
			DataGridViewRow selectedRow = dGVCat.Rows[index];

			textBoxCodCat.Text = selectedRow.Cells[0].Value.ToString();
			txtBoxNomCat.Text = selectedRow.Cells[1].Value.ToString();
			
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			ora.Open();
			try
			{
				OracleCommand sqlc = new OracleCommand("DELETE FROM categoria_juguete " +
				"WHERE cod_categoria = " + int.Parse(textBoxCodCat.Text), ora);
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
