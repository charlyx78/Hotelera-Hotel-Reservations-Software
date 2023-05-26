namespace Hotelera
{
    partial class ClientesWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientesWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservacionesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hacerReservaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel18 = new System.Windows.Forms.FlowLayoutPanel();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel20 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNuevoCliente = new System.Windows.Forms.Button();
            this.btnEditarCliente = new System.Windows.Forms.Button();
            this.btnEliminarCliente = new System.Windows.Forms.Button();
            this.flowLayoutPanel17 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel8 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.label15 = new System.Windows.Forms.Label();
            this.txtApellidoPat = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.label16 = new System.Windows.Forms.Label();
            this.txtApellidoMat = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel9 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel10 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCol = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel11 = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCiudad = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel12 = new System.Windows.Forms.FlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPais = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRfc = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel13 = new System.Windows.Forms.FlowLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel14 = new System.Windows.Forms.FlowLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCel = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtReferencia = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel15 = new System.Windows.Forms.FlowLayoutPanel();
            this.label17 = new System.Windows.Forms.Label();
            this.txtFechNac = new System.Windows.Forms.DateTimePicker();
            this.flowLayoutPanel16 = new System.Windows.Forms.FlowLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEstadoCivil = new System.Windows.Forms.ComboBox();
            this.checkOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.flowLayoutPanel18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel20.SuspendLayout();
            this.flowLayoutPanel17.SuspendLayout();
            this.flowLayoutPanel8.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
            this.flowLayoutPanel9.SuspendLayout();
            this.flowLayoutPanel10.SuspendLayout();
            this.flowLayoutPanel11.SuspendLayout();
            this.flowLayoutPanel12.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel13.SuspendLayout();
            this.flowLayoutPanel14.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel15.SuspendLayout();
            this.flowLayoutPanel16.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesMenuItem,
            this.reservacionesMenuItem,
            this.salirMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(925, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuOperativo";
            // 
            // clientesMenuItem
            // 
            this.clientesMenuItem.Name = "clientesMenuItem";
            this.clientesMenuItem.Size = new System.Drawing.Size(76, 23);
            this.clientesMenuItem.Text = "Clientes";
            this.clientesMenuItem.Click += new System.EventHandler(this.clientesMenuItem_Click);
            // 
            // reservacionesMenuItem
            // 
            this.reservacionesMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hacerReservaciónToolStripMenuItem,
            this.checkInToolStripMenuItem,
            this.checkOutToolStripMenuItem});
            this.reservacionesMenuItem.Name = "reservacionesMenuItem";
            this.reservacionesMenuItem.Size = new System.Drawing.Size(120, 23);
            this.reservacionesMenuItem.Text = "Reservaciones";
            // 
            // hacerReservaciónToolStripMenuItem
            // 
            this.hacerReservaciónToolStripMenuItem.Name = "hacerReservaciónToolStripMenuItem";
            this.hacerReservaciónToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.hacerReservaciónToolStripMenuItem.Text = "Hacer reservación";
            this.hacerReservaciónToolStripMenuItem.Click += new System.EventHandler(this.hacerReservaciónToolStripMenuItem_Click);
            // 
            // checkInToolStripMenuItem
            // 
            this.checkInToolStripMenuItem.Name = "checkInToolStripMenuItem";
            this.checkInToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.checkInToolStripMenuItem.Text = "Check In";
            this.checkInToolStripMenuItem.Click += new System.EventHandler(this.checkInToolStripMenuItem_Click);
            // 
            // salirMenuItem
            // 
            this.salirMenuItem.Name = "salirMenuItem";
            this.salirMenuItem.Size = new System.Drawing.Size(52, 23);
            this.salirMenuItem.Text = "Salir";
            this.salirMenuItem.Click += new System.EventHandler(this.salirMenuItem_Click);
            // 
            // flowLayoutPanel18
            // 
            this.flowLayoutPanel18.Controls.Add(this.dgvClientes);
            this.flowLayoutPanel18.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel18.Name = "flowLayoutPanel18";
            this.flowLayoutPanel18.Size = new System.Drawing.Size(898, 502);
            this.flowLayoutPanel18.TabIndex = 9;
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(3, 3);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(895, 497);
            this.dgvClientes.TabIndex = 1;
            this.dgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellClick);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel18);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel1);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(12, 33);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(901, 837);
            this.flowLayoutPanel2.TabIndex = 7;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel20);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel17);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 511);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(895, 322);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // flowLayoutPanel20
            // 
            this.flowLayoutPanel20.Controls.Add(this.btnNuevoCliente);
            this.flowLayoutPanel20.Controls.Add(this.btnEditarCliente);
            this.flowLayoutPanel20.Controls.Add(this.btnEliminarCliente);
            this.flowLayoutPanel20.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel20.Name = "flowLayoutPanel20";
            this.flowLayoutPanel20.Size = new System.Drawing.Size(163, 315);
            this.flowLayoutPanel20.TabIndex = 35;
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.btnNuevoCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoCliente.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNuevoCliente.Location = new System.Drawing.Point(3, 25);
            this.btnNuevoCliente.Margin = new System.Windows.Forms.Padding(3, 25, 3, 25);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(157, 34);
            this.btnNuevoCliente.TabIndex = 30;
            this.btnNuevoCliente.Text = "Nuevo";
            this.btnNuevoCliente.UseVisualStyleBackColor = false;
            this.btnNuevoCliente.Click += new System.EventHandler(this.btnNuevoCliente_Click);
            // 
            // btnEditarCliente
            // 
            this.btnEditarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.btnEditarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarCliente.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditarCliente.Location = new System.Drawing.Point(3, 87);
            this.btnEditarCliente.Margin = new System.Windows.Forms.Padding(3, 3, 3, 25);
            this.btnEditarCliente.Name = "btnEditarCliente";
            this.btnEditarCliente.Size = new System.Drawing.Size(157, 34);
            this.btnEditarCliente.TabIndex = 31;
            this.btnEditarCliente.Text = "Editar";
            this.btnEditarCliente.UseVisualStyleBackColor = false;
            this.btnEditarCliente.Click += new System.EventHandler(this.btnEditarCliente_Click);
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.btnEliminarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCliente.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminarCliente.Location = new System.Drawing.Point(3, 149);
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Size = new System.Drawing.Size(157, 34);
            this.btnEliminarCliente.TabIndex = 32;
            this.btnEliminarCliente.Text = "Eliminar";
            this.btnEliminarCliente.UseVisualStyleBackColor = false;
            this.btnEliminarCliente.Click += new System.EventHandler(this.btnEliminarCliente_Click);
            // 
            // flowLayoutPanel17
            // 
            this.flowLayoutPanel17.Controls.Add(this.flowLayoutPanel8);
            this.flowLayoutPanel17.Controls.Add(this.flowLayoutPanel6);
            this.flowLayoutPanel17.Controls.Add(this.flowLayoutPanel7);
            this.flowLayoutPanel17.Controls.Add(this.flowLayoutPanel9);
            this.flowLayoutPanel17.Controls.Add(this.flowLayoutPanel10);
            this.flowLayoutPanel17.Controls.Add(this.flowLayoutPanel11);
            this.flowLayoutPanel17.Controls.Add(this.flowLayoutPanel12);
            this.flowLayoutPanel17.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel17.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanel17.Controls.Add(this.flowLayoutPanel13);
            this.flowLayoutPanel17.Controls.Add(this.flowLayoutPanel14);
            this.flowLayoutPanel17.Controls.Add(this.flowLayoutPanel5);
            this.flowLayoutPanel17.Controls.Add(this.flowLayoutPanel15);
            this.flowLayoutPanel17.Controls.Add(this.flowLayoutPanel16);
            this.flowLayoutPanel17.Location = new System.Drawing.Point(172, 3);
            this.flowLayoutPanel17.Name = "flowLayoutPanel17";
            this.flowLayoutPanel17.Size = new System.Drawing.Size(714, 315);
            this.flowLayoutPanel17.TabIndex = 36;
            // 
            // flowLayoutPanel8
            // 
            this.flowLayoutPanel8.Controls.Add(this.label3);
            this.flowLayoutPanel8.Controls.Add(this.txtNombre);
            this.flowLayoutPanel8.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel8.Name = "flowLayoutPanel8";
            this.flowLayoutPanel8.Size = new System.Drawing.Size(232, 57);
            this.flowLayoutPanel8.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(3, 22);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(225, 29);
            this.txtNombre.TabIndex = 3;
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Controls.Add(this.label15);
            this.flowLayoutPanel6.Controls.Add(this.txtApellidoPat);
            this.flowLayoutPanel6.Location = new System.Drawing.Point(241, 3);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(232, 57);
            this.flowLayoutPanel6.TabIndex = 19;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(3, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(124, 19);
            this.label15.TabIndex = 2;
            this.label15.Text = "Apellido paterno";
            // 
            // txtApellidoPat
            // 
            this.txtApellidoPat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellidoPat.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoPat.Location = new System.Drawing.Point(3, 22);
            this.txtApellidoPat.Name = "txtApellidoPat";
            this.txtApellidoPat.Size = new System.Drawing.Size(225, 29);
            this.txtApellidoPat.TabIndex = 3;
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.Controls.Add(this.label16);
            this.flowLayoutPanel7.Controls.Add(this.txtApellidoMat);
            this.flowLayoutPanel7.Location = new System.Drawing.Point(479, 3);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(232, 57);
            this.flowLayoutPanel7.TabIndex = 20;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(3, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(129, 19);
            this.label16.TabIndex = 2;
            this.label16.Text = "Apellido materno";
            // 
            // txtApellidoMat
            // 
            this.txtApellidoMat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellidoMat.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoMat.Location = new System.Drawing.Point(3, 22);
            this.txtApellidoMat.Name = "txtApellidoMat";
            this.txtApellidoMat.Size = new System.Drawing.Size(225, 29);
            this.txtApellidoMat.TabIndex = 3;
            // 
            // flowLayoutPanel9
            // 
            this.flowLayoutPanel9.Controls.Add(this.label1);
            this.flowLayoutPanel9.Controls.Add(this.txtCalle);
            this.flowLayoutPanel9.Location = new System.Drawing.Point(3, 66);
            this.flowLayoutPanel9.Name = "flowLayoutPanel9";
            this.flowLayoutPanel9.Size = new System.Drawing.Size(232, 57);
            this.flowLayoutPanel9.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Calle";
            // 
            // txtCalle
            // 
            this.txtCalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCalle.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalle.Location = new System.Drawing.Point(3, 22);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(225, 29);
            this.txtCalle.TabIndex = 3;
            // 
            // flowLayoutPanel10
            // 
            this.flowLayoutPanel10.Controls.Add(this.label4);
            this.flowLayoutPanel10.Controls.Add(this.txtCol);
            this.flowLayoutPanel10.Location = new System.Drawing.Point(241, 66);
            this.flowLayoutPanel10.Name = "flowLayoutPanel10";
            this.flowLayoutPanel10.Size = new System.Drawing.Size(232, 57);
            this.flowLayoutPanel10.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Colonia";
            // 
            // txtCol
            // 
            this.txtCol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCol.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCol.Location = new System.Drawing.Point(3, 22);
            this.txtCol.Name = "txtCol";
            this.txtCol.Size = new System.Drawing.Size(225, 29);
            this.txtCol.TabIndex = 3;
            // 
            // flowLayoutPanel11
            // 
            this.flowLayoutPanel11.Controls.Add(this.label5);
            this.flowLayoutPanel11.Controls.Add(this.txtCiudad);
            this.flowLayoutPanel11.Location = new System.Drawing.Point(479, 66);
            this.flowLayoutPanel11.Name = "flowLayoutPanel11";
            this.flowLayoutPanel11.Size = new System.Drawing.Size(232, 57);
            this.flowLayoutPanel11.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ciudad";
            // 
            // txtCiudad
            // 
            this.txtCiudad.FormattingEnabled = true;
            this.txtCiudad.Location = new System.Drawing.Point(3, 22);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(225, 27);
            this.txtCiudad.TabIndex = 15;
            // 
            // flowLayoutPanel12
            // 
            this.flowLayoutPanel12.Controls.Add(this.label6);
            this.flowLayoutPanel12.Controls.Add(this.txtPais);
            this.flowLayoutPanel12.Location = new System.Drawing.Point(3, 129);
            this.flowLayoutPanel12.Name = "flowLayoutPanel12";
            this.flowLayoutPanel12.Size = new System.Drawing.Size(232, 57);
            this.flowLayoutPanel12.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 19);
            this.label6.TabIndex = 2;
            this.label6.Text = "País";
            // 
            // txtPais
            // 
            this.txtPais.FormattingEnabled = true;
            this.txtPais.Location = new System.Drawing.Point(3, 22);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(225, 27);
            this.txtPais.TabIndex = 15;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.label2);
            this.flowLayoutPanel3.Controls.Add(this.txtRfc);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(241, 129);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(232, 57);
            this.flowLayoutPanel3.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "RFC";
            // 
            // txtRfc
            // 
            this.txtRfc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRfc.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRfc.Location = new System.Drawing.Point(3, 22);
            this.txtRfc.Name = "txtRfc";
            this.txtRfc.Size = new System.Drawing.Size(225, 29);
            this.txtRfc.TabIndex = 4;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.label7);
            this.flowLayoutPanel4.Controls.Add(this.txtCorreo);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(479, 129);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(232, 57);
            this.flowLayoutPanel4.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 19);
            this.label7.TabIndex = 2;
            this.label7.Text = "Correo";
            // 
            // txtCorreo
            // 
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCorreo.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(3, 22);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(225, 29);
            this.txtCorreo.TabIndex = 4;
            // 
            // flowLayoutPanel13
            // 
            this.flowLayoutPanel13.Controls.Add(this.label10);
            this.flowLayoutPanel13.Controls.Add(this.txtTel);
            this.flowLayoutPanel13.Location = new System.Drawing.Point(3, 192);
            this.flowLayoutPanel13.Name = "flowLayoutPanel13";
            this.flowLayoutPanel13.Size = new System.Drawing.Size(232, 57);
            this.flowLayoutPanel13.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 19);
            this.label10.TabIndex = 2;
            this.label10.Text = "Teléfono de casa";
            // 
            // txtTel
            // 
            this.txtTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTel.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel.Location = new System.Drawing.Point(3, 22);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(225, 29);
            this.txtTel.TabIndex = 4;
            this.txtTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTel_KeyPress);
            // 
            // flowLayoutPanel14
            // 
            this.flowLayoutPanel14.Controls.Add(this.label11);
            this.flowLayoutPanel14.Controls.Add(this.txtCel);
            this.flowLayoutPanel14.Location = new System.Drawing.Point(241, 192);
            this.flowLayoutPanel14.Name = "flowLayoutPanel14";
            this.flowLayoutPanel14.Size = new System.Drawing.Size(232, 57);
            this.flowLayoutPanel14.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 19);
            this.label11.TabIndex = 2;
            this.label11.Text = "Celular";
            // 
            // txtCel
            // 
            this.txtCel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCel.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCel.Location = new System.Drawing.Point(3, 22);
            this.txtCel.Name = "txtCel";
            this.txtCel.Size = new System.Drawing.Size(225, 29);
            this.txtCel.TabIndex = 4;
            this.txtCel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCel_KeyPress);
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.label8);
            this.flowLayoutPanel5.Controls.Add(this.txtReferencia);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(479, 192);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(232, 57);
            this.flowLayoutPanel5.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 19);
            this.label8.TabIndex = 2;
            this.label8.Text = "Referencia";
            // 
            // txtReferencia
            // 
            this.txtReferencia.FormattingEnabled = true;
            this.txtReferencia.Location = new System.Drawing.Point(3, 22);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(225, 27);
            this.txtReferencia.TabIndex = 16;
            // 
            // flowLayoutPanel15
            // 
            this.flowLayoutPanel15.Controls.Add(this.label17);
            this.flowLayoutPanel15.Controls.Add(this.txtFechNac);
            this.flowLayoutPanel15.Location = new System.Drawing.Point(3, 255);
            this.flowLayoutPanel15.Name = "flowLayoutPanel15";
            this.flowLayoutPanel15.Size = new System.Drawing.Size(232, 57);
            this.flowLayoutPanel15.TabIndex = 27;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(3, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(151, 19);
            this.label17.TabIndex = 2;
            this.label17.Text = "Fecha de nacimiento";
            // 
            // txtFechNac
            // 
            this.txtFechNac.Location = new System.Drawing.Point(3, 22);
            this.txtFechNac.Name = "txtFechNac";
            this.txtFechNac.Size = new System.Drawing.Size(225, 29);
            this.txtFechNac.TabIndex = 15;
            // 
            // flowLayoutPanel16
            // 
            this.flowLayoutPanel16.Controls.Add(this.label9);
            this.flowLayoutPanel16.Controls.Add(this.txtEstadoCivil);
            this.flowLayoutPanel16.Location = new System.Drawing.Point(241, 255);
            this.flowLayoutPanel16.Name = "flowLayoutPanel16";
            this.flowLayoutPanel16.Size = new System.Drawing.Size(232, 57);
            this.flowLayoutPanel16.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 19);
            this.label9.TabIndex = 2;
            this.label9.Text = "Estado civil";
            // 
            // txtEstadoCivil
            // 
            this.txtEstadoCivil.FormattingEnabled = true;
            this.txtEstadoCivil.Location = new System.Drawing.Point(3, 22);
            this.txtEstadoCivil.Name = "txtEstadoCivil";
            this.txtEstadoCivil.Size = new System.Drawing.Size(225, 27);
            this.txtEstadoCivil.TabIndex = 16;
            // 
            // checkOutToolStripMenuItem
            // 
            this.checkOutToolStripMenuItem.Name = "checkOutToolStripMenuItem";
            this.checkOutToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.checkOutToolStripMenuItem.Text = "CheckOut";
            this.checkOutToolStripMenuItem.Click += new System.EventHandler(this.checkOutToolStripMenuItem_Click);
            // 
            // ClientesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(925, 882);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ClientesWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotelera - Clientes";
            this.Load += new System.EventHandler(this.ClientesWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.flowLayoutPanel18.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel20.ResumeLayout(false);
            this.flowLayoutPanel17.ResumeLayout(false);
            this.flowLayoutPanel8.ResumeLayout(false);
            this.flowLayoutPanel8.PerformLayout();
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            this.flowLayoutPanel7.ResumeLayout(false);
            this.flowLayoutPanel7.PerformLayout();
            this.flowLayoutPanel9.ResumeLayout(false);
            this.flowLayoutPanel9.PerformLayout();
            this.flowLayoutPanel10.ResumeLayout(false);
            this.flowLayoutPanel10.PerformLayout();
            this.flowLayoutPanel11.ResumeLayout(false);
            this.flowLayoutPanel11.PerformLayout();
            this.flowLayoutPanel12.ResumeLayout(false);
            this.flowLayoutPanel12.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel13.ResumeLayout(false);
            this.flowLayoutPanel13.PerformLayout();
            this.flowLayoutPanel14.ResumeLayout(false);
            this.flowLayoutPanel14.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.flowLayoutPanel15.ResumeLayout(false);
            this.flowLayoutPanel15.PerformLayout();
            this.flowLayoutPanel16.ResumeLayout(false);
            this.flowLayoutPanel16.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservacionesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel18;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel20;
        private System.Windows.Forms.Button btnNuevoCliente;
        private System.Windows.Forms.Button btnEditarCliente;
        private System.Windows.Forms.Button btnEliminarCliente;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel17;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtApellidoPat;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtApellidoMat;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCol;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox txtCiudad;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox txtPais;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRfc;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox txtReferencia;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker txtFechNac;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel16;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox txtEstadoCivil;
        private System.Windows.Forms.ToolStripMenuItem checkInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hacerReservaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkOutToolStripMenuItem;
    }
}