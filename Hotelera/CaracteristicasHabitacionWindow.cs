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
    public partial class CaracteristicasHabitacionWindow : Form
    {
        int idUsuario;
        public CaracteristicasHabitacionWindow(int idUsuarioParam)
        {
            idUsuario = idUsuarioParam;
            InitializeComponent();
        }

        private void CaracteristicasHabitacionWindow_Load(object sender, EventArgs e)
        {
            actualizar();
        }

        private void btnNuevaCaractHab_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Por favor, llene todos los campos para registrar una característica de habitacion", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                EnlaceDB enlace = new EnlaceDB();
                if (enlace.Gestion_CaracteristicasHab(
                    "I",
                    0,
                    txtNombre.Text.Trim(),
                    txtDesc.Text.Trim(),
                    idUsuario))
                {
                    this.Controls.Clear();
                    MessageBox.Show("Característica de habitacion registrada exitosamente!", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.InitializeComponent();
                    actualizar();
                }
            }
        }

        private void btnEditarCaractHab_Click(object sender, EventArgs e)
        {
            if (dgvCaracteristicasHab.CurrentRow.Index != -1)
            {
                if (txtNombre.Text == "")
                {
                    MessageBox.Show("Por favor, llene todos los campos para editar una característica de habitacion", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    EnlaceDB enlace = new EnlaceDB();
                    if (enlace.Gestion_CaracteristicasHab(
                        "U",
                        Convert.ToInt32(dgvCaracteristicasHab.Rows[dgvCaracteristicasHab.CurrentRow.Index].Cells[0].Value),
                        txtNombre.Text.Trim(),
                        txtDesc.Text.Trim(),
                        idUsuario))
                    {
                        this.Controls.Clear();
                        MessageBox.Show("Característica de habitacion editada exitosamente!", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.InitializeComponent();
                        actualizar();
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una característica de habitación para editar", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarCaractHab_Click(object sender, EventArgs e)
        {
            if (dgvCaracteristicasHab.CurrentRow.Index != -1)
            {
                if (MessageBox.Show("¿Está seguro de que desea eliminar esta característica de habitacion? Una vez eliminada, su información solo podrá ser recuperada por el SA", "Alerta!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    EnlaceDB enlace = new EnlaceDB();
                    if (enlace.Gestion_CaracteristicasHab(
                        "D",
                        Convert.ToInt32(dgvCaracteristicasHab.Rows[dgvCaracteristicasHab.CurrentRow.Index].Cells[0].Value),
                        "",
                        "",
                        idUsuario))
                    {
                        this.Controls.Clear();
                        MessageBox.Show("Característica de habitacion eliminada exitosamente!", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.InitializeComponent();
                        actualizar();
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una característica de habitacion para eliminar", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvCaracteristicasHab_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombre.Text = dgvCaracteristicasHab.Rows[dgvCaracteristicasHab.CurrentRow.Index].Cells[1].Value.ToString();
            txtDesc.Text = dgvCaracteristicasHab.Rows[dgvCaracteristicasHab.CurrentRow.Index].Cells[2].Value.ToString();
        }
        private void actualizar()
        {
            EnlaceDB enlace = new EnlaceDB();
            dgvCaracteristicasHab.DataSource = enlace.get_CaractHab();
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
