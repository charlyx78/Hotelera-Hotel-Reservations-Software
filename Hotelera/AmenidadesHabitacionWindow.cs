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
    public partial class AmenidadesHabitacionWindow : Form
    {
        int idUsuario;
        public AmenidadesHabitacionWindow(int idUsuarioParam)
        {
            idUsuario = idUsuarioParam;
            InitializeComponent();
        }

        private void AmenidadesHabitacionWindow_Load(object sender, EventArgs e)
        {
            actualizar();
        }
        private void btnNuevaAmHab_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Por favor, llene todos los campos para registrar una amenidad de habitacion", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                EnlaceDB enlace = new EnlaceDB();
                if (enlace.Gestion_AmenidadesHab(
                    "I",
                    0,
                    txtNombre.Text.Trim(),
                    txtDesc.Text.Trim(),
                    idUsuario))
                {
                    this.Controls.Clear();
                    MessageBox.Show("Amenidad de habitacion registrada exitosamente!", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.InitializeComponent();
                    actualizar();
                }
            }
        }
        private void btnEditarAmHab_Click(object sender, EventArgs e)
        {
            if (dgvAmenidadesHab.CurrentRow.Index != -1)
            {
                if (txtNombre.Text == "" )
                {
                    MessageBox.Show("Por favor, llene todos los campos para editar una amenidad de habitacion", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    EnlaceDB enlace = new EnlaceDB();
                    if (enlace.Gestion_AmenidadesHab(
                        "U",
                        Convert.ToInt32(dgvAmenidadesHab.Rows[dgvAmenidadesHab.CurrentRow.Index].Cells[0].Value),
                        txtNombre.Text.Trim(),
                        txtDesc.Text.Trim(),
                        idUsuario))
                    {
                        this.Controls.Clear();
                        MessageBox.Show("Amenidad de habitacion editada exitosamente!", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.InitializeComponent();
                        actualizar();
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una amenidad de habitacion para editar", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnEliminarAmHab_Click(object sender, EventArgs e)
        {
            if (dgvAmenidadesHab.CurrentRow.Index != -1)
            {
                if (MessageBox.Show("¿Está seguro de que desea eliminar este amenidad de habitacion? Una vez eliminada, su información solo podrá ser recuperada por el SA", "Alerta!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    EnlaceDB enlace = new EnlaceDB();
                    if (enlace.Gestion_AmenidadesHab(
                        "D",
                        Convert.ToInt32(dgvAmenidadesHab.Rows[dgvAmenidadesHab.CurrentRow.Index].Cells[0].Value),
                        "",
                        "",
                        idUsuario))
                    {
                        this.Controls.Clear();
                        MessageBox.Show("Amenidad de habitacion eliminada exitosamente!", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.InitializeComponent();
                        actualizar();
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una amenidad de habitacion para eliminar", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvAmenidadesHab_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombre.Text = dgvAmenidadesHab.Rows[dgvAmenidadesHab.CurrentRow.Index].Cells[1].Value.ToString();
            txtDesc.Text = dgvAmenidadesHab.Rows[dgvAmenidadesHab.CurrentRow.Index].Cells[2].Value.ToString();
        }
        private void actualizar()
        {
            EnlaceDB enlace = new EnlaceDB();
            dgvAmenidadesHab.DataSource = enlace.get_AmHab();
        }
    }
}
