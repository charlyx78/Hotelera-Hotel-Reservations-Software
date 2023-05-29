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
    public partial class CheckOutWindow : Form
    {
        int idUsuario;
        string fechaOps;
        public CheckOutWindow(int idUsuarioPaaram,string fechaOpsParam)
        {
            idUsuario = idUsuarioPaaram;
            fechaOps = fechaOpsParam;
            InitializeComponent();
        }

        private void btnExt_Click(object sender, EventArgs e)
        {
            flpPago.Visible = false;
            flpExt.Visible = true;
        }
        private void btnPago_Click(object sender, EventArgs e)
        {
            try
            {
                EnlaceDB enlace = new EnlaceDB();
                int idHotel = Convert.ToInt32(enlace.get_ServiciosReservaciones("RH", 0, Convert.ToInt32(txCdoReserv.Text), 0, 0).Rows[0].ItemArray[0]);
                dgvServDisp.DataSource = enlace.get_ServiciosReservaciones("R", 0, Convert.ToInt32(txCdoReserv.Text), 0, idHotel);
                //dgvServDisp.DataSource = enlace.get_ServiciosReservaciones("R", 0, Convert.ToInt32(txCdoReserv.Text), 0, idHotel);
                flpExt.Visible = false;
                flpPago.Visible = true;
                //dgvServDisp.DataSource = enlace.Crear_Reservaciones("RES", Convert.ToInt32(txCdoReserv.Text ), "", dateTimePicker1.Value.ToString(), dateTimePicker1.Value.ToString(), 0, 0, 0, 0, 0, 0, fechaOps,fechaOps);
                //if(enlace.Crear_Reservaciones("MP", Convert.ToInt32(txCdoReserv.Text), "", dateTimePicker1.Value.ToString(), dateTimePicker1.Value.ToString(), 0, 0, 0, 0, 0, 0, fechaOps,fechaOps).Rows.Count > 0)
                //{
                //    string montoPendiente = enlace.Crear_Reservaciones("MP", Convert.ToInt32(txCdoReserv.Text), "", dateTimePicker1.Value.ToString(), dateTimePicker1.Value.ToString(), 0, 0, 0, 0, 0, 0, fechaOps,fechaOps).Rows[0].ItemArray[0].ToString();
                //    txtMontoPendiente.Text = montoPendiente;
                //}
                actualizar();
                actualizarTotal();
            }
            catch
            {
                MessageBox.Show("No existe una reservación con el código introducido", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            EnlaceDB enlace = new EnlaceDB();
            if(enlace.Gestion_Reservaciones("PTC", Convert.ToInt32(txCdoReserv.Text), "", dateTimePicker1.Value.ToString(), dateTimePicker1.Value.ToString(), 0, 0, 0, 0, 0, 0, fechaOps,fechaOps,1000))
            {
                if (enlace.Gestion_Reservaciones("CHO", Convert.ToInt32(txCdoReserv.Text), "", dateTimePicker1.Value.ToString(), dateTimePicker1.Value.ToString(), 0, 0, 0, 0, 0, 0, fechaOps, fechaOps,1000))
                {
                    MessageBox.Show("Check Out realizado exitosamente!", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResumenFacturaWindow resumenFactura = new ResumenFacturaWindow(Convert.ToInt32(txCdoReserv.Text));
                    resumenFactura.Show();
                    this.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EnlaceDB enlace = new EnlaceDB();
            if (enlace.Gestion_Reservaciones("PTB", Convert.ToInt32(txCdoReserv.Text), "", dateTimePicker1.Value.ToString(), dateTimePicker1.Value.ToString(), 0, 0, 0, 0, 0, 0, fechaOps, fechaOps,1000))
            {
                if (enlace.Gestion_Reservaciones("CHO", Convert.ToInt32(txCdoReserv.Text), "", dateTimePicker1.Value.ToString(), dateTimePicker1.Value.ToString(), 0, 0, 0, 0, 0, 0, fechaOps, fechaOps,100))
                {
                    MessageBox.Show("Check Out realizado exitosamente!", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResumenFacturaWindow resumenFactura = new ResumenFacturaWindow(Convert.ToInt32(txCdoReserv.Text));
                    resumenFactura.Show();
                    this.Close();
                }
            }
        }

        private void btnConfirmarCheckIn_Click(object sender, EventArgs e)
        {
            EnlaceDB enlace = new EnlaceDB();
            if (enlace.Gestion_Reservaciones("PE", Convert.ToInt32(txCdoReserv.Text), "", dateTimePicker1.Value.ToString(), dateTimePicker1.Value.ToString(), 0, 0, 0, 0, 0, 0, fechaOps,fechaOps,1000))
            {
                if (enlace.Gestion_Reservaciones("CHO", Convert.ToInt32(txCdoReserv.Text), "", dateTimePicker1.Value.ToString(), dateTimePicker1.Value.ToString(), 0, 0, 0, 0, 0, 0, fechaOps, fechaOps,1000))
                {
                    MessageBox.Show("Check Out realizado exitosamente!", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResumenFacturaWindow resumenFactura = new ResumenFacturaWindow(Convert.ToInt32(txCdoReserv.Text));
                    resumenFactura.Show();
                    this.Close();
                }
            }
        }

        private void btnExtReserv_Click(object sender, EventArgs e)
        {
            EnlaceDB enlace = new EnlaceDB();
            string fechaSalidaPasada = enlace.Crear_Reservaciones(
                "SFS",
                Convert.ToInt32(txCdoReserv.Text),
                "",
                dtpInvisible.Value.ToString(), dtpInvisible.Value.ToString(),
                0,
                0,
                0,
                0,
                0,
                0,
                dtpInvisible.Value.ToString(), dtpInvisible.Value.ToString()).Rows[0].ItemArray[0].ToString();
            DateTime fechaSalidaPasadaFormateada = DateTime.Parse(fechaSalidaPasada);
            if (fechaSalidaPasadaFormateada <= dateTimePicker1.Value)
            {
                MessageBox.Show("Seleccione una fecha posterior a la fecha de salida de la reservación", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                int idHotel = Convert.ToInt32(enlace.get_HotelReserv(Convert.ToInt32(txCdoReserv.Text)).Rows[0].ItemArray[0]);
                ReservacionExtensionWindow reservacionAgregarWindow = new ReservacionExtensionWindow(Convert.ToInt32(txCdoReserv.Text), idHotel, idUsuario, fechaOps, fechaSalidaPasada, fechaOps);
                if (enlace.Gestion_Reservaciones("EXT", Convert.ToInt32(txCdoReserv.Text),"",dtpInvisible.Value.ToString(),dateTimePicker1.Value.ToString(), 0,0,0,0,0,0,dtpInvisible.Value.ToString(), dtpInvisible.Value.ToString(),0));
                reservacionAgregarWindow.Show();
                this.Hide();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgvServDisp.CurrentRow != null)
            {
                EnlaceDB enlace = new EnlaceDB();
                if (enlace.Gestion_ServAdicionalesReservaciones("I", 0, Convert.ToInt32(txCdoReserv.Text), Convert.ToInt32(dgvServDisp.Rows[dgvServDisp.CurrentRow.Index].Cells[0].Value), 0))
                {
                    MessageBox.Show("Servicio agregado exitosamente a la reservacion!", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    actualizar();
                    actualizarTotal();
                }
            }
        }
        private void actualizar()
        {
            EnlaceDB enlace = new EnlaceDB();
            int idHotel = Convert.ToInt32(enlace.get_ServiciosReservaciones("RH", 0, Convert.ToInt32(txCdoReserv.Text), 0, 0).Rows[0].ItemArray[0]);
            dgvServDisp.DataSource = enlace.get_ServiciosReservaciones("R", 0, Convert.ToInt32(txCdoReserv.Text), 0, idHotel);
            dgvServAgg.DataSource = enlace.get_ServiciosReservaciones("S", 0, Convert.ToInt32(txCdoReserv.Text), 0, 0);
        }

        private void CheckOutWindow_Load(object sender, EventArgs e)
        {
            //actualizar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(dgvServAgg.CurrentRow!=null)
            {
                EnlaceDB enlace = new EnlaceDB();
                if (enlace.Gestion_ServAdicionalesReservaciones("D", Convert.ToInt32(dgvServAgg.Rows[dgvServAgg.CurrentRow.Index].Cells[0].Value), Convert.ToInt32(txCdoReserv.Text), 0, 0))
                {
                    MessageBox.Show("Servicio eliminado exitosamente de la reservacion!", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    actualizar();
                    actualizarTotal();
                }
            }
        }

        private void actualizarTotal()
        {
            EnlaceDB enlace = new EnlaceDB();
            string valorTotal = "";
            if (enlace.Crear_Reservaciones(
                    "S",
                    Convert.ToInt32(txCdoReserv.Text),
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
                Convert.ToInt32(txCdoReserv.Text),
                "",
                dtpInvisible.Value.ToString(), dtpInvisible.Value.ToString(),
                0,
                0,
                0,
                0,
                0,
                0,
                dtpInvisible.Value.ToString(), dtpInvisible.Value.ToString()).Rows[0].ItemArray[2].ToString();
            }
            txtMontoPendiente.Text = valorTotal;
        }
    }
}
