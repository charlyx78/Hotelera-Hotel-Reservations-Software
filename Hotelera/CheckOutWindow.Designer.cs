
namespace Hotelera
{
    partial class CheckOutWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckOutWindow));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.txCdoReserv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnExt = new System.Windows.Forms.Button();
            this.btnPago = new System.Windows.Forms.Button();
            this.flpExt = new System.Windows.Forms.FlowLayoutPanel();
            this.flpPago = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvResumenReserv = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMontoPendiente = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnConfirmarCheckIn = new System.Windows.Forms.Button();
            this.btnExtReserv = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flpExt.SuspendLayout();
            this.flpPago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumenReserv)).BeginInit();
            this.flowLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(3, 22);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(770, 29);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha a extender reservación";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.txCdoReserv);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.flpExt);
            this.flowLayoutPanel1.Controls.Add(this.flpPago);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(779, 716);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 19);
            this.label4.TabIndex = 37;
            this.label4.Text = "Código de la reservación";
            // 
            // txCdoReserv
            // 
            this.txCdoReserv.Location = new System.Drawing.Point(3, 22);
            this.txCdoReserv.Name = "txCdoReserv";
            this.txCdoReserv.Size = new System.Drawing.Size(773, 29);
            this.txCdoReserv.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 19);
            this.label5.TabIndex = 38;
            this.label5.Text = "¿Qué deseas hacer?";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnExt);
            this.flowLayoutPanel2.Controls.Add(this.btnPago);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 76);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(776, 35);
            this.flowLayoutPanel2.TabIndex = 41;
            // 
            // btnExt
            // 
            this.btnExt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.btnExt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExt.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExt.Location = new System.Drawing.Point(3, 0);
            this.btnExt.Margin = new System.Windows.Forms.Padding(3, 0, 3, 25);
            this.btnExt.Name = "btnExt";
            this.btnExt.Size = new System.Drawing.Size(375, 34);
            this.btnExt.TabIndex = 40;
            this.btnExt.Text = "Extender reservación";
            this.btnExt.UseVisualStyleBackColor = false;
            this.btnExt.Click += new System.EventHandler(this.btnExt_Click);
            // 
            // btnPago
            // 
            this.btnPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.btnPago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPago.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPago.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPago.Location = new System.Drawing.Point(384, 0);
            this.btnPago.Margin = new System.Windows.Forms.Padding(3, 0, 3, 25);
            this.btnPago.Name = "btnPago";
            this.btnPago.Size = new System.Drawing.Size(389, 34);
            this.btnPago.TabIndex = 39;
            this.btnPago.Text = "Proceder al pago";
            this.btnPago.UseVisualStyleBackColor = false;
            this.btnPago.Click += new System.EventHandler(this.btnPago_Click);
            // 
            // flpExt
            // 
            this.flpExt.Controls.Add(this.label1);
            this.flpExt.Controls.Add(this.dateTimePicker1);
            this.flpExt.Controls.Add(this.btnExtReserv);
            this.flpExt.Location = new System.Drawing.Point(3, 117);
            this.flpExt.Name = "flpExt";
            this.flpExt.Size = new System.Drawing.Size(776, 114);
            this.flpExt.TabIndex = 42;
            this.flpExt.Visible = false;
            // 
            // flpPago
            // 
            this.flpPago.Controls.Add(this.label2);
            this.flpPago.Controls.Add(this.dgvResumenReserv);
            this.flpPago.Controls.Add(this.label3);
            this.flpPago.Controls.Add(this.txtMontoPendiente);
            this.flpPago.Controls.Add(this.flowLayoutPanel4);
            this.flpPago.Location = new System.Drawing.Point(3, 237);
            this.flpPago.Name = "flpPago";
            this.flpPago.Size = new System.Drawing.Size(776, 475);
            this.flpPago.TabIndex = 43;
            this.flpPago.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Resumen de los servicios de la reservación";
            // 
            // dgvResumenReserv
            // 
            this.dgvResumenReserv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResumenReserv.Location = new System.Drawing.Point(3, 22);
            this.dgvResumenReserv.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.dgvResumenReserv.Name = "dgvResumenReserv";
            this.dgvResumenReserv.Size = new System.Drawing.Size(776, 298);
            this.dgvResumenReserv.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Monto pendiente a pagar";
            // 
            // txtMontoPendiente
            // 
            this.txtMontoPendiente.Location = new System.Drawing.Point(3, 362);
            this.txtMontoPendiente.Name = "txtMontoPendiente";
            this.txtMontoPendiente.ReadOnly = true;
            this.txtMontoPendiente.Size = new System.Drawing.Size(776, 29);
            this.txtMontoPendiente.TabIndex = 5;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.button2);
            this.flowLayoutPanel4.Controls.Add(this.button1);
            this.flowLayoutPanel4.Controls.Add(this.btnConfirmarCheckIn);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 397);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(773, 67);
            this.flowLayoutPanel4.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(3, 25);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 25, 3, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(250, 34);
            this.button2.TabIndex = 34;
            this.button2.Text = "Pago con tarjeta de crédito";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(259, 25);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 25, 3, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 34);
            this.button1.TabIndex = 33;
            this.button1.Text = "Pago con tarjeta de débito";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnConfirmarCheckIn
            // 
            this.btnConfirmarCheckIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.btnConfirmarCheckIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmarCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmarCheckIn.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarCheckIn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConfirmarCheckIn.Location = new System.Drawing.Point(515, 25);
            this.btnConfirmarCheckIn.Margin = new System.Windows.Forms.Padding(3, 25, 3, 25);
            this.btnConfirmarCheckIn.Name = "btnConfirmarCheckIn";
            this.btnConfirmarCheckIn.Size = new System.Drawing.Size(255, 34);
            this.btnConfirmarCheckIn.TabIndex = 32;
            this.btnConfirmarCheckIn.Text = "Pago con efectivo";
            this.btnConfirmarCheckIn.UseVisualStyleBackColor = false;
            this.btnConfirmarCheckIn.Click += new System.EventHandler(this.btnConfirmarCheckIn_Click);
            // 
            // btnExtReserv
            // 
            this.btnExtReserv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.btnExtReserv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExtReserv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExtReserv.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtReserv.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExtReserv.Location = new System.Drawing.Point(3, 74);
            this.btnExtReserv.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.btnExtReserv.Name = "btnExtReserv";
            this.btnExtReserv.Size = new System.Drawing.Size(770, 34);
            this.btnExtReserv.TabIndex = 41;
            this.btnExtReserv.Text = "Confirmar";
            this.btnExtReserv.UseVisualStyleBackColor = false;
            this.btnExtReserv.Click += new System.EventHandler(this.btnExtReserv_Click);
            // 
            // CheckOutWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 720);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CheckOutWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotelera - Check Out";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flpExt.ResumeLayout(false);
            this.flpExt.PerformLayout();
            this.flpPago.ResumeLayout(false);
            this.flpPago.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumenReserv)).EndInit();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvResumenReserv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMontoPendiente;
        private System.Windows.Forms.Button btnConfirmarCheckIn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txCdoReserv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnExt;
        private System.Windows.Forms.Button btnPago;
        private System.Windows.Forms.FlowLayoutPanel flpExt;
        private System.Windows.Forms.FlowLayoutPanel flpPago;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Button btnExtReserv;
    }
}