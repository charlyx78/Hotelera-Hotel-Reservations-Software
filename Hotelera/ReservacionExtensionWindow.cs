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
    public partial class ReservacionExtensionWindow : Form
    {
        int idReserv, idHotel, idUsuario;
        string fechaAReservar, fechaAReservar2, fechaOps;
        public ReservacionExtensionWindow(int idReservParam, int idHotelParam, int idUsuarioParam, string fechaAReservarParam, string fechaAReservar2Param, string fechaOpsParam)
        {
            idUsuario = idUsuarioParam;
            idReserv = idReservParam;
            idHotel = idHotelParam;
            fechaAReservar = fechaAReservarParam;
            fechaAReservar2 = fechaAReservar2Param;
            fechaOps = fechaOpsParam;
            InitializeComponent();
        }
        private void ReservacionHabitaciones_Load(object sender, EventArgs e)
        {
            actualizarTablas();
            actualizarTotal();
        }
        private void btnContServAdic_Click(object sender, EventArgs e)
        {
            ReservacionServiciosAdicionalesWindow reservacionServiciosAdicionales = new ReservacionServiciosAdicionalesWindow(idReserv, idHotel);
            reservacionServiciosAdicionales.Owner = this;
            reservacionServiciosAdicionales.Show();
            this.Hide();
        }
        private void btnAggHabReserv_Click_1(object sender, EventArgs e)
        {
            if (txtCantPersonas.Text == "")
            {
                MessageBox.Show("Por favor, llene todos los campos para registrar agregar una habitacion a la reservacion", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Convert.ToInt32(txtCantPersonas.Text) > Convert.ToInt32(dgvHabitaciones.Rows[dgvHabitaciones.CurrentRow.Index].Cells[5].Value))
            {
                MessageBox.Show("La cantidad de personas digitadas supera la capacidad de personas de la habitación", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Convert.ToInt32(dgvHabitaciones.Rows[dgvHabitaciones.CurrentRow.Index].Cells[7].Value) == 0) {
                MessageBox.Show("Ya no hay habitaciones disponibles de este tipo", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                EnlaceDB enlace = new EnlaceDB();
                int i = 1;
                while (i <= Convert.ToInt32(txtCantHabs.Text.Trim()))
                {
                    i++;
                    if (enlace.Gestion_HabitacionesReservaciones("I", 0, idReserv, idHotel, 0, Convert.ToInt32(dgvHabitaciones.Rows[dgvHabitaciones.CurrentRow.Index].Cells[0].Value), Convert.ToInt32(txtCantHabs.Text), Convert.ToInt32(txtCantPersonas.Text), fechaAReservar, fechaAReservar2))
                    {
                        //MessageBox.Show("Habitacion agregada exitosamente a la reservacion!", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                this.Controls.Clear();
                this.InitializeComponent();
                actualizarTablas();
                actualizarTotal();
            }
        }
        private void actualizarTotal()
        {
            EnlaceDB enlace = new EnlaceDB();
            string valorTotal = "";
            if(enlace.Crear_Reservaciones(
                    "S",
                    idReserv,
                    "",
                    dtpInvisible.Value.ToString(), dtpInvisible.Value.ToString(),
                    0,
                    0,
                    0,
                    0,
                    0,
                    0,
                    dtpInvisible.Value.ToString(), dtpInvisible.Value.ToString()).Rows.Count > 0)
                {
                valorTotal = enlace.Crear_Reservaciones(
                "S",
                idReserv,
                "",
                dtpInvisible.Value.ToString(), dtpInvisible.Value.ToString(),
                0,
                0,
                0,
                0,
                0,
                0,
                dtpInvisible.Value.ToString(), dtpInvisible.Value.ToString()).Rows[0].ItemArray[1].ToString();
            }
            txtTotal.Text = valorTotal;
        }
        private void actualizarTablas() {
            EnlaceDB enlace = new EnlaceDB();
            dgvHabitaciones.DataSource = enlace.get_BusqTiposHab("R", idHotel, fechaAReservar, fechaAReservar2);
        }

        private void btnGestHabReserv_Click(object sender, EventArgs e)
        {
            HabitacionesReservacion habitacionesReservacion = new HabitacionesReservacion(idReserv);
            habitacionesReservacion.ShowDialog();
            actualizarTablas();
            actualizarTotal();
        }

        private void txtCantHabs_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void flowLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtCantPersonas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnGestServAdic_Click(object sender, EventArgs e)
        {
            ReservacionServiciosAdicionalesWindow reservacionServiciosAdicionalesWindow = new ReservacionServiciosAdicionalesWindow(idReserv, idHotel);
            reservacionServiciosAdicionalesWindow.ShowDialog();
            actualizarTablas();
            actualizarTotal();
        }

        private void btnContReserv_Click(object sender, EventArgs e)
        {
            EnlaceDB enlace = new EnlaceDB();
        }

        private void dgvTiposHabitacion_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 4 && e.Value != null)
            {
                if (decimal.TryParse(e.Value.ToString(), out decimal valor))
                {
                    e.Value = valor.ToString("C2");
                }
            }
        }
    }
}
