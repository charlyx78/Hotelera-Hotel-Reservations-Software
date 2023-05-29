
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
            this.dtpInvisible = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnExt = new System.Windows.Forms.Button();
            this.btnPago = new System.Windows.Forms.Button();
            this.flpExt = new System.Windows.Forms.FlowLayoutPanel();
            this.btnExtReserv = new System.Windows.Forms.Button();
            this.flpPago = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvServDisp = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvServAgg = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMontoPendiente = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnConfirmarCheckIn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flpExt.SuspendLayout();
            this.flpPago.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServDisp)).BeginInit();
            this.flowLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServAgg)).BeginInit();
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
            this.flowLayoutPanel1.Controls.Add(this.dtpInvisible);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.flpExt);
            this.flowLayoutPanel1.Controls.Add(this.flpPago);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(779, 846);
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
            // dtpInvisible
            // 
            this.dtpInvisible.Location = new System.Drawing.Point(3, 57);
            this.dtpInvisible.Name = "dtpInvisible";
            this.dtpInvisible.Size = new System.Drawing.Size(200, 29);
            this.dtpInvisible.TabIndex = 44;
            this.dtpInvisible.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 19);
            this.label5.TabIndex = 38;
            this.label5.Text = "¿Qué deseas hacer?";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnExt);
            this.flowLayoutPanel2.Controls.Add(this.btnPago);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 111);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(776, 35);
            this.flowLayoutPanel2.TabIndex = 41;
            // 
            // btnExt
            // 
            this.btnExt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.btnExt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExt.Enabled = false;
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
            this.flpExt.Location = new System.Drawing.Point(3, 152);
            this.flpExt.Name = "flpExt";
            this.flpExt.Size = new System.Drawing.Size(776, 114);
            this.flpExt.TabIndex = 42;
            this.flpExt.Visible = false;
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
            // flpPago
            // 
            this.flpPago.Controls.Add(this.flowLayoutPanel3);
            this.flpPago.Controls.Add(this.flowLayoutPanel5);
            this.flpPago.Controls.Add(this.label3);
            this.flpPago.Controls.Add(this.txtMontoPendiente);
            this.flpPago.Location = new System.Drawing.Point(3, 272);
            this.flpPago.Name = "flpPago";
            this.flpPago.Size = new System.Drawing.Size(776, 433);
            this.flpPago.TabIndex = 43;
            this.flpPago.Visible = false;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.label2);
            this.flowLayoutPanel3.Controls.Add(this.dgvServDisp);
            this.flowLayoutPanel3.Controls.Add(this.button3);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(375, 377);
            this.flowLayoutPanel3.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Servicios del hotel";
            // 
            // dgvServDisp
            // 
            this.dgvServDisp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServDisp.Location = new System.Drawing.Point(3, 22);
            this.dgvServDisp.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.dgvServDisp.Name = "dgvServDisp";
            this.dgvServDisp.Size = new System.Drawing.Size(372, 298);
            this.dgvServDisp.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(3, 343);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(372, 34);
            this.button3.TabIndex = 42;
            this.button3.Text = "Agregar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.label6);
            this.flowLayoutPanel5.Controls.Add(this.dgvServAgg);
            this.flowLayoutPanel5.Controls.Add(this.button4);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(384, 3);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(389, 377);
            this.flowLayoutPanel5.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(260, 19);
            this.label6.TabIndex = 2;
            this.label6.Text = "Servicios agregados a la reservación";
            // 
            // dgvServAgg
            // 
            this.dgvServAgg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServAgg.Location = new System.Drawing.Point(3, 22);
            this.dgvServAgg.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.dgvServAgg.Name = "dgvServAgg";
            this.dgvServAgg.Size = new System.Drawing.Size(383, 298);
            this.dgvServAgg.TabIndex = 3;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(3, 343);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(383, 34);
            this.button4.TabIndex = 43;
            this.button4.Text = "Eliminar";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 383);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Monto pendiente a pagar";
            // 
            // txtMontoPendiente
            // 
            this.txtMontoPendiente.Location = new System.Drawing.Point(3, 405);
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
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 711);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(773, 62);
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
            // CheckOutWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 881);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CheckOutWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotelera - Check Out";
            this.Load += new System.EventHandler(this.CheckOutWindow_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flpExt.ResumeLayout(false);
            this.flpExt.PerformLayout();
            this.flpPago.ResumeLayout(false);
            this.flpPago.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServDisp)).EndInit();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServAgg)).EndInit();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvServDisp;
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
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvServAgg;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DateTimePicker dtpInvisible;
    }
}