using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotelera
{
    public partial class HotelesWindow : Form
    {
        int idUsuario;
        public HotelesWindow(int idUsuarioParam)
        {
            idUsuario = idUsuarioParam;
            InitializeComponent();
        }
        private void HotelesWindow_Load(object sender, EventArgs e)
        {
            actualizar();
        }
        #region MENU   
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

        #endregion MENU
        private void btnNuevoHot_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == "" ||
                txtCalle.Text.Trim() == "" ||
                txtCol.Text.Trim() == "" ||
                txtCiudad.Text.Trim() == "" ||
                txtPais.Text.Trim() == "" ||
                txtCantPisos.Text.Trim() == "" ||
                txtZonaTuristica.Text=="" ||
                txtFechAp.Text.Trim() == "")
            {
                MessageBox.Show("Por favor, llene todos los campos para registrar un hotel", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                EnlaceDB enlace = new EnlaceDB();
                if (enlace.Gestion_Hotel(
                    "I",
                    0,
                    txtNombre.Text.Trim(),
                    txtCalle.Text.Trim(),
                    txtCol.Text.Trim(),
                    (string)txtCiudad.SelectedValue,
                    (string)txtPais.SelectedValue,
                    Convert.ToInt32(txtCantPisos.Text.Trim()),
                    0,
                    0,
                    Convert.ToInt32(txtZonaTuristica.SelectedValue),
                    txtFechAp.Text.Trim(),
                    idUsuario
                ))
                {
                    this.Controls.Clear();
                    MessageBox.Show("Hotel registrado exitosamente!", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.InitializeComponent();
                    actualizar();
                }
            }
        }
        private void btnEditarHotel_Click(object sender, EventArgs e)
        {
            if (dgvHoteles.CurrentRow.Index < 0)
            {
                MessageBox.Show("Seleccione un hotel a editar", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (txtNombre.Text.Trim() == "" ||
                  txtCalle.Text.Trim() == "" ||
                  txtCol.Text.Trim() == "" ||
                  txtCiudad.Text.Trim() == "" ||
                  txtPais.Text.Trim() == "" ||
                  txtCantPisos.Text.Trim() == "" ||
                  txtZonaTuristica.Text == "" ||
                  txtFechAp.Text.Trim() == "")
                {
                    MessageBox.Show("Por favor, llene todos los campos para actualizar el hotel", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    EnlaceDB enlace = new EnlaceDB();
                    if (enlace.Gestion_Hotel(
                        "U",
                        Convert.ToInt32(dgvHoteles.Rows[dgvHoteles.CurrentRow.Index].Cells[0].Value),
                        txtNombre.Text.Trim(),
                        txtCalle.Text.Trim(),
                        txtCol.Text.Trim(),
                        (string)txtCiudad.SelectedValue,
                        (string)txtPais.SelectedValue,
                        Convert.ToInt32(txtCantPisos.Text.Trim()),
                        0,
                        0,
                        Convert.ToInt32(txtZonaTuristica.SelectedValue),
                        txtFechAp.Text.Trim(),
                        idUsuario
                    ))
                    {
                        this.Controls.Clear();
                        MessageBox.Show("Hotel actualizado exitosamente!", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.InitializeComponent();
                        actualizar();
                    }
                }
            }
        }
        private void btnEliminarHotel_Click(object sender, EventArgs e)
        {
            if (dgvHoteles.CurrentRow.Index < 0)
            {
                MessageBox.Show("Seleccione un hotel a eliminar", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                EnlaceDB enlace = new EnlaceDB();
                if (enlace.Gestion_Hotel(
                    "D",
                    Convert.ToInt32(dgvHoteles.Rows[dgvHoteles.CurrentRow.Index].Cells[0].Value),
                    "",
                    "",
                    "",
                    "",
                    "",
                    0,
                    0,
                    0,
                    0,
                    txtFechAp.Text.Trim(),
                    idUsuario
                ))
                {
                    this.Controls.Clear();
                    MessageBox.Show("Hotel eliminado exitosamente!", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.InitializeComponent();
                    actualizar();
                }
            }
        }
        private void btnVerTiposHab_Click(object sender, EventArgs e)
        {
            int idHotelSeleccionado = Convert.ToInt32(dgvHoteles.Rows[dgvHoteles.CurrentRow.Index].Cells[0].Value);
            TiposHabitacionWindow tiposHabitacionWindow = new TiposHabitacionWindow(idUsuario, idHotelSeleccionado);
            tiposHabitacionWindow.ShowDialog();
            actualizar();
        }
        private void btnVerServAdicionales_Click(object sender, EventArgs e)
        {
            int idHotelSeleccionado = Convert.ToInt32(dgvHoteles.Rows[dgvHoteles.CurrentRow.Index].Cells[0].Value);
            ServiciosAdicionalesWindow serviciosAdicionalesWindow = new ServiciosAdicionalesWindow(idUsuario, idHotelSeleccionado);
            serviciosAdicionalesWindow.ShowDialog();
            actualizar();
        }
        private void actualizar()
        {
            EnlaceDB enlace = new EnlaceDB();
            dgvHoteles.DataSource = enlace.get_Hoteles();
            txtZonaTuristica.DataSource = enlace.get_Combobox("SP_MostrarZonasTuristicas");
            txtZonaTuristica.DisplayMember = "nombre";
            txtZonaTuristica.ValueMember = "idZonaTuristica";
            txtCiudad.DataSource = enlace.get_Combobox("SP_MostrarCiudades");
            txtCiudad.DisplayMember = "nombre";
            txtCiudad.ValueMember = "cveCiudad";
            txtPais.DataSource = enlace.get_Combobox("SP_MostrarPaises");
            txtPais.DisplayMember = "nombre";
            txtPais.ValueMember = "cvePais";
        }

        private void dgvHoteles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombre.Text = dgvHoteles.Rows[dgvHoteles.CurrentRow.Index].Cells[1].Value.ToString();
            txtCalle.Text = dgvHoteles.Rows[dgvHoteles.CurrentRow.Index].Cells[2].Value.ToString();
            txtCol.Text = dgvHoteles.Rows[dgvHoteles.CurrentRow.Index].Cells[3].Value.ToString();
            txtCiudad.Text = dgvHoteles.Rows[dgvHoteles.CurrentRow.Index].Cells[4].Value.ToString();
            txtPais.Text = dgvHoteles.Rows[dgvHoteles.CurrentRow.Index].Cells[5].Value.ToString();
            txtCantPisos.Text = dgvHoteles.Rows[dgvHoteles.CurrentRow.Index].Cells[6].Value.ToString();
            txtZonaTuristica.Text = dgvHoteles.Rows[dgvHoteles.CurrentRow.Index].Cells[9].Value.ToString();
            txtFechAp.Text = dgvHoteles.Rows[dgvHoteles.CurrentRow.Index].Cells[10].Value.ToString();
        }

        private void txtCantPisos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
