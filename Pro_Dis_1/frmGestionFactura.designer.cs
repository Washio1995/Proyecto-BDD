namespace Pro_Dis_1
{
    partial class frmGestionFactura
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
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dGVFacturas = new System.Windows.Forms.DataGridView();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.label9 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.textBoxDet = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.textBoxCodCli = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxCodFac = new System.Windows.Forms.TextBox();
			this.textBoxId = new System.Windows.Forms.TextBox();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dGVFacturas)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.dGVFacturas);
			this.groupBox2.Controls.Add(this.comboBox2);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Location = new System.Drawing.Point(5, 151);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(790, 287);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Tag = "";
			this.groupBox2.Text = " listado";
			// 
			// dGVFacturas
			// 
			this.dGVFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dGVFacturas.Location = new System.Drawing.Point(18, 44);
			this.dGVFacturas.Name = "dGVFacturas";
			this.dGVFacturas.Size = new System.Drawing.Size(755, 225);
			this.dGVFacturas.TabIndex = 19;
			this.dGVFacturas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVFacturas_CellClick);
			this.dGVFacturas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(591, 16);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(112, 21);
			this.comboBox2.TabIndex = 18;
			this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
			// 
			// label9
			// 
			this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label9.Location = new System.Drawing.Point(396, 16);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(192, 25);
			this.label9.TabIndex = 18;
			this.label9.Text = "Listar por Cliente";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label9.Click += new System.EventHandler(this.label9_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.tableLayoutPanel1);
			this.groupBox1.Location = new System.Drawing.Point(11, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(784, 133);
			this.groupBox1.TabIndex = 5;
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
			this.tableLayoutPanel1.Controls.Add(this.textBoxDet, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.label5, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.textBoxCodCli, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.textBoxCodFac, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.textBoxId, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.btnLimpiar, 2, 2);
			this.tableLayoutPanel1.Controls.Add(this.btnEliminar, 3, 2);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 19);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(757, 108);
			this.tableLayoutPanel1.TabIndex = 1;
			// 
			// textBoxDet
			// 
			this.textBoxDet.Location = new System.Drawing.Point(192, 75);
			this.textBoxDet.Name = "textBoxDet";
			this.textBoxDet.Size = new System.Drawing.Size(165, 20);
			this.textBoxDet.TabIndex = 24;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.Location = new System.Drawing.Point(3, 72);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(183, 25);
			this.label3.TabIndex = 23;
			this.label3.Text = "Detalle";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.Location = new System.Drawing.Point(381, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(183, 25);
			this.label5.TabIndex = 6;
			this.label5.Text = "Codigo Cliente";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBoxCodCli
			// 
			this.textBoxCodCli.Location = new System.Drawing.Point(570, 3);
			this.textBoxCodCli.Name = "textBoxCodCli";
			this.textBoxCodCli.Size = new System.Drawing.Size(165, 20);
			this.textBoxCodCli.TabIndex = 14;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.Location = new System.Drawing.Point(3, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(183, 25);
			this.label2.TabIndex = 3;
			this.label2.Text = "Codigo Factura";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.Location = new System.Drawing.Point(3, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(183, 25);
			this.label1.TabIndex = 2;
			this.label1.Text = "Id Jugueteria";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// textBoxCodFac
			// 
			this.textBoxCodFac.Location = new System.Drawing.Point(192, 3);
			this.textBoxCodFac.Name = "textBoxCodFac";
			this.textBoxCodFac.Size = new System.Drawing.Size(165, 20);
			this.textBoxCodFac.TabIndex = 19;
			// 
			// textBoxId
			// 
			this.textBoxId.Location = new System.Drawing.Point(192, 39);
			this.textBoxId.Name = "textBoxId";
			this.textBoxId.Size = new System.Drawing.Size(165, 20);
			this.textBoxId.TabIndex = 22;
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Location = new System.Drawing.Point(381, 75);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(183, 23);
			this.btnLimpiar.TabIndex = 18;
			this.btnLimpiar.Text = "LIMPIAR";
			this.btnLimpiar.UseVisualStyleBackColor = true;
			this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
			// 
			// btnEliminar
			// 
			this.btnEliminar.Location = new System.Drawing.Point(570, 75);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(184, 23);
			this.btnEliminar.TabIndex = 20;
			this.btnEliminar.Text = "ELIMINAR";
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// frmGestionFactura
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox2);
			this.Name = "frmGestionFactura";
			this.Text = " GESTION DE FACTURAS";
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dGVFacturas)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dGVFacturas;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBoxCodCli;
		private System.Windows.Forms.TextBox textBoxCodFac;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.TextBox textBoxId;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.TextBox textBoxDet;
		private System.Windows.Forms.Label label3;
	}
}