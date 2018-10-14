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
    public partial class frmNuevaFactura : Form
    {
        OracleConnection ora = new OracleConnection("DATA SOURCE = orcl; PASSWORD=Emora; USER ID = Emora");

        int cod_detalle = 0;
        float iva = 0;
        float total = 0;
        float impuesto=0.12F;

        public frmNuevaFactura()
        {
            InitializeComponent();
            OracleDataAdapter dtaa = new OracleDataAdapter("SELECT * from cliente", ora);
            DataSet ds = new DataSet();
            dtaa.Fill(ds, "cliente");
            dGVClientes.DataSource = ds;
            dGVClientes.DataMember = "cliente";

            OracleDataAdapter dtaa2 = new OracleDataAdapter("SELECT * from juguete", ora);
            DataSet ds2 = new DataSet();
            dtaa2.Fill(ds2, "juguete");
            dGVJuguete.DataSource = ds2;
            dGVJuguete.DataMember = "juguete";


            LlenarCombo();
			limpiarUno();
			cod_detalle = obtenerCodDetalle();


		}

        private void LlenarCombo()
        {
           
			DataSet ds = new DataSet();
			OracleDataAdapter da = new OracleDataAdapter("SELECT LOCALIZACON_JUGUETERIA, ID_JUGUETERIA FROM JUGUETERIA", ora);
			//se indica el nombre de la tabla
			da.Fill(ds, "jugueteria");
			comboBoxSede.DataSource = ds.Tables[0].DefaultView;
			//se especifica el campo de la tabla
			comboBoxSede.ValueMember = "ID_JUGUETERIA";
			comboBoxSede.DisplayMember = "LOCALIZACON_JUGUETERIA";

			DataSet ds1 = new DataSet();
			OracleDataAdapter da1 = new OracleDataAdapter("SELECT * FROM CATEGORIA_JUGUETE", ora);
			//se indica el nombre de la tabla
			da1.Fill(ds1, "categoria_juguete");
			comboBoxCat.DataSource = ds1.Tables[0].DefaultView;
			//se especifica el campo de la tabla
			comboBoxCat.ValueMember = "COD_CATEGORIA";
			comboBoxCat.DisplayMember = "NOMBRE_CATEGORIA";


		}

		private int obtenerCodDetalle()
		{
			int id_detalle = 0;

			try
			{
				ora.Open();

				OracleCommand cm = new OracleCommand("SELECT MAX(cod_detalle) from detalle_factura", ora);
				id_detalle = int.Parse((cm.ExecuteScalar()).ToString());
			

			}
			catch (Exception ex)
			{
				//MessageBox.Show("" + ex + "");
			}
			ora.Close();

			return id_detalle;
		}


		private void comboBoxSede_SelectedIndexChanged(object sender, EventArgs e)
        {
			for (int i = 0; i < 5; i++)
			{
				if (comboBoxSede.SelectedIndex == i)
				{
					txtIdJ.Text = comboBoxSede.SelectedValue.ToString();
				}

			}
			/*if (comboBoxSede.SelectedItem.ToString() == "SUR")
            {
                txtIdJ.Text = "101";
            }
            if (comboBoxSede.SelectedItem.ToString() == "NORTE")
            {
                txtIdJ.Text = "102";
            }*/
        }

        private void comboBoxCat_SelectedIndexChanged(object sender, EventArgs e)
        {
			/*if (comboBoxCat.SelectedItem.ToString() == "Juguetes Electricos")
            {
                txtCat.Text = "111";
            }
            if (comboBoxCat.SelectedItem.ToString() == "Juguetes Tipicos")
            {
                txtCat.Text = "112";
            }
            if (comboBoxCat.SelectedItem.ToString() == "Juguetes Cientificos")
            {
                txtCat.Text = "113";
            }
            if (comboBoxCat.SelectedItem.ToString() == "Juguetes de Coleccion")
            {
                txtCat.Text = "114";
            }*/

			for (int i = 0; i < 10; i++)
			{
				if (comboBoxCat.SelectedIndex == i)
				{
					txtCat.Text = comboBoxCat.SelectedValue.ToString();
				}
			}


		}

        private void dGVClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void btnLimpiarTodo_Click(object sender, EventArgs e)
        {
            textBoxCodFac.Text = "";
            textBoxCan.Text = "";

            textBoxCodArt.Text = "";
            txtCat.Text = "";
            textBoxNomArt.Text = "";
            txtIdJ.Text = "";
            textBoxDes.Text = "";
            textBoxPre.Text = "";
            textBoxMar.Text = "";
            comboBoxSede.Text = "";
            comboBoxCat.Text = "";

            textBoxCodCli.Text = "";
            textBoxCed.Text = "";
            textBoxNombre.Text = "";
            textBoxDir.Text = "";
            textBoxTel.Text = "";
            textBoxCorreo.Text = "";

            textBoxSub.Text = "";
            textBoxIVA.Text = "";
            textBoxTotal.Text = "";

            OracleDataAdapter dtaa = new OracleDataAdapter("SELECT * from cliente", ora);
            DataSet ds = new DataSet();
            dtaa.Fill(ds, "cliente");
            dGVClientes.DataSource = ds;
            dGVClientes.DataMember = "cliente";

            OracleDataAdapter dtaa2 = new OracleDataAdapter("SELECT * from juguete", ora);
            DataSet ds2 = new DataSet();
            dtaa2.Fill(ds2, "juguete");
            dGVJuguete.DataSource = ds2;
            dGVJuguete.DataMember = "juguete";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textBoxCan.Text = "";

            textBoxCodArt.Text = "";
            txtCat.Text = "";
            textBoxNomArt.Text = "";
            textBoxDes.Text = "";
            textBoxPre.Text = "";
            textBoxMar.Text = "";
            comboBoxCat.Text = "";
        }

        private void dGVJuguete_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            


        }

        

        private void btnAgregar_Click(object sender, EventArgs e)
        {
			cod_detalle = obtenerCodDetalle() + 1;
			ora.Open();
            try
            {
                if (textBoxSub.Text=="")
                {
                    textBoxSub.Text = (float.Parse(textBoxPre.Text) * int.Parse(textBoxCan.Text)).ToString();
                    textBoxIVA.Text = (float.Parse(textBoxSub.Text) * impuesto).ToString();
                    textBoxTotal.Text = (float.Parse(textBoxSub.Text) + float.Parse(textBoxIVA.Text)).ToString();

                }
                else
                {
                    textBoxSub.Text = (float.Parse(textBoxSub.Text)+ float.Parse(textBoxPre.Text) * int.Parse(textBoxCan.Text)).ToString();
                    textBoxIVA.Text = (float.Parse(textBoxSub.Text) * impuesto).ToString();
                    textBoxTotal.Text = (float.Parse(textBoxSub.Text) + float.Parse(textBoxIVA.Text)).ToString();

                }

                
                
                iva = (float.Parse(textBoxPre.Text) * int.Parse(textBoxCan.Text) * impuesto);
                total = ((float.Parse(textBoxPre.Text) * int.Parse(textBoxCan.Text) * impuesto) + (float.Parse(textBoxPre.Text) * int.Parse(textBoxCan.Text)));
                //Console.WriteLine("codDetalle " + cod_detalle);
               
    
                OracleCommand sqlc = new OracleCommand("INSERT INTO detalle_factura VALUES("
                    + cod_detalle
                    + "," + int.Parse(textBoxCodArt.Text.Trim())
                    + "," + int.Parse(textBoxCan.Text.Trim())
                    + "," + iva
                    + "," + total
                    + ")", ora);
                OracleDataAdapter dtaa = new OracleDataAdapter();
                dtaa.InsertCommand = sqlc;
                dtaa.InsertCommand.ExecuteNonQuery();
                

            }
			catch (OracleException a)
			{
				MessageBox.Show(a.Message);
			}
			ora.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
			cod_detalle = obtenerCodDetalle();
			ora.Open();
            try
            {
                           
                                
                OracleCommand sqlc = new OracleCommand("INSERT INTO factura VALUES("
                    + int.Parse(textBoxCodFac.Text.Trim()) 
                    + "," + int.Parse(txtIdJ.Text.Trim())
                    + "," + int.Parse(textBoxCodCli.Text.Trim())
                    + ",'" + cod_detalle
                    + "','" + dTFecha.Value.ToShortDateString()
                    + "'," + float.Parse(textBoxSub.Text.Trim())
                    + "," + float.Parse(textBoxTotal.Text.Trim())
                    + ")", ora);
                OracleDataAdapter dtaa = new OracleDataAdapter();
                dtaa.InsertCommand = sqlc;
                dtaa.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Factura Registrada");
                
            }
			catch (OracleException a)
			{
				MessageBox.Show(a.Message);
			}
			ora.Close();

        }


		private void limpiarUno()
		{
			txtCat.Text = "";
			txtIdJ.Text = "";
			comboBoxCat.SelectedIndex = -1;
			comboBoxSede.SelectedIndex = -1;
		}

		private void btnLimpiarCli_Click(object sender, EventArgs e)
        {
            textBoxCodCli.Text = "";
            textBoxCed.Text = "";
            textBoxNombre.Text = "";
            textBoxDir.Text = "";
            textBoxTel.Text = "";
            textBoxCorreo.Text = "";

        }

        private void btnBuscarCli_Click(object sender, EventArgs e)
        {
            if(textBoxCed.Text.Trim()=="")
            {
                OracleDataAdapter dtaa = new OracleDataAdapter("SELECT * from cliente ", ora);

                DataSet ds = new DataSet();
                dtaa.Fill(ds, "cliente");
                dGVClientes.DataSource = ds;
                dGVClientes.DataMember = "cliente";

            }
            
            else
            {
                OracleDataAdapter dtaa2 = new OracleDataAdapter("SELECT * from cliente where cedula_cliente='"
                + textBoxCed.Text.Trim() + "'", ora);
                DataSet ds2 = new DataSet();
                dtaa2.Fill(ds2, "cliente");
                dGVClientes.DataSource = ds2;
                dGVClientes.DataMember = "cliente";
            }
            

        }

        private void btnBuscarArt_Click(object sender, EventArgs e)
        {
            if(textBoxCodArt.Text.Trim()=="")
            {
                OracleDataAdapter dtaa = new OracleDataAdapter("SELECT * from juguete", ora);
                DataSet ds = new DataSet();
                dtaa.Fill(ds, "juguete");
                dGVJuguete.DataSource = ds;
                dGVJuguete.DataMember = "juguete";
            }            

            else
            {
                OracleDataAdapter dtaa2 = new OracleDataAdapter("SELECT * from juguete where cod_juguete="
                + textBoxCodArt.Text.Trim() + "", ora);
                DataSet ds2 = new DataSet();
                dtaa2.Fill(ds2, "juguete");
                dGVJuguete.DataSource = ds2;
                dGVJuguete.DataMember = "juguete";
            }
            
        }

		private void dGVClientes_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int index = e.RowIndex;// get the Row Index
			DataGridViewRow selectedRow = dGVClientes.Rows[index];

			textBoxCodCli.Text = selectedRow.Cells[0].Value.ToString();

			textBoxCed.Text = selectedRow.Cells[1].Value.ToString();
			textBoxNombre.Text = selectedRow.Cells[2].Value.ToString();
			textBoxDir.Text = selectedRow.Cells[3].Value.ToString();
			textBoxTel.Text = selectedRow.Cells[4].Value.ToString();
			textBoxCorreo.Text = selectedRow.Cells[5].Value.ToString();
		}

		private void dGVJuguete_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int index = e.RowIndex;// get the Row Index
			DataGridViewRow selectedRow = dGVJuguete.Rows[index];

			textBoxCodArt.Text = selectedRow.Cells[0].Value.ToString();
			txtCat.Text = selectedRow.Cells[1].Value.ToString();
			txtIdJ.Text = selectedRow.Cells[2].Value.ToString();
			for (int i = 1; i < 10; i++)
			{
				if (int.Parse(selectedRow.Cells[2].Value.ToString()) == 100 + i)
				{
					comboBoxSede.SelectedValue = 100 + i;
				}
				if (int.Parse(selectedRow.Cells[1].Value.ToString()) == 110 + i)
				{
					comboBoxCat.SelectedValue = 110 + i;
				}
			}
			textBoxNomArt.Text = selectedRow.Cells[3].Value.ToString();
			textBoxDes.Text = selectedRow.Cells[4].Value.ToString();
			textBoxPre.Text = selectedRow.Cells[5].Value.ToString();
			textBoxMar.Text = selectedRow.Cells[6].Value.ToString();
		}
	}
}
