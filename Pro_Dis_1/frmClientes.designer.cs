namespace Pro_Dis_1
{
    partial class frmClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.textBoxCod = new System.Windows.Forms.TextBox();
			this.textBoxCed = new System.Windows.Forms.TextBox();
			this.textBoxTel = new System.Windows.Forms.TextBox();
			this.textBoxDir = new System.Windows.Forms.TextBox();
			this.textBoxCorreo = new System.Windows.Forms.TextBox();
			this.textBoxNombre = new System.Windows.Forms.TextBox();
			this.btnRegistrar = new System.Windows.Forms.Button();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.btnActualizar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.comboBoxRec = new System.Windows.Forms.ComboBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.List = new System.Windows.Forms.Label();
			this.comboBoxCon = new System.Windows.Forms.ComboBox();
			this.dGVClientes = new System.Windows.Forms.DataGridView();
			this.groupBox1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dGVClientes)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.tableLayoutPanel1);
			this.groupBox1.Location = new System.Drawing.Point(4, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(790, 241);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "EDICION";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 4;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.label5, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.label6, 2, 1);
			this.tableLayoutPanel1.Controls.Add(this.label7, 2, 2);
			this.tableLayoutPanel1.Controls.Add(this.textBoxCod, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.textBoxCed, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.textBoxTel, 3, 1);
			this.tableLayoutPanel1.Controls.Add(this.textBoxDir, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.textBoxCorreo, 3, 2);
			this.tableLayoutPanel1.Controls.Add(this.textBoxNombre, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.btnRegistrar, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.btnLimpiar, 1, 4);
			this.tableLayoutPanel1.Controls.Add(this.btnActualizar, 2, 4);
			this.tableLayoutPanel1.Controls.Add(this.btnEliminar, 3, 4);
			this.tableLayoutPanel1.Controls.Add(this.comboBoxRec, 1, 3);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 5;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(781, 220);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.Location = new System.Drawing.Point(3, 138);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(189, 25);
			this.label4.TabIndex = 19;
			this.label4.Text = "Recurrencia";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(189, 25);
			this.label1.TabIndex = 2;
			this.label1.Text = "Codigo";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.Location = new System.Drawing.Point(3, 46);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(189, 25);
			this.label2.TabIndex = 3;
			this.label2.Text = "Cedula";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.Location = new System.Drawing.Point(3, 92);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(189, 25);
			this.label3.TabIndex = 4;
			this.label3.Text = "Nombre";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.Location = new System.Drawing.Point(393, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(189, 25);
			this.label5.TabIndex = 6;
			this.label5.Text = "Direccion";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label6.Location = new System.Drawing.Point(393, 46);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(189, 25);
			this.label6.TabIndex = 7;
			this.label6.Text = "Telefono";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label7.Location = new System.Drawing.Point(393, 92);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(189, 25);
			this.label7.TabIndex = 8;
			this.label7.Text = "Correo Electronico";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBoxCod
			// 
			this.textBoxCod.Location = new System.Drawing.Point(198, 3);
			this.textBoxCod.Name = "textBoxCod";
			this.textBoxCod.Size = new System.Drawing.Size(165, 20);
			this.textBoxCod.TabIndex = 10;
			// 
			// textBoxCed
			// 
			this.textBoxCed.Location = new System.Drawing.Point(198, 49);
			this.textBoxCed.MaxLength = 10;
			this.textBoxCed.Name = "textBoxCed";
			this.textBoxCed.Size = new System.Drawing.Size(165, 20);
			this.textBoxCed.TabIndex = 11;
			// 
			// textBoxTel
			// 
			this.textBoxTel.Location = new System.Drawing.Point(588, 49);
			this.textBoxTel.Name = "textBoxTel";
			this.textBoxTel.Size = new System.Drawing.Size(165, 20);
			this.textBoxTel.TabIndex = 14;
			// 
			// textBoxDir
			// 
			this.textBoxDir.Location = new System.Drawing.Point(588, 3);
			this.textBoxDir.Name = "textBoxDir";
			this.textBoxDir.Size = new System.Drawing.Size(165, 20);
			this.textBoxDir.TabIndex = 15;
			// 
			// textBoxCorreo
			// 
			this.textBoxCorreo.Location = new System.Drawing.Point(588, 95);
			this.textBoxCorreo.Name = "textBoxCorreo";
			this.textBoxCorreo.Size = new System.Drawing.Size(165, 20);
			this.textBoxCorreo.TabIndex = 16;
			// 
			// textBoxNombre
			// 
			this.textBoxNombre.Location = new System.Drawing.Point(198, 95);
			this.textBoxNombre.Name = "textBoxNombre";
			this.textBoxNombre.Size = new System.Drawing.Size(165, 20);
			this.textBoxNombre.TabIndex = 12;
			// 
			// btnRegistrar
			// 
			this.btnRegistrar.Location = new System.Drawing.Point(3, 187);
			this.btnRegistrar.Name = "btnRegistrar";
			this.btnRegistrar.Size = new System.Drawing.Size(189, 30);
			this.btnRegistrar.TabIndex = 0;
			this.btnRegistrar.Text = "REGISTRAR";
			this.btnRegistrar.UseVisualStyleBackColor = true;
			this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Location = new System.Drawing.Point(198, 187);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(189, 29);
			this.btnLimpiar.TabIndex = 17;
			this.btnLimpiar.Text = "LIMPIAR";
			this.btnLimpiar.UseVisualStyleBackColor = true;
			this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
			// 
			// btnActualizar
			// 
			this.btnActualizar.Location = new System.Drawing.Point(393, 187);
			this.btnActualizar.Name = "btnActualizar";
			this.btnActualizar.Size = new System.Drawing.Size(185, 29);
			this.btnActualizar.TabIndex = 1;
			this.btnActualizar.Text = "ACTUALIZAR";
			this.btnActualizar.UseVisualStyleBackColor = true;
			this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
			// 
			// btnEliminar
			// 
			this.btnEliminar.Location = new System.Drawing.Point(588, 187);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(189, 29);
			this.btnEliminar.TabIndex = 18;
			this.btnEliminar.Text = "ELIMINAR";
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// comboBoxRec
			// 
			this.comboBoxRec.FormattingEnabled = true;
			this.comboBoxRec.Location = new System.Drawing.Point(198, 141);
			this.comboBoxRec.Name = "comboBoxRec";
			this.comboBoxRec.Size = new System.Drawing.Size(121, 21);
			this.comboBoxRec.TabIndex = 20;
			this.comboBoxRec.SelectedIndexChanged += new System.EventHandler(this.comboBoxRec_SelectedIndexChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.List);
			this.groupBox2.Controls.Add(this.comboBoxCon);
			this.groupBox2.Controls.Add(this.dGVClientes);
			this.groupBox2.Location = new System.Drawing.Point(5, 250);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(790, 214);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Listado";
			// 
			// List
			// 
			this.List.AutoSize = true;
			this.List.Location = new System.Drawing.Point(527, 22);
			this.List.Name = "List";
			this.List.Size = new System.Drawing.Size(53, 13);
			this.List.TabIndex = 2;
			this.List.Text = "Listar por:";
			this.List.Click += new System.EventHandler(this.label8_Click);
			// 
			// comboBoxCon
			// 
			this.comboBoxCon.FormattingEnabled = true;
			this.comboBoxCon.Location = new System.Drawing.Point(590, 14);
			this.comboBoxCon.Name = "comboBoxCon";
			this.comboBoxCon.Size = new System.Drawing.Size(90, 21);
			this.comboBoxCon.TabIndex = 1;
			this.comboBoxCon.SelectedIndexChanged += new System.EventHandler(this.comboBoxCon_SelectedIndexChanged);
			// 
			// dGVClientes
			// 
			this.dGVClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dGVClientes.Location = new System.Drawing.Point(8, 47);
			this.dGVClientes.Name = "dGVClientes";
			this.dGVClientes.Size = new System.Drawing.Size(775, 161);
			this.dGVClientes.TabIndex = 0;
			this.dGVClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVClientes_CellClick_1);
			this.dGVClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVClientes_CellContentClick);
			// 
			// frmClientes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 476);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "frmClientes";
			this.Text = "CLIENTES";
			this.groupBox1.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dGVClientes)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxCod;
        private System.Windows.Forms.TextBox textBoxCed;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxTel;
        private System.Windows.Forms.TextBox textBoxDir;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxCorreo;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView dGVClientes;
        private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox comboBoxRec;
		private System.Windows.Forms.Label List;
		private System.Windows.Forms.ComboBox comboBoxCon;
	}
}