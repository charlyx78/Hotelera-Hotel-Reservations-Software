using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotelera
{
    public partial class ServiciosAdicionalesWindow : Form
    {
        int idUsuario;
        public ServiciosAdicionalesWindow(int idUsuarioParam)
        {
            idUsuario = idUsuarioParam;
            InitializeComponent();
        }
        private void ServiciosAdicionalesWindow_Load(object sender, EventArgs e)
        {
            actualizar();
        }

        private void btnNuevoServAdicional_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtDescripcion.Text == "" || txtCosto.Text == "")
            {
                MessageBox.Show("Por favor, llene todos los campos para registrar un servicio adicional", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                EnlaceDB enlace = new EnlaceDB();
                if (enlace.Gestion_ServAdicionales("I", 0, txtNombre.Text.Trim(), txtDescripcion.Text.Trim(), float.Parse(txtCosto.Text.Trim(), CultureInfo.InvariantCulture.NumberFormat), idUsuario))
                {
                    this.Controls.Clear();
                    MessageBox.Show("Servicio adicional registrado exitosamente!", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.InitializeComponent();
                    actualizar();
                }
            }
        }

        private void btnEditarServiAdicional_Click(object sender, EventArgs e)
        {
            if (dgvServAdicionales.CurrentRow.Index != -1)
            {
                if (txtNombre.Text == "")
                {
                    MessageBox.Show("Por favor, llene todos los campos para editar un servicio adicional", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    EnlaceDB enlace = new EnlaceDB();
                    if (enlace.Gestion_ServAdicionales(
                        "U",
                        Convert.ToInt32(dgvServAdicionales.Rows[dgvServAdicionales.CurrentRow.Index].Cells[0].Value),
                        txtNombre.Text.Trim(), txtDescripcion.Text.Trim(), float.Parse(txtCosto.Text.Trim(), CultureInfo.InvariantCulture.NumberFormat), idUsuario))
                    {
                        this.Controls.Clear();
                        MessageBox.Show("Servicio adicional editado exitosamente!", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.InitializeComponent();
                        actualizar();
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un servicio adicional para editar", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarServAdicional_Click(object sender, EventArgs e)
        {
            if (dgvServAdicionales.CurrentRow.Index != -1)
            {
                if (MessageBox.Show("¿Está seguro de que desea eliminar este servicio adicional? Una vez eliminado, su información solo podrá ser recuperada por el SA", "Alerta!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (txtNombre.Text == "")
                    {
                        MessageBox.Show("Por favor, llene todos los campos para eliminar un servicio adicional", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        EnlaceDB enlace = new EnlaceDB();
                        if (enlace.Gestion_ServAdicionales(
                            "D",
                            Convert.ToInt32(dgvServAdicionales.Rows[dgvServAdicionales.CurrentRow.Index].Cells[0].Value),
                            "", "", 0, idUsuario))
                        {
                            this.Controls.Clear();
                            MessageBox.Show("Servicio adicional eliminado exitosamente!", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.InitializeComponent();
                            actualizar();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un servicio adicional para eliminar", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvServAdicionales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombre.Text = dgvServAdicionales.Rows[dgvServAdicionales.CurrentRow.Index].Cells[1].Value.ToString();
            txtDescripcion.Text = dgvServAdicionales.Rows[dgvServAdicionales.CurrentRow.Index].Cells[2].Value.ToString();
            txtCosto.Text = dgvServAdicionales.Rows[dgvServAdicionales.CurrentRow.Index].Cells[3].Value.ToString();

        }
        private void actualizar()
        {
            EnlaceDB enlace = new EnlaceDB();
            dgvServAdicionales.DataSource = enlace.get_ServAdicionales();
        }

        private void dgvServAdicionales_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.Value != null)
            {
                e.Value = "$" + e.Value.ToString();
                e.FormattingApplied = true;
            }
        }

        private void txtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
