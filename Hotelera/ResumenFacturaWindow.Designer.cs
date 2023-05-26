
namespace Hotelera
{
    partial class ResumenFacturaWindow
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
            this.dgvFact = new System.Windows.Forms.DataGridView();
            this.dgvHabs = new System.Windows.Forms.DataGridView();
            this.dgvSa = new System.Windows.Forms.DataGridView();
            this.btnTicket = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSa)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFact
            // 
            this.dgvFact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFact.Location = new System.Drawing.Point(12, 12);
            this.dgvFact.Name = "dgvFact";
            this.dgvFact.Size = new System.Drawing.Size(1176, 112);
            this.dgvFact.TabIndex = 0;
            // 
            // dgvHabs
            // 
            this.dgvHabs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHabs.Location = new System.Drawing.Point(12, 130);
            this.dgvHabs.Name = "dgvHabs";
            this.dgvHabs.Size = new System.Drawing.Size(1176, 358);
            this.dgvHabs.TabIndex = 1;
            // 
            // dgvSa
            // 
            this.dgvSa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSa.Location = new System.Drawing.Point(12, 494);
            this.dgvSa.Name = "dgvSa";
            this.dgvSa.Size = new System.Drawing.Size(1176, 250);
            this.dgvSa.TabIndex = 2;
            // 
            // btnTicket
            // 
            this.btnTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.btnTicket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTicket.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTicket.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTicket.Location = new System.Drawing.Point(840, 751);
            this.btnTicket.Margin = new System.Windows.Forms.Padding(4);
            this.btnTicket.Name = "btnTicket";
            this.btnTicket.Size = new System.Drawing.Size(348, 41);
            this.btnTicket.TabIndex = 48;
            this.btnTicket.Text = "Imprimir factura";
            this.btnTicket.UseVisualStyleBackColor = false;
            this.btnTicket.Click += new System.EventHandler(this.btnTicket_Click);
            // 
            // ResumenFacturaWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 813);
            this.Controls.Add(this.btnTicket);
            this.Controls.Add(this.dgvSa);
            this.Controls.Add(this.dgvHabs);
            this.Controls.Add(this.dgvFact);
            this.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ResumenFacturaWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResumenFacturaWindow";
            this.Load += new System.EventHandler(this.ResumenFacturaWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFact;
        private System.Windows.Forms.DataGridView dgvHabs;
        private System.Windows.Forms.DataGridView dgvSa;
        private System.Windows.Forms.Button btnTicket;
    }
}