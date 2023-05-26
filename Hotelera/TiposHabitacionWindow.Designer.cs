namespace Hotelera
{
    partial class TiposHabitacionWindow
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
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.dgvTiposHab = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNuevoTipoHab = new System.Windows.Forms.Button();
            this.btnEditarTipoHab = new System.Windows.Forms.Button();
            this.btnEliminarTipoHab = new System.Windows.Forms.Button();
            this.btnVerAmen = new System.Windows.Forms.Button();
            this.btnVerCaract = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel8 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.label15 = new System.Windows.Forms.Label();
            this.txtCantCamas = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.label16 = new System.Windows.Forms.Label();
            this.txtTipoCama = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel9 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCostoPersona = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel10 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCapPersonas = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel11 = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNivelHab = new System.Windows.Forms.ComboBox();
            this.menuAdministrador = new System.Windows.Forms.MenuStrip();
            this.no = new System.Windows.Forms.ToolStripMenuItem();
            this.hotelesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviciosAdicionalesDeHotelMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDeHabitaciónMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposHabMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiposHab)).BeginInit();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel8.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
            this.flowLayoutPanel9.SuspendLayout();
            this.flowLayoutPanel10.SuspendLayout();
            this.flowLayoutPanel11.SuspendLayout();
            this.menuAdministrador.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.dgvTiposHab);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(12, 35);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(901, 833);
            this.flowLayoutPanel2.TabIndex = 8;
            // 
            // dgvTiposHab
            // 
            this.dgvTiposHab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTiposHab.Location = new System.Drawing.Point(3, 3);
            this.dgvTiposHab.Name = "dgvTiposHab";
            this.dgvTiposHab.Size = new System.Drawing.Size(898, 513);
            this.dgvTiposHab.TabIndex = 1;
            this.dgvTiposHab.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTiposHab_CellClick);
            this.dgvTiposHab.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvTiposHab_CellFormatting);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanel3.Controls.Add(this.flowLayoutPanel1);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 522);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(898, 311);
            this.flowLayoutPanel3.TabIndex = 8;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.btnNuevoTipoHab);
            this.flowLayoutPanel4.Controls.Add(this.btnEditarTipoHab);
            this.flowLayoutPanel4.Controls.Add(this.btnEliminarTipoHab);
            this.flowLayoutPanel4.Controls.Add(this.btnVerAmen);
            this.flowLayoutPanel4.Controls.Add(this.btnVerCaract);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(165, 308);
            this.flowLayoutPanel4.TabIndex = 9;
            // 
            // btnNuevoTipoHab
            // 
            this.btnNuevoTipoHab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.btnNuevoTipoHab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoTipoHab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoTipoHab.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoTipoHab.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNuevoTipoHab.Location = new System.Drawing.Point(3, 25);
            this.btnNuevoTipoHab.Margin = new System.Windows.Forms.Padding(3, 25, 3, 25);
            this.btnNuevoTipoHab.Name = "btnNuevoTipoHab";
            this.btnNuevoTipoHab.Size = new System.Drawing.Size(157, 34);
            this.btnNuevoTipoHab.TabIndex = 30;
            this.btnNuevoTipoHab.Text = "Nuevo";
            this.btnNuevoTipoHab.UseVisualStyleBackColor = false;
            this.btnNuevoTipoHab.Click += new System.EventHandler(this.btnNuevoTipoHab_Click);
            // 
            // btnEditarTipoHab
            // 
            this.btnEditarTipoHab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.btnEditarTipoHab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarTipoHab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarTipoHab.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarTipoHab.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditarTipoHab.Location = new System.Drawing.Point(3, 87);
            this.btnEditarTipoHab.Margin = new System.Windows.Forms.Padding(3, 3, 3, 25);
            this.btnEditarTipoHab.Name = "btnEditarTipoHab";
            this.btnEditarTipoHab.Size = new System.Drawing.Size(157, 34);
            this.btnEditarTipoHab.TabIndex = 31;
            this.btnEditarTipoHab.Text = "Editar";
            this.btnEditarTipoHab.UseVisualStyleBackColor = false;
            this.btnEditarTipoHab.Click += new System.EventHandler(this.btnEditarTipoHab_Click);
            // 
            // btnEliminarTipoHab
            // 
            this.btnEliminarTipoHab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.btnEliminarTipoHab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarTipoHab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarTipoHab.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarTipoHab.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminarTipoHab.Location = new System.Drawing.Point(3, 149);
            this.btnEliminarTipoHab.Margin = new System.Windows.Forms.Padding(3, 3, 3, 25);
            this.btnEliminarTipoHab.Name = "btnEliminarTipoHab";
            this.btnEliminarTipoHab.Size = new System.Drawing.Size(157, 34);
            this.btnEliminarTipoHab.TabIndex = 32;
            this.btnEliminarTipoHab.Text = "Eliminar";
            this.btnEliminarTipoHab.UseVisualStyleBackColor = false;
            this.btnEliminarTipoHab.Click += new System.EventHandler(this.btnEliminarTipoHab_Click);
            // 
            // btnVerAmen
            // 
            this.btnVerAmen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.btnVerAmen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerAmen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerAmen.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerAmen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVerAmen.Location = new System.Drawing.Point(3, 211);
            this.btnVerAmen.Margin = new System.Windows.Forms.Padding(3, 3, 3, 25);
            this.btnVerAmen.Name = "btnVerAmen";
            this.btnVerAmen.Size = new System.Drawing.Size(157, 34);
            this.btnVerAmen.TabIndex = 33;
            this.btnVerAmen.Text = "Ver amenidades";
            this.btnVerAmen.UseVisualStyleBackColor = false;
            this.btnVerAmen.Click += new System.EventHandler(this.btnVerAmen_Click);
            // 
            // btnVerCaract
            // 
            this.btnVerCaract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.btnVerCaract.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerCaract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerCaract.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerCaract.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVerCaract.Location = new System.Drawing.Point(3, 273);
            this.btnVerCaract.Name = "btnVerCaract";
            this.btnVerCaract.Size = new System.Drawing.Size(157, 34);
            this.btnVerCaract.TabIndex = 34;
            this.btnVerCaract.Text = "Ver caracteristicas";
            this.btnVerCaract.UseVisualStyleBackColor = false;
            this.btnVerCaract.Click += new System.EventHandler(this.btnVerCaract_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel8);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel6);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel7);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel9);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel10);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel11);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(174, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(716, 308);
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
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Controls.Add(this.label15);
            this.flowLayoutPanel6.Controls.Add(this.txtCantCamas);
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
            this.label15.Size = new System.Drawing.Size(140, 19);
            this.label15.TabIndex = 2;
            this.label15.Text = "Cantidad de camas";
            // 
            // txtCantCamas
            // 
            this.txtCantCamas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantCamas.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantCamas.Location = new System.Drawing.Point(3, 22);
            this.txtCantCamas.Name = "txtCantCamas";
            this.txtCantCamas.Size = new System.Drawing.Size(225, 29);
            this.txtCantCamas.TabIndex = 3;
            this.txtCantCamas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantCamas_KeyPress);
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.Controls.Add(this.label16);
            this.flowLayoutPanel7.Controls.Add(this.txtTipoCama);
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
            this.label16.Size = new System.Drawing.Size(101, 19);
            this.label16.TabIndex = 2;
            this.label16.Text = "Tipo de cama";
            // 
            // txtTipoCama
            // 
            this.txtTipoCama.FormattingEnabled = true;
            this.txtTipoCama.Location = new System.Drawing.Point(3, 22);
            this.txtTipoCama.Name = "txtTipoCama";
            this.txtTipoCama.Size = new System.Drawing.Size(225, 27);
            this.txtTipoCama.TabIndex = 16;
            // 
            // flowLayoutPanel9
            // 
            this.flowLayoutPanel9.Controls.Add(this.label1);
            this.flowLayoutPanel9.Controls.Add(this.txtCostoPersona);
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
            this.label1.Size = new System.Drawing.Size(137, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Costo por persona";
            // 
            // txtCostoPersona
            // 
            this.txtCostoPersona.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCostoPersona.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostoPersona.Location = new System.Drawing.Point(3, 22);
            this.txtCostoPersona.Name = "txtCostoPersona";
            this.txtCostoPersona.Size = new System.Drawing.Size(225, 29);
            this.txtCostoPersona.TabIndex = 3;
            this.txtCostoPersona.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCostoPersona_KeyPress);
            // 
            // flowLayoutPanel10
            // 
            this.flowLayoutPanel10.Controls.Add(this.label4);
            this.flowLayoutPanel10.Controls.Add(this.txtCapPersonas);
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
            this.label4.Size = new System.Drawing.Size(169, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Capacidad de personas";
            // 
            // txtCapPersonas
            // 
            this.txtCapPersonas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCapPersonas.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCapPersonas.Location = new System.Drawing.Point(3, 22);
            this.txtCapPersonas.Name = "txtCapPersonas";
            this.txtCapPersonas.Size = new System.Drawing.Size(225, 29);
            this.txtCapPersonas.TabIndex = 3;
            this.txtCapPersonas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCapPersonas_KeyPress);
            // 
            // flowLayoutPanel11
            // 
            this.flowLayoutPanel11.Controls.Add(this.label5);
            this.flowLayoutPanel11.Controls.Add(this.txtNivelHab);
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
            this.label5.Size = new System.Drawing.Size(142, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nivel de habitación";
            // 
            // txtNivelHab
            // 
            this.txtNivelHab.FormattingEnabled = true;
            this.txtNivelHab.Location = new System.Drawing.Point(3, 22);
            this.txtNivelHab.Name = "txtNivelHab";
            this.txtNivelHab.Size = new System.Drawing.Size(225, 27);
            this.txtNivelHab.TabIndex = 15;
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
            this.menuAdministrador.TabIndex = 9;
            this.menuAdministrador.Text = "menuOperativo";
            // 
            // no
            // 
            this.no.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hotelesMenuItem,
            this.serviciosAdicionalesDeHotelMenuItem});
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(73, 23);
            this.no.Text = "Hoteles";
            // 
            // hotelesMenuItem
            // 
            this.hotelesMenuItem.Name = "hotelesMenuItem";
            this.hotelesMenuItem.Size = new System.Drawing.Size(281, 24);
            this.hotelesMenuItem.Text = "Hoteles";
            this.hotelesMenuItem.Click += new System.EventHandler(this.hotelesMenuItem_Click_1);
            // 
            // serviciosAdicionalesDeHotelMenuItem
            // 
            this.serviciosAdicionalesDeHotelMenuItem.Name = "serviciosAdicionalesDeHotelMenuItem";
            this.serviciosAdicionalesDeHotelMenuItem.Size = new System.Drawing.Size(281, 24);
            this.serviciosAdicionalesDeHotelMenuItem.Text = "Servicios adicionales de hotel";
            this.serviciosAdicionalesDeHotelMenuItem.Click += new System.EventHandler(this.serviciosAdicionalesDeHotelMenuItem_Click_1);
            // 
            // tiposDeHabitaciónMenuItem
            // 
            this.tiposDeHabitaciónMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiposHabMenuItem,
            this.amHabMenuItem,
            this.caractHabMenuItem});
            this.tiposDeHabitaciónMenuItem.Name = "tiposDeHabitaciónMenuItem";
            this.tiposDeHabitaciónMenuItem.Size = new System.Drawing.Size(155, 23);
            this.tiposDeHabitaciónMenuItem.Text = "Tipos de habitación";
            // 
            // tiposHabMenuItem
            // 
            this.tiposHabMenuItem.Name = "tiposHabMenuItem";
            this.tiposHabMenuItem.Size = new System.Drawing.Size(275, 24);
            this.tiposHabMenuItem.Text = "Tipos de habitación";
            this.tiposHabMenuItem.Click += new System.EventHandler(this.tiposHabMenuItem_Click_1);
            // 
            // amHabMenuItem
            // 
            this.amHabMenuItem.Name = "amHabMenuItem";
            this.amHabMenuItem.Size = new System.Drawing.Size(275, 24);
            this.amHabMenuItem.Text = "Amenidades de habitación";
            this.amHabMenuItem.Click += new System.EventHandler(this.amHabMenuItem_Click_1);
            // 
            // caractHabMenuItem
            // 
            this.caractHabMenuItem.Name = "caractHabMenuItem";
            this.caractHabMenuItem.Size = new System.Drawing.Size(275, 24);
            this.caractHabMenuItem.Text = "Características de habitación";
            this.caractHabMenuItem.Click += new System.EventHandler(this.caractHabMenuItem_Click_1);
            // 
            // usuariosMenuItem
            // 
            this.usuariosMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.habilitarInhabilitarUsuarioMenuItem});
            this.usuariosMenuItem.Name = "usuariosMenuItem";
            this.usuariosMenuItem.Size = new System.Drawing.Size(82, 23);
            this.usuariosMenuItem.Text = "Usuarios";
            this.usuariosMenuItem.Click += new System.EventHandler(this.usuariosMenuItem_Click);
            // 
            // habilitarInhabilitarUsuarioMenuItem
            // 
            this.habilitarInhabilitarUsuarioMenuItem.Name = "habilitarInhabilitarUsuarioMenuItem";
            this.habilitarInhabilitarUsuarioMenuItem.Size = new System.Drawing.Size(269, 24);
            this.habilitarInhabilitarUsuarioMenuItem.Text = "Habilitar/Inhabilitar usuario";
            this.habilitarInhabilitarUsuarioMenuItem.Click += new System.EventHandler(this.habilitarInhabilitarUsuarioMenuItem_Click_1);
            // 
            // cancelarReservacionMenuItem
            // 
            this.cancelarReservacionMenuItem.Name = "cancelarReservacionMenuItem";
            this.cancelarReservacionMenuItem.Size = new System.Drawing.Size(165, 23);
            this.cancelarReservacionMenuItem.Text = "Cancelar reservación";
            this.cancelarReservacionMenuItem.Click += new System.EventHandler(this.cancelarReservacionMenuItem_Click_1);
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
            this.reporteDeOcupaciónPorHotelMenuItem.Click += new System.EventHandler(this.reporteDeOcupaciónPorHotelMenuItem_Click_1);
            // 
            // reporteDeVentasMenuItem
            // 
            this.reporteDeVentasMenuItem.Name = "reporteDeVentasMenuItem";
            this.reporteDeVentasMenuItem.Size = new System.Drawing.Size(296, 24);
            this.reporteDeVentasMenuItem.Text = "Reporte de ventas";
            this.reporteDeVentasMenuItem.Click += new System.EventHandler(this.reporteDeVentasMenuItem_Click_1);
            // 
            // historialDeClienteMenuItem
            // 
            this.historialDeClienteMenuItem.Name = "historialDeClienteMenuItem";
            this.historialDeClienteMenuItem.Size = new System.Drawing.Size(296, 24);
            this.historialDeClienteMenuItem.Text = "Historial de cliente";
            this.historialDeClienteMenuItem.Click += new System.EventHandler(this.historialDeClienteMenuItem_Click_1);
            // 
            // salirMenuItem
            // 
            this.salirMenuItem.Name = "salirMenuItem";
            this.salirMenuItem.Size = new System.Drawing.Size(52, 23);
            this.salirMenuItem.Text = "Salir";
            this.salirMenuItem.Click += new System.EventHandler(this.salirMenuItem_Click_2);
            // 
            // TiposHabitacionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(925, 880);
            this.Controls.Add(this.menuAdministrador);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TiposHabitacionWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotelera - Tipos de habitación";
            this.Load += new System.EventHandler(this.TiposHabitacionWindow_Load);
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiposHab)).EndInit();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
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
            this.menuAdministrador.ResumeLayout(false);
            this.menuAdministrador.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnEliminarTipoHab;
        private System.Windows.Forms.Button btnEditarTipoHab;
        private System.Windows.Forms.Button btnNuevoTipoHab;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtCantCamas;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox txtTipoCama;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCostoPersona;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCapPersonas;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox txtNivelHab;
        private System.Windows.Forms.DataGridView dgvTiposHab;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Button btnVerAmen;
        private System.Windows.Forms.Button btnVerCaract;
        private System.Windows.Forms.MenuStrip menuAdministrador;
        private System.Windows.Forms.ToolStripMenuItem no;
        private System.Windows.Forms.ToolStripMenuItem hotelesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviciosAdicionalesDeHotelMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposDeHabitaciónMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposHabMenuItem;
        private System.Windows.Forms.ToolStripMenuItem amHabMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caractHabMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosMenuItem;
        private System.Windows.Forms.ToolStripMenuItem habilitarInhabilitarUsuarioMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelarReservacionMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeOcupaciónPorHotelMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeVentasMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialDeClienteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirMenuItem;
    }
}