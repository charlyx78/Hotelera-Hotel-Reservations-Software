
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
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnIrALogin = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuAdministrador.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.menuAdministrador.TabIndex = 11;
            this.menuAdministrador.Text = "menuOperativo";
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
            // CancelacionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1327, 563);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.menuAdministrador);
            this.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CancelacionWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CancelacionWindow";
            this.menuAdministrador.ResumeLayout(false);
            this.menuAdministrador.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnIrALogin;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}