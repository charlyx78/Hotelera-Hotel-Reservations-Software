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
        int idUsuario, idHotel;
        public ServiciosAdicionalesWindow(int idUsuarioParam, int idHotelParam)
        {
            idHotel = idHotelParam;
            idUsuario = idUsuarioParam;
            InitializeComponent();
        }
        private void ServiciosAdicionalesWindow_Load(object sender, EventArgs e)
        {
            actualizar();
        }

        private void btnNuevoServAdicional_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtCosto.Text == "")
            {
                MessageBox.Show("Por favor, llene todos los campos para registrar un servicio adicional", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                EnlaceDB enlace = new EnlaceDB();
                if (enlace.Gestion_ServAdicionales("I", 0, txtNombre.Text.Trim(), txtDescripcion.Text.Trim(), float.Parse(txtCosto.Text.Trim(), CultureInfo.InvariantCulture.NumberFormat), idHotel, idUsuario))
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
                        txtNombre.Text.Trim(), txtDescripcion.Text.Trim(), float.Parse(txtCosto.Text.Trim(), CultureInfo.InvariantCulture.NumberFormat), idHotel, idUsuario))
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
                    EnlaceDB enlace = new EnlaceDB();
                    if (enlace.Gestion_ServAdicionales(
                        "D",
                        Convert.ToInt32(dgvServAdicionales.Rows[dgvServAdicionales.CurrentRow.Index].Cells[0].Value),
                        "", "", 0, idHotel, idUsuario))
                    {
                        this.Controls.Clear();
                        MessageBox.Show("Servicio adicional eliminado exitosamente!", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.InitializeComponent();
                        actualizar();
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
            dgvServAdicionales.DataSource = enlace.get_ServAdicionales(idHotel);
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

        private void hotelesMenuItem_Click(object sender, EventArgs e)
        {
            HotelesWindow hotelesWindow = new HotelesWindow(idUsuario);
            hotelesWindow.Show();
            this.Close();
        }

        private void amHabMenuItem_Click(object sender, EventArgs e)
        {
            AmenidadesHabitacionWindow amenidadesHabitacion = new AmenidadesHabitacionWindow(idUsuario);
            amenidadesHabitacion.Show();
            this.Close();
        }

        private void caractHabMenuItem_Click(object sender, EventArgs e)
        {
            CaracteristicasHabitacionWindow caracteristicasHabitacion = new CaracteristicasHabitacionWindow(idUsuario);
            this.Close();
            caracteristicasHabitacion.Show();
        }

        private void habilitarInhabilitarUsuarioMenuItem_Click(object sender, EventArgs e)
        {
            UsuariosWindow usuariosWindow = new UsuariosWindow(idUsuario);
            usuariosWindow.Show();
            this.Close();
        }

        private void cancelarReservacionMenuItem_Click(object sender, EventArgs e)
        {
            CancelacionWindow cancelacionWindow = new CancelacionWindow(idUsuario);
            cancelacionWindow.Show();
            this.Close();
        }

        private void reporteDeOcupaciónPorHotelMenuItem_Click(object sender, EventArgs e)
        {
            ReporteOcupacionWindow reporteOcupacion = new ReporteOcupacionWindow(idUsuario);
            reporteOcupacion.Show();
            this.Close();
        }

        private void reporteDeVentasMenuItem_Click(object sender, EventArgs e)
        {
            ReporteVentasWindow reporteVentasWindow = new ReporteVentasWindow(idUsuario);
            reporteVentasWindow.Show();
            this.Close();
        }

        private void historialDeClienteMenuItem_Click(object sender, EventArgs e)
        {
            HistorialClienteWindow historialClienteWindow = new HistorialClienteWindow(idUsuario);
            historialClienteWindow.Show();
            this.Close();
        }

        private void salirMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
