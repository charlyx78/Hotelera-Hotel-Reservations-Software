
namespace Hotelera
{
    partial class CancelacionWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CancelacionWindow));
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnIrALogin = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuAdministrador.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel1);
            this.flowLayoutPanel2.Controls.Add(this.dataGridView1);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(12, 32);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1303, 516);
            this.flowLayoutPanel2.TabIndex = 12;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnIrALogin);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(164, 513);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // btnIrALogin
            // 
            this.btnIrALogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.btnIrALogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIrALogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIrALogin.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIrALogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnIrALogin.Location = new System.Drawing.Point(3, 3);
            this.btnIrALogin.Name = "btnIrALogin";
            this.btnIrALogin.Size = new System.Drawing.Size(157, 48);
            this.btnIrALogin.TabIndex = 30;
            this.btnIrALogin.Text = "Cancelar reservación";
            this.btnIrALogin.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(173, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1130, 513);
            this.dataGridView1.TabIndex = 1;
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
            this.menuAdministrador.Size = new System.Drawing.Size(1327, 29);
            this.menuAdministrador.TabIndex = 13;
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
            this.hotelesMenuItem.Click += new System.EventHandler(this.hotelesMenuItem_Click);
            // 
            // serviciosAdicionalesDeHotelMenuItem
            // 
            this.serviciosAdicionalesDeHotelMenuItem.Name = "serviciosAdicionalesDeHotelMenuItem";
            this.serviciosAdicionalesDeHotelMenuItem.Size = new System.Drawing.Size(281, 24);
            this.serviciosAdicionalesDeHotelMenuItem.Text = "Servicios adicionales de hotel";
            this.serviciosAdicionalesDeHotelMenuItem.Click += new System.EventHandler(this.serviciosAdicionalesDeHotelMenuItem_Click);
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
            this.tiposHabMenuItem.Click += new System.EventHandler(this.tiposHabMenuItem_Click);
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
            // CancelacionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1327, 563);
            this.Controls.Add(this.menuAdministrador);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CancelacionWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CancelacionWindow";
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuAdministrador.ResumeLayout(false);
            this.menuAdministrador.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnIrALogin;
        private System.Windows.Forms.DataGridView dataGridView1;
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