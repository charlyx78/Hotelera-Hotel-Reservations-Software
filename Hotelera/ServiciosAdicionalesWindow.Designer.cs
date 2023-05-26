
namespace Hotelera
{
    partial class ServiciosAdicionalesWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiciosAdicionalesWindow));
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.dgvServAdicionales = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNuevoServAdicional = new System.Windows.Forms.Button();
            this.btnEditarServiAdicional = new System.Windows.Forms.Button();
            this.btnEliminarServAdicional = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel8 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel10 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCosto = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvServAdicionales)).BeginInit();
            this.flowLayoutPanel6.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel8.SuspendLayout();
            this.flowLayoutPanel10.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.menuAdministrador.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.dgvServAdicionales);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel6);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(12, 32);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(900, 798);
            this.flowLayoutPanel2.TabIndex = 9;
            // 
            // dgvServAdicionales
            // 
            this.dgvServAdicionales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServAdicionales.Location = new System.Drawing.Point(3, 3);
            this.dgvServAdicionales.Name = "dgvServAdicionales";
            this.dgvServAdicionales.Size = new System.Drawing.Size(897, 497);
            this.dgvServAdicionales.TabIndex = 1;
            this.dgvServAdicionales.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServAdicionales_CellClick);
            this.dgvServAdicionales.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvServAdicionales_CellFormatting);
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Controls.Add(this.flowLayoutPanel7);
            this.flowLayoutPanel6.Controls.Add(this.flowLayoutPanel1);
            this.flowLayoutPanel6.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel6.Location = new System.Drawing.Point(3, 506);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(898, 265);
            this.flowLayoutPanel6.TabIndex = 8;
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.Controls.Add(this.btnNuevoServAdicional);
            this.flowLayoutPanel7.Controls.Add(this.btnEditarServiAdicional);
            this.flowLayoutPanel7.Controls.Add(this.btnEliminarServAdicional);
            this.flowLayoutPanel7.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(163, 258);
            this.flowLayoutPanel7.TabIndex = 34;
            // 
            // btnNuevoServAdicional
            // 
            this.btnNuevoServAdicional.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.btnNuevoServAdicional.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoServAdicional.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoServAdicional.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoServAdicional.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNuevoServAdicional.Location = new System.Drawing.Point(3, 25);
            this.btnNuevoServAdicional.Margin = new System.Windows.Forms.Padding(3, 25, 3, 25);
            this.btnNuevoServAdicional.Name = "btnNuevoServAdicional";
            this.btnNuevoServAdicional.Size = new System.Drawing.Size(157, 34);
            this.btnNuevoServAdicional.TabIndex = 34;
            this.btnNuevoServAdicional.Text = "Nuevo";
            this.btnNuevoServAdicional.UseVisualStyleBackColor = false;
            this.btnNuevoServAdicional.Click += new System.EventHandler(this.btnNuevoServAdicional_Click);
            // 
            // btnEditarServiAdicional
            // 
            this.btnEditarServiAdicional.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.btnEditarServiAdicional.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarServiAdicional.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarServiAdicional.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarServiAdicional.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditarServiAdicional.Location = new System.Drawing.Point(3, 87);
            this.btnEditarServiAdicional.Margin = new System.Windows.Forms.Padding(3, 3, 3, 25);
            this.btnEditarServiAdicional.Name = "btnEditarServiAdicional";
            this.btnEditarServiAdicional.Size = new System.Drawing.Size(157, 34);
            this.btnEditarServiAdicional.TabIndex = 31;
            this.btnEditarServiAdicional.Text = "Editar";
            this.btnEditarServiAdicional.UseVisualStyleBackColor = false;
            this.btnEditarServiAdicional.Click += new System.EventHandler(this.btnEditarServiAdicional_Click);
            // 
            // btnEliminarServAdicional
            // 
            this.btnEliminarServAdicional.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.btnEliminarServAdicional.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarServAdicional.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarServAdicional.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarServAdicional.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminarServAdicional.Location = new System.Drawing.Point(3, 149);
            this.btnEliminarServAdicional.Margin = new System.Windows.Forms.Padding(3, 3, 3, 25);
            this.btnEliminarServAdicional.Name = "btnEliminarServAdicional";
            this.btnEliminarServAdicional.Size = new System.Drawing.Size(157, 34);
            this.btnEliminarServAdicional.TabIndex = 32;
            this.btnEliminarServAdicional.Text = "Eliminar";
            this.btnEliminarServAdicional.UseVisualStyleBackColor = false;
            this.btnEliminarServAdicional.Click += new System.EventHandler(this.btnEliminarServAdicional_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel8);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel10);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(172, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(725, 258);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // flowLayoutPanel8
            // 
            this.flowLayoutPanel8.Controls.Add(this.label3);
            this.flowLayoutPanel8.Controls.Add(this.txtNombre);
            this.flowLayoutPanel8.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel8.Name = "flowLayoutPanel8";
            this.flowLayoutPanel8.Size = new System.Drawing.Size(722, 57);
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
            this.txtNombre.Size = new System.Drawing.Size(719, 29);
            this.txtNombre.TabIndex = 3;
            // 
            // flowLayoutPanel10
            // 
            this.flowLayoutPanel10.Controls.Add(this.label4);
            this.flowLayoutPanel10.Controls.Add(this.txtDescripcion);
            this.flowLayoutPanel10.Location = new System.Drawing.Point(3, 66);
            this.flowLayoutPanel10.Name = "flowLayoutPanel10";
            this.flowLayoutPanel10.Size = new System.Drawing.Size(722, 125);
            this.flowLayoutPanel10.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcion.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(3, 22);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(719, 100);
            this.txtDescripcion.TabIndex = 3;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.label1);
            this.flowLayoutPanel3.Controls.Add(this.txtCosto);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 197);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(722, 57);
            this.flowLayoutPanel3.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Costo";
            // 
            // txtCosto
            // 
            this.txtCosto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCosto.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCosto.Location = new System.Drawing.Point(3, 22);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(719, 29);
            this.txtCosto.TabIndex = 3;
            this.txtCosto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCosto_KeyPress);
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
            this.menuAdministrador.TabIndex = 10;
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
            // ServiciosAdicionalesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 822);
            this.Controls.Add(this.menuAdministrador);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ServiciosAdicionalesWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotelera - Servicios adicionales";
            this.Load += new System.EventHandler(this.ServiciosAdicionalesWindow_Load);
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServAdicionales)).EndInit();
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel7.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel8.ResumeLayout(false);
            this.flowLayoutPanel8.PerformLayout();
            this.flowLayoutPanel10.ResumeLayout(false);
            this.flowLayoutPanel10.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.menuAdministrador.ResumeLayout(false);
            this.menuAdministrador.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.DataGridView dgvServAdicionales;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
        private System.Windows.Forms.Button btnNuevoServAdicional;
        private System.Windows.Forms.Button btnEditarServiAdicional;
        private System.Windows.Forms.Button btnEliminarServAdicional;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCosto;
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