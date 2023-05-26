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
            flpExt.Visible = false;
            flpPago.Visible = true;
            EnlaceDB enlace = new EnlaceDB();
            dgvResumenReserv.DataSource = enlace.Crear_Reservaciones("RES", Convert.ToInt32(txCdoReserv.Text), "", dateTimePicker1.Value.ToString(), dateTimePicker1.Value.ToString(), 0, 0, 0, 0, 0, 0, fechaOps,fechaOps);
            if(enlace.Crear_Reservaciones("MP", Convert.ToInt32(txCdoReserv.Text), "", dateTimePicker1.Value.ToString(), dateTimePicker1.Value.ToString(), 0, 0, 0, 0, 0, 0, fechaOps,fechaOps).Rows.Count > 0)
            {
                string montoPendiente = enlace.Crear_Reservaciones("MP", Convert.ToInt32(txCdoReserv.Text), "", dateTimePicker1.Value.ToString(), dateTimePicker1.Value.ToString(), 0, 0, 0, 0, 0, 0, fechaOps,fechaOps).Rows[0].ItemArray[0].ToString();
                txtMontoPendiente.Text = montoPendiente;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EnlaceDB enlace = new EnlaceDB();
            if(enlace.Gestion_Reservaciones("PTC", Convert.ToInt32(txCdoReserv.Text), "", dateTimePicker1.Value.ToString(), dateTimePicker1.Value.ToString(), 0, 0, 0, 0, 0, 0, fechaOps,fechaOps))
            {
                if (enlace.Gestion_Reservaciones("CHO", Convert.ToInt32(txCdoReserv.Text), "", dateTimePicker1.Value.ToString(), dateTimePicker1.Value.ToString(), 0, 0, 0, 0, 0, 0, fechaOps, fechaOps))
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
            if (enlace.Gestion_Reservaciones("PTB", Convert.ToInt32(txCdoReserv.Text), "", dateTimePicker1.Value.ToString(), dateTimePicker1.Value.ToString(), 0, 0, 0, 0, 0, 0, fechaOps, fechaOps))
            {
                if (enlace.Gestion_Reservaciones("CHO", Convert.ToInt32(txCdoReserv.Text), "", dateTimePicker1.Value.ToString(), dateTimePicker1.Value.ToString(), 0, 0, 0, 0, 0, 0, fechaOps, fechaOps))
                {
                    MessageBox.Show("Check Out realizado exitosamente!", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void btnConfirmarCheckIn_Click(object sender, EventArgs e)
        {
            EnlaceDB enlace = new EnlaceDB();
            if (enlace.Gestion_Reservaciones("PE", Convert.ToInt32(txCdoReserv.Text), "", dateTimePicker1.Value.ToString(), dateTimePicker1.Value.ToString(), 0, 0, 0, 0, 0, 0, fechaOps, fechaOps))
            {
                if (enlace.Gestion_Reservaciones("CHO", Convert.ToInt32(txCdoReserv.Text), "", dateTimePicker1.Value.ToString(), dateTimePicker1.Value.ToString(), 0, 0, 0, 0, 0, 0, fechaOps, fechaOps))
                {
                    MessageBox.Show("Check Out realizado exitosamente!", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void btnExtReserv_Click(object sender, EventArgs e)
        {
            EnlaceDB enlace = new EnlaceDB();
            int idHotel = Convert.ToInt32(enlace.get_HotelReserv(Convert.ToInt32(txCdoReserv.Text)).Rows[0].ItemArray[0]);
            ReservacionAgregarWindow reservacionAgregarWindow = new ReservacionAgregarWindow(Convert.ToInt32(txCdoReserv.Text), idHotel, idUsuario, fechaOps,dateTimePicker1.Value.ToString(),fechaOps);
            reservacionAgregarWindow.Show();
            this.Hide();
        }
    }
}
