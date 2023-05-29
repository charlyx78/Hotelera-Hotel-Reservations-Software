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
    public partial class ReservacionesWindow : Form
    {
        bool isPrimeraHabAgregada;
        int idReservacion;
        int idUsuario;
        string fechaOps;
        public ReservacionesWindow(int idUsuarioParam,string fechaOpsParam)
        {
            fechaOps = fechaOpsParam;
            idUsuario = idUsuarioParam;
            InitializeComponent();
            isPrimeraHabAgregada = false;
            idReservacion = 0;
        }

        //private void clientesMenuItem_Click(object sender, EventArgs e)
        //{
        //    ClientesWindow clientesWindow = new ClientesWindow();
        //    clientesWindow.Show();
        //    this.Hide();
        //}
        private void ReservacionesWindow_Load(object sender, EventArgs e)
        {
            actualizar();
        }

        private void reservacionesMenuItem_Click(object sender, EventArgs e)
        {
            ReservacionesWindow reservacionesWindow = new ReservacionesWindow(idUsuario, fechaOps);
            reservacionesWindow.Show();
            this.Hide();
        }

        private void salirMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btnBusqCorreo_Click(object sender, EventArgs e)
        {
            EnlaceDB enlace = new EnlaceDB();
            lbClientes.DataSource = enlace.get_BusqClientes("C", txtCliente.Text.Trim(), "", "");
            lbClientes.ValueMember = "ID";
            lbClientes.DisplayMember = "Correo";
        }

        private void btnBusqAp_Click(object sender, EventArgs e)
        {
            EnlaceDB enlace = new EnlaceDB();
            lbClientes.DataSource = enlace.get_BusqClientes("A", "", txtCliente.Text.Trim(), "");
            lbClientes.ValueMember = "ID";
            lbClientes.DisplayMember = "Nombre";
        }

        private void btnBusqRFC_Click(object sender, EventArgs e)
        {
            EnlaceDB enlace = new EnlaceDB();
            lbClientes.DataSource = enlace.get_BusqClientes("R", "", "", txtCliente.Text.Trim());
            lbClientes.ValueMember = "ID";
            lbClientes.DisplayMember = "RFC";
        }
        private void txtCiudad_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            EnlaceDB enlace = new EnlaceDB();
            dgvHabitaciones.DataSource = enlace.get_BusqTiposHab("R", Convert.ToInt32(txtHotel.SelectedValue), txtFechLlegada.Value.ToString(), txtFechSalida.Value.ToString());
        }
        private void txtCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnlaceDB enlace = new EnlaceDB();
            txtHotel.DataSource = enlace.get_BusqHoteles(txtCiudad.SelectedValue.ToString());
            txtHotel.ValueMember = "ID";
            txtHotel.DisplayMember = "nombre";
        }
        private void actualizar()
        {
            EnlaceDB enlace = new EnlaceDB();
            txtCiudad.DataSource = enlace.get_Combobox("SP_MostrarCiudades");
            txtCiudad.ValueMember = "cveCiudad";
            txtCiudad.DisplayMember = "nombre";
            txtTipoPagoAnticipo.DataSource = enlace.get_Combobox("SP_MostrarTiposPago");
            txtTipoPagoAnticipo.ValueMember = "ID";
            txtTipoPagoAnticipo.DisplayMember = "nombre";
        }
        private void btnAggHab_Click(object sender, EventArgs e)
        {
            if (lbClientes.SelectedIndex == -1 ||
               txtHotel.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, llene todos los campos para registrar una reservacion", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtFechLlegada.Value > txtFechSalida.Value)
            {
                MessageBox.Show("La fecha de salida no puede ser anterior a la fecha de llegada", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Convert.ToInt32(txtCantPersonas.Text) > Convert.ToInt32(dgvHabitaciones.Rows[dgvHabitaciones.CurrentRow.Index].Cells[5].Value))
            {
                MessageBox.Show("La cantidad de personas digitadas supera la capacidad de personas de la habitación", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (!isPrimeraHabAgregada)
                {
                    EnlaceDB enlace = new EnlaceDB();
                    idReservacion = Convert.ToInt32(enlace.Crear_Reservaciones(
                        "I",
                        0,
                        txtCiudad.SelectedValue.ToString(),
                        txtFechLlegada.Value.ToString(),
                        txtFechSalida.Value.ToString(),
                        1001,
                        0,
                        1000,
                        Convert.ToInt32(lbClientes.SelectedValue),
                        idUsuario,
                        Convert.ToInt32(txtHotel.SelectedValue),
                        "",
                        txtFechSalida.Value.ToString()
                    ).Rows[0][0]);
                    if (idReservacion != 0)
                    {
                        isPrimeraHabAgregada = true;
                        txtCliente.Enabled = false;
                        lbClientes.Enabled = false;
                        txtCiudad.Enabled = false;
                        txtHotel.Enabled = false;
                        txtFechLlegada.Enabled = false;
                        txtFechSalida.Enabled = false;
                        int i = 1;
                        while (i <= Convert.ToInt32(txtCantHabs.Text.Trim()))
                        {
                            if (enlace.Gestion_HabitacionesReservaciones("I", 0, idReservacion, Convert.ToInt32(txtHotel.SelectedValue), 0, Convert.ToInt32(dgvHabitaciones.Rows[dgvHabitaciones.CurrentRow.Index].Cells[0].Value), Convert.ToInt32(txtCantHabs.Text), Convert.ToInt32(txtCantPersonas.Text), txtFechLlegada.Value.ToString(), txtFechSalida.Value.ToString()))
                            {
                                //MessageBox.Show("Habitacion agregada exitosamente a la reservacion!", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                i++;
                            }
                        }
                        dgvHabitaciones.DataSource = enlace.get_BusqTiposHab("R", Convert.ToInt32(txtHotel.SelectedValue), txtFechLlegada.Value.ToString(), txtFechSalida.Value.ToString());
                        actualizarTotal();
                    }
                }
                else
                {
                    EnlaceDB enlace = new EnlaceDB();
                    int i = 1;
                    while (i <= Convert.ToInt32(txtCantHabs.Text.Trim()))
                    {
                        i++;
                        if (enlace.Gestion_HabitacionesReservaciones("I", 0, idReservacion, Convert.ToInt32(txtHotel.SelectedValue), 0, Convert.ToInt32(dgvHabitaciones.Rows[dgvHabitaciones.CurrentRow.Index].Cells[0].Value), Convert.ToInt32(txtCantHabs.Text), Convert.ToInt32(txtCantPersonas.Text), txtFechLlegada.Value.ToString(), txtFechSalida.Value.ToString()))
                        {
                            //MessageBox.Show("Habitacion agregada exitosamente a la reservacion!", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    dgvHabitaciones.DataSource = enlace.get_BusqTiposHab("R", Convert.ToInt32(txtHotel.SelectedValue), txtFechLlegada.Value.ToString(), txtFechSalida.Value.ToString());
                    actualizarTotal();
                }
            }
        }

        private void btnContinuarReserv_Click(object sender, EventArgs e)
        {
            if (txtAnticipo.Text == "")
            {
                MessageBox.Show("Introduzca un monto de anticipo a dar", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Convert.ToDouble(txtAnticipo.Text) > Convert.ToDouble(txtTotal.Text))
            {
                MessageBox.Show("El monto de anticipo es mayor al monto total", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                EnlaceDB enlace = new EnlaceDB();
                if (enlace.Gestion_Reservaciones("UA",
                        idReservacion,
                        "",
                        txtFechLlegada.Value.ToString(), txtFechLlegada.Value.ToString(),
                        0,
                        Convert.ToInt32(txtAnticipo.Text),
                        0,
                        0,
                        0,
                        0,
                        txtFechLlegada.Value.ToString(), txtFechLlegada.Value.ToString(),
                        Convert.ToInt32(txtTipoPagoAnticipo.SelectedValue)))
                {
                    MessageBox.Show("Reservación registrada exitosamente! Código de reservación generado: " + idReservacion, "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClientesWindow clientesWindow = new ClientesWindow(idUsuario, fechaOps);
                    clientesWindow.Show();
                    this.Close();
                }
            }
        }

        private void clientesMenuItem_Click(object sender, EventArgs e)
        {
            ClientesWindow clientesWindow = new ClientesWindow(idUsuario, fechaOps);
            clientesWindow.Show();
            this.Hide();
        }

        private void checkInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckInWindow checkInWindow = new CheckInWindow(idUsuario, fechaOps);
            checkInWindow.ShowDialog();
            this.Hide();
        }

        private void checkOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckOutWindow checkOutWindow = new CheckOutWindow(idUsuario, fechaOps);
            checkOutWindow.Show();
            this.Hide();
        }

        private void salirMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btnVerHabsAgg_Click(object sender, EventArgs e)
        {
            HabitacionesReservacion habitacionesReservacion = new HabitacionesReservacion(idReservacion);
            habitacionesReservacion.ShowDialog();
            EnlaceDB enlace = new EnlaceDB();
            dgvHabitaciones.DataSource = enlace.get_BusqTiposHab("R", Convert.ToInt32(txtHotel.SelectedValue), txtFechLlegada.Value.ToString(), txtFechSalida.Value.ToString());
            actualizarTotal();
        }
        private void actualizarTotal()
        {
            EnlaceDB enlace = new EnlaceDB();
            string valorTotal = "";
            if (enlace.Crear_Reservaciones(
                    "S",
                    idReservacion,
                    "",
                    txtFechSalida.Value.ToString(), txtFechSalida.Value.ToString(),
                    0,
                    0,
                    0,
                    0,
                    0,
                    0,
                    txtFechSalida.Value.ToString(), txtFechSalida.Value.ToString()).Rows.Count > 0)
            {
                valorTotal = enlace.Crear_Reservaciones(
                "S",
                idReservacion,
                "",
                txtFechSalida.Value.ToString(), txtFechSalida.Value.ToString(),
                0,
                0,
                0,
                0,
                0,
                0,
                txtFechSalida.Value.ToString(), txtFechSalida.Value.ToString()).Rows[0].ItemArray[1].ToString();
            }
            txtTotal.Text = valorTotal;
        }

        private void flowLayoutPanel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtFechSalida_ValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtHotel.SelectedValue) != 0)
            {
                EnlaceDB enlace = new EnlaceDB();
                dgvHabitaciones.DataSource = enlace.get_BusqTiposHab("R", Convert.ToInt32(txtHotel.SelectedValue), txtFechLlegada.Value.ToString(), txtFechSalida.Value.ToString());
            }
        }

        private void txtFechLlegada_ValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtHotel.SelectedValue) != 0)
            {
                EnlaceDB enlace = new EnlaceDB();
                dgvHabitaciones.DataSource = enlace.get_BusqTiposHab("R", Convert.ToInt32(txtHotel.SelectedValue), txtFechLlegada.Value.ToString(), txtFechSalida.Value.ToString());
            }
        }
    }

}
