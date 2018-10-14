namespace Pro_Dis_1
{
    partial class frmEmpleados
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
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.textBoxTel = new System.Windows.Forms.TextBox();
			this.textBoxDir = new System.Windows.Forms.TextBox();
			this.textBoxSal = new System.Windows.Forms.TextBox();
			this.textBoxCod = new System.Windows.Forms.TextBox();
			this.textBoxNom = new System.Windows.Forms.TextBox();
			this.btnRegistrar = new System.Windows.Forms.Button();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.btnActualizar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxCorEle = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.textBoxCed = new System.Windows.Forms.TextBox();
			this.txtIdJ = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dGVEmpleado = new System.Windows.Forms.DataGridView();
			this.comboFraHor = new System.Windows.Forms.ComboBox();
			this.label9 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dGVEmpleado)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.tableLayoutPanel1);
			this.groupBox1.Location = new System.Drawing.Point(5, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(848, 241);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "EDICION";
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 4;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.Controls.Add(this.comboBox3, 3, 1);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.label5, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.label6, 2, 1);
			this.tableLayoutPanel1.Controls.Add(this.label7, 2, 2);
			this.tableLayoutPanel1.Controls.Add(this.label8, 2, 3);
			this.tableLayoutPanel1.Controls.Add(this.textBoxTel, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.textBoxDir, 3, 2);
			this.tableLayoutPanel1.Controls.Add(this.textBoxSal, 3, 3);
			this.tableLayoutPanel1.Controls.Add(this.textBoxCod, 1, 4);
			this.tableLayoutPanel1.Controls.Add(this.textBoxNom, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnRegistrar, 0, 5);
			this.tableLayoutPanel1.Controls.Add(this.btnLimpiar, 1, 5);
			this.tableLayoutPanel1.Controls.Add(this.btnActualizar, 2, 5);
			this.tableLayoutPanel1.Controls.Add(this.btnEliminar, 3, 5);
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.textBoxCorEle, 3, 4);
			this.tableLayoutPanel1.Controls.Add(this.label11, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.label10, 2, 4);
			this.tableLayoutPanel1.Controls.Add(this.comboBox1, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.textBoxCed, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.txtIdJ, 1, 1);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 19);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 6;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(839, 220);
			this.tableLayoutPanel1.TabIndex = 0;
			this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
			// 
			// comboBox3
			// 
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.Location = new System.Drawing.Point(630, 39);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(135, 21);
			this.comboBox3.TabIndex = 26;
			this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(203, 25);
			this.label1.TabIndex = 2;
			this.label1.Text = "Sede";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.Location = new System.Drawing.Point(3, 72);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(203, 25);
			this.label3.TabIndex = 4;
			this.label3.Text = "Cedula";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.Location = new System.Drawing.Point(3, 108);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(203, 25);
			this.label4.TabIndex = 5;
			this.label4.Text = "Telefono";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.Location = new System.Drawing.Point(421, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(203, 25);
			this.label5.TabIndex = 6;
			this.label5.Text = "Nombre";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label6.Location = new System.Drawing.Point(421, 36);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(203, 25);
			this.label6.TabIndex = 7;
			this.label6.Text = "Tipo Empleado";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label7.Location = new System.Drawing.Point(421, 72);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(203, 25);
			this.label7.TabIndex = 8;
			this.label7.Text = "Direccion";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label8
			// 
			this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label8.Location = new System.Drawing.Point(421, 108);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(203, 25);
			this.label8.TabIndex = 9;
			this.label8.Text = "Salario";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBoxTel
			// 
			this.textBoxTel.Location = new System.Drawing.Point(212, 111);
			this.textBoxTel.Name = "textBoxTel";
			this.textBoxTel.Size = new System.Drawing.Size(165, 20);
			this.textBoxTel.TabIndex = 13;
			// 
			// textBoxDir
			// 
			this.textBoxDir.Location = new System.Drawing.Point(630, 75);
			this.textBoxDir.Name = "textBoxDir";
			this.textBoxDir.Size = new System.Drawing.Size(165, 20);
			this.textBoxDir.TabIndex = 15;
			// 
			// textBoxSal
			// 
			this.textBoxSal.Location = new System.Drawing.Point(630, 111);
			this.textBoxSal.Name = "textBoxSal";
			this.textBoxSal.Size = new System.Drawing.Size(165, 20);
			this.textBoxSal.TabIndex = 16;
			// 
			// textBoxCod
			// 
			this.textBoxCod.Location = new System.Drawing.Point(212, 147);
			this.textBoxCod.Name = "textBoxCod";
			this.textBoxCod.Size = new System.Drawing.Size(165, 20);
			this.textBoxCod.TabIndex = 19;
			// 
			// textBoxNom
			// 
			this.textBoxNom.Location = new System.Drawing.Point(630, 3);
			this.textBoxNom.Name = "textBoxNom";
			this.textBoxNom.Size = new System.Drawing.Size(165, 20);
			this.textBoxNom.TabIndex = 20;
			// 
			// btnRegistrar
			// 
			this.btnRegistrar.Location = new System.Drawing.Point(3, 183);
			this.btnRegistrar.Name = "btnRegistrar";
			this.btnRegistrar.Size = new System.Drawing.Size(189, 30);
			this.btnRegistrar.TabIndex = 0;
			this.btnRegistrar.Text = "REGISTRAR";
			this.btnRegistrar.UseVisualStyleBackColor = true;
			this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Location = new System.Drawing.Point(212, 183);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(185, 29);
			this.btnLimpiar.TabIndex = 1;
			this.btnLimpiar.Text = "LIMPIAR";
			this.btnLimpiar.UseVisualStyleBackColor = true;
			this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
			// 
			// btnActualizar
			// 
			this.btnActualizar.Location = new System.Drawing.Point(421, 183);
			this.btnActualizar.Name = "btnActualizar";
			this.btnActualizar.Size = new System.Drawing.Size(181, 28);
			this.btnActualizar.TabIndex = 21;
			this.btnActualizar.Text = "ACTUALIZAR";
			this.btnActualizar.UseVisualStyleBackColor = true;
			this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
			// 
			// btnEliminar
			// 
			this.btnEliminar.Location = new System.Drawing.Point(630, 183);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(181, 28);
			this.btnEliminar.TabIndex = 22;
			this.btnEliminar.Text = "ELIMINAR";
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.Location = new System.Drawing.Point(3, 144);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(203, 25);
			this.label2.TabIndex = 3;
			this.label2.Text = "Codigo";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBoxCorEle
			// 
			this.textBoxCorEle.Location = new System.Drawing.Point(630, 147);
			this.textBoxCorEle.Name = "textBoxCorEle";
			this.textBoxCorEle.Size = new System.Drawing.Size(165, 20);
			this.textBoxCorEle.TabIndex = 11;
			// 
			// label11
			// 
			this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label11.Location = new System.Drawing.Point(3, 36);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(203, 25);
			this.label11.TabIndex = 23;
			this.label11.Text = "ID Jugueteria";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label11.Click += new System.EventHandler(this.label11_Click);
			// 
			// label10
			// 
			this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label10.Location = new System.Drawing.Point(421, 144);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(203, 25);
			this.label10.TabIndex = 18;
			this.label10.Text = "Correo Electronico";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(212, 3);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(78, 21);
			this.comboBox1.TabIndex = 24;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// textBoxCed
			// 
			this.textBoxCed.Location = new System.Drawing.Point(212, 75);
			this.textBoxCed.Name = "textBoxCed";
			this.textBoxCed.Size = new System.Drawing.Size(165, 20);
			this.textBoxCed.TabIndex = 12;
			// 
			// txtIdJ
			// 
			this.txtIdJ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.txtIdJ.AutoSize = true;
			this.txtIdJ.Location = new System.Drawing.Point(212, 47);
			this.txtIdJ.Name = "txtIdJ";
			this.txtIdJ.Size = new System.Drawing.Size(203, 13);
			this.txtIdJ.TabIndex = 25;
			this.txtIdJ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.txtIdJ.Click += new System.EventHandler(this.txtIdJ_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.dGVEmpleado);
			this.groupBox2.Controls.Add(this.comboFraHor);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Location = new System.Drawing.Point(5, 246);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(848, 210);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Listado";
			// 
			// dGVEmpleado
			// 
			this.dGVEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dGVEmpleado.Location = new System.Drawing.Point(9, 44);
			this.dGVEmpleado.Name = "dGVEmpleado";
			this.dGVEmpleado.Size = new System.Drawing.Size(833, 150);
			this.dGVEmpleado.TabIndex = 19;
			this.dGVEmpleado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVEmpleado_CellClick);
			this.dGVEmpleado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVEmpleado_CellContentClick);
			// 
			// comboFraHor
			// 
			this.comboFraHor.FormattingEnabled = true;
			this.comboFraHor.Location = new System.Drawing.Point(647, 14);
			this.comboFraHor.Name = "comboFraHor";
			this.comboFraHor.Size = new System.Drawing.Size(168, 21);
			this.comboFraHor.TabIndex = 18;
			this.comboFraHor.SelectedIndexChanged += new System.EventHandler(this.comboFraHor_SelectedIndexChanged);
			// 
			// label9
			// 
			this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label9.Location = new System.Drawing.Point(573, 11);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(71, 25);
			this.label9.TabIndex = 18;
			this.label9.Text = "Listar por:";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// frmEmpleados
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(865, 470);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "frmEmpleados";
			this.Text = "EMPLEADOS";
			this.Load += new System.EventHandler(this.frmEmpleados_Load);
			this.groupBox1.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dGVEmpleado)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxCorEle;
        private System.Windows.Forms.TextBox textBoxCed;
        private System.Windows.Forms.TextBox textBoxTel;
        private System.Windows.Forms.TextBox textBoxDir;
        private System.Windows.Forms.TextBox textBoxSal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxCod;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboFraHor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dGVEmpleado;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label txtIdJ;
        private System.Windows.Forms.ComboBox comboBox3;
    }
}