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
    public partial class frmEmpleados : Form
    {
        OracleConnection ora = new OracleConnection("DATA SOURCE = orcl; PASSWORD=Emora; USER ID = Emora");

   

        public frmEmpleados()
        {
            InitializeComponent();
			actDGV();
			LlenarCombo();
			limpiar();
            
        }

        public void LlenarCombo()
        {
            comboFraHor.Items.Add("TIEMPO COMPLETO");
            comboFraHor.Items.Add("MEDIO TIEMPO");
            comboBox3.Items.Add("Tiempo Completo");
            comboBox3.Items.Add("Medio Tiempo");

			DataSet ds = new DataSet();
			OracleDataAdapter da = new OracleDataAdapter("SELECT LOCALIZACON_JUGUETERIA, ID_JUGUETERIA FROM JUGUETERIA", ora);
			//se indica el nombre de la tabla
			da.Fill(ds, "jugueteria");
			comboBox1.DataSource = ds.Tables[0].DefaultView;
			//se especifica el campo de la tabla
			comboBox1.ValueMember = "ID_JUGUETERIA";
			comboBox1.DisplayMember = "LOCALIZACON_JUGUETERIA";

		}

		public void limpiar()
		{
			textBoxCed.Text = "";
            textBoxTel.Text = "";
            textBoxCod.Text = "";
            textBoxNom.Text = "";
            textBoxDir.Text = "";
            textBoxSal.Text = "";
            textBoxCorEle.Text = "";
            txtIdJ.Text = "";
            comboBox1.SelectedIndex = -1;
            comboFraHor.Text = "";
            comboBox3.Text = "";
			actDGV();
		}

		public void actDGV()
		{
			OracleDataAdapter dtaa2 = new OracleDataAdapter("SELECT * from empleado", ora);
			DataSet ds = new DataSet();
			dtaa2.Fill(ds, "empleado");
			dGVEmpleado.DataSource = ds;
			dGVEmpleado.DataMember = "empleado";
		}


		private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            ora.Open();
            try
            {
                OracleCommand sqlc = new OracleCommand("INSERT INTO empleado VALUES(" 
                    + int.Parse(textBoxCod.Text.Trim())
                    + "," +  comboBox1.SelectedValue
                    + ",'" + textBoxCed.Text.Trim() 
                    + "','" + textBoxNom.Text.Trim() 
                    + "','" + textBoxDir.Text.Trim() 
                    + "','" + textBoxTel.Text.Trim()
                    + "','" + textBoxCorEle.Text.Trim()
                    + "','" + comboBox3.SelectedItem.ToString()
                    + "','" + textBoxSal.Text.Trim() + "')", ora);
                OracleDataAdapter dtaa = new OracleDataAdapter();
                dtaa.InsertCommand = sqlc;
                dtaa.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Empleado registrado");
				actDGV();
			
            }
            catch(OracleException a)
            {
				MessageBox.Show(a.Message);
            }
            ora.Close();
			limpiar();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


			for (int i=0; i<5; i++)
			{
				if (comboBox1.SelectedIndex == i)
				{
                txtIdJ.Text = comboBox1.SelectedValue.ToString();
				}

			}
		}

		private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtIdJ_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
			limpiar();
			actDGV();

        }

        private void dGVEmpleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dGVEmpleado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;// get the Row Index
            DataGridViewRow selectedRow = dGVEmpleado.Rows[index];

            textBoxCod.Text = selectedRow.Cells[0].Value.ToString();
            txtIdJ.Text = selectedRow.Cells[1].Value.ToString();
			for (int i = 1; i < 5; i++)
			{
				if (int.Parse(selectedRow.Cells[1].Value.ToString()) == 100 + i)
				{
					comboBox1.SelectedValue = 100 + i;
				}
			}
            textBoxCed.Text = selectedRow.Cells[2].Value.ToString();
            textBoxNom.Text = selectedRow.Cells[3].Value.ToString();
            textBoxDir.Text = selectedRow.Cells[4].Value.ToString();
            textBoxTel.Text = selectedRow.Cells[5].Value.ToString();
            textBoxCorEle.Text = selectedRow.Cells[6].Value.ToString();
            if (selectedRow.Cells[7].Value.ToString() == "Tiempo Completo")
            {
                comboBox3.SelectedItem = "Tiempo Completo";
            }
            if (selectedRow.Cells[7].Value.ToString() == "Medio Tiempo")
            {
                comboBox3.SelectedItem = "Medio Tiempo";
            }
            textBoxSal.Text = selectedRow.Cells[8].Value.ToString();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ora.Open();
            try
            {
                OracleCommand sqlc = new OracleCommand("UPDATE empleado SET "
                    + "cod_empleado = " + int.Parse(textBoxCod.Text.Trim())
                    + ", id_jugueteria =" + int.Parse(txtIdJ.Text.Trim())
                    + ", cedula_empleado ='" + textBoxCed.Text.Trim()
                    + "', nombre_empleado ='" + textBoxNom.Text.Trim()
                    + "', direccion_empleado ='" + textBoxDir.Text.Trim()
                    + "', telefono_empleado = '" + textBoxTel.Text.Trim()
                    + "', correo_electronico_empleado ='" + textBoxCorEle.Text.Trim()
                    + "', tipo_empleado ='" + comboBox3.SelectedItem.ToString()
                    + "', salario_empleado =" + int.Parse(textBoxSal.Text.Trim()) +
                    " WHERE cod_empleado = " + int.Parse(textBoxCod.Text.Trim())
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ora.Open();
            try
            {
                OracleCommand sqlc = new OracleCommand("DELETE FROM empleado " +
                "WHERE cod_empleado = " + int.Parse(textBoxCod.Text.Trim()) , ora);
                OracleDataAdapter dtaa = new OracleDataAdapter();
                dtaa.InsertCommand = sqlc;
                dtaa.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Registro Eliminado");
                OracleDataAdapter dtaa2 = new OracleDataAdapter("SELECT * from empleado", ora);
                DataSet ds = new DataSet();
                dtaa2.Fill(ds, "empleado");
                dGVEmpleado.DataSource = ds;
                dGVEmpleado.DataMember = "empleado";

            }
			catch (OracleException a)
			{
				MessageBox.Show(a.Message);
			}
			ora.Close();

			limpiar();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
			

        }

		private void comboFraHor_SelectedIndexChanged(object sender, EventArgs e)
		{
			
			if (comboFraHor.SelectedItem.ToString() == "TIEMPO COMPLETO")
			{
				OracleDataAdapter dtaa2 = new OracleDataAdapter("SELECT * from empleado WHERE tipo_empleado = 'Tiempo Completo' ", ora);
				DataSet ds = new DataSet();
				dtaa2.Fill(ds, "empleado");
				dGVEmpleado.DataSource = ds;
				dGVEmpleado.DataMember = "empleado";

			}
			if (comboFraHor.SelectedItem.ToString() == "MEDIO TIEMPO")
			{
				OracleDataAdapter dtaa2 = new OracleDataAdapter("SELECT * from empleado WHERE tipo_empleado = 'Medio Tiempo' ", ora);
				DataSet ds = new DataSet();
				dtaa2.Fill(ds, "empleado");
				dGVEmpleado.DataSource = ds;
				dGVEmpleado.DataMember = "empleado";

			}
			comboFraHor.Text = "";
		}

		private void frmEmpleados_Load(object sender, EventArgs e)
		{

		}
	}
}
