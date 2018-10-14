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
    public partial class frmClientes : Form
    {
        OracleConnection ora = new OracleConnection("DATA SOURCE = orcl; PASSWORD=Emora; USER ID = Emora");
        
        public frmClientes()
        {
            InitializeComponent();
            OracleDataAdapter dtaa = new OracleDataAdapter("SELECT * from cliente", ora);
            DataSet ds = new DataSet();
            dtaa.Fill(ds, "cliente");
            dGVClientes.DataSource = ds;
            dGVClientes.DataMember = "cliente";
			
			comboBoxRec.Items.Add("Alta");
			comboBoxRec.Items.Add("Baja");

			comboBoxCon.Items.Add("Alta");
			comboBoxCon.Items.Add("Baja");
		}
		

		private void btnRegistrar_Click(object sender, EventArgs e)
        {
            ora.Open();
            try
            {
                OracleCommand sqlc = new OracleCommand("INSERT INTO cliente VALUES(" 
                    + int.Parse(textBoxCod.Text.Trim()) 
                    + ",'" + textBoxCed.Text.Trim() 
                    + "','" + textBoxNombre.Text.Trim() 
                    + "','" + textBoxDir.Text.Trim() 
                    + "','" + textBoxTel.Text.Trim() 
                    + "','" + textBoxCorreo.Text.Trim() 
					+ "','" + comboBoxRec.Text.Trim()
					+ "')", ora);
                OracleDataAdapter dtaa = new OracleDataAdapter();
                dtaa.InsertCommand = sqlc;
                dtaa.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Cliente registrado");
                OracleDataAdapter dtaa2 = new OracleDataAdapter("SELECT * from cliente", ora);
                DataSet ds = new DataSet();
                dtaa2.Fill(ds, "cliente");
                dGVClientes.DataSource = ds;
                dGVClientes.DataMember = "cliente";

            }
			catch (OracleException a)
			{
				MessageBox.Show(a.Message);
			}
			ora.Close();

            textBoxCod.Text = "";
            textBoxCed.Text = "";
            textBoxNombre.Text = "";
            textBoxDir.Text = "";
            textBoxTel.Text = "";
            textBoxCorreo.Text = "";
			comboBoxRec.Text = "";
		}

        private void dGVClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;// get the Row Index
            DataGridViewRow selectedRow = dGVClientes.Rows[index];

            textBoxCod.Text = selectedRow.Cells[0].Value.ToString();
                      
            textBoxCed.Text = selectedRow.Cells[1].Value.ToString();
            textBoxNombre.Text = selectedRow.Cells[2].Value.ToString();
            textBoxDir.Text = selectedRow.Cells[3].Value.ToString();
            textBoxTel.Text = selectedRow.Cells[4].Value.ToString();
            textBoxCorreo.Text = selectedRow.Cells[5].Value.ToString();
			comboBoxRec.Text = selectedRow.Cells[6].Value.ToString();
		}

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ora.Open();
            try
            {
                OracleCommand sqlc = new OracleCommand("UPDATE cliente SET " 
                    + "cod_cliente = " + int.Parse(textBoxCod.Text.Trim()) 
                    + ", cedula_cliente ='" + textBoxCed.Text.Trim() 
                    + "', nombre_cliente ='" + textBoxNombre.Text.Trim() 
                    + "', direccion_cliente ='" + textBoxDir.Text.Trim() 
                    + "', telefono_cliente ='" + textBoxTel.Text.Trim() 
                    + "', correo_electronico_cliente ='" + textBoxCorreo.Text.Trim()
					+ "', recurrencia_cliente ='" + comboBoxRec.Text.Trim()
					+ "' WHERE cod_cliente = " + int.Parse(textBoxCod.Text.Trim())
                    , ora);

                OracleDataAdapter dtaa = new OracleDataAdapter();
                dtaa.InsertCommand = sqlc;
                dtaa.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Cliente modificado");
                OracleDataAdapter dtaa2 = new OracleDataAdapter("SELECT * from Cliente", ora);
                DataSet ds = new DataSet();
                dtaa2.Fill(ds, "Cliente");
                dGVClientes.DataSource = ds;
                dGVClientes.DataMember = "Cliente";

            }
			catch (OracleException a)
			{
				MessageBox.Show(a.Message);
			}
			ora.Close();

            textBoxCed.Text = "";
            textBoxTel.Text = "";
            textBoxCod.Text = "";
            textBoxNombre.Text = "";
            textBoxDir.Text = "";
            textBoxCorreo.Text = "";
			comboBoxRec.Text = "";

		}

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textBoxCod.Text = "";
            textBoxCed.Text = "";
            textBoxNombre.Text = "";
            textBoxDir.Text = "";
            textBoxTel.Text = "";
            textBoxCorreo.Text = "";
			comboBoxRec.Text = "";
			comboBoxCon.Text = "";

			OracleDataAdapter dtaa2 = new OracleDataAdapter("SELECT * from Cliente", ora);
			DataSet ds = new DataSet();
			dtaa2.Fill(ds, "Cliente");
			dGVClientes.DataSource = ds;
			dGVClientes.DataMember = "Cliente";

		}

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ora.Open();
            try
            {
                OracleCommand sqlc = new OracleCommand("DELETE FROM cliente WHERE cod_cliente=" 
                    + int.Parse(textBoxCod.Text.Trim()) + "", ora);
                OracleDataAdapter dtaa = new OracleDataAdapter();
                dtaa.DeleteCommand = sqlc;               
                dtaa.DeleteCommand.ExecuteNonQuery();
                MessageBox.Show("Cliente eliminado");
                OracleDataAdapter dtaa2 = new OracleDataAdapter("SELECT * from cliente", ora);
                DataSet ds = new DataSet();
                dtaa2.Fill(ds, "cliente");
                dGVClientes.DataSource = ds;
                dGVClientes.DataMember = "cliente";
            }
			catch (OracleException a)
			{
				MessageBox.Show(a.Message);
			}
			ora.Close();


            textBoxCed.Text = "";
            textBoxTel.Text = "";
            textBoxCod.Text = "";
            textBoxNombre.Text = "";
            textBoxDir.Text = "";
            textBoxCorreo.Text = "";
			comboBoxRec.Text = "";
		}

        private void dGVClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
		}

		private void comboBoxRec_SelectedIndexChanged(object sender, EventArgs e)
		{


		}

		private void label8_Click(object sender, EventArgs e)
		{

		}

		private void btnCon_Click(object sender, EventArgs e)
		{
			
			
		}

		private void comboBoxCon_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (comboBoxCon.SelectedItem.ToString() == "Alta")
			{
				OracleDataAdapter dtaa2 = new OracleDataAdapter("SELECT * from CLIENTE WHERE recurrencia_cliente = 'Alta' ", ora);
				DataSet ds = new DataSet();
				dtaa2.Fill(ds, "cliente");
				dGVClientes.DataSource = ds;
				dGVClientes.DataMember = "cliente";
			}
			
			if (comboBoxCon.SelectedItem.ToString() == "Baja")
			{
				OracleDataAdapter dtaa2 = new OracleDataAdapter("SELECT * from CLIENTE WHERE recurrencia_cliente = 'Baja' ", ora);
				DataSet ds = new DataSet();
				dtaa2.Fill(ds, "cliente");
				dGVClientes.DataSource = ds;
				dGVClientes.DataMember = "cliente";
			}
		}

		private void dGVClientes_CellClick_1(object sender, DataGridViewCellEventArgs e)
		{
			int index = e.RowIndex;// get the Row Index
			DataGridViewRow selectedRow = dGVClientes.Rows[index];

			textBoxCod.Text = selectedRow.Cells[0].Value.ToString();

			textBoxCed.Text = selectedRow.Cells[1].Value.ToString();
			textBoxNombre.Text = selectedRow.Cells[2].Value.ToString();
			textBoxDir.Text = selectedRow.Cells[3].Value.ToString();
			textBoxTel.Text = selectedRow.Cells[4].Value.ToString();
			textBoxCorreo.Text = selectedRow.Cells[5].Value.ToString();
			comboBoxRec.Text = selectedRow.Cells[6].Value.ToString();
		}
	}
}
