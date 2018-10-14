namespace Pro_Dis_1
{
    partial class frmJuguetes
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
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.dGVJuguete = new System.Windows.Forms.DataGridView();
			this.label9 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.txtIdJ = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.textBoxPre = new System.Windows.Forms.TextBox();
			this.textBoxMar = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtCat = new System.Windows.Forms.Label();
			this.comboBoxCat = new System.Windows.Forms.ComboBox();
			this.comboBoxSed = new System.Windows.Forms.ComboBox();
			this.btnRegistrar = new System.Windows.Forms.Button();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.textBoxDes = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxNom = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxCod = new System.Windows.Forms.TextBox();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dGVJuguete)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.comboBox1);
			this.groupBox2.Controls.Add(this.dGVJuguete);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Location = new System.Drawing.Point(8, 253);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(790, 240);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Listado";
			this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(660, 19);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 21;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// dGVJuguete
			// 
			this.dGVJuguete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dGVJuguete.Location = new System.Drawing.Point(9, 46);
			this.dGVJuguete.Name = "dGVJuguete";
			this.dGVJuguete.ShowCellErrors = false;
			this.dGVJuguete.Size = new System.Drawing.Size(772, 179);
			this.dGVJuguete.TabIndex = 19;
			this.dGVJuguete.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVJuguetes_CellClick);
			this.dGVJuguete.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVJuguete_CellContentClick);
			// 
			// label9
			// 
			this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label9.Location = new System.Drawing.Point(553, 16);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(130, 25);
			this.label9.TabIndex = 18;
			this.label9.Text = "Listar por:";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.tableLayoutPanel1);
			this.groupBox1.Location = new System.Drawing.Point(8, 10);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(790, 241);
			this.groupBox1.TabIndex = 2;
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
			this.tableLayoutPanel1.Controls.Add(this.txtIdJ, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.label10, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.label7, 2, 2);
			this.tableLayoutPanel1.Controls.Add(this.label8, 2, 3);
			this.tableLayoutPanel1.Controls.Add(this.textBoxPre, 3, 2);
			this.tableLayoutPanel1.Controls.Add(this.textBoxMar, 3, 3);
			this.tableLayoutPanel1.Controls.Add(this.label5, 2, 1);
			this.tableLayoutPanel1.Controls.Add(this.label6, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.txtCat, 3, 1);
			this.tableLayoutPanel1.Controls.Add(this.comboBoxCat, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.comboBoxSed, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnRegistrar, 0, 5);
			this.tableLayoutPanel1.Controls.Add(this.btnLimpiar, 1, 5);
			this.tableLayoutPanel1.Controls.Add(this.button3, 2, 5);
			this.tableLayoutPanel1.Controls.Add(this.button4, 3, 5);
			this.tableLayoutPanel1.Controls.Add(this.textBoxDes, 1, 4);
			this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.textBoxNom, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.textBoxCod, 1, 2);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 6;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(781, 220);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// txtIdJ
			// 
			this.txtIdJ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtIdJ.Location = new System.Drawing.Point(198, 36);
			this.txtIdJ.Name = "txtIdJ";
			this.txtIdJ.Size = new System.Drawing.Size(189, 25);
			this.txtIdJ.TabIndex = 23;
			this.txtIdJ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label10
			// 
			this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label10.Location = new System.Drawing.Point(3, 36);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(189, 25);
			this.label10.TabIndex = 22;
			this.label10.Text = "ID Jugueteria";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(189, 25);
			this.label1.TabIndex = 2;
			this.label1.Text = "Sede";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label1.Click += new System.EventHandler(this.label1_Click_2);
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label7.Location = new System.Drawing.Point(393, 72);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(189, 25);
			this.label7.TabIndex = 8;
			this.label7.Text = "Precio";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label8
			// 
			this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label8.Location = new System.Drawing.Point(393, 108);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(189, 25);
			this.label8.TabIndex = 9;
			this.label8.Text = "Marca";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBoxPre
			// 
			this.textBoxPre.Location = new System.Drawing.Point(588, 75);
			this.textBoxPre.Name = "textBoxPre";
			this.textBoxPre.Size = new System.Drawing.Size(165, 20);
			this.textBoxPre.TabIndex = 15;
			// 
			// textBoxMar
			// 
			this.textBoxMar.Location = new System.Drawing.Point(588, 111);
			this.textBoxMar.Name = "textBoxMar";
			this.textBoxMar.Size = new System.Drawing.Size(165, 20);
			this.textBoxMar.TabIndex = 16;
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.Location = new System.Drawing.Point(393, 36);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(189, 25);
			this.label5.TabIndex = 6;
			this.label5.Text = "Categoria";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label6.Location = new System.Drawing.Point(393, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(189, 25);
			this.label6.TabIndex = 7;
			this.label6.Text = "Nombre Categoria";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtCat
			// 
			this.txtCat.Location = new System.Drawing.Point(588, 36);
			this.txtCat.Name = "txtCat";
			this.txtCat.Size = new System.Drawing.Size(190, 25);
			this.txtCat.TabIndex = 20;
			this.txtCat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// comboBoxCat
			// 
			this.comboBoxCat.FormattingEnabled = true;
			this.comboBoxCat.Location = new System.Drawing.Point(588, 3);
			this.comboBoxCat.Name = "comboBoxCat";
			this.comboBoxCat.Size = new System.Drawing.Size(165, 21);
			this.comboBoxCat.TabIndex = 17;
			this.comboBoxCat.SelectedIndexChanged += new System.EventHandler(this.comboBoxCat_SelectedIndexChanged);
			// 
			// comboBoxSed
			// 
			this.comboBoxSed.FormattingEnabled = true;
			this.comboBoxSed.Location = new System.Drawing.Point(198, 3);
			this.comboBoxSed.Name = "comboBoxSed";
			this.comboBoxSed.Size = new System.Drawing.Size(76, 21);
			this.comboBoxSed.TabIndex = 21;
			this.comboBoxSed.SelectedIndexChanged += new System.EventHandler(this.comboBoxSed_SelectedIndexChanged);
			// 
			// btnRegistrar
			// 
			this.btnRegistrar.Location = new System.Drawing.Point(3, 183);
			this.btnRegistrar.Name = "btnRegistrar";
			this.btnRegistrar.Size = new System.Drawing.Size(189, 30);
			this.btnRegistrar.TabIndex = 0;
			this.btnRegistrar.Text = "REGISTRAR";
			this.btnRegistrar.UseVisualStyleBackColor = true;
			this.btnRegistrar.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Location = new System.Drawing.Point(198, 183);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(185, 29);
			this.btnLimpiar.TabIndex = 1;
			this.btnLimpiar.Text = "LIMPIAR";
			this.btnLimpiar.UseVisualStyleBackColor = true;
			this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(393, 183);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(189, 30);
			this.button3.TabIndex = 18;
			this.button3.Text = "ACTUALIZAR";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(588, 183);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(190, 29);
			this.button4.TabIndex = 19;
			this.button4.Text = "ELIMINAR";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// textBoxDes
			// 
			this.textBoxDes.Location = new System.Drawing.Point(198, 147);
			this.textBoxDes.Name = "textBoxDes";
			this.textBoxDes.Size = new System.Drawing.Size(165, 20);
			this.textBoxDes.TabIndex = 13;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.Location = new System.Drawing.Point(3, 144);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(189, 25);
			this.label4.TabIndex = 5;
			this.label4.Text = "Descripcion";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.Location = new System.Drawing.Point(3, 108);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(189, 25);
			this.label3.TabIndex = 4;
			this.label3.Text = "Nombre";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBoxNom
			// 
			this.textBoxNom.Location = new System.Drawing.Point(198, 111);
			this.textBoxNom.Name = "textBoxNom";
			this.textBoxNom.Size = new System.Drawing.Size(165, 20);
			this.textBoxNom.TabIndex = 12;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.Location = new System.Drawing.Point(3, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(189, 25);
			this.label2.TabIndex = 3;
			this.label2.Text = "Codigo";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBoxCod
			// 
			this.textBoxCod.Location = new System.Drawing.Point(198, 75);
			this.textBoxCod.Name = "textBoxCod";
			this.textBoxCod.Size = new System.Drawing.Size(165, 20);
			this.textBoxCod.TabIndex = 11;
			// 
			// frmJuguetes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(810, 515);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox2);
			this.Name = "frmJuguetes";
			this.Text = "JUGUETES";
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dGVJuguete)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxCod;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxDes;
        private System.Windows.Forms.TextBox textBoxPre;
        private System.Windows.Forms.TextBox textBoxMar;
        private System.Windows.Forms.ComboBox comboBoxCat;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dGVJuguete;
        private System.Windows.Forms.Label txtCat;
        private System.Windows.Forms.ComboBox comboBoxSed;
        private System.Windows.Forms.Label txtIdJ;
        private System.Windows.Forms.Label label10;
		private System.Windows.Forms.ComboBox comboBox1;
	}
}