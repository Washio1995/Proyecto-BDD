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
    public partial class frmJuguetes : Form
    {
        OracleConnection ora = new OracleConnection("DATA SOURCE = orcl; PASSWORD=Emora; USER ID = Emora");
	

		public frmJuguetes()
        {
            InitializeComponent(); 
			llenacombobox();
			limpiar();
			actDGV();

		}

		public void actDGV()
		{
			OracleDataAdapter dtaa = new OracleDataAdapter("SELECT * from juguete", ora);
			DataSet ds = new DataSet();
			dtaa.Fill(ds, "juguete");
			dGVJuguete.DataSource = ds;
			dGVJuguete.DataMember = "juguete";
		}

		public void limpiar()
		{
			textBoxCod.Text = "";
            txtCat.Text = "";
            textBoxNom.Text = "";
            txtIdJ.Text = "";
            textBoxDes.Text = "";
            textBoxPre.Text = "";
            textBoxMar.Text = "";
			comboBoxCat.SelectedIndex = -1;
			comboBoxSed.SelectedIndex = -1;
			comboBox1.SelectedIndex = -1;
		}

		public void llenacombobox()
		{
			DataSet ds = new DataSet();
			OracleDataAdapter da = new OracleDataAdapter("SELECT ID_JUGUETERIA,LOCALIZACON_JUGUETERIA FROM JUGUETERIA", ora);
			//se indica el nombre de la tabla
			da.Fill(ds, "jugueteria");
			comboBoxSed.DataSource = ds.Tables[0].DefaultView;
			//se especifica el campo de la tabla
			comboBoxSed.ValueMember = "ID_JUGUETERIA";
			comboBoxSed.DisplayMember = "LOCALIZACON_JUGUETERIA";

			DataSet ds1 = new DataSet();
			OracleDataAdapter da1 = new OracleDataAdapter("SELECT * FROM CATEGORIA_JUGUETE", ora);
			//se indica el nombre de la tabla
			da1.Fill(ds1, "categoria_juguete");
			comboBoxCat.DataSource = ds1.Tables[0].DefaultView;
			//se especifica el campo de la tabla
			comboBoxCat.ValueMember = "COD_CATEGORIA";
			comboBoxCat.DisplayMember = "NOMBRE_CATEGORIA";
			
			DataSet ds2 = new DataSet();
			OracleDataAdapter da2 = new OracleDataAdapter("SELECT * FROM CATEGORIA_JUGUETE", ora);
			//se indica el nombre de la tabla
			da2.Fill(ds2, "categoria_juguete");
			comboBox1.DataSource = ds2.Tables[0].DefaultView;
			//se especifica el campo de la tabla
			comboBox1.ValueMember = "COD_CATEGORIA";
			comboBox1.DisplayMember = "NOMBRE_CATEGORIA";
		}

		

		private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ora.Open();
            try
            {
                OracleCommand sqlc = new OracleCommand("INSERT INTO juguete VALUES("
                    + int.Parse(textBoxCod.Text.Trim())
                    + "," + int.Parse(txtCat.Text.Trim())
                    + "," + int.Parse(txtIdJ.Text.Trim())
                    + ",'" + textBoxNom.Text.Trim()
                    + "','" + textBoxDes.Text.Trim()
                    + "','" + int.Parse(textBoxPre.Text.Trim())
                    + "','" + textBoxMar.Text.Trim()
                    + "')", ora);
                OracleDataAdapter dtaa = new OracleDataAdapter();
                dtaa.InsertCommand = sqlc;
                dtaa.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Juguete Registrado");
				actDGV();

            }
			catch (OracleException a)
			{
				MessageBox.Show(a.Message);
			}
			ora.Close();

			limpiar();

		}


        private void comboBoxCat_SelectedIndexChanged(object sender, EventArgs e)
        {
			for (int i = 0; i < 10; i++)
			{
				if (comboBoxCat.SelectedIndex == i)
				{
					txtCat.Text = comboBoxCat.SelectedValue.ToString();
				}
			}
		}

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
			limpiar();
			actDGV();
		}

		private void dGVJuguetes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;// get the Row Index
            DataGridViewRow selectedRow = dGVJuguete.Rows[index];

            textBoxCod.Text = selectedRow.Cells[0].Value.ToString();
            txtCat.Text = selectedRow.Cells[1].Value.ToString();
            txtIdJ.Text = selectedRow.Cells[2].Value.ToString();
			for (int i = 1; i < 10; i++)
			{
				if (int.Parse(selectedRow.Cells[2].Value.ToString()) == 100 + i )
				{
					comboBoxSed.SelectedValue = 100 + i;
				}
				if (int.Parse(selectedRow.Cells[1].Value.ToString()) == 110 + i)
				{
					comboBoxCat.SelectedValue = 110 + i;
				}
			}
			textBoxNom.Text = selectedRow.Cells[3].Value.ToString();
            textBoxDes.Text = selectedRow.Cells[4].Value.ToString();
            textBoxPre.Text = selectedRow.Cells[5].Value.ToString();
            textBoxMar.Text = selectedRow.Cells[6].Value.ToString();  
        }

        private void comboBoxSed_SelectedIndexChanged(object sender, EventArgs e)
        {
			for (int i = 0; i < 5; i++)
			{
				if (comboBoxSed.SelectedIndex == i)
				{
					txtIdJ.Text = comboBoxSed.SelectedValue.ToString();
				}

			}
		}

        private void button3_Click(object sender, EventArgs e)
        {
            ora.Open();
            try
            {
                OracleCommand sqlc = new OracleCommand("UPDATE juguete SET "
                    + "cod_juguete = " + int.Parse(textBoxCod.Text.Trim())
                    + ", cod_categoria =" + int.Parse(txtCat.Text.Trim())
                    + ", id_jugueteria =" + int.Parse(txtIdJ.Text.Trim())
                    + ", nombre_juguete ='" + textBoxNom.Text.Trim()
                    + "', descripcion_juguete ='" + textBoxDes.Text.Trim()
                    + "', precio_juguete = '" + textBoxPre.Text.Trim()
                    + "', marca_juguete ='" + textBoxMar.Text.Trim()
                    + "' WHERE cod_juguete = " + int.Parse(textBoxCod.Text.Trim())
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
			ora.Close();
			limpiar();
		}

        private void button4_Click(object sender, EventArgs e)
        {
            ora.Open();
            try
            {
                OracleCommand sqlc = new OracleCommand("DELETE FROM juguete  "
                + " WHERE cod_juguete = " + int.Parse(textBoxCod.Text.Trim()), ora);
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

        private void dGVJuguete_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

		private void btnConsultar_Click(object sender, EventArgs e)
		{
		}

		private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}

		private void checkedListBox1_SelectedValueChanged(object sender, EventArgs e)
		{
			
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

			if(comboBox1.SelectedIndex==-1)
			{

			} else
			{

			
			int valor;
			bool parseOK = Int32.TryParse(comboBox1.SelectedValue.ToString(), out valor);

				for (int i = 111; i < 120; i++)
				{
					if (valor == i)
					{
						OracleDataAdapter dtaa = new OracleDataAdapter("SELECT * from juguete where cod_categoria=" + i, ora);
						DataSet ds = new DataSet();
						dtaa.Fill(ds, "juguete");
						dGVJuguete .DataSource = ds;
						dGVJuguete.DataMember = "juguete";
					}
				}
			}

			
		}
	}
}
