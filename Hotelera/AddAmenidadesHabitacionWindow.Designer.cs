
namespace Hotelera
{
    partial class AddAmenidadesHabitacionWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAmenidadesHabitacionWindow));
            this.lbAmHabDisp = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAggAmHab = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.lbAmHabAg = new System.Windows.Forms.ListBox();
            this.btnEliminarAmHabAgg = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbAmHabDisp
            // 
            this.lbAmHabDisp.FormattingEnabled = true;
            this.lbAmHabDisp.ItemHeight = 19;
            this.lbAmHabDisp.Location = new System.Drawing.Point(3, 22);
            this.lbAmHabDisp.Name = "lbAmHabDisp";
            this.lbAmHabDisp.Size = new System.Drawing.Size(895, 137);
            this.lbAmHabDisp.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.btnAggAmHab);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel1.Controls.Add(this.btnEliminarAmHabAgg);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(901, 496);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.lbAmHabDisp);
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
            this.label1.Size = new System.Drawing.Size(275, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Amenidades de habitacion disponibles";
            // 
            // btnAggAmHab
            // 
            this.btnAggAmHab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.btnAggAmHab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAggAmHab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAggAmHab.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAggAmHab.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAggAmHab.Location = new System.Drawing.Point(3, 198);
            this.btnAggAmHab.Margin = new System.Windows.Forms.Padding(3, 25, 3, 25);
            this.btnAggAmHab.Name = "btnAggAmHab";
            this.btnAggAmHab.Size = new System.Drawing.Size(898, 34);
            this.btnAggAmHab.TabIndex = 31;
            this.btnAggAmHab.Text = "Agregar";
            this.btnAggAmHab.UseVisualStyleBackColor = false;
            this.btnAggAmHab.Click += new System.EventHandler(this.btnNuevoTipoHab_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.label3);
            this.flowLayoutPanel3.Controls.Add(this.lbAmHabAg);
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
            this.label3.Size = new System.Drawing.Size(268, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Amenidades de habitacion agregadas";
            // 
            // lbAmHabAg
            // 
            this.lbAmHabAg.FormattingEnabled = true;
            this.lbAmHabAg.ItemHeight = 19;
            this.lbAmHabAg.Location = new System.Drawing.Point(3, 22);
            this.lbAmHabAg.Name = "lbAmHabAg";
            this.lbAmHabAg.Size = new System.Drawing.Size(895, 137);
            this.lbAmHabAg.TabIndex = 0;
            // 
            // btnEliminarAmHabAgg
            // 
            this.btnEliminarAmHabAgg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.btnEliminarAmHabAgg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarAmHabAgg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarAmHabAgg.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarAmHabAgg.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminarAmHabAgg.Location = new System.Drawing.Point(3, 452);
            this.btnEliminarAmHabAgg.Margin = new System.Windows.Forms.Padding(3, 25, 3, 25);
            this.btnEliminarAmHabAgg.Name = "btnEliminarAmHabAgg";
            this.btnEliminarAmHabAgg.Size = new System.Drawing.Size(898, 34);
            this.btnEliminarAmHabAgg.TabIndex = 32;
            this.btnEliminarAmHabAgg.Text = "Eliminar";
            this.btnEliminarAmHabAgg.UseVisualStyleBackColor = false;
            this.btnEliminarAmHabAgg.Click += new System.EventHandler(this.btnEliminarAmHabAg_Click);
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
            this.btnCerrar.TabIndex = 32;
            this.btnCerrar.Text = "Cerrar y guardar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // AddAmenidadesHabitacionWindow
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
            this.Name = "AddAmenidadesHabitacionWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotelera - Agregar amenidad de habitacion";
            this.Load += new System.EventHandler(this.AddAmenidadesHabitacionWindow_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbAmHabDisp;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbAmHabAg;
        private System.Windows.Forms.Button btnAggAmHab;
        private System.Windows.Forms.Button btnEliminarAmHabAgg;
        private System.Windows.Forms.Button btnCerrar;
    }
}