
namespace Hotelera
{
    partial class AddServiciosAdicionalesHotelWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddServiciosAdicionalesHotelWindow));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbServAdicionalesDisp = new System.Windows.Forms.ListBox();
            this.btnAggServAdicionales = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.lbServAdicionalesAgg = new System.Windows.Forms.ListBox();
            this.btnEliminarServAdicionalesAgg = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.btnAggServAdicionales);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel1.Controls.Add(this.btnEliminarServAdicionalesAgg);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(901, 496);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.lbServAdicionalesDisp);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(898, 167);
            this.flowLayoutPanel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Servicios adicionales disponibles";
            // 
            // lbServAdicionalesDisp
            // 
            this.lbServAdicionalesDisp.FormattingEnabled = true;
            this.lbServAdicionalesDisp.ItemHeight = 19;
            this.lbServAdicionalesDisp.Location = new System.Drawing.Point(3, 22);
            this.lbServAdicionalesDisp.Name = "lbServAdicionalesDisp";
            this.lbServAdicionalesDisp.Size = new System.Drawing.Size(895, 137);
            this.lbServAdicionalesDisp.TabIndex = 0;
            // 
            // btnAggServAdicionales
            // 
            this.btnAggServAdicionales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.btnAggServAdicionales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAggServAdicionales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAggServAdicionales.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAggServAdicionales.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAggServAdicionales.Location = new System.Drawing.Point(3, 198);
            this.btnAggServAdicionales.Margin = new System.Windows.Forms.Padding(3, 25, 3, 25);
            this.btnAggServAdicionales.Name = "btnAggServAdicionales";
            this.btnAggServAdicionales.Size = new System.Drawing.Size(898, 34);
            this.btnAggServAdicionales.TabIndex = 31;
            this.btnAggServAdicionales.Text = "Agregar";
            this.btnAggServAdicionales.UseVisualStyleBackColor = false;
            this.btnAggServAdicionales.Click += new System.EventHandler(this.btnAggServAdicionales_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.label3);
            this.flowLayoutPanel3.Controls.Add(this.lbServAdicionalesAgg);
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 260);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(898, 164);
            this.flowLayoutPanel3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Servicios adicionales agregados";
            // 
            // lbServAdicionalesAgg
            // 
            this.lbServAdicionalesAgg.FormattingEnabled = true;
            this.lbServAdicionalesAgg.ItemHeight = 19;
            this.lbServAdicionalesAgg.Location = new System.Drawing.Point(3, 22);
            this.lbServAdicionalesAgg.Name = "lbServAdicionalesAgg";
            this.lbServAdicionalesAgg.Size = new System.Drawing.Size(895, 137);
            this.lbServAdicionalesAgg.TabIndex = 0;
            // 
            // btnEliminarServAdicionalesAgg
            // 
            this.btnEliminarServAdicionalesAgg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.btnEliminarServAdicionalesAgg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarServAdicionalesAgg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarServAdicionalesAgg.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarServAdicionalesAgg.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminarServAdicionalesAgg.Location = new System.Drawing.Point(3, 452);
            this.btnEliminarServAdicionalesAgg.Margin = new System.Windows.Forms.Padding(3, 25, 3, 25);
            this.btnEliminarServAdicionalesAgg.Name = "btnEliminarServAdicionalesAgg";
            this.btnEliminarServAdicionalesAgg.Size = new System.Drawing.Size(898, 34);
            this.btnEliminarServAdicionalesAgg.TabIndex = 32;
            this.btnEliminarServAdicionalesAgg.Text = "Eliminar";
            this.btnEliminarServAdicionalesAgg.UseVisualStyleBackColor = false;
            this.btnEliminarServAdicionalesAgg.Click += new System.EventHandler(this.btnEliminarServAdicionalesAgg_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCerrar.Location = new System.Drawing.Point(756, 536);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(3, 25, 3, 25);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(157, 34);
            this.btnCerrar.TabIndex = 34;
            this.btnCerrar.Text = "Cerrar y guardar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // AddServiciosAdicionalesHotelWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 604);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddServiciosAdicionalesHotelWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotelera - Agregar servicios adicionales";
            this.Load += new System.EventHandler(this.AddServiciosAdicionalesHotelWindow_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbServAdicionalesDisp;
        private System.Windows.Forms.Button btnAggServAdicionales;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbServAdicionalesAgg;
        private System.Windows.Forms.Button btnEliminarServAdicionalesAgg;
        private System.Windows.Forms.Button btnCerrar;
    }
}