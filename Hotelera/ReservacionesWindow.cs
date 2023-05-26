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
        int idUsuario;
        string fechaOps;
        public ReservacionesWindow(int idUsuarioParam,string fechaOpsParam)
        {
            fechaOps = fechaOpsParam;
            idUsuario = idUsuarioParam;
            InitializeComponent();
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
            lbHoteles.DataSource = enlace.get_BusqHoteles(txtCiudad.SelectedValue.ToString());
            lbHoteles.ValueMember = "ID";
            lbHoteles.DisplayMember = "nombre";
        }
        private void actualizar()
        {
            EnlaceDB enlace = new EnlaceDB();
            txtCiudad.DataSource = enlace.get_Combobox("SP_MostrarCiudades");
            txtCiudad.ValueMember = "cveCiudad";
            txtCiudad.DisplayMember = "nombre";
        }

        private void btnContinuarReserv_Click(object sender, EventArgs e)
        {
            if (lbClientes.SelectedIndex == -1 ||
               lbHoteles.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, llene todos los campos para registrar una reservacion", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(txtFechLlegada.Value>txtFechSalida.Value)
            {
                MessageBox.Show("La fecha de salida no puede ser anterior a la fecha de llegada", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                EnlaceDB enlace = new EnlaceDB();
                int idReservacion = Convert.ToInt32(enlace.Crear_Reservaciones(
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
                    Convert.ToInt32(lbHoteles.SelectedValue),
                    dtpFechaRegistro.Value.ToString(), dtpFechaRegistro.Value.ToString()
                ).Rows[0][0]);
                ReservacionAgregarWindow reservacionHabitaciones = new ReservacionAgregarWindow(idReservacion, Convert.ToInt32(lbHoteles.SelectedValue), idUsuario, txtFechLlegada.Value.ToString(), txtFechSalida.Value.ToString(),fechaOps);
                reservacionHabitaciones.Owner = this;
                reservacionHabitaciones.Show();
                this.Hide();
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
    }
}
