using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Hotelera
{
    public partial class UsuariosWindow : Form
    {
        int idUsuario;
        string regexContrasena = "^(?=.*[A-Z])(?=.*[a-z])(?=.*[@#$%^&+=])(.{8,})$";
        public UsuariosWindow(int idUsuarioParam)
        {
            idUsuario = idUsuarioParam;
            InitializeComponent();
        }
        private void UsuariosWindow_Load(object sender, EventArgs e)
        {
            EnlaceDB enlace = new EnlaceDB();
            actualizar();
            dgvUsuarios.ClearSelection();
            dgvUsuarios.MultiSelect = false;
            txtCiudad.DataSource = enlace.get_Combobox("SP_MostrarCiudades");
            txtCiudad.DisplayMember = "nombre";
            txtCiudad.ValueMember = "cveCiudad";
            txtPais.DataSource = enlace.get_Combobox("SP_MostrarPaises");
            txtPais.DisplayMember = "nombre";
            txtPais.ValueMember = "cvePais";
        }

        #region MENU 
        //private void hotelesMenuItem_Click(object sender, EventArgs e)
        //{
        //    HotelesWindow hotelesWindow = new HotelesWindow();
        //    hotelesWindow.Show();
        //    this.Close();
        //}


        private void habilitarInhabilitarUsuarioMenuItem_Click(object sender, EventArgs e)
        {
            UsuariosWindow usuariosWindow = new UsuariosWindow(idUsuario);
            usuariosWindow.Show();
            this.Close();
        }

        private void salirMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
#endregion MENU

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "" ||
                txtContraseña.Text == "" ||
                txtNombre.Text == "" ||
                txtApellidoPat.Text == "" ||
                txtApellidoMat.Text == "" ||
                txtNoNomina.Text == "" ||
                dtpFechNac.Text == "" ||
                txtCalle.Text == "" ||
                txtCol.Text == "" ||
                txtCiudad.Text == "" ||
                txtPais.Text == "" ||
                txtCel.Text == "")
            {
                MessageBox.Show("Por favor, llene todos los campos para registrar un usuario", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Regex.IsMatch(txtContraseña.Text.Trim(), regexContrasena))
            {
                MessageBox.Show("El formato de la contraseña no está permitido. Asegurese de que su contraseña incluya un minimo de 8 caracteres, una minuscula, una mayuscula y un caracter especial", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                EnlaceDB enlace = new EnlaceDB();
                if (
                enlace.Gestion_Usuario(
                    "I",
                    0,
                    txtCorreo.Text.Trim(),
                    txtContraseña.Text.Trim(),
                    txtNombre.Text.Trim(),
                    txtApellidoPat.Text.Trim(),
                    txtApellidoMat.Text.Trim(),
                    txtNoNomina.Text.Trim(),
                    dtpFechNac.Text.Trim(),
                    txtCalle.Text.Trim(),
                    txtCol.Text.Trim(),
                    txtCiudad.SelectedValue.ToString(),
                    txtPais.SelectedValue.ToString(),
                    txtTel.Text.Trim(),
                    txtCel.Text.Trim(),
                    1,
                    idUsuario))
                {
                    this.Controls.Clear();
                    MessageBox.Show("Usuario operativo registrado exitosamente!", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.InitializeComponent();
                    actualizar();
                }
            }
        }
        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow.Index != -1)
            {
                if (txtCorreo.Text == "" ||
                    txtContraseña.Text == "" ||
                    txtNombre.Text == "" ||
                    txtApellidoPat.Text == "" ||
                    txtApellidoMat.Text == "" ||
                    txtNoNomina.Text == "" ||
                    dtpFechNac.Text == "" ||
                    txtCalle.Text == "" ||
                    txtCol.Text == "" ||
                    txtCiudad.Text == "" ||
                    txtPais.Text == "" ||
                    txtCel.Text == "")
                {
                    MessageBox.Show("Por favor, llene todos los campos para editar al usuario", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!Regex.IsMatch(txtContraseña.Text.Trim(), regexContrasena))
                {
                    MessageBox.Show("El formato de la contraseña no está permitido. Asegurese de que su contraseña incluya un minimo de 8 caracteres, una minuscula, una mayuscula y un caracter especial", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    EnlaceDB enlace = new EnlaceDB();
                    if (
                    enlace.Gestion_Usuario(
                        "U",
                        Convert.ToInt32(dgvUsuarios.Rows[dgvUsuarios.CurrentRow.Index].Cells[0].Value),
                        txtCorreo.Text.Trim(),
                        txtContraseña.Text.Trim(),
                        txtNombre.Text.Trim(),
                        txtApellidoPat.Text.Trim(),
                        txtApellidoMat.Text.Trim(),
                        txtNoNomina.Text.Trim(),
                        dtpFechNac.Text.Trim(),
                        txtCalle.Text.Trim(),
                        txtCol.Text.Trim(),
                        txtCiudad.SelectedValue.ToString(),
                        txtPais.SelectedValue.ToString(),
                        txtTel.Text.Trim(),
                        txtCel.Text.Trim(),
                        1,
                        idUsuario))
                    {
                        this.Controls.Clear();
                        MessageBox.Show("Usuario operativo editado exitosamente!", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.InitializeComponent();
                        actualizar();
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un usuario para editar", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow.Index != -1)
            {
                if (MessageBox.Show("¿Está seguro de que desea eliminar a este usuario? Una vez eliminado, su información será eliminada PERMANENTEMENTE", "Alerta!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    EnlaceDB enlace = new EnlaceDB();
                    if (enlace.Gestion_Usuario(
                        "D",
                        Convert.ToInt32(dgvUsuarios.Rows[dgvUsuarios.CurrentRow.Index].Cells[0].Value),
                        txtCorreo.Text.Trim(),
                        txtContraseña.Text.Trim(),
                        txtNombre.Text.Trim(),
                        txtApellidoPat.Text.Trim(),
                        txtApellidoMat.Text.Trim(),
                        txtNoNomina.Text.Trim(),
                        dtpFechNac.Text.Trim(),
                        txtCalle.Text.Trim(),
                        txtCol.Text.Trim(),
                        txtCiudad.Text.Trim(),
                        txtPais.Text.Trim(),
                        txtTel.Text.Trim(),
                        txtCel.Text.Trim(),
                        1,
                        idUsuario))
                    {
                        this.Controls.Clear();
                        MessageBox.Show("Usuario eliminado exitosamente", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.InitializeComponent();
                        actualizar();
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error al intentar eliminar el usuario, intentelo mas tarde", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un usuario para eliminar", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnHabUsuario_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow.Index != -1)
            {
                EnlaceDB enlace = new EnlaceDB();
                if (enlace.Gestion_Usuario(
                    "H",
                    Convert.ToInt32(dgvUsuarios.Rows[dgvUsuarios.CurrentRow.Index].Cells[0].Value),
                    txtCorreo.Text.Trim(),
                    txtContraseña.Text.Trim(),
                    txtNombre.Text.Trim(),
                    txtApellidoPat.Text.Trim(),
                    txtApellidoMat.Text.Trim(),
                    txtNoNomina.Text.Trim(),
                    dtpFechNac.Text.Trim(),
                    txtCalle.Text.Trim(),
                    txtCol.Text.Trim(),
                    txtCiudad.Text.Trim(),
                    txtPais.Text.Trim(),
                    txtTel.Text.Trim(),
                    txtCel.Text.Trim(),
                    1,
                    idUsuario))
                {
                    this.Controls.Clear();
                    MessageBox.Show("Usuario habilitado exitosamente", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.InitializeComponent();
                    actualizar();
                }
                else
                {
                    MessageBox.Show("Hubo un error al intentar habilitar el usuario, intentelo mas tarde", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un usuario para habilitar", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnInhabUsuario_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow != null)
            {
                EnlaceDB enlace = new EnlaceDB();
                if (enlace.Gestion_Usuario(
                    "X",
                    Convert.ToInt32(dgvUsuarios.Rows[dgvUsuarios.CurrentRow.Index].Cells[0].Value),
                    txtCorreo.Text.Trim(),
                    txtContraseña.Text.Trim(),
                    txtNombre.Text.Trim(),
                    txtApellidoPat.Text.Trim(),
                    txtApellidoMat.Text.Trim(),
                    txtNoNomina.Text.Trim(),
                    dtpFechNac.Text.Trim(),
                    txtCalle.Text.Trim(),
                    txtCol.Text.Trim(),
                    txtCiudad.Text.Trim(),
                    txtPais.Text.Trim(),
                    txtTel.Text.Trim(),
                    txtCel.Text.Trim(),
                    0,
                    idUsuario))
                {
                    this.Controls.Clear();
                    MessageBox.Show("Usuario inhabilitado exitosamente", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.InitializeComponent();
                    actualizar();

                }
                else
                {
                    MessageBox.Show("Hubo un error al intentar inhabilitar el usuario, intentelo mas tarde", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un usuario para inhabilitar", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCorreo.Text = dgvUsuarios.Rows[dgvUsuarios.CurrentRow.Index].Cells[1].Value.ToString();
            txtNombre.Text = dgvUsuarios.Rows[dgvUsuarios.CurrentRow.Index].Cells[2].Value.ToString();
            txtApellidoPat.Text = dgvUsuarios.Rows[dgvUsuarios.CurrentRow.Index].Cells[3].Value.ToString();
            txtApellidoMat.Text = dgvUsuarios.Rows[dgvUsuarios.CurrentRow.Index].Cells[4].Value.ToString();
            txtNoNomina.Text = dgvUsuarios.Rows[dgvUsuarios.CurrentRow.Index].Cells[5].Value.ToString();
            dtpFechNac.Text = dgvUsuarios.Rows[dgvUsuarios.CurrentRow.Index].Cells[6].Value.ToString();
            txtCalle.Text = dgvUsuarios.Rows[dgvUsuarios.CurrentRow.Index].Cells[7].Value.ToString();
            txtCol.Text = dgvUsuarios.Rows[dgvUsuarios.CurrentRow.Index].Cells[8].Value.ToString();
            txtCiudad.Text = dgvUsuarios.Rows[dgvUsuarios.CurrentRow.Index].Cells[9].Value.ToString();
            txtPais.Text = dgvUsuarios.Rows[dgvUsuarios.CurrentRow.Index].Cells[10].Value.ToString();
            txtTel.Text = dgvUsuarios.Rows[dgvUsuarios.CurrentRow.Index].Cells[11].Value.ToString();
            txtCel.Text = dgvUsuarios.Rows[dgvUsuarios.CurrentRow.Index].Cells[12].Value.ToString();
        }
        private void actualizar()
        {
            EnlaceDB enlace = new EnlaceDB();
            dgvUsuarios.DataSource = enlace.get_Usuarios("S");
        }

        private void txtCel_KeyPress(object sender, KeyPressEventArgs e)
        {
                        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
                        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNoNomina_KeyPress(object sender, KeyPressEventArgs e)
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

        private void habilitarInhabilitarUsuarioMenuItem_Click_1(object sender, EventArgs e)
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

        private void salirMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
