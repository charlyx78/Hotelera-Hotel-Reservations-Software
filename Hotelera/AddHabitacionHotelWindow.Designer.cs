
namespace Hotelera
{
    partial class AddHabitacionHotelWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddHabitacionHotelWindow));
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.dgvHabitaciones = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNuevaHab = new System.Windows.Forms.Button();
            this.btnEditarHab = new System.Windows.Forms.Button();
            this.btnEliminarHab = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel8 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTipoHab = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel9 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPiso = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel10 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNoHab = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitaciones)).BeginInit();
            this.flowLayoutPanel6.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel8.SuspendLayout();
            this.flowLayoutPanel9.SuspendLayout();
            this.flowLayoutPanel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.dgvHabitaciones);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel6);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(900, 732);
            this.flowLayoutPanel2.TabIndex = 9;
            // 
            // dgvHabitaciones
            // 
            this.dgvHabitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHabitaciones.Location = new System.Drawing.Point(3, 3);
            this.dgvHabitaciones.Name = "dgvHabitaciones";
            this.dgvHabitaciones.Size = new System.Drawing.Size(897, 497);
            this.dgvHabitaciones.TabIndex = 1;
            this.dgvHabitaciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHabitaciones_CellClick);
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Controls.Add(this.flowLayoutPanel7);
            this.flowLayoutPanel6.Controls.Add(this.flowLayoutPanel1);
            this.flowLayoutPanel6.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel6.Location = new System.Drawing.Point(3, 506);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(898, 220);
            this.flowLayoutPanel6.TabIndex = 8;
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.Controls.Add(this.btnNuevaHab);
            this.flowLayoutPanel7.Controls.Add(this.btnEditarHab);
            this.flowLayoutPanel7.Controls.Add(this.btnEliminarHab);
            this.flowLayoutPanel7.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(163, 212);
            this.flowLayoutPanel7.TabIndex = 34;
            // 
            // btnNuevaHab
            // 
            this.btnNuevaHab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.btnNuevaHab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevaHab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaHab.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaHab.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNuevaHab.Location = new System.Drawing.Point(3, 25);
            this.btnNuevaHab.Margin = new System.Windows.Forms.Padding(3, 25, 3, 25);
            this.btnNuevaHab.Name = "btnNuevaHab";
            this.btnNuevaHab.Size = new System.Drawing.Size(157, 34);
            this.btnNuevaHab.TabIndex = 34;
            this.btnNuevaHab.Text = "Nuevo";
            this.btnNuevaHab.UseVisualStyleBackColor = false;
            this.btnNuevaHab.Click += new System.EventHandler(this.btnNuevaHab_Click);
            // 
            // btnEditarHab
            // 
            this.btnEditarHab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.btnEditarHab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarHab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarHab.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarHab.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditarHab.Location = new System.Drawing.Point(3, 87);
            this.btnEditarHab.Margin = new System.Windows.Forms.Padding(3, 3, 3, 25);
            this.btnEditarHab.Name = "btnEditarHab";
            this.btnEditarHab.Size = new System.Drawing.Size(157, 34);
            this.btnEditarHab.TabIndex = 31;
            this.btnEditarHab.Text = "Editar";
            this.btnEditarHab.UseVisualStyleBackColor = false;
            this.btnEditarHab.Click += new System.EventHandler(this.btnEditarHab_Click);
            // 
            // btnEliminarHab
            // 
            this.btnEliminarHab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.btnEliminarHab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarHab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarHab.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarHab.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminarHab.Location = new System.Drawing.Point(3, 149);
            this.btnEliminarHab.Margin = new System.Windows.Forms.Padding(3, 3, 3, 25);
            this.btnEliminarHab.Name = "btnEliminarHab";
            this.btnEliminarHab.Size = new System.Drawing.Size(157, 34);
            this.btnEliminarHab.TabIndex = 32;
            this.btnEliminarHab.Text = "Eliminar";
            this.btnEliminarHab.UseVisualStyleBackColor = false;
            this.btnEliminarHab.Click += new System.EventHandler(this.btnEliminarHab_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel8);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel9);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel10);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(172, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(725, 212);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // flowLayoutPanel8
            // 
            this.flowLayoutPanel8.Controls.Add(this.label3);
            this.flowLayoutPanel8.Controls.Add(this.txtTipoHab);
            this.flowLayoutPanel8.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel8.Name = "flowLayoutPanel8";
            this.flowLayoutPanel8.Size = new System.Drawing.Size(232, 57);
            this.flowLayoutPanel8.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo de habitación";
            // 
            // txtTipoHab
            // 
            this.txtTipoHab.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoHab.FormattingEnabled = true;
            this.txtTipoHab.Location = new System.Drawing.Point(3, 22);
            this.txtTipoHab.Name = "txtTipoHab";
            this.txtTipoHab.Size = new System.Drawing.Size(225, 27);
            this.txtTipoHab.TabIndex = 16;
            // 
            // flowLayoutPanel9
            // 
            this.flowLayoutPanel9.Controls.Add(this.label1);
            this.flowLayoutPanel9.Controls.Add(this.txtPiso);
            this.flowLayoutPanel9.Location = new System.Drawing.Point(241, 3);
            this.flowLayoutPanel9.Name = "flowLayoutPanel9";
            this.flowLayoutPanel9.Size = new System.Drawing.Size(232, 57);
            this.flowLayoutPanel9.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Piso";
            // 
            // txtPiso
            // 
            this.txtPiso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPiso.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPiso.Location = new System.Drawing.Point(3, 22);
            this.txtPiso.Name = "txtPiso";
            this.txtPiso.Size = new System.Drawing.Size(225, 29);
            this.txtPiso.TabIndex = 3;
            // 
            // flowLayoutPanel10
            // 
            this.flowLayoutPanel10.Controls.Add(this.label4);
            this.flowLayoutPanel10.Controls.Add(this.txtNoHab);
            this.flowLayoutPanel10.Location = new System.Drawing.Point(479, 3);
            this.flowLayoutPanel10.Name = "flowLayoutPanel10";
            this.flowLayoutPanel10.Size = new System.Drawing.Size(232, 57);
            this.flowLayoutPanel10.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Número de habitación";
            // 
            // txtNoHab
            // 
            this.txtNoHab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNoHab.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoHab.Location = new System.Drawing.Point(3, 22);
            this.txtNoHab.Name = "txtNoHab";
            this.txtNoHab.Size = new System.Drawing.Size(225, 29);
            this.txtNoHab.TabIndex = 3;
            // 
            // AddHabitacionHotelWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 756);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddHabitacionHotelWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotelera  - Agregar habitacion a hotel";
            this.Load += new System.EventHandler(this.AddTipoHabitacionHotelWindow_Load);
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitaciones)).EndInit();
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel7.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel8.ResumeLayout(false);
            this.flowLayoutPanel8.PerformLayout();
            this.flowLayoutPanel9.ResumeLayout(false);
            this.flowLayoutPanel9.PerformLayout();
            this.flowLayoutPanel10.ResumeLayout(false);
            this.flowLayoutPanel10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.DataGridView dgvHabitaciones;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
        private System.Windows.Forms.Button btnNuevaHab;
        private System.Windows.Forms.Button btnEditarHab;
        private System.Windows.Forms.Button btnEliminarHab;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox txtTipoHab;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPiso;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNoHab;
    }
}