
namespace Hotelera
{
    partial class CheckInWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckInWindow));
            this.label1 = new System.Windows.Forms.Label();
            this.txtCdoReserv = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dgvHabsReserv = new System.Windows.Forms.DataGridView();
            this.btnConfirmarCheckIn = new System.Windows.Forms.Button();
            this.dtpInvisible = new System.Windows.Forms.DateTimePicker();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabsReserv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduzca un codigo de resevacion";
            // 
            // txtCdoReserv
            // 
            this.txtCdoReserv.Location = new System.Drawing.Point(3, 22);
            this.txtCdoReserv.Name = "txtCdoReserv";
            this.txtCdoReserv.Size = new System.Drawing.Size(648, 29);
            this.txtCdoReserv.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.txtCdoReserv);
            this.flowLayoutPanel1.Controls.Add(this.dgvHabsReserv);
            this.flowLayoutPanel1.Controls.Add(this.btnConfirmarCheckIn);
            this.flowLayoutPanel1.Controls.Add(this.dtpInvisible);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(651, 336);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // dgvHabsReserv
            // 
            this.dgvHabsReserv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHabsReserv.Location = new System.Drawing.Point(3, 57);
            this.dgvHabsReserv.Name = "dgvHabsReserv";
            this.dgvHabsReserv.Size = new System.Drawing.Size(648, 212);
            this.dgvHabsReserv.TabIndex = 2;
            // 
            // btnConfirmarCheckIn
            // 
            this.btnConfirmarCheckIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.btnConfirmarCheckIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmarCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmarCheckIn.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarCheckIn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConfirmarCheckIn.Location = new System.Drawing.Point(3, 297);
            this.btnConfirmarCheckIn.Margin = new System.Windows.Forms.Padding(3, 25, 3, 25);
            this.btnConfirmarCheckIn.Name = "btnConfirmarCheckIn";
            this.btnConfirmarCheckIn.Size = new System.Drawing.Size(648, 34);
            this.btnConfirmarCheckIn.TabIndex = 31;
            this.btnConfirmarCheckIn.Text = "Confirmar Check In";
            this.btnConfirmarCheckIn.UseVisualStyleBackColor = false;
            this.btnConfirmarCheckIn.Click += new System.EventHandler(this.btnConfirmarCheckIn_Click);
            // 
            // dtpInvisible
            // 
            this.dtpInvisible.Location = new System.Drawing.Point(3, 359);
            this.dtpInvisible.Name = "dtpInvisible";
            this.dtpInvisible.Size = new System.Drawing.Size(200, 29);
            this.dtpInvisible.TabIndex = 32;
            this.dtpInvisible.Visible = false;
            // 
            // CheckInWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 360);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CheckInWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotelera - Check In";
            this.Load += new System.EventHandler(this.CheckInWindow_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabsReserv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCdoReserv;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvHabsReserv;
        private System.Windows.Forms.Button btnConfirmarCheckIn;
        private System.Windows.Forms.DateTimePicker dtpInvisible;
    }
}