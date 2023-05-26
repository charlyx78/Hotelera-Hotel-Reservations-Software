
namespace Hotelera
{
    partial class HabitacionesReservacion
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
            this.dgvHabReserv = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnEliminarHabReserv = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabReserv)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvHabReserv
            // 
            this.dgvHabReserv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHabReserv.Location = new System.Drawing.Point(3, 3);
            this.dgvHabReserv.Name = "dgvHabReserv";
            this.dgvHabReserv.Size = new System.Drawing.Size(761, 503);
            this.dgvHabReserv.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.dgvHabReserv);
            this.flowLayoutPanel1.Controls.Add(this.btnEliminarHabReserv);
            this.flowLayoutPanel1.Controls.Add(this.btnCerrar);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(779, 580);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnEliminarHabReserv
            // 
            this.btnEliminarHabReserv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.btnEliminarHabReserv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarHabReserv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarHabReserv.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarHabReserv.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminarHabReserv.Location = new System.Drawing.Point(3, 512);
            this.btnEliminarHabReserv.Name = "btnEliminarHabReserv";
            this.btnEliminarHabReserv.Size = new System.Drawing.Size(384, 40);
            this.btnEliminarHabReserv.TabIndex = 38;
            this.btnEliminarHabReserv.Text = "Eliminar";
            this.btnEliminarHabReserv.UseVisualStyleBackColor = false;
            this.btnEliminarHabReserv.Click += new System.EventHandler(this.btnEliminarHabReserv_Click);
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
            this.btnCerrar.TabIndex = 37;
            this.btnCerrar.Text = "Cerrar y guardar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // HabitacionesReservacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 604);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HabitacionesReservacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotelera - Habitaciones de la reservacion";
            this.Load += new System.EventHandler(this.HabitacionesReservacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabReserv)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHabReserv;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnEliminarHabReserv;
        private System.Windows.Forms.Button btnCerrar;
    }
}