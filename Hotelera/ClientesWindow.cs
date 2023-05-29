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
    public partial class ClientesWindow : Form
    {
        int idUsuario;
        string fechaOps;
        public ClientesWindow(int idUsuarioParam, string fechaOpsParam)
        {
            fechaOps = fechaOpsParam;
            idUsuario = idUsuarioParam;
            InitializeComponent();
        }
        private void ClientesWindow_Load(object sender, EventArgs e)
        {
            actualizar();
        }
        private void clientesMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void hacerReservaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReservacionesWindow reservacionesWindow = new ReservacionesWindow(idUsuario, fechaOps);
            reservacionesWindow.Owner = this;
            reservacionesWindow.ShowDialog();
        }
        private void checkInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckInWindow checkInWindow = new CheckInWindow(idUsuario, fechaOps);
            checkInWindow.ShowDialog();
        }
        private void checkOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckOutWindow checkOutWindow = new CheckOutWindow(idUsuario, fechaOps);
            checkOutWindow.ShowDialog();
        }
        private void salirMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            if (
                txtNombre.Text.Trim() == "" ||
                txtApellidoPat.Text.Trim() == "" ||
                txtApellidoMat.Text.Trim() == "" ||
                txtCalle.Text.Trim() == "" ||
                txtCol.Text.Trim() == "" ||
                txtCiudad.Text.Trim() == "" ||
                txtPais.Text.Trim() == "" ||
                txtRfc.Text.Trim() == "" ||
                txtCorreo.Text.Trim() == "" ||
                txtCel.Text.Trim() == "" ||
                txtReferencia.Text.Trim() == "" ||
                txtFechNac.Text.Trim() == "" ||
                txtEstadoCivil.Text.Trim() == "")
            {
                MessageBox.Show("Por favor, llene todos los campos para registrar un cliente", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                EnlaceDB enlace = new EnlaceDB();
                if (enlace.Gestion_Cliente(
                "I",
                0,
                txtNombre.Text.Trim(),
                txtApellidoPat.Text.Trim(),
                txtApellidoMat.Text.Trim(),
                txtCalle.Text.Trim(),
                txtCol.Text.Trim(),
                txtCiudad.SelectedValue.ToString(),
                txtPais.SelectedValue.ToString(),
                txtRfc.Text.Trim(),
                txtCorreo.Text.Trim(),
                txtTel.Text.Trim(),
                txtCel.Text.Trim(),
                Convert.ToInt32(txtReferencia.SelectedValue),
                txtFechNac.Text.Trim(),
                Convert.ToInt32(txtEstadoCivil.SelectedValue),
                idUsuario))
                {
                    this.Controls.Clear();
                    MessageBox.Show("Cliente registrado exitosamente!", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.InitializeComponent();
                    actualizar();
                }
            }
        }
        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow != null)
            {
                if (
                txtNombre.Text.Trim() == "" ||
                txtApellidoPat.Text.Trim() == "" ||
                txtApellidoMat.Text.Trim() == "" ||
                txtCalle.Text.Trim() == "" ||
                txtCol.Text.Trim() == "" ||
                txtCiudad.Text.Trim() == "" ||
                txtPais.Text.Trim() == "" ||
                txtRfc.Text.Trim() == "" ||
                txtCorreo.Text.Trim() == "" ||
                txtCel.Text.Trim() == "" ||
                txtReferencia.Text.Trim() == "" ||
                txtFechNac.Text.Trim() == "" ||
                txtEstadoCivil.Text.Trim() == "")
                {
                    MessageBox.Show("Por favor, llene todos los campos para editar un cliente", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    EnlaceDB enlace = new EnlaceDB();
                    if (enlace.Gestion_Cliente(
                    "U",
                    Convert.ToInt32(dgvClientes.Rows[dgvClientes.CurrentRow.Index].Cells[0].Value),
                    txtNombre.Text.Trim(),
                    txtApellidoPat.Text.Trim(),
                    txtApellidoMat.Text.Trim(),
                    txtCalle.Text.Trim(),
                    txtCol.Text.Trim(),
                    txtCiudad.SelectedValue.ToString(),
                    txtPais.SelectedValue.ToString(),
                    txtRfc.Text.Trim(),
                    txtCorreo.Text.Trim(),
                    txtTel.Text.Trim(),
                    txtCel.Text.Trim(),
                    Convert.ToInt32(txtReferencia.SelectedValue),
                    txtFechNac.Text.Trim(),
                    Convert.ToInt32(txtEstadoCivil.SelectedValue),
                    idUsuario))
                    {
                        this.Controls.Clear();
                        MessageBox.Show("Cliente editado exitosamente!", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.InitializeComponent();
                        actualizar();
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un cliente para editar", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow.Index != -1)
            {
                if (MessageBox.Show("¿Está seguro de que desea eliminar este cliente? Una vez eliminada, su información solo podrá ser recuperada por el SA", "Alerta!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    EnlaceDB enlace = new EnlaceDB();
                    if (enlace.Gestion_Cliente(
                    "D",
                    Convert.ToInt32(dgvClientes.Rows[dgvClientes.CurrentRow.Index].Cells[0].Value),
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    1,
                    txtFechNac.Text.Trim(),
                    1,
                    idUsuario))
                    {
                        this.Controls.Clear();
                        MessageBox.Show("Cliente eliminado exitosamente!", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.InitializeComponent();
                        actualizar();
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un cliente para eliminar", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombre.Text = dgvClientes.Rows[dgvClientes.CurrentRow.Index].Cells[1].Value.ToString();
            txtApellidoPat.Text = dgvClientes.Rows[dgvClientes.CurrentRow.Index].Cells[2].Value.ToString();
            txtApellidoMat.Text = dgvClientes.Rows[dgvClientes.CurrentRow.Index].Cells[3].Value.ToString();
            txtCalle.Text = dgvClientes.Rows[dgvClientes.CurrentRow.Index].Cells[4].Value.ToString();
            txtCol.Text = dgvClientes.Rows[dgvClientes.CurrentRow.Index].Cells[5].Value.ToString();
            txtCiudad.Text = dgvClientes.Rows[dgvClientes.CurrentRow.Index].Cells[6].Value.ToString();
            txtPais.Text = dgvClientes.Rows[dgvClientes.CurrentRow.Index].Cells[7].Value.ToString();
            txtRfc.Text = dgvClientes.Rows[dgvClientes.CurrentRow.Index].Cells[8].Value.ToString();
            txtCorreo.Text = dgvClientes.Rows[dgvClientes.CurrentRow.Index].Cells[9].Value.ToString();
            txtTel.Text = dgvClientes.Rows[dgvClientes.CurrentRow.Index].Cells[10].Value.ToString();
            txtCel.Text = dgvClientes.Rows[dgvClientes.CurrentRow.Index].Cells[11].Value.ToString();
            txtReferencia.Text = dgvClientes.Rows[dgvClientes.CurrentRow.Index].Cells[12].Value.ToString();
            txtFechNac.Text = dgvClientes.Rows[dgvClientes.CurrentRow.Index].Cells[13].Value.ToString();
            txtEstadoCivil.Text = dgvClientes.Rows[dgvClientes.CurrentRow.Index].Cells[14].Value.ToString();
        }
        private void actualizar()
        {
            EnlaceDB enlace = new EnlaceDB();
            dgvClientes.DataSource = enlace.get_Clientes();
            txtReferencia.DataSource = enlace.get_Combobox("SP_MostrarReferencias");
            txtReferencia.ValueMember = "ID";
            txtReferencia.DisplayMember = "nombre";            
            txtEstadoCivil.DataSource = enlace.get_Combobox("SP_MostrarEstadoCivil");
            txtEstadoCivil.ValueMember = "ID";
            txtEstadoCivil.DisplayMember = "nombre";
            txtCiudad.DataSource = enlace.get_Combobox("SP_MostrarCiudades");
            txtCiudad.ValueMember = "cveCiudad";
            txtCiudad.DisplayMember = "nombre";
            txtPais.DataSource = enlace.get_Combobox("SP_MostrarPaises");
            txtPais.ValueMember = "cvePais";
            txtPais.DisplayMember = "nombre";
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
