
namespace Hotelera
{
    partial class AddCaracteristicasHabitacionWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCaracteristicasHabitacionWindow));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbCaractHabDisp = new System.Windows.Forms.ListBox();
            this.btnAggCaractHab = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.lbCaractHabAg = new System.Windows.Forms.ListBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnEliminarCaractHabAgg = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.btnAggCaractHab);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel1.Controls.Add(this.btnEliminarCaractHabAgg);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(901, 496);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Caracteristicas de habitacion disponibles";
            // 
            // lbCaractHabDisp
            // 
            this.lbCaractHabDisp.FormattingEnabled = true;
            this.lbCaractHabDisp.ItemHeight = 19;
            this.lbCaractHabDisp.Location = new System.Drawing.Point(3, 22);
            this.lbCaractHabDisp.Name = "lbCaractHabDisp";
            this.lbCaractHabDisp.Size = new System.Drawing.Size(895, 137);
            this.lbCaractHabDisp.TabIndex = 0;
            // 
            // btnAggCaractHab
            // 
            this.btnAggCaractHab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.btnAggCaractHab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAggCaractHab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAggCaractHab.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAggCaractHab.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAggCaractHab.Location = new System.Drawing.Point(3, 198);
            this.btnAggCaractHab.Margin = new System.Windows.Forms.Padding(3, 25, 3, 25);
            this.btnAggCaractHab.Name = "btnAggCaractHab";
            this.btnAggCaractHab.Size = new System.Drawing.Size(898, 34);
            this.btnAggCaractHab.TabIndex = 31;
            this.btnAggCaractHab.Text = "Agregar";
            this.btnAggCaractHab.UseVisualStyleBackColor = false;
            this.btnAggCaractHab.Click += new System.EventHandler(this.btnAggCaractHab_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.label3);
            this.flowLayoutPanel3.Controls.Add(this.lbCaractHabAg);
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
            this.label3.Size = new System.Drawing.Size(282, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Caracteristicas de habitacion agregadas";
            // 
            // lbCaractHabAg
            // 
            this.lbCaractHabAg.FormattingEnabled = true;
            this.lbCaractHabAg.ItemHeight = 19;
            this.lbCaractHabAg.Location = new System.Drawing.Point(3, 22);
            this.lbCaractHabAg.Name = "lbCaractHabAg";
            this.lbCaractHabAg.Size = new System.Drawing.Size(895, 137);
            this.lbCaractHabAg.TabIndex = 0;
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
            this.btnCerrar.TabIndex = 33;
            this.btnCerrar.Text = "Cerrar y guardar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnEliminarCaractHabAgg
            // 
            this.btnEliminarCaractHabAgg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.btnEliminarCaractHabAgg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarCaractHabAgg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCaractHabAgg.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCaractHabAgg.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminarCaractHabAgg.Location = new System.Drawing.Point(3, 452);
            this.btnEliminarCaractHabAgg.Margin = new System.Windows.Forms.Padding(3, 25, 3, 25);
            this.btnEliminarCaractHabAgg.Name = "btnEliminarCaractHabAgg";
            this.btnEliminarCaractHabAgg.Size = new System.Drawing.Size(898, 34);
            this.btnEliminarCaractHabAgg.TabIndex = 32;
            this.btnEliminarCaractHabAgg.Text = "Eliminar";
            this.btnEliminarCaractHabAgg.UseVisualStyleBackColor = false;
            this.btnEliminarCaractHabAgg.Click += new System.EventHandler(this.btnEliminarCaractHabAgg_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.lbCaractHabDisp);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(898, 167);
            this.flowLayoutPanel2.TabIndex = 4;
            // 
            // AddCaracteristicasHabitacionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 604);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnCerrar);
            this.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddCaracteristicasHabitacionWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotelera - Agregar características de habitación";
            this.Load += new System.EventHandler(this.AddCaracteristicasHabitacionWindow_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbCaractHabDisp;
        private System.Windows.Forms.Button btnAggCaractHab;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbCaractHabAg;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnEliminarCaractHabAgg;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    }
}