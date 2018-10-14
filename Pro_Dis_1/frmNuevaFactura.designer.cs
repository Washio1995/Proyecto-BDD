namespace Pro_Dis_1
{
    partial class frmNuevaFactura
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
			this.dGVClientes = new System.Windows.Forms.DataGridView();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.btnBuscarCli = new System.Windows.Forms.Button();
			this.btnLimpiarCli = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.textBoxCodCli = new System.Windows.Forms.TextBox();
			this.textBoxCed = new System.Windows.Forms.TextBox();
			this.textBoxNombre = new System.Windows.Forms.TextBox();
			this.textBoxTel = new System.Windows.Forms.TextBox();
			this.textBoxCorreo = new System.Windows.Forms.TextBox();
			this.textBoxDir = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.textBoxPre = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.textBoxCodArt = new System.Windows.Forms.TextBox();
			this.textBoxNomArt = new System.Windows.Forms.TextBox();
			this.textBoxDes = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.textBoxMar = new System.Windows.Forms.TextBox();
			this.comboBoxCat = new System.Windows.Forms.ComboBox();
			this.txtCat = new System.Windows.Forms.Label();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.textBoxCan = new System.Windows.Forms.TextBox();
			this.label20 = new System.Windows.Forms.Label();
			this.btnBuscarArt = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.label15 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxCodFac = new System.Windows.Forms.TextBox();
			this.comboBoxSede = new System.Windows.Forms.ComboBox();
			this.label17 = new System.Windows.Forms.Label();
			this.dTFecha = new System.Windows.Forms.DateTimePicker();
			this.txtIdJ = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.dGVJuguete = new System.Windows.Forms.DataGridView();
			this.textBoxTotal = new System.Windows.Forms.TextBox();
			this.textBoxIVA = new System.Windows.Forms.TextBox();
			this.textBoxSub = new System.Windows.Forms.TextBox();
			this.label19 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.btnLimpiarTodo = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dGVClientes)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dGVJuguete)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dGVClientes);
			this.groupBox1.Controls.Add(this.tableLayoutPanel1);
			this.groupBox1.Location = new System.Drawing.Point(8, 83);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(784, 237);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "CLIENTE";
			// 
			// dGVClientes
			// 
			this.dGVClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dGVClientes.Location = new System.Drawing.Point(17, 137);
			this.dGVClientes.Name = "dGVClientes";
			this.dGVClientes.Size = new System.Drawing.Size(758, 87);
			this.dGVClientes.TabIndex = 1;
			this.dGVClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVClientes_CellClick);
			this.dGVClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVClientes_CellContentClick);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 4;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.Controls.Add(this.btnBuscarCli, 2, 3);
			this.tableLayoutPanel1.Controls.Add(this.btnLimpiarCli, 3, 3);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.label5, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.label6, 2, 1);
			this.tableLayoutPanel1.Controls.Add(this.label7, 2, 2);
			this.tableLayoutPanel1.Controls.Add(this.textBoxCodCli, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.textBoxCed, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.textBoxNombre, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.textBoxTel, 3, 1);
			this.tableLayoutPanel1.Controls.Add(this.textBoxCorreo, 3, 2);
			this.tableLayoutPanel1.Controls.Add(this.textBoxDir, 3, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 4;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(781, 107);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// btnBuscarCli
			// 
			this.btnBuscarCli.Location = new System.Drawing.Point(393, 81);
			this.btnBuscarCli.Name = "btnBuscarCli";
			this.btnBuscarCli.Size = new System.Drawing.Size(189, 23);
			this.btnBuscarCli.TabIndex = 0;
			this.btnBuscarCli.Text = "BUSCAR";
			this.btnBuscarCli.UseVisualStyleBackColor = true;
			this.btnBuscarCli.Click += new System.EventHandler(this.btnBuscarCli_Click);
			// 
			// btnLimpiarCli
			// 
			this.btnLimpiarCli.Location = new System.Drawing.Point(588, 81);
			this.btnLimpiarCli.Name = "btnLimpiarCli";
			this.btnLimpiarCli.Size = new System.Drawing.Size(185, 23);
			this.btnLimpiarCli.TabIndex = 1;
			this.btnLimpiarCli.Text = "LIMPIAR";
			this.btnLimpiarCli.UseVisualStyleBackColor = true;
			this.btnLimpiarCli.Click += new System.EventHandler(this.btnLimpiarCli_Click);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(189, 25);
			this.label1.TabIndex = 2;
			this.label1.Text = "Codigo Cliente";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.Location = new System.Drawing.Point(3, 26);
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
			this.label3.Location = new System.Drawing.Point(3, 52);
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
			this.label6.Location = new System.Drawing.Point(393, 26);
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
			this.label7.Location = new System.Drawing.Point(393, 52);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(189, 25);
			this.label7.TabIndex = 8;
			this.label7.Text = "Correo Electronico";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBoxCodCli
			// 
			this.textBoxCodCli.Enabled = false;
			this.textBoxCodCli.Location = new System.Drawing.Point(198, 3);
			this.textBoxCodCli.Name = "textBoxCodCli";
			this.textBoxCodCli.Size = new System.Drawing.Size(165, 20);
			this.textBoxCodCli.TabIndex = 10;
			// 
			// textBoxCed
			// 
			this.textBoxCed.Location = new System.Drawing.Point(198, 29);
			this.textBoxCed.MaxLength = 10;
			this.textBoxCed.Name = "textBoxCed";
			this.textBoxCed.Size = new System.Drawing.Size(165, 20);
			this.textBoxCed.TabIndex = 11;
			// 
			// textBoxNombre
			// 
			this.textBoxNombre.Enabled = false;
			this.textBoxNombre.Location = new System.Drawing.Point(198, 55);
			this.textBoxNombre.Name = "textBoxNombre";
			this.textBoxNombre.Size = new System.Drawing.Size(165, 20);
			this.textBoxNombre.TabIndex = 12;
			// 
			// textBoxTel
			// 
			this.textBoxTel.Enabled = false;
			this.textBoxTel.Location = new System.Drawing.Point(588, 29);
			this.textBoxTel.Name = "textBoxTel";
			this.textBoxTel.Size = new System.Drawing.Size(165, 20);
			this.textBoxTel.TabIndex = 14;
			// 
			// textBoxCorreo
			// 
			this.textBoxCorreo.Enabled = false;
			this.textBoxCorreo.Location = new System.Drawing.Point(588, 55);
			this.textBoxCorreo.Name = "textBoxCorreo";
			this.textBoxCorreo.Size = new System.Drawing.Size(165, 20);
			this.textBoxCorreo.TabIndex = 15;
			// 
			// textBoxDir
			// 
			this.textBoxDir.Enabled = false;
			this.textBoxDir.Location = new System.Drawing.Point(588, 3);
			this.textBoxDir.Name = "textBoxDir";
			this.textBoxDir.Size = new System.Drawing.Size(165, 20);
			this.textBoxDir.TabIndex = 16;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.tableLayoutPanel2);
			this.groupBox2.Location = new System.Drawing.Point(8, 326);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(784, 162);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "ARTICULO";
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 4;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel2.Controls.Add(this.label12, 2, 1);
			this.tableLayoutPanel2.Controls.Add(this.label13, 2, 2);
			this.tableLayoutPanel2.Controls.Add(this.textBoxPre, 3, 2);
			this.tableLayoutPanel2.Controls.Add(this.label11, 2, 0);
			this.tableLayoutPanel2.Controls.Add(this.label8, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.textBoxCodArt, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.textBoxNomArt, 1, 1);
			this.tableLayoutPanel2.Controls.Add(this.textBoxDes, 1, 2);
			this.tableLayoutPanel2.Controls.Add(this.label9, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.label10, 0, 2);
			this.tableLayoutPanel2.Controls.Add(this.label14, 0, 3);
			this.tableLayoutPanel2.Controls.Add(this.textBoxMar, 1, 3);
			this.tableLayoutPanel2.Controls.Add(this.comboBoxCat, 3, 1);
			this.tableLayoutPanel2.Controls.Add(this.txtCat, 3, 0);
			this.tableLayoutPanel2.Controls.Add(this.btnAgregar, 2, 4);
			this.tableLayoutPanel2.Controls.Add(this.btnLimpiar, 3, 4);
			this.tableLayoutPanel2.Controls.Add(this.textBoxCan, 3, 3);
			this.tableLayoutPanel2.Controls.Add(this.label20, 2, 3);
			this.tableLayoutPanel2.Controls.Add(this.btnBuscarArt, 1, 4);
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 5;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(781, 146);
			this.tableLayoutPanel2.TabIndex = 0;
			// 
			// label12
			// 
			this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label12.Location = new System.Drawing.Point(393, 29);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(189, 25);
			this.label12.TabIndex = 7;
			this.label12.Text = "Nombre Categoria";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label13
			// 
			this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label13.Location = new System.Drawing.Point(393, 58);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(189, 25);
			this.label13.TabIndex = 8;
			this.label13.Text = "Precio";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBoxPre
			// 
			this.textBoxPre.Enabled = false;
			this.textBoxPre.Location = new System.Drawing.Point(588, 61);
			this.textBoxPre.Name = "textBoxPre";
			this.textBoxPre.Size = new System.Drawing.Size(165, 20);
			this.textBoxPre.TabIndex = 15;
			// 
			// label11
			// 
			this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label11.Location = new System.Drawing.Point(393, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(189, 25);
			this.label11.TabIndex = 6;
			this.label11.Text = "Categoria";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label8
			// 
			this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label8.Location = new System.Drawing.Point(3, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(189, 25);
			this.label8.TabIndex = 3;
			this.label8.Text = "Codigo Articulo";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBoxCodArt
			// 
			this.textBoxCodArt.Location = new System.Drawing.Point(198, 3);
			this.textBoxCodArt.Name = "textBoxCodArt";
			this.textBoxCodArt.Size = new System.Drawing.Size(165, 20);
			this.textBoxCodArt.TabIndex = 11;
			// 
			// textBoxNomArt
			// 
			this.textBoxNomArt.Enabled = false;
			this.textBoxNomArt.Location = new System.Drawing.Point(198, 32);
			this.textBoxNomArt.Name = "textBoxNomArt";
			this.textBoxNomArt.Size = new System.Drawing.Size(165, 20);
			this.textBoxNomArt.TabIndex = 12;
			// 
			// textBoxDes
			// 
			this.textBoxDes.Enabled = false;
			this.textBoxDes.Location = new System.Drawing.Point(198, 61);
			this.textBoxDes.Name = "textBoxDes";
			this.textBoxDes.Size = new System.Drawing.Size(165, 20);
			this.textBoxDes.TabIndex = 13;
			// 
			// label9
			// 
			this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label9.Location = new System.Drawing.Point(3, 29);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(189, 25);
			this.label9.TabIndex = 4;
			this.label9.Text = "Nombre";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label10
			// 
			this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label10.Location = new System.Drawing.Point(3, 58);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(189, 25);
			this.label10.TabIndex = 5;
			this.label10.Text = "Descripcion";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label14
			// 
			this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label14.Location = new System.Drawing.Point(3, 87);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(189, 25);
			this.label14.TabIndex = 9;
			this.label14.Text = "Marca";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBoxMar
			// 
			this.textBoxMar.Enabled = false;
			this.textBoxMar.Location = new System.Drawing.Point(198, 90);
			this.textBoxMar.Name = "textBoxMar";
			this.textBoxMar.Size = new System.Drawing.Size(165, 20);
			this.textBoxMar.TabIndex = 16;
			// 
			// comboBoxCat
			// 
			this.comboBoxCat.Enabled = false;
			this.comboBoxCat.FormattingEnabled = true;
			this.comboBoxCat.Location = new System.Drawing.Point(588, 32);
			this.comboBoxCat.Name = "comboBoxCat";
			this.comboBoxCat.Size = new System.Drawing.Size(165, 21);
			this.comboBoxCat.TabIndex = 17;
			this.comboBoxCat.SelectedIndexChanged += new System.EventHandler(this.comboBoxCat_SelectedIndexChanged);
			// 
			// txtCat
			// 
			this.txtCat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtCat.AutoSize = true;
			this.txtCat.Location = new System.Drawing.Point(588, 0);
			this.txtCat.Name = "txtCat";
			this.txtCat.Size = new System.Drawing.Size(190, 13);
			this.txtCat.TabIndex = 18;
			this.txtCat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnAgregar
			// 
			this.btnAgregar.Location = new System.Drawing.Point(393, 119);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(189, 24);
			this.btnAgregar.TabIndex = 0;
			this.btnAgregar.Text = "AGREGAR";
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Location = new System.Drawing.Point(588, 119);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(185, 24);
			this.btnLimpiar.TabIndex = 1;
			this.btnLimpiar.Text = "LIMPIAR";
			this.btnLimpiar.UseVisualStyleBackColor = true;
			this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
			// 
			// textBoxCan
			// 
			this.textBoxCan.Location = new System.Drawing.Point(588, 90);
			this.textBoxCan.Name = "textBoxCan";
			this.textBoxCan.Size = new System.Drawing.Size(165, 20);
			this.textBoxCan.TabIndex = 20;
			// 
			// label20
			// 
			this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label20.AutoSize = true;
			this.label20.Location = new System.Drawing.Point(393, 87);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(189, 29);
			this.label20.TabIndex = 19;
			this.label20.Text = "Cantidad";
			this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnBuscarArt
			// 
			this.btnBuscarArt.Location = new System.Drawing.Point(198, 119);
			this.btnBuscarArt.Name = "btnBuscarArt";
			this.btnBuscarArt.Size = new System.Drawing.Size(189, 23);
			this.btnBuscarArt.TabIndex = 21;
			this.btnBuscarArt.Text = "BUSCAR";
			this.btnBuscarArt.UseVisualStyleBackColor = true;
			this.btnBuscarArt.Click += new System.EventHandler(this.btnBuscarArt_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.tableLayoutPanel3);
			this.groupBox3.Location = new System.Drawing.Point(8, 4);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(786, 77);
			this.groupBox3.TabIndex = 6;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "DATOS FACTURA";
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 4;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel3.Controls.Add(this.label15, 2, 0);
			this.tableLayoutPanel3.Controls.Add(this.label4, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.textBoxCodFac, 1, 0);
			this.tableLayoutPanel3.Controls.Add(this.comboBoxSede, 3, 0);
			this.tableLayoutPanel3.Controls.Add(this.label17, 0, 1);
			this.tableLayoutPanel3.Controls.Add(this.dTFecha, 1, 1);
			this.tableLayoutPanel3.Controls.Add(this.txtIdJ, 3, 1);
			this.tableLayoutPanel3.Controls.Add(this.label21, 2, 1);
			this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 2;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(781, 57);
			this.tableLayoutPanel3.TabIndex = 0;
			// 
			// label15
			// 
			this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label15.Location = new System.Drawing.Point(393, 0);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(189, 25);
			this.label15.TabIndex = 19;
			this.label15.Text = "Sede";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.Location = new System.Drawing.Point(3, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(189, 25);
			this.label4.TabIndex = 18;
			this.label4.Text = "Codigo Factura";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBoxCodFac
			// 
			this.textBoxCodFac.Location = new System.Drawing.Point(198, 3);
			this.textBoxCodFac.Name = "textBoxCodFac";
			this.textBoxCodFac.Size = new System.Drawing.Size(165, 20);
			this.textBoxCodFac.TabIndex = 18;
			// 
			// comboBoxSede
			// 
			this.comboBoxSede.FormattingEnabled = true;
			this.comboBoxSede.Location = new System.Drawing.Point(588, 3);
			this.comboBoxSede.Name = "comboBoxSede";
			this.comboBoxSede.Size = new System.Drawing.Size(121, 21);
			this.comboBoxSede.TabIndex = 0;
			this.comboBoxSede.SelectedIndexChanged += new System.EventHandler(this.comboBoxSede_SelectedIndexChanged);
			// 
			// label17
			// 
			this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label17.Location = new System.Drawing.Point(3, 28);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(189, 25);
			this.label17.TabIndex = 21;
			this.label17.Text = "Fecha";
			this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dTFecha
			// 
			this.dTFecha.Location = new System.Drawing.Point(198, 31);
			this.dTFecha.Name = "dTFecha";
			this.dTFecha.Size = new System.Drawing.Size(180, 20);
			this.dTFecha.TabIndex = 23;
			this.dTFecha.Value = new System.DateTime(2018, 8, 4, 0, 0, 0, 0);
			// 
			// txtIdJ
			// 
			this.txtIdJ.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtIdJ.AutoSize = true;
			this.txtIdJ.Location = new System.Drawing.Point(588, 28);
			this.txtIdJ.Name = "txtIdJ";
			this.txtIdJ.Size = new System.Drawing.Size(190, 29);
			this.txtIdJ.TabIndex = 24;
			this.txtIdJ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label21
			// 
			this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label21.AutoSize = true;
			this.label21.Location = new System.Drawing.Point(393, 28);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(189, 29);
			this.label21.TabIndex = 25;
			this.label21.Text = "ID Juguetería";
			this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.dGVJuguete);
			this.groupBox4.Controls.Add(this.textBoxTotal);
			this.groupBox4.Controls.Add(this.textBoxIVA);
			this.groupBox4.Controls.Add(this.textBoxSub);
			this.groupBox4.Controls.Add(this.label19);
			this.groupBox4.Controls.Add(this.label18);
			this.groupBox4.Controls.Add(this.label16);
			this.groupBox4.Location = new System.Drawing.Point(11, 494);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(781, 155);
			this.groupBox4.TabIndex = 7;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "DETALLE";
			// 
			// dGVJuguete
			// 
			this.dGVJuguete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dGVJuguete.Location = new System.Drawing.Point(10, 16);
			this.dGVJuguete.Name = "dGVJuguete";
			this.dGVJuguete.Size = new System.Drawing.Size(762, 80);
			this.dGVJuguete.TabIndex = 19;
			this.dGVJuguete.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVJuguete_CellClick);
			this.dGVJuguete.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVJuguete_CellContentClick);
			// 
			// textBoxTotal
			// 
			this.textBoxTotal.Enabled = false;
			this.textBoxTotal.Location = new System.Drawing.Point(588, 126);
			this.textBoxTotal.Name = "textBoxTotal";
			this.textBoxTotal.Size = new System.Drawing.Size(165, 20);
			this.textBoxTotal.TabIndex = 18;
			// 
			// textBoxIVA
			// 
			this.textBoxIVA.Enabled = false;
			this.textBoxIVA.Location = new System.Drawing.Point(588, 100);
			this.textBoxIVA.Name = "textBoxIVA";
			this.textBoxIVA.Size = new System.Drawing.Size(165, 20);
			this.textBoxIVA.TabIndex = 17;
			// 
			// textBoxSub
			// 
			this.textBoxSub.Enabled = false;
			this.textBoxSub.Location = new System.Drawing.Point(198, 103);
			this.textBoxSub.Name = "textBoxSub";
			this.textBoxSub.Size = new System.Drawing.Size(165, 20);
			this.textBoxSub.TabIndex = 16;
			// 
			// label19
			// 
			this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label19.Location = new System.Drawing.Point(393, 126);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(189, 25);
			this.label19.TabIndex = 11;
			this.label19.Text = "Total";
			this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label18
			// 
			this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label18.Location = new System.Drawing.Point(390, 103);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(189, 25);
			this.label18.TabIndex = 10;
			this.label18.Text = "IVA";
			this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label16
			// 
			this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label16.Location = new System.Drawing.Point(7, 100);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(189, 25);
			this.label16.TabIndex = 9;
			this.label16.Text = "Subtotal";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnGuardar
			// 
			this.btnGuardar.Location = new System.Drawing.Point(407, 655);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(189, 25);
			this.btnGuardar.TabIndex = 8;
			this.btnGuardar.Text = "GUARDAR";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// btnLimpiarTodo
			// 
			this.btnLimpiarTodo.Location = new System.Drawing.Point(603, 655);
			this.btnLimpiarTodo.Name = "btnLimpiarTodo";
			this.btnLimpiarTodo.Size = new System.Drawing.Size(189, 25);
			this.btnLimpiarTodo.TabIndex = 9;
			this.btnLimpiarTodo.Text = "LIMPIAR TODO";
			this.btnLimpiarTodo.UseVisualStyleBackColor = true;
			this.btnLimpiarTodo.Click += new System.EventHandler(this.btnLimpiarTodo_Click);
			// 
			// frmNuevaFactura
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(989, 683);
			this.Controls.Add(this.btnLimpiarTodo);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "frmNuevaFactura";
			this.Text = "NUEVA FACTURA";
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dGVClientes)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dGVJuguete)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnBuscarCli;
        private System.Windows.Forms.Button btnLimpiarCli;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxCodCli;
        private System.Windows.Forms.TextBox textBoxCed;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxTel;
        private System.Windows.Forms.TextBox textBoxCorreo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxPre;
        private System.Windows.Forms.ComboBox comboBoxCat;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxCodArt;
        private System.Windows.Forms.TextBox textBoxNomArt;
        private System.Windows.Forms.TextBox textBoxDes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxMar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCodFac;
        private System.Windows.Forms.ComboBox comboBoxSede;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.TextBox textBoxIVA;
        private System.Windows.Forms.TextBox textBoxSub;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiarTodo;
        private System.Windows.Forms.TextBox textBoxDir;
        private System.Windows.Forms.DataGridView dGVClientes;
        private System.Windows.Forms.DataGridView dGVJuguete;
        private System.Windows.Forms.DateTimePicker dTFecha;
        private System.Windows.Forms.Label txtCat;
        private System.Windows.Forms.TextBox textBoxCan;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label txtIdJ;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnBuscarArt;
    }
}