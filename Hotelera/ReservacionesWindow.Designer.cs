namespace Hotelera
{
    partial class ReservacionesWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservacionesWindow));
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel12 = new System.Windows.Forms.FlowLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFechLlegada = new System.Windows.Forms.DateTimePicker();
            this.flowLayoutPanel8 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFechSalida = new System.Windows.Forms.DateTimePicker();
            this.btnContinuarReserv = new System.Windows.Forms.Button();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.btnBusqCorreo = new System.Windows.Forms.Button();
            this.btnBusqAp = new System.Windows.Forms.Button();
            this.btnBusqRFC = new System.Windows.Forms.Button();
            this.lbClientes = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCiudad = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtHotel = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel10 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.flowLayoutPanel11 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label13 = new System.Windows.Forms.Label();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.dgvHabitaciones = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCantHabs = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel9 = new System.Windows.Forms.FlowLayoutPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCantPersonas = new System.Windows.Forms.TextBox();
            this.btnVerHabsAgg = new System.Windows.Forms.Button();
            this.btnAggHab = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel14 = new System.Windows.Forms.FlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel13 = new System.Windows.Forms.FlowLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAnticipo = new System.Windows.Forms.TextBox();
            this.txtTipoPagoAnticipo = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel12.SuspendLayout();
            this.flowLayoutPanel8.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel10.SuspendLayout();
            this.flowLayoutPanel11.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitaciones)).BeginInit();
            this.flowLayoutPanel7.SuspendLayout();
            this.flowLayoutPanel9.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel14.SuspendLayout();
            this.flowLayoutPanel13.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.BackColor = System.Drawing.SystemColors.Window;
            this.flowLayoutPanel5.Controls.Add(this.flowLayoutPanel12);
            this.flowLayoutPanel5.Controls.Add(this.flowLayoutPanel8);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(3, 354);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Padding = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel5.Size = new System.Drawing.Size(500, 129);
            this.flowLayoutPanel5.TabIndex = 37;
            // 
            // flowLayoutPanel12
            // 
            this.flowLayoutPanel12.Controls.Add(this.label7);
            this.flowLayoutPanel12.Controls.Add(this.txtFechLlegada);
            this.flowLayoutPanel12.Location = new System.Drawing.Point(5, 5);
            this.flowLayoutPanel12.Name = "flowLayoutPanel12";
            this.flowLayoutPanel12.Size = new System.Drawing.Size(484, 57);
            this.flowLayoutPanel12.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 19);
            this.label7.TabIndex = 2;
            this.label7.Text = "Desde";
            // 
            // txtFechLlegada
            // 
            this.txtFechLlegada.Location = new System.Drawing.Point(3, 22);
            this.txtFechLlegada.Name = "txtFechLlegada";
            this.txtFechLlegada.Size = new System.Drawing.Size(481, 29);
            this.txtFechLlegada.TabIndex = 16;
            this.txtFechLlegada.ValueChanged += new System.EventHandler(this.txtFechLlegada_ValueChanged);
            // 
            // flowLayoutPanel8
            // 
            this.flowLayoutPanel8.Controls.Add(this.label4);
            this.flowLayoutPanel8.Controls.Add(this.txtFechSalida);
            this.flowLayoutPanel8.Location = new System.Drawing.Point(5, 68);
            this.flowLayoutPanel8.Name = "flowLayoutPanel8";
            this.flowLayoutPanel8.Size = new System.Drawing.Size(484, 57);
            this.flowLayoutPanel8.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Hasta";
            // 
            // txtFechSalida
            // 
            this.txtFechSalida.Location = new System.Drawing.Point(3, 22);
            this.txtFechSalida.Name = "txtFechSalida";
            this.txtFechSalida.Size = new System.Drawing.Size(481, 29);
            this.txtFechSalida.TabIndex = 16;
            this.txtFechSalida.ValueChanged += new System.EventHandler(this.txtFechSalida_ValueChanged);
            // 
            // btnContinuarReserv
            // 
            this.btnContinuarReserv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.btnContinuarReserv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContinuarReserv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinuarReserv.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinuarReserv.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnContinuarReserv.Location = new System.Drawing.Point(3, 603);
            this.btnContinuarReserv.Name = "btnContinuarReserv";
            this.btnContinuarReserv.Size = new System.Drawing.Size(1454, 40);
            this.btnContinuarReserv.TabIndex = 36;
            this.btnContinuarReserv.Text = "Continuar";
            this.btnContinuarReserv.UseVisualStyleBackColor = false;
            this.btnContinuarReserv.Click += new System.EventHandler(this.btnContinuarReserv_Click);
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.BackColor = System.Drawing.SystemColors.Window;
            this.flowLayoutPanel4.Controls.Add(this.label1);
            this.flowLayoutPanel4.Controls.Add(this.txtCliente);
            this.flowLayoutPanel4.Controls.Add(this.btnBusqCorreo);
            this.flowLayoutPanel4.Controls.Add(this.btnBusqAp);
            this.flowLayoutPanel4.Controls.Add(this.btnBusqRFC);
            this.flowLayoutPanel4.Controls.Add(this.lbClientes);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 22);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Padding = new System.Windows.Forms.Padding(3);
            this.flowLayoutPanel4.Size = new System.Drawing.Size(500, 167);
            this.flowLayoutPanel4.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cliente";
            // 
            // txtCliente
            // 
            this.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCliente.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(6, 25);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(485, 29);
            this.txtCliente.TabIndex = 34;
            // 
            // btnBusqCorreo
            // 
            this.btnBusqCorreo.BackColor = System.Drawing.Color.DarkGray;
            this.btnBusqCorreo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBusqCorreo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusqCorreo.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusqCorreo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBusqCorreo.Location = new System.Drawing.Point(6, 60);
            this.btnBusqCorreo.Name = "btnBusqCorreo";
            this.btnBusqCorreo.Size = new System.Drawing.Size(153, 51);
            this.btnBusqCorreo.TabIndex = 33;
            this.btnBusqCorreo.Text = "Buscar por correo";
            this.btnBusqCorreo.UseVisualStyleBackColor = false;
            this.btnBusqCorreo.Click += new System.EventHandler(this.btnBusqCorreo_Click);
            // 
            // btnBusqAp
            // 
            this.btnBusqAp.BackColor = System.Drawing.Color.DarkGray;
            this.btnBusqAp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBusqAp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusqAp.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusqAp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBusqAp.Location = new System.Drawing.Point(165, 60);
            this.btnBusqAp.Name = "btnBusqAp";
            this.btnBusqAp.Size = new System.Drawing.Size(152, 51);
            this.btnBusqAp.TabIndex = 31;
            this.btnBusqAp.Text = "Buscar por apellidos";
            this.btnBusqAp.UseVisualStyleBackColor = false;
            this.btnBusqAp.Click += new System.EventHandler(this.btnBusqAp_Click);
            // 
            // btnBusqRFC
            // 
            this.btnBusqRFC.BackColor = System.Drawing.Color.DarkGray;
            this.btnBusqRFC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBusqRFC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusqRFC.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusqRFC.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBusqRFC.Location = new System.Drawing.Point(323, 60);
            this.btnBusqRFC.Name = "btnBusqRFC";
            this.btnBusqRFC.Size = new System.Drawing.Size(168, 51);
            this.btnBusqRFC.TabIndex = 32;
            this.btnBusqRFC.Text = "Buscar por RFC";
            this.btnBusqRFC.UseVisualStyleBackColor = false;
            this.btnBusqRFC.Click += new System.EventHandler(this.btnBusqRFC_Click);
            // 
            // lbClientes
            // 
            this.lbClientes.FormattingEnabled = true;
            this.lbClientes.ItemHeight = 19;
            this.lbClientes.Location = new System.Drawing.Point(6, 117);
            this.lbClientes.Name = "lbClientes";
            this.lbClientes.Size = new System.Drawing.Size(485, 42);
            this.lbClientes.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.SystemColors.Window;
            this.flowLayoutPanel2.Controls.Add(this.label8);
            this.flowLayoutPanel2.Controls.Add(this.txtCiudad);
            this.flowLayoutPanel2.Controls.Add(this.label9);
            this.flowLayoutPanel2.Controls.Add(this.txtHotel);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 214);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(3);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(500, 115);
            this.flowLayoutPanel2.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 19);
            this.label8.TabIndex = 2;
            this.label8.Text = "Ciudad";
            // 
            // txtCiudad
            // 
            this.txtCiudad.FormattingEnabled = true;
            this.txtCiudad.Location = new System.Drawing.Point(6, 25);
            this.txtCiudad.Margin = new System.Windows.Forms.Padding(3, 3, 3, 7);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(483, 27);
            this.txtCiudad.TabIndex = 17;
            this.txtCiudad.SelectedIndexChanged += new System.EventHandler(this.txtCiudad_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 19);
            this.label9.TabIndex = 18;
            this.label9.Text = "Hotel";
            // 
            // txtHotel
            // 
            this.txtHotel.FormattingEnabled = true;
            this.txtHotel.Location = new System.Drawing.Point(6, 81);
            this.txtHotel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 7);
            this.txtHotel.Name = "txtHotel";
            this.txtHotel.Size = new System.Drawing.Size(483, 27);
            this.txtHotel.TabIndex = 15;
            this.txtHotel.SelectedIndexChanged += new System.EventHandler(this.txtCiudad_SelectedIndexChanged_1);
            // 
            // flowLayoutPanel10
            // 
            this.flowLayoutPanel10.Controls.Add(this.label3);
            this.flowLayoutPanel10.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanel10.Controls.Add(this.label5);
            this.flowLayoutPanel10.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel10.Controls.Add(this.label14);
            this.flowLayoutPanel10.Controls.Add(this.flowLayoutPanel5);
            this.flowLayoutPanel10.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel10.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel10.Name = "flowLayoutPanel10";
            this.flowLayoutPanel10.Size = new System.Drawing.Size(507, 491);
            this.flowLayoutPanel10.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 19);
            this.label3.TabIndex = 43;
            this.label3.Text = "Selecciona un cliente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 19);
            this.label5.TabIndex = 44;
            this.label5.Text = "Selecciona un hotel";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(3, 332);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(240, 19);
            this.label14.TabIndex = 45;
            this.label14.Text = "Selecciona un rango de fechas";
            // 
            // flowLayoutPanel11
            // 
            this.flowLayoutPanel11.Controls.Add(this.flowLayoutPanel10);
            this.flowLayoutPanel11.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel11.Controls.Add(this.label2);
            this.flowLayoutPanel11.Controls.Add(this.flowLayoutPanel1);
            this.flowLayoutPanel11.Controls.Add(this.btnContinuarReserv);
            this.flowLayoutPanel11.Location = new System.Drawing.Point(12, 32);
            this.flowLayoutPanel11.Name = "flowLayoutPanel11";
            this.flowLayoutPanel11.Size = new System.Drawing.Size(1460, 651);
            this.flowLayoutPanel11.TabIndex = 43;
            this.flowLayoutPanel11.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel11_Paint);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel3.Controls.Add(this.label13);
            this.flowLayoutPanel3.Controls.Add(this.flowLayoutPanel6);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(516, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(941, 491);
            this.flowLayoutPanel3.TabIndex = 45;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(289, 19);
            this.label13.TabIndex = 45;
            this.label13.Text = "Selecciona una o varias habitaciones";
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.BackColor = System.Drawing.SystemColors.Window;
            this.flowLayoutPanel6.Controls.Add(this.dgvHabitaciones);
            this.flowLayoutPanel6.Controls.Add(this.flowLayoutPanel7);
            this.flowLayoutPanel6.Controls.Add(this.flowLayoutPanel9);
            this.flowLayoutPanel6.Controls.Add(this.btnVerHabsAgg);
            this.flowLayoutPanel6.Controls.Add(this.btnAggHab);
            this.flowLayoutPanel6.Location = new System.Drawing.Point(3, 22);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Padding = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel6.Size = new System.Drawing.Size(938, 461);
            this.flowLayoutPanel6.TabIndex = 48;
            // 
            // dgvHabitaciones
            // 
            this.dgvHabitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHabitaciones.Location = new System.Drawing.Point(6, 6);
            this.dgvHabitaciones.Margin = new System.Windows.Forms.Padding(4);
            this.dgvHabitaciones.Name = "dgvHabitaciones";
            this.dgvHabitaciones.Size = new System.Drawing.Size(927, 340);
            this.dgvHabitaciones.TabIndex = 47;
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.Controls.Add(this.label11);
            this.flowLayoutPanel7.Controls.Add(this.txtCantHabs);
            this.flowLayoutPanel7.Location = new System.Drawing.Point(5, 353);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(456, 57);
            this.flowLayoutPanel7.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(183, 19);
            this.label11.TabIndex = 0;
            this.label11.Text = "Cantidad de habitaciones";
            // 
            // txtCantHabs
            // 
            this.txtCantHabs.Location = new System.Drawing.Point(3, 22);
            this.txtCantHabs.Name = "txtCantHabs";
            this.txtCantHabs.Size = new System.Drawing.Size(453, 29);
            this.txtCantHabs.TabIndex = 1;
            // 
            // flowLayoutPanel9
            // 
            this.flowLayoutPanel9.Controls.Add(this.label12);
            this.flowLayoutPanel9.Controls.Add(this.txtCantPersonas);
            this.flowLayoutPanel9.Location = new System.Drawing.Point(467, 353);
            this.flowLayoutPanel9.Name = "flowLayoutPanel9";
            this.flowLayoutPanel9.Size = new System.Drawing.Size(466, 57);
            this.flowLayoutPanel9.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(159, 19);
            this.label12.TabIndex = 2;
            this.label12.Text = "Cantidad de personas";
            // 
            // txtCantPersonas
            // 
            this.txtCantPersonas.Location = new System.Drawing.Point(3, 22);
            this.txtCantPersonas.Name = "txtCantPersonas";
            this.txtCantPersonas.Size = new System.Drawing.Size(463, 29);
            this.txtCantPersonas.TabIndex = 3;
            // 
            // btnVerHabsAgg
            // 
            this.btnVerHabsAgg.BackColor = System.Drawing.Color.DarkGray;
            this.btnVerHabsAgg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerHabsAgg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerHabsAgg.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerHabsAgg.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVerHabsAgg.Location = new System.Drawing.Point(5, 416);
            this.btnVerHabsAgg.Name = "btnVerHabsAgg";
            this.btnVerHabsAgg.Size = new System.Drawing.Size(456, 40);
            this.btnVerHabsAgg.TabIndex = 56;
            this.btnVerHabsAgg.Text = "Ver habitaciones agregadas";
            this.btnVerHabsAgg.UseVisualStyleBackColor = false;
            this.btnVerHabsAgg.Click += new System.EventHandler(this.btnVerHabsAgg_Click);
            // 
            // btnAggHab
            // 
            this.btnAggHab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.btnAggHab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAggHab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAggHab.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAggHab.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAggHab.Location = new System.Drawing.Point(467, 416);
            this.btnAggHab.Name = "btnAggHab";
            this.btnAggHab.Size = new System.Drawing.Size(466, 40);
            this.btnAggHab.TabIndex = 55;
            this.btnAggHab.Text = "Agregar habitacion a la reservacion";
            this.btnAggHab.UseVisualStyleBackColor = false;
            this.btnAggHab.Click += new System.EventHandler(this.btnAggHab_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 497);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Pago de la reservación";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Window;
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel14);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel13);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 519);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1454, 71);
            this.flowLayoutPanel1.TabIndex = 54;
            // 
            // flowLayoutPanel14
            // 
            this.flowLayoutPanel14.Controls.Add(this.label6);
            this.flowLayoutPanel14.Controls.Add(this.txtTotal);
            this.flowLayoutPanel14.Location = new System.Drawing.Point(4, 4);
            this.flowLayoutPanel14.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel14.Name = "flowLayoutPanel14";
            this.flowLayoutPanel14.Size = new System.Drawing.Size(720, 63);
            this.flowLayoutPanel14.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 19);
            this.label6.TabIndex = 3;
            this.label6.Text = "Monto total a pagar";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(3, 22);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(717, 29);
            this.txtTotal.TabIndex = 49;
            // 
            // flowLayoutPanel13
            // 
            this.flowLayoutPanel13.Controls.Add(this.label10);
            this.flowLayoutPanel13.Controls.Add(this.txtAnticipo);
            this.flowLayoutPanel13.Controls.Add(this.txtTipoPagoAnticipo);
            this.flowLayoutPanel13.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel13.Location = new System.Drawing.Point(732, 4);
            this.flowLayoutPanel13.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel13.Name = "flowLayoutPanel13";
            this.flowLayoutPanel13.Size = new System.Drawing.Size(715, 63);
            this.flowLayoutPanel13.TabIndex = 51;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(4, 0);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 19);
            this.label10.TabIndex = 3;
            this.label10.Text = "Monto de anticipo";
            // 
            // txtAnticipo
            // 
            this.txtAnticipo.Location = new System.Drawing.Point(3, 22);
            this.txtAnticipo.Name = "txtAnticipo";
            this.txtAnticipo.Size = new System.Drawing.Size(509, 29);
            this.txtAnticipo.TabIndex = 49;
            // 
            // txtTipoPagoAnticipo
            // 
            this.txtTipoPagoAnticipo.FormattingEnabled = true;
            this.txtTipoPagoAnticipo.Location = new System.Drawing.Point(518, 23);
            this.txtTipoPagoAnticipo.Margin = new System.Windows.Forms.Padding(3, 23, 3, 3);
            this.txtTipoPagoAnticipo.Name = "txtTipoPagoAnticipo";
            this.txtTipoPagoAnticipo.Size = new System.Drawing.Size(197, 27);
            this.txtTipoPagoAnticipo.TabIndex = 50;
            // 
            // ReservacionesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1484, 691);
            this.Controls.Add(this.flowLayoutPanel11);
            this.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReservacionesWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotelera - Reservaciones";
            this.Load += new System.EventHandler(this.ReservacionesWindow_Load);
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel12.ResumeLayout(false);
            this.flowLayoutPanel12.PerformLayout();
            this.flowLayoutPanel8.ResumeLayout(false);
            this.flowLayoutPanel8.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel10.ResumeLayout(false);
            this.flowLayoutPanel10.PerformLayout();
            this.flowLayoutPanel11.ResumeLayout(false);
            this.flowLayoutPanel11.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitaciones)).EndInit();
            this.flowLayoutPanel7.ResumeLayout(false);
            this.flowLayoutPanel7.PerformLayout();
            this.flowLayoutPanel9.ResumeLayout(false);
            this.flowLayoutPanel9.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel14.ResumeLayout(false);
            this.flowLayoutPanel14.PerformLayout();
            this.flowLayoutPanel13.ResumeLayout(false);
            this.flowLayoutPanel13.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker txtFechLlegada;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbClientes;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox txtHotel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker txtFechSalida;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel10;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel11;
        private System.Windows.Forms.Button btnContinuarReserv;
        private System.Windows.Forms.Button btnBusqCorreo;
        private System.Windows.Forms.Button btnBusqAp;
        private System.Windows.Forms.Button btnBusqRFC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox txtCiudad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.DataGridView dgvHabitaciones;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel14;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAnticipo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCantHabs;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCantPersonas;
        private System.Windows.Forms.Button btnVerHabsAgg;
        private System.Windows.Forms.Button btnAggHab;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox txtTipoPagoAnticipo;
        private System.Windows.Forms.Label label14;
    }
}