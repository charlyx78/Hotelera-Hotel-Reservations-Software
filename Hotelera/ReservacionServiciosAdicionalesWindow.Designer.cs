
namespace Hotelera
{
    partial class ReservacionServiciosAdicionalesWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservacionServiciosAdicionalesWindow));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dgvServAd = new System.Windows.Forms.DataGridView();
            this.btnEliminaServiAdicReserv = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServAd)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.dgvServAd);
            this.flowLayoutPanel1.Controls.Add(this.btnEliminaServiAdicReserv);
            this.flowLayoutPanel1.Controls.Add(this.btnCerrar);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(779, 580);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // dgvServAd
            // 
            this.dgvServAd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServAd.Location = new System.Drawing.Point(3, 3);
            this.dgvServAd.Name = "dgvServAd";
            this.dgvServAd.Size = new System.Drawing.Size(761, 503);
            this.dgvServAd.TabIndex = 0;
            // 
            // btnEliminaServiAdicReserv
            // 
            this.btnEliminaServiAdicReserv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.btnEliminaServiAdicReserv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminaServiAdicReserv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminaServiAdicReserv.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminaServiAdicReserv.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminaServiAdicReserv.Location = new System.Drawing.Point(3, 512);
            this.btnEliminaServiAdicReserv.Name = "btnEliminaServiAdicReserv";
            this.btnEliminaServiAdicReserv.Size = new System.Drawing.Size(384, 40);
            this.btnEliminaServiAdicReserv.TabIndex = 40;
            this.btnEliminaServiAdicReserv.Text = "Eliminar";
            this.btnEliminaServiAdicReserv.UseVisualStyleBackColor = false;
            this.btnEliminaServiAdicReserv.Click += new System.EventHandler(this.btnEliminaServiAdicReserv_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Gray;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCerrar.Location = new System.Drawing.Point(393, 512);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(371, 40);
            this.btnCerrar.TabIndex = 39;
            this.btnCerrar.Text = "Cerrar y guardar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // ReservacionServiciosAdicionalesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 604);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReservacionServiciosAdicionalesWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotelera - Agregar servicios adicionales a la reservacion";
            this.Load += new System.EventHandler(this.ReservacionServiciosAdicionalesWindow_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServAd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvServAd;
        private System.Windows.Forms.Button btnEliminaServiAdicReserv;
        private System.Windows.Forms.Button btnCerrar;
    }
}