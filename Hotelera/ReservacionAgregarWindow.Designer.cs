
namespace Hotelera
{
    partial class ReservacionAgregarWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservacionAgregarWindow));
            this.dgvHabitaciones = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCantPersonas = new System.Windows.Forms.TextBox();
            this.btnAggHabReserv = new System.Windows.Forms.Button();
            this.btnGestHabReserv = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel8 = new System.Windows.Forms.FlowLayoutPanel();
            this.dgvServicios = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel9 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAggServAdicReserv = new System.Windows.Forms.Button();
            this.btnGestServAdic = new System.Windows.Forms.Button();
            this.flowLayoutPanel12 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel14 = new System.Windows.Forms.FlowLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel13 = new System.Windows.Forms.FlowLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAnticipo = new System.Windows.Forms.TextBox();
            this.btnContReserv = new System.Windows.Forms.Button();
            this.dtpInvisible = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitaciones)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).BeginInit();
            this.flowLayoutPanel9.SuspendLayout();
            this.flowLayoutPanel12.SuspendLayout();
            this.flowLayoutPanel14.SuspendLayout();
            this.flowLayoutPanel13.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvHabitaciones
            // 
            this.dgvHabitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHabitaciones.Location = new System.Drawing.Point(4, 4);
            this.dgvHabitaciones.Margin = new System.Windows.Forms.Padding(4);
            this.dgvHabitaciones.Name = "dgvHabitaciones";
            this.dgvHabitaciones.Size = new System.Drawing.Size(797, 376);
            this.dgvHabitaciones.TabIndex = 46;
            this.dgvHabitaciones.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvTiposHabitacion_CellFormatting);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Window;
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel6);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 22);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1173, 389);
            this.flowLayoutPanel1.TabIndex = 48;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.dgvHabitaciones);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(801, 380);
            this.flowLayoutPanel3.TabIndex = 1;
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Controls.Add(this.flowLayoutPanel7);
            this.flowLayoutPanel6.Controls.Add(this.btnAggHabReserv);
            this.flowLayoutPanel6.Controls.Add(this.btnGestHabReserv);
            this.flowLayoutPanel6.Location = new System.Drawing.Point(811, 4);
            this.flowLayoutPanel6.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(356, 379);
            this.flowLayoutPanel6.TabIndex = 45;
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.Controls.Add(this.label3);
            this.flowLayoutPanel7.Controls.Add(this.txtCantPersonas);
            this.flowLayoutPanel7.Location = new System.Drawing.Point(4, 4);
            this.flowLayoutPanel7.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(348, 63);
            this.flowLayoutPanel7.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad de personas";
            // 
            // txtCantPersonas
            // 
            this.txtCantPersonas.Location = new System.Drawing.Point(3, 22);
            this.txtCantPersonas.Name = "txtCantPersonas";
            this.txtCantPersonas.Size = new System.Drawing.Size(341, 29);
            this.txtCantPersonas.TabIndex = 49;
            this.txtCantPersonas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantPersonas_KeyPress);
            // 
            // btnAggHabReserv
            // 
            this.btnAggHabReserv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.btnAggHabReserv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAggHabReserv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAggHabReserv.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAggHabReserv.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAggHabReserv.Location = new System.Drawing.Point(4, 75);
            this.btnAggHabReserv.Margin = new System.Windows.Forms.Padding(4);
            this.btnAggHabReserv.Name = "btnAggHabReserv";
            this.btnAggHabReserv.Size = new System.Drawing.Size(348, 41);
            this.btnAggHabReserv.TabIndex = 47;
            this.btnAggHabReserv.Text = "Agregar habitación a la reservación";
            this.btnAggHabReserv.UseVisualStyleBackColor = false;
            this.btnAggHabReserv.Click += new System.EventHandler(this.btnAggHabReserv_Click_1);
            // 
            // btnGestHabReserv
            // 
            this.btnGestHabReserv.BackColor = System.Drawing.Color.DarkGray;
            this.btnGestHabReserv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGestHabReserv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestHabReserv.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestHabReserv.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGestHabReserv.Location = new System.Drawing.Point(4, 124);
            this.btnGestHabReserv.Margin = new System.Windows.Forms.Padding(4);
            this.btnGestHabReserv.Name = "btnGestHabReserv";
            this.btnGestHabReserv.Size = new System.Drawing.Size(348, 41);
            this.btnGestHabReserv.TabIndex = 49;
            this.btnGestHabReserv.Text = "Ver habitaciones agregadas a la reservación";
            this.btnGestHabReserv.UseVisualStyleBackColor = false;
            this.btnGestHabReserv.Click += new System.EventHandler(this.btnGestHabReserv_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 19);
            this.label1.TabIndex = 50;
            this.label1.Text = "Selecciona las habitaciones";
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.label1);
            this.flowLayoutPanel4.Controls.Add(this.flowLayoutPanel1);
            this.flowLayoutPanel4.Controls.Add(this.label6);
            this.flowLayoutPanel4.Controls.Add(this.flowLayoutPanel5);
            this.flowLayoutPanel4.Controls.Add(this.flowLayoutPanel12);
            this.flowLayoutPanel4.Controls.Add(this.btnContReserv);
            this.flowLayoutPanel4.Controls.Add(this.dtpInvisible);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(1176, 956);
            this.flowLayoutPanel4.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 414);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(278, 19);
            this.label6.TabIndex = 52;
            this.label6.Text = "Selecciona los servicios adicionales";
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.BackColor = System.Drawing.SystemColors.Window;
            this.flowLayoutPanel5.Controls.Add(this.flowLayoutPanel8);
            this.flowLayoutPanel5.Controls.Add(this.flowLayoutPanel9);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(3, 436);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(1173, 386);
            this.flowLayoutPanel5.TabIndex = 49;
            // 
            // flowLayoutPanel8
            // 
            this.flowLayoutPanel8.Controls.Add(this.dgvServicios);
            this.flowLayoutPanel8.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel8.Name = "flowLayoutPanel8";
            this.flowLayoutPanel8.Size = new System.Drawing.Size(801, 380);
            this.flowLayoutPanel8.TabIndex = 1;
            // 
            // dgvServicios
            // 
            this.dgvServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServicios.Location = new System.Drawing.Point(4, 4);
            this.dgvServicios.Margin = new System.Windows.Forms.Padding(4);
            this.dgvServicios.Name = "dgvServicios";
            this.dgvServicios.Size = new System.Drawing.Size(797, 376);
            this.dgvServicios.TabIndex = 46;
            // 
            // flowLayoutPanel9
            // 
            this.flowLayoutPanel9.Controls.Add(this.btnAggServAdicReserv);
            this.flowLayoutPanel9.Controls.Add(this.btnGestServAdic);
            this.flowLayoutPanel9.Location = new System.Drawing.Point(811, 4);
            this.flowLayoutPanel9.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel9.Name = "flowLayoutPanel9";
            this.flowLayoutPanel9.Size = new System.Drawing.Size(356, 379);
            this.flowLayoutPanel9.TabIndex = 45;
            // 
            // btnAggServAdicReserv
            // 
            this.btnAggServAdicReserv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.btnAggServAdicReserv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAggServAdicReserv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAggServAdicReserv.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAggServAdicReserv.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAggServAdicReserv.Location = new System.Drawing.Point(4, 4);
            this.btnAggServAdicReserv.Margin = new System.Windows.Forms.Padding(4);
            this.btnAggServAdicReserv.Name = "btnAggServAdicReserv";
            this.btnAggServAdicReserv.Size = new System.Drawing.Size(348, 41);
            this.btnAggServAdicReserv.TabIndex = 47;
            this.btnAggServAdicReserv.Text = "Agregar servicio adicional a la reservación";
            this.btnAggServAdicReserv.UseVisualStyleBackColor = false;
            this.btnAggServAdicReserv.Click += new System.EventHandler(this.btnAggServAdicReserv_Click);
            // 
            // btnGestServAdic
            // 
            this.btnGestServAdic.BackColor = System.Drawing.Color.DarkGray;
            this.btnGestServAdic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGestServAdic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestServAdic.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestServAdic.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGestServAdic.Location = new System.Drawing.Point(4, 53);
            this.btnGestServAdic.Margin = new System.Windows.Forms.Padding(4);
            this.btnGestServAdic.Name = "btnGestServAdic";
            this.btnGestServAdic.Size = new System.Drawing.Size(348, 49);
            this.btnGestServAdic.TabIndex = 49;
            this.btnGestServAdic.Text = "Ver servicios adicionales agregados a la habitación";
            this.btnGestServAdic.UseVisualStyleBackColor = false;
            this.btnGestServAdic.Click += new System.EventHandler(this.btnGestServAdic_Click);
            // 
            // flowLayoutPanel12
            // 
            this.flowLayoutPanel12.BackColor = System.Drawing.SystemColors.Window;
            this.flowLayoutPanel12.Controls.Add(this.flowLayoutPanel14);
            this.flowLayoutPanel12.Controls.Add(this.flowLayoutPanel13);
            this.flowLayoutPanel12.Location = new System.Drawing.Point(3, 828);
            this.flowLayoutPanel12.Name = "flowLayoutPanel12";
            this.flowLayoutPanel12.Size = new System.Drawing.Size(1173, 71);
            this.flowLayoutPanel12.TabIndex = 53;
            // 
            // flowLayoutPanel14
            // 
            this.flowLayoutPanel14.Controls.Add(this.label8);
            this.flowLayoutPanel14.Controls.Add(this.txtTotal);
            this.flowLayoutPanel14.Location = new System.Drawing.Point(4, 4);
            this.flowLayoutPanel14.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel14.Name = "flowLayoutPanel14";
            this.flowLayoutPanel14.Size = new System.Drawing.Size(575, 63);
            this.flowLayoutPanel14.TabIndex = 52;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 19);
            this.label8.TabIndex = 3;
            this.label8.Text = "Monto total a pagar";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(3, 22);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(564, 29);
            this.txtTotal.TabIndex = 49;
            // 
            // flowLayoutPanel13
            // 
            this.flowLayoutPanel13.Controls.Add(this.label7);
            this.flowLayoutPanel13.Controls.Add(this.txtAnticipo);
            this.flowLayoutPanel13.Location = new System.Drawing.Point(587, 4);
            this.flowLayoutPanel13.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel13.Name = "flowLayoutPanel13";
            this.flowLayoutPanel13.Size = new System.Drawing.Size(580, 63);
            this.flowLayoutPanel13.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 19);
            this.label7.TabIndex = 3;
            this.label7.Text = "Monto de anticipo";
            // 
            // txtAnticipo
            // 
            this.txtAnticipo.Location = new System.Drawing.Point(3, 22);
            this.txtAnticipo.Name = "txtAnticipo";
            this.txtAnticipo.Size = new System.Drawing.Size(573, 29);
            this.txtAnticipo.TabIndex = 49;
            // 
            // btnContReserv
            // 
            this.btnContReserv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.btnContReserv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContReserv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContReserv.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContReserv.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnContReserv.Location = new System.Drawing.Point(4, 906);
            this.btnContReserv.Margin = new System.Windows.Forms.Padding(4);
            this.btnContReserv.Name = "btnContReserv";
            this.btnContReserv.Size = new System.Drawing.Size(1172, 41);
            this.btnContReserv.TabIndex = 51;
            this.btnContReserv.Text = "Continuar";
            this.btnContReserv.UseVisualStyleBackColor = false;
            this.btnContReserv.Click += new System.EventHandler(this.btnContReserv_Click);
            // 
            // dtpInvisible
            // 
            this.dtpInvisible.Location = new System.Drawing.Point(3, 954);
            this.dtpInvisible.Name = "dtpInvisible";
            this.dtpInvisible.Size = new System.Drawing.Size(200, 29);
            this.dtpInvisible.TabIndex = 46;
            this.dtpInvisible.Visible = false;
            // 
            // ReservacionAgregarWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 980);
            this.Controls.Add(this.flowLayoutPanel4);
            this.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReservacionAgregarWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotelera - Seleccion de habitaciones";
            this.Load += new System.EventHandler(this.ReservacionHabitaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitaciones)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel7.ResumeLayout(false);
            this.flowLayoutPanel7.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).EndInit();
            this.flowLayoutPanel9.ResumeLayout(false);
            this.flowLayoutPanel12.ResumeLayout(false);
            this.flowLayoutPanel14.ResumeLayout(false);
            this.flowLayoutPanel14.PerformLayout();
            this.flowLayoutPanel13.ResumeLayout(false);
            this.flowLayoutPanel13.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvHabitaciones;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCantPersonas;
        private System.Windows.Forms.Button btnAggHabReserv;
        private System.Windows.Forms.Button btnGestHabReserv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel8;
        private System.Windows.Forms.DataGridView dgvServicios;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel9;
        private System.Windows.Forms.Button btnAggServAdicReserv;
        private System.Windows.Forms.Button btnGestServAdic;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel12;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel14;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAnticipo;
        private System.Windows.Forms.Button btnContReserv;
        private System.Windows.Forms.DateTimePicker dtpInvisible;
    }
}