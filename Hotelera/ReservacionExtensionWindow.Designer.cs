
namespace Hotelera
{
    partial class ReservacionExtensionWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservacionExtensionWindow));
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
            this.flowLayoutPanel12 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel14 = new System.Windows.Forms.FlowLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnContReserv = new System.Windows.Forms.Button();
            this.dtpInvisible = new System.Windows.Forms.DateTimePicker();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCantHabs = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitaciones)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel12.SuspendLayout();
            this.flowLayoutPanel14.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
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
            this.flowLayoutPanel6.Controls.Add(this.flowLayoutPanel2);
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
            this.flowLayoutPanel7.Location = new System.Drawing.Point(4, 67);
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
            this.btnAggHabReserv.Location = new System.Drawing.Point(4, 138);
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
            this.btnGestHabReserv.Location = new System.Drawing.Point(4, 187);
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
            this.flowLayoutPanel4.Controls.Add(this.flowLayoutPanel12);
            this.flowLayoutPanel4.Controls.Add(this.btnContReserv);
            this.flowLayoutPanel4.Controls.Add(this.dtpInvisible);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(1176, 956);
            this.flowLayoutPanel4.TabIndex = 51;
            this.flowLayoutPanel4.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel4_Paint);
            // 
            // flowLayoutPanel12
            // 
            this.flowLayoutPanel12.BackColor = System.Drawing.SystemColors.Window;
            this.flowLayoutPanel12.Controls.Add(this.flowLayoutPanel14);
            this.flowLayoutPanel12.Location = new System.Drawing.Point(3, 417);
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
            // btnContReserv
            // 
            this.btnContReserv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.btnContReserv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContReserv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContReserv.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContReserv.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnContReserv.Location = new System.Drawing.Point(4, 495);
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
            this.dtpInvisible.Location = new System.Drawing.Point(3, 543);
            this.dtpInvisible.Name = "dtpInvisible";
            this.dtpInvisible.Size = new System.Drawing.Size(200, 29);
            this.dtpInvisible.TabIndex = 46;
            this.dtpInvisible.Visible = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label11);
            this.flowLayoutPanel2.Controls.Add(this.txtCantHabs);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(349, 57);
            this.flowLayoutPanel2.TabIndex = 50;
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
            this.txtCantHabs.Size = new System.Drawing.Size(342, 29);
            this.txtCantHabs.TabIndex = 1;
            // 
            // ReservacionExtensionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 980);
            this.Controls.Add(this.flowLayoutPanel4);
            this.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReservacionExtensionWindow";
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
            this.flowLayoutPanel12.ResumeLayout(false);
            this.flowLayoutPanel14.ResumeLayout(false);
            this.flowLayoutPanel14.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
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
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel12;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel14;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnContReserv;
        private System.Windows.Forms.DateTimePicker dtpInvisible;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCantHabs;
    }
}