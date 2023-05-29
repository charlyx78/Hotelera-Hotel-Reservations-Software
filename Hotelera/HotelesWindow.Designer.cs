namespace Hotelera
{
    partial class HotelesWindow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HotelesWindow));
            this.menuAdministrador = new System.Windows.Forms.MenuStrip();
            this.no = new System.Windows.Forms.ToolStripMenuItem();
            this.hotelesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDeHabitaciónMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.amHabMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caractHabMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.habilitarInhabilitarUsuarioMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelarReservacionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeOcupaciónPorHotelMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeVentasMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialDeClienteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.dgvHoteles = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNuevoHot = new System.Windows.Forms.Button();
            this.btnEditarHotel = new System.Windows.Forms.Button();
            this.btnEliminarHotel = new System.Windows.Forms.Button();
            this.btnVerTiposHab = new System.Windows.Forms.Button();
            this.btnVerServAdicionales = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel8 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
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
            this.txtCantPisos = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel13 = new System.Windows.Forms.FlowLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.txtZonaTuristica = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel14 = new System.Windows.Forms.FlowLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.txtFechAp = new System.Windows.Forms.DateTimePicker();
            this.menuAdministrador.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoteles)).BeginInit();
            this.flowLayoutPanel6.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel8.SuspendLayout();
            this.flowLayoutPanel9.SuspendLayout();
            this.flowLayoutPanel10.SuspendLayout();
            this.flowLayoutPanel11.SuspendLayout();
            this.flowLayoutPanel12.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel13.SuspendLayout();
            this.flowLayoutPanel14.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuAdministrador
            // 
            this.menuAdministrador.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuAdministrador.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.no,
            this.tiposDeHabitaciónMenuItem,
            this.usuariosMenuItem,
            this.cancelarReservacionMenuItem,
            this.reportesMenuItem,
            this.salirMenuItem});
            this.menuAdministrador.Location = new System.Drawing.Point(0, 0);
            this.menuAdministrador.Name = "menuAdministrador";
            this.menuAdministrador.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuAdministrador.Size = new System.Drawing.Size(925, 29);
            this.menuAdministrador.TabIndex = 1;
            this.menuAdministrador.Text = "menuOperativo";
            // 
            // no
            // 
            this.no.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hotelesMenuItem});
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(73, 23);
            this.no.Text = "Hoteles";
            // 
            // hotelesMenuItem
            // 
            this.hotelesMenuItem.Name = "hotelesMenuItem";
            this.hotelesMenuItem.Size = new System.Drawing.Size(130, 24);
            this.hotelesMenuItem.Text = "Hoteles";
            this.hotelesMenuItem.Click += new System.EventHandler(this.hotelesMenuItem_Click);
            // 
            // tiposDeHabitaciónMenuItem
            // 
            this.tiposDeHabitaciónMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.amHabMenuItem,
            this.caractHabMenuItem});
            this.tiposDeHabitaciónMenuItem.Name = "tiposDeHabitaciónMenuItem";
            this.tiposDeHabitaciónMenuItem.Size = new System.Drawing.Size(155, 23);
            this.tiposDeHabitaciónMenuItem.Text = "Tipos de habitación";
            // 
            // amHabMenuItem
            // 
            this.amHabMenuItem.Name = "amHabMenuItem";
            this.amHabMenuItem.Size = new System.Drawing.Size(275, 24);
            this.amHabMenuItem.Text = "Amenidades de habitación";
            this.amHabMenuItem.Click += new System.EventHandler(this.amHabMenuItem_Click);
            // 
            // caractHabMenuItem
            // 
            this.caractHabMenuItem.Name = "caractHabMenuItem";
            this.caractHabMenuItem.Size = new System.Drawing.Size(275, 24);
            this.caractHabMenuItem.Text = "Características de habitación";
            this.caractHabMenuItem.Click += new System.EventHandler(this.caractHabMenuItem_Click);
            // 
            // usuariosMenuItem
            // 
            this.usuariosMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.habilitarInhabilitarUsuarioMenuItem});
            this.usuariosMenuItem.Name = "usuariosMenuItem";
            this.usuariosMenuItem.Size = new System.Drawing.Size(82, 23);
            this.usuariosMenuItem.Text = "Usuarios";
            // 
            // habilitarInhabilitarUsuarioMenuItem
            // 
            this.habilitarInhabilitarUsuarioMenuItem.Name = "habilitarInhabilitarUsuarioMenuItem";
            this.habilitarInhabilitarUsuarioMenuItem.Size = new System.Drawing.Size(269, 24);
            this.habilitarInhabilitarUsuarioMenuItem.Text = "Habilitar/Inhabilitar usuario";
            this.habilitarInhabilitarUsuarioMenuItem.Click += new System.EventHandler(this.habilitarInhabilitarUsuarioMenuItem_Click);
            // 
            // cancelarReservacionMenuItem
            // 
            this.cancelarReservacionMenuItem.Name = "cancelarReservacionMenuItem";
            this.cancelarReservacionMenuItem.Size = new System.Drawing.Size(165, 23);
            this.cancelarReservacionMenuItem.Text = "Cancelar reservación";
            this.cancelarReservacionMenuItem.Click += new System.EventHandler(this.cancelarReservacionMenuItem_Click);
            // 
            // reportesMenuItem
            // 
            this.reportesMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteDeOcupaciónPorHotelMenuItem,
            this.reporteDeVentasMenuItem,
            this.historialDeClienteMenuItem});
            this.reportesMenuItem.Name = "reportesMenuItem";
            this.reportesMenuItem.Size = new System.Drawing.Size(83, 23);
            this.reportesMenuItem.Text = "Reportes";
            // 
            // reporteDeOcupaciónPorHotelMenuItem
            // 
            this.reporteDeOcupaciónPorHotelMenuItem.Name = "reporteDeOcupaciónPorHotelMenuItem";
            this.reporteDeOcupaciónPorHotelMenuItem.Size = new System.Drawing.Size(296, 24);
            this.reporteDeOcupaciónPorHotelMenuItem.Text = "Reporte de ocupación por hotel";
            this.reporteDeOcupaciónPorHotelMenuItem.Click += new System.EventHandler(this.reporteDeOcupaciónPorHotelMenuItem_Click);
            // 
            // reporteDeVentasMenuItem
            // 
            this.reporteDeVentasMenuItem.Name = "reporteDeVentasMenuItem";
            this.reporteDeVentasMenuItem.Size = new System.Drawing.Size(296, 24);
            this.reporteDeVentasMenuItem.Text = "Reporte de ventas";
            this.reporteDeVentasMenuItem.Click += new System.EventHandler(this.reporteDeVentasMenuItem_Click);
            // 
            // historialDeClienteMenuItem
            // 
            this.historialDeClienteMenuItem.Name = "historialDeClienteMenuItem";
            this.historialDeClienteMenuItem.Size = new System.Drawing.Size(296, 24);
            this.historialDeClienteMenuItem.Text = "Historial de cliente";
            this.historialDeClienteMenuItem.Click += new System.EventHandler(this.historialDeClienteMenuItem_Click);
            // 
            // salirMenuItem
            // 
            this.salirMenuItem.Name = "salirMenuItem";
            this.salirMenuItem.Size = new System.Drawing.Size(52, 23);
            this.salirMenuItem.Text = "Salir";
            this.salirMenuItem.Click += new System.EventHandler(this.salirMenuItem_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.dgvHoteles);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel6);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(12, 35);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(900, 842);
            this.flowLayoutPanel2.TabIndex = 8;
            // 
            // dgvHoteles
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHoteles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHoteles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHoteles.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHoteles.Location = new System.Drawing.Point(3, 3);
            this.dgvHoteles.Name = "dgvHoteles";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHoteles.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHoteles.Size = new System.Drawing.Size(897, 300);
            this.dgvHoteles.TabIndex = 1;
            this.dgvHoteles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoteles_CellClick);
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Controls.Add(this.flowLayoutPanel7);
            this.flowLayoutPanel6.Controls.Add(this.flowLayoutPanel1);
            this.flowLayoutPanel6.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel6.Location = new System.Drawing.Point(3, 309);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(898, 333);
            this.flowLayoutPanel6.TabIndex = 8;
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.Controls.Add(this.btnNuevoHot);
            this.flowLayoutPanel7.Controls.Add(this.btnEditarHotel);
            this.flowLayoutPanel7.Controls.Add(this.btnEliminarHotel);
            this.flowLayoutPanel7.Controls.Add(this.btnVerTiposHab);
            this.flowLayoutPanel7.Controls.Add(this.btnVerServAdicionales);
            this.flowLayoutPanel7.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(163, 327);
            this.flowLayoutPanel7.TabIndex = 34;
            // 
            // btnNuevoHot
            // 
            this.btnNuevoHot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.btnNuevoHot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoHot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoHot.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoHot.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNuevoHot.Location = new System.Drawing.Point(3, 25);
            this.btnNuevoHot.Margin = new System.Windows.Forms.Padding(3, 25, 3, 25);
            this.btnNuevoHot.Name = "btnNuevoHot";
            this.btnNuevoHot.Size = new System.Drawing.Size(157, 34);
            this.btnNuevoHot.TabIndex = 34;
            this.btnNuevoHot.Text = "Nuevo";
            this.btnNuevoHot.UseVisualStyleBackColor = false;
            this.btnNuevoHot.Click += new System.EventHandler(this.btnNuevoHot_Click);
            // 
            // btnEditarHotel
            // 
            this.btnEditarHotel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.btnEditarHotel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarHotel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarHotel.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarHotel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditarHotel.Location = new System.Drawing.Point(3, 87);
            this.btnEditarHotel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 25);
            this.btnEditarHotel.Name = "btnEditarHotel";
            this.btnEditarHotel.Size = new System.Drawing.Size(157, 34);
            this.btnEditarHotel.TabIndex = 31;
            this.btnEditarHotel.Text = "Editar";
            this.btnEditarHotel.UseVisualStyleBackColor = false;
            this.btnEditarHotel.Click += new System.EventHandler(this.btnEditarHotel_Click);
            // 
            // btnEliminarHotel
            // 
            this.btnEliminarHotel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.btnEliminarHotel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarHotel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarHotel.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarHotel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminarHotel.Location = new System.Drawing.Point(3, 149);
            this.btnEliminarHotel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 25);
            this.btnEliminarHotel.Name = "btnEliminarHotel";
            this.btnEliminarHotel.Size = new System.Drawing.Size(157, 34);
            this.btnEliminarHotel.TabIndex = 32;
            this.btnEliminarHotel.Text = "Eliminar";
            this.btnEliminarHotel.UseVisualStyleBackColor = false;
            this.btnEliminarHotel.Click += new System.EventHandler(this.btnEliminarHotel_Click);
            // 
            // btnVerTiposHab
            // 
            this.btnVerTiposHab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.btnVerTiposHab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerTiposHab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerTiposHab.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerTiposHab.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVerTiposHab.Location = new System.Drawing.Point(3, 211);
            this.btnVerTiposHab.Margin = new System.Windows.Forms.Padding(3, 3, 3, 25);
            this.btnVerTiposHab.Name = "btnVerTiposHab";
            this.btnVerTiposHab.Size = new System.Drawing.Size(157, 34);
            this.btnVerTiposHab.TabIndex = 33;
            this.btnVerTiposHab.Text = "Ver habitaciones";
            this.btnVerTiposHab.UseVisualStyleBackColor = false;
            this.btnVerTiposHab.Click += new System.EventHandler(this.btnVerTiposHab_Click);
            // 
            // btnVerServAdicionales
            // 
            this.btnVerServAdicionales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.btnVerServAdicionales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerServAdicionales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerServAdicionales.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerServAdicionales.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVerServAdicionales.Location = new System.Drawing.Point(3, 273);
            this.btnVerServAdicionales.Margin = new System.Windows.Forms.Padding(3, 3, 3, 25);
            this.btnVerServAdicionales.Name = "btnVerServAdicionales";
            this.btnVerServAdicionales.Size = new System.Drawing.Size(157, 50);
            this.btnVerServAdicionales.TabIndex = 35;
            this.btnVerServAdicionales.Text = "Ver servicios adicionales";
            this.btnVerServAdicionales.UseVisualStyleBackColor = false;
            this.btnVerServAdicionales.Click += new System.EventHandler(this.btnVerServAdicionales_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel8);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel9);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel10);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel11);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel12);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel13);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel14);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(172, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(725, 327);
            this.flowLayoutPanel1.TabIndex = 6;
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
            // flowLayoutPanel9
            // 
            this.flowLayoutPanel9.Controls.Add(this.label1);
            this.flowLayoutPanel9.Controls.Add(this.txtCalle);
            this.flowLayoutPanel9.Location = new System.Drawing.Point(241, 3);
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
            this.flowLayoutPanel10.Location = new System.Drawing.Point(479, 3);
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
            this.flowLayoutPanel11.Location = new System.Drawing.Point(3, 66);
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
            this.txtCiudad.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.flowLayoutPanel12.Location = new System.Drawing.Point(241, 66);
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
            this.txtPais.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPais.FormattingEnabled = true;
            this.txtPais.Location = new System.Drawing.Point(3, 22);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(225, 27);
            this.txtPais.TabIndex = 15;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.label2);
            this.flowLayoutPanel3.Controls.Add(this.txtCantPisos);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(479, 66);
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
            this.label2.Size = new System.Drawing.Size(132, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantidad de pisos";
            // 
            // txtCantPisos
            // 
            this.txtCantPisos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantPisos.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantPisos.Location = new System.Drawing.Point(3, 22);
            this.txtCantPisos.Name = "txtCantPisos";
            this.txtCantPisos.Size = new System.Drawing.Size(225, 29);
            this.txtCantPisos.TabIndex = 4;
            this.txtCantPisos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantPisos_KeyPress);
            // 
            // flowLayoutPanel13
            // 
            this.flowLayoutPanel13.Controls.Add(this.label10);
            this.flowLayoutPanel13.Controls.Add(this.txtZonaTuristica);
            this.flowLayoutPanel13.Location = new System.Drawing.Point(3, 129);
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
            this.label10.Size = new System.Drawing.Size(103, 19);
            this.label10.TabIndex = 2;
            this.label10.Text = "Zona turística";
            // 
            // txtZonaTuristica
            // 
            this.txtZonaTuristica.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZonaTuristica.FormattingEnabled = true;
            this.txtZonaTuristica.Location = new System.Drawing.Point(3, 22);
            this.txtZonaTuristica.Name = "txtZonaTuristica";
            this.txtZonaTuristica.Size = new System.Drawing.Size(225, 27);
            this.txtZonaTuristica.TabIndex = 16;
            // 
            // flowLayoutPanel14
            // 
            this.flowLayoutPanel14.Controls.Add(this.label11);
            this.flowLayoutPanel14.Controls.Add(this.txtFechAp);
            this.flowLayoutPanel14.Location = new System.Drawing.Point(241, 129);
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
            this.label11.Size = new System.Drawing.Size(133, 19);
            this.label11.TabIndex = 2;
            this.label11.Text = "Fecha de apertura";
            // 
            // txtFechAp
            // 
            this.txtFechAp.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechAp.Location = new System.Drawing.Point(3, 22);
            this.txtFechAp.Name = "txtFechAp";
            this.txtFechAp.Size = new System.Drawing.Size(225, 29);
            this.txtFechAp.TabIndex = 16;
            // 
            // HotelesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(925, 889);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.menuAdministrador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HotelesWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotelera - Hoteles";
            this.Load += new System.EventHandler(this.HotelesWindow_Load);
            this.menuAdministrador.ResumeLayout(false);
            this.menuAdministrador.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoteles)).EndInit();
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel7.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel8.ResumeLayout(false);
            this.flowLayoutPanel8.PerformLayout();
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
            this.flowLayoutPanel13.ResumeLayout(false);
            this.flowLayoutPanel13.PerformLayout();
            this.flowLayoutPanel14.ResumeLayout(false);
            this.flowLayoutPanel14.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuAdministrador;
        private System.Windows.Forms.ToolStripMenuItem no;
        private System.Windows.Forms.ToolStripMenuItem usuariosMenuItem;
        private System.Windows.Forms.ToolStripMenuItem habilitarInhabilitarUsuarioMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelarReservacionMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeOcupaciónPorHotelMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeVentasMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialDeClienteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.DataGridView dgvHoteles;
        private System.Windows.Forms.ToolStripMenuItem tiposDeHabitaciónMenuItem;
        private System.Windows.Forms.ToolStripMenuItem amHabMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caractHabMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
        private System.Windows.Forms.Button btnEditarHotel;
        private System.Windows.Forms.Button btnEliminarHotel;
        private System.Windows.Forms.Button btnVerTiposHab;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
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
        private System.Windows.Forms.TextBox txtCantPisos;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker txtFechAp;
        private System.Windows.Forms.ComboBox txtZonaTuristica;
        private System.Windows.Forms.Button btnNuevoHot;
        private System.Windows.Forms.ToolStripMenuItem hotelesMenuItem;
        private System.Windows.Forms.Button btnVerServAdicionales;
    }
}