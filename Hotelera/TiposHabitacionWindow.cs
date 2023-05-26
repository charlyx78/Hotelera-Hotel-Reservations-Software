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
    public partial class TiposHabitacionWindow : Form
    {
        int idUsuario;
        public TiposHabitacionWindow(int idUsuarioParam)
        {
            idUsuario = idUsuarioParam;
            InitializeComponent();
        }
        private void TiposHabitacionWindow_Load(object sender, EventArgs e)
        {
            EnlaceDB enlace = new EnlaceDB();
            actualizar();
        }

        private void tiposDeHabitaciónMenuItem_Click(object sender, EventArgs e)
        {
            TiposHabitacionWindow tiposHabitacionWindow = new TiposHabitacionWindow(idUsuario);
            tiposHabitacionWindow.Show();
            this.Close();
        }

        private void salirMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btnNuevoTipoHab_Click(object sender, EventArgs e)
        {
            if(txtNombre.Text=="" || 
                txtCantCamas.Text=="" || 
                txtCapPersonas.Text=="" || 
                txtTipoCama.Text=="" || 
                txtCostoPersona.Text=="" || 
                txtNivelHab.Text == "")
            {
                MessageBox.Show("Por favor, llene todos los campos para registrar un tipo de habitacion", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                EnlaceDB enlace = new EnlaceDB();
                if(
                enlace.Gestion_TipoHab(
                    "I",
                    0,
                    txtNombre.Text.Trim(),
                    Convert.ToInt32(txtCantCamas.Text.Trim()),
                    Convert.ToInt32(txtTipoCama.SelectedValue),
                    float.Parse(txtCostoPersona.Text.Trim(), CultureInfo.InvariantCulture.NumberFormat),
                    Convert.ToInt32(txtCapPersonas.Text.Trim()),
                    Convert.ToInt32(txtNivelHab.SelectedValue),
                    idUsuario))
                {
                    this.Controls.Clear();
                    MessageBox.Show("Tipo de habitacion registrado exitosamente!", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.InitializeComponent();
                    actualizar();
                }
            }
        }
        private void btnEditarTipoHab_Click(object sender, EventArgs e)
        {
            if (dgvTiposHab.CurrentRow.Index != -1)
            {
                if (txtNombre.Text == "" ||
                    txtCantCamas.Text == "" ||
                    txtCapPersonas.Text == "" ||
                    txtTipoCama.Text == "" ||
                    txtCostoPersona.Text == "" ||
                    txtNivelHab.Text == "")
                {
                    MessageBox.Show("Por favor, llene todos los campos para registrar un tipo de habitacion", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    EnlaceDB enlace = new EnlaceDB();
                    if (enlace.Gestion_TipoHab(
                        "U",
                        Convert.ToInt32(dgvTiposHab.Rows[dgvTiposHab.CurrentRow.Index].Cells[0].Value),
                        txtNombre.Text.Trim(),
                        Convert.ToInt32(txtCantCamas.Text.Trim()),
                        Convert.ToInt32(txtTipoCama.SelectedValue),
                        float.Parse(txtCostoPersona.Text.Trim(), CultureInfo.InvariantCulture.NumberFormat),
                        Convert.ToInt32(txtCapPersonas.Text.Trim()),
                        Convert.ToInt32(txtNivelHab.SelectedValue),
                        idUsuario))
                    {
                        this.Controls.Clear();
                        MessageBox.Show("Tipo de habitación editado exitosamente!", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.InitializeComponent();
                        actualizar();
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un tipo de habitación para editar", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void btnEliminarTipoHab_Click(object sender, EventArgs e)
        {
            if (dgvTiposHab.CurrentRow.Index != -1)
            {
                if (MessageBox.Show("¿Está seguro de que desea eliminar este tipo de habitacion? Una vez eliminada, su información solo podrá ser recuperada por el SA", "Alerta!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    EnlaceDB enlace = new EnlaceDB();
                    if (enlace.Gestion_TipoHab(
                        "D",
                        Convert.ToInt32(dgvTiposHab.Rows[dgvTiposHab.CurrentRow.Index].Cells[0].Value),
                        "",
                        0,
                        0,
                        0,
                        0,
                        0,
                        idUsuario))
                    {
                        this.Controls.Clear();
                        MessageBox.Show("Tipo de habitacion eliminado exitosamente!", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.InitializeComponent();
                        actualizar();
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un tipo de habitación para eliminar", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnVerAmen_Click(object sender, EventArgs e)
        {
            int idHabSeleccionada = Convert.ToInt32(dgvTiposHab.Rows[dgvTiposHab.CurrentRow.Index].Cells[0].Value);
            AddAmenidadesHabitacionWindow addAmenidadesHabitacionWindow = new AddAmenidadesHabitacionWindow(idHabSeleccionada);
            addAmenidadesHabitacionWindow.ShowDialog();
        }
        private void btnVerCaract_Click(object sender, EventArgs e)
        {
            int idHabSeleccionada = Convert.ToInt32(dgvTiposHab.Rows[dgvTiposHab.CurrentRow.Index].Cells[0].Value);
            AddCaracteristicasHabitacionWindow addCaracteristicasHabitacionWindow = new AddCaracteristicasHabitacionWindow(idHabSeleccionada);
            addCaracteristicasHabitacionWindow.ShowDialog();
        }
        private void dgvTiposHab_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombre.Text = dgvTiposHab.Rows[dgvTiposHab.CurrentRow.Index].Cells[1].Value.ToString();
            txtCantCamas.Text = dgvTiposHab.Rows[dgvTiposHab.CurrentRow.Index].Cells[2].Value.ToString();
            txtTipoCama.Text = dgvTiposHab.Rows[dgvTiposHab.CurrentRow.Index].Cells[3].Value.ToString();
            txtCostoPersona.Text = dgvTiposHab.Rows[dgvTiposHab.CurrentRow.Index].Cells[4].Value.ToString();
            txtCapPersonas.Text = dgvTiposHab.Rows[dgvTiposHab.CurrentRow.Index].Cells[5].Value.ToString();
            txtNivelHab.Text = dgvTiposHab.Rows[dgvTiposHab.CurrentRow.Index].Cells[6].Value.ToString();
        }
        private void actualizar()
        {
            EnlaceDB enlace = new EnlaceDB();
            dgvTiposHab.DataSource = enlace.get_TiposHab("S");
            txtTipoCama.DataSource = enlace.get_Combobox("SP_MostrarTiposCama");
            txtTipoCama.DisplayMember = "nombreTipoCama";
            txtTipoCama.ValueMember = "idTipoCama";

            txtNivelHab.DataSource = enlace.get_Combobox("SP_MostrarNivelesHab");
            txtNivelHab.DisplayMember = "nombreNivelHab";
            txtNivelHab.ValueMember = "idNivelHabitacion";
        }
        private void dgvTiposHab_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.ColumnIndex == 4 && e.Value != null)
            {
                if (decimal.TryParse(e.Value.ToString(), out decimal valor))
                {
                    e.Value = valor.ToString("C2");
                }
            }
        }

        private void txtCantCamas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCostoPersona_KeyPress(object sender, KeyPressEventArgs e)
        {
                        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCapPersonas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
