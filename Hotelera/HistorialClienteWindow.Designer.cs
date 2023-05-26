
namespace Hotelera
{
    partial class HistorialClienteWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistorialClienteWindow));
            this.dgvHistorialCliente = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel12 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.btnClienteAp = new System.Windows.Forms.Button();
            this.btnClienteCorreo = new System.Windows.Forms.Button();
            this.btnClienteRFC = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.btnAño = new System.Windows.Forms.Button();
            this.menuAdministrador = new System.Windows.Forms.MenuStrip();
            this.hotelesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDeHabitaciónMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.habilitarInhabilitarUsuarioMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelarReservacionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeOcupaciónPorHotelMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeVentasMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialDeClienteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbClientes = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialCliente)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel12.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.menuAdministrador.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvHistorialCliente
            // 
            this.dgvHistorialCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorialCliente.Location = new System.Drawing.Point(408, 150);
            this.dgvHistorialCliente.Name = "dgvHistorialCliente";
            this.dgvHistorialCliente.Size = new System.Drawing.Size(907, 517);
            this.dgvHistorialCliente.TabIndex = 36;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Controls.Add(this.groupBox2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 32);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1303, 112);
            this.flowLayoutPanel1.TabIndex = 35;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel12);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(643, 106);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // flowLayoutPanel12
            // 
            this.flowLayoutPanel12.Controls.Add(this.txtCliente);
            this.flowLayoutPanel12.Controls.Add(this.btnClienteAp);
            this.flowLayoutPanel12.Controls.Add(this.btnClienteCorreo);
            this.flowLayoutPanel12.Controls.Add(this.btnClienteRFC);
            this.flowLayoutPanel12.Location = new System.Drawing.Point(6, 28);
            this.flowLayoutPanel12.Name = "flowLayoutPanel12";
            this.flowLayoutPanel12.Size = new System.Drawing.Size(631, 72);
            this.flowLayoutPanel12.TabIndex = 25;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(3, 3);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(628, 29);
            this.txtCliente.TabIndex = 39;
            // 
            // btnClienteAp
            // 
            this.btnClienteAp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.btnClienteAp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClienteAp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClienteAp.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClienteAp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClienteAp.Location = new System.Drawing.Point(3, 38);
            this.btnClienteAp.Name = "btnClienteAp";
            this.btnClienteAp.Size = new System.Drawing.Size(171, 34);
            this.btnClienteAp.TabIndex = 37;
            this.btnClienteAp.Text = "Buscar por apellidos";
            this.btnClienteAp.UseVisualStyleBackColor = false;
            this.btnClienteAp.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnClienteCorreo
            // 
            this.btnClienteCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.btnClienteCorreo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClienteCorreo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClienteCorreo.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClienteCorreo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClienteCorreo.Location = new System.Drawing.Point(180, 38);
            this.btnClienteCorreo.Name = "btnClienteCorreo";
            this.btnClienteCorreo.Size = new System.Drawing.Size(253, 34);
            this.btnClienteCorreo.TabIndex = 40;
            this.btnClienteCorreo.Text = "Buscar por correo electrónico";
            this.btnClienteCorreo.UseVisualStyleBackColor = false;
            this.btnClienteCorreo.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClienteRFC
            // 
            this.btnClienteRFC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.btnClienteRFC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClienteRFC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClienteRFC.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClienteRFC.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClienteRFC.Location = new System.Drawing.Point(439, 38);
            this.btnClienteRFC.Name = "btnClienteRFC";
            this.btnClienteRFC.Size = new System.Drawing.Size(189, 34);
            this.btnClienteRFC.TabIndex = 41;
            this.btnClienteRFC.Text = "Buscar por RFC";
            this.btnClienteRFC.UseVisualStyleBackColor = false;
            this.btnClienteRFC.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.flowLayoutPanel3);
            this.groupBox2.Location = new System.Drawing.Point(652, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(242, 106);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Año";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.txtAño);
            this.flowLayoutPanel3.Controls.Add(this.btnAño);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(6, 28);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(232, 72);
            this.flowLayoutPanel3.TabIndex = 25;
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(3, 3);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(225, 29);
            this.txtAño.TabIndex = 40;
            this.txtAño.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAño_KeyPress);
            // 
            // btnAño
            // 
            this.btnAño.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.btnAño.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAño.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAño.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAño.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAño.Location = new System.Drawing.Point(3, 38);
            this.btnAño.Name = "btnAño";
            this.btnAño.Size = new System.Drawing.Size(225, 34);
            this.btnAño.TabIndex = 38;
            this.btnAño.Text = "Buscar";
            this.btnAño.UseVisualStyleBackColor = false;
            this.btnAño.Click += new System.EventHandler(this.btnAño_Click);
            // 
            // menuAdministrador
            // 
            this.menuAdministrador.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuAdministrador.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hotelesMenuItem,
            this.tiposDeHabitaciónMenuItem,
            this.usuariosMenuItem,
            this.cancelarReservacionMenuItem,
            this.reportesMenuItem,
            this.salirMenuItem});
            this.menuAdministrador.Location = new System.Drawing.Point(0, 0);
            this.menuAdministrador.Name = "menuAdministrador";
            this.menuAdministrador.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuAdministrador.Size = new System.Drawing.Size(1327, 29);
            this.menuAdministrador.TabIndex = 38;
            this.menuAdministrador.Text = "Hotelera - Reporte por ocupación de hotel";
            // 
            // hotelesMenuItem
            // 
            this.hotelesMenuItem.Name = "hotelesMenuItem";
            this.hotelesMenuItem.Size = new System.Drawing.Size(73, 23);
            this.hotelesMenuItem.Text = "Hoteles";
            // 
            // tiposDeHabitaciónMenuItem
            // 
            this.tiposDeHabitaciónMenuItem.Name = "tiposDeHabitaciónMenuItem";
            this.tiposDeHabitaciónMenuItem.Size = new System.Drawing.Size(155, 23);
            this.tiposDeHabitaciónMenuItem.Text = "Tipos de habitación";
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
            // 
            // cancelarReservacionMenuItem
            // 
            this.cancelarReservacionMenuItem.Name = "cancelarReservacionMenuItem";
            this.cancelarReservacionMenuItem.Size = new System.Drawing.Size(165, 23);
            this.cancelarReservacionMenuItem.Text = "Cancelar reservación";
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
            // 
            // reporteDeVentasMenuItem
            // 
            this.reporteDeVentasMenuItem.Name = "reporteDeVentasMenuItem";
            this.reporteDeVentasMenuItem.Size = new System.Drawing.Size(296, 24);
            this.reporteDeVentasMenuItem.Text = "Reporte de ventas";
            // 
            // historialDeClienteMenuItem
            // 
            this.historialDeClienteMenuItem.Name = "historialDeClienteMenuItem";
            this.historialDeClienteMenuItem.Size = new System.Drawing.Size(296, 24);
            this.historialDeClienteMenuItem.Text = "Historial de cliente";
            // 
            // salirMenuItem
            // 
            this.salirMenuItem.Name = "salirMenuItem";
            this.salirMenuItem.Size = new System.Drawing.Size(52, 23);
            this.salirMenuItem.Text = "Salir";
            // 
            // lbClientes
            // 
            this.lbClientes.FormattingEnabled = true;
            this.lbClientes.ItemHeight = 19;
            this.lbClientes.Location = new System.Drawing.Point(12, 150);
            this.lbClientes.Name = "lbClientes";
            this.lbClientes.Size = new System.Drawing.Size(390, 517);
            this.lbClientes.TabIndex = 27;
            this.lbClientes.SelectedValueChanged += new System.EventHandler(this.lbClientes_SelectedValueChanged);
            // 
            // HistorialClienteWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1327, 691);
            this.Controls.Add(this.menuAdministrador);
            this.Controls.Add(this.dgvHistorialCliente);
            this.Controls.Add(this.lbClientes);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HistorialClienteWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotelera - Historial de clientes";
            this.Load += new System.EventHandler(this.HistorialClienteWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialCliente)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel12.ResumeLayout(false);
            this.flowLayoutPanel12.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.menuAdministrador.ResumeLayout(false);
            this.menuAdministrador.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHistorialCliente;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel12;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button btnClienteAp;
        private System.Windows.Forms.MenuStrip menuAdministrador;
        private System.Windows.Forms.ToolStripMenuItem hotelesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposDeHabitaciónMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosMenuItem;
        private System.Windows.Forms.ToolStripMenuItem habilitarInhabilitarUsuarioMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelarReservacionMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeOcupaciónPorHotelMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeVentasMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialDeClienteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirMenuItem;
        private System.Windows.Forms.Button btnAño;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.Button btnClienteCorreo;
        private System.Windows.Forms.Button btnClienteRFC;
        private System.Windows.Forms.ListBox lbClientes;
    }
}