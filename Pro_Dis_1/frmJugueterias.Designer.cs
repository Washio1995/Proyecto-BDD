namespace Pro_Dis_1
{
	partial class frmJugueterias
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
			this.dGVJugueterias = new System.Windows.Forms.DataGridView();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.textBoxDir = new System.Windows.Forms.TextBox();
			this.textBoxTel = new System.Windows.Forms.TextBox();
			this.textBoxLoc = new System.Windows.Forms.TextBox();
			this.btnActualizar = new System.Windows.Forms.Button();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.textBoxNom = new System.Windows.Forms.TextBox();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnRegistrar = new System.Windows.Forms.Button();
			this.textBoxId = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dGVJugueterias)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dGVJugueterias);
			this.groupBox1.Location = new System.Drawing.Point(12, 172);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(776, 149);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "LISTADO";
			// 
			// dGVJugueterias
			// 
			this.dGVJugueterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dGVJugueterias.Location = new System.Drawing.Point(6, 19);
			this.dGVJugueterias.Name = "dGVJugueterias";
			this.dGVJugueterias.Size = new System.Drawing.Size(764, 124);
			this.dGVJugueterias.TabIndex = 0;
			this.dGVJugueterias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVJugueterias_CellContentClick);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.tableLayoutPanel1);
			this.groupBox2.Location = new System.Drawing.Point(12, 17);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(776, 149);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "EDICION";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 4;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.Controls.Add(this.btnRegistrar, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.label5, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.label6, 2, 1);
			this.tableLayoutPanel1.Controls.Add(this.textBoxDir, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.textBoxTel, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.textBoxLoc, 3, 1);
			this.tableLayoutPanel1.Controls.Add(this.btnActualizar, 2, 3);
			this.tableLayoutPanel1.Controls.Add(this.textBoxNom, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.btnEliminar, 3, 3);
			this.tableLayoutPanel1.Controls.Add(this.textBoxId, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnLimpiar, 1, 3);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 21);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 4;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(764, 122);
			this.tableLayoutPanel1.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(185, 25);
			this.label1.TabIndex = 2;
			this.label1.Text = "Id Jugueteria";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.Location = new System.Drawing.Point(3, 30);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(185, 25);
			this.label2.TabIndex = 3;
			this.label2.Text = "Nombre Jugueteria";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.Location = new System.Drawing.Point(3, 60);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(185, 25);
			this.label3.TabIndex = 4;
			this.label3.Text = "Direccion Jugueteria";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.Location = new System.Drawing.Point(385, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(185, 25);
			this.label5.TabIndex = 6;
			this.label5.Text = "Telefono Jugueteria";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label6.Location = new System.Drawing.Point(385, 30);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(185, 25);
			this.label6.TabIndex = 7;
			this.label6.Text = "Localizacion Jugueteria";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBoxDir
			// 
			this.textBoxDir.Location = new System.Drawing.Point(194, 63);
			this.textBoxDir.Name = "textBoxDir";
			this.textBoxDir.Size = new System.Drawing.Size(165, 20);
			this.textBoxDir.TabIndex = 12;
			// 
			// textBoxTel
			// 
			this.textBoxTel.Location = new System.Drawing.Point(576, 3);
			this.textBoxTel.Name = "textBoxTel";
			this.textBoxTel.Size = new System.Drawing.Size(165, 20);
			this.textBoxTel.TabIndex = 14;
			// 
			// textBoxLoc
			// 
			this.textBoxLoc.Location = new System.Drawing.Point(576, 33);
			this.textBoxLoc.Name = "textBoxLoc";
			this.textBoxLoc.Size = new System.Drawing.Size(165, 20);
			this.textBoxLoc.TabIndex = 16;
			// 
			// btnActualizar
			// 
			this.btnActualizar.Location = new System.Drawing.Point(385, 93);
			this.btnActualizar.Name = "btnActualizar";
			this.btnActualizar.Size = new System.Drawing.Size(185, 23);
			this.btnActualizar.TabIndex = 17;
			this.btnActualizar.Text = "ACTUALIZAR";
			this.btnActualizar.UseVisualStyleBackColor = true;
			this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Location = new System.Drawing.Point(194, 93);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(185, 23);
			this.btnLimpiar.TabIndex = 18;
			this.btnLimpiar.Text = "LIMPIAR";
			this.btnLimpiar.UseVisualStyleBackColor = true;
			this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
			// 
			// textBoxNom
			// 
			this.textBoxNom.Location = new System.Drawing.Point(194, 33);
			this.textBoxNom.Name = "textBoxNom";
			this.textBoxNom.Size = new System.Drawing.Size(165, 20);
			this.textBoxNom.TabIndex = 19;
			// 
			// btnEliminar
			// 
			this.btnEliminar.Location = new System.Drawing.Point(576, 93);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(185, 23);
			this.btnEliminar.TabIndex = 20;
			this.btnEliminar.Text = "ELIMINAR";
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// btnRegistrar
			// 
			this.btnRegistrar.Location = new System.Drawing.Point(3, 93);
			this.btnRegistrar.Name = "btnRegistrar";
			this.btnRegistrar.Size = new System.Drawing.Size(185, 23);
			this.btnRegistrar.TabIndex = 21;
			this.btnRegistrar.Text = "REGISTRAR";
			this.btnRegistrar.UseVisualStyleBackColor = true;
			this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
			// 
			// textBoxId
			// 
			this.textBoxId.Location = new System.Drawing.Point(194, 3);
			this.textBoxId.Name = "textBoxId";
			this.textBoxId.Size = new System.Drawing.Size(165, 20);
			this.textBoxId.TabIndex = 22;
			// 
			// frmJugueterias
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(812, 341);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "frmJugueterias";
			this.Text = "frmJugueterias";
			this.Load += new System.EventHandler(this.frmJugueterias_Load);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dGVJugueterias)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridView dGVJugueterias;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.Button btnActualizar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBoxDir;
		private System.Windows.Forms.TextBox textBoxTel;
		private System.Windows.Forms.TextBox textBoxLoc;
		private System.Windows.Forms.TextBox textBoxNom;
		private System.Windows.Forms.Button btnRegistrar;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.TextBox textBoxId;
	}
}