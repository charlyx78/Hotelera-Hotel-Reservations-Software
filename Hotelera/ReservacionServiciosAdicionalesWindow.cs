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
    public partial class ReservacionServiciosAdicionalesWindow : Form
    {
        int idReserv, idHotel;
        public ReservacionServiciosAdicionalesWindow(int idReservParam, int idHotelParam)
        {
            idReserv = idReservParam;
            idHotel = idHotelParam;
            InitializeComponent();
        }

        private void btnFinReserv_Click(object sender, EventArgs e)
        {
            this.Owner.Owner.Owner.Show();
            MessageBox.Show("Reservacion creada exitosamente!", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnEliminaServiAdicReserv_Click(object sender, EventArgs e)
        {
            EnlaceDB enlace = new EnlaceDB();
            if (enlace.Gestion_ServAdicionalesReservaciones("D", Convert.ToInt32(dgvServAd.Rows[dgvServAd.CurrentRow.Index].Cells[0].Value), idReserv, 0,0))
            {
                MessageBox.Show("Servicio eliminado exitosamente de la reservacion!", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                actualizar();
            }
        }

        private void ReservacionServiciosAdicionalesWindow_Load(object sender, EventArgs e)
        {
            actualizar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void actualizar()
        {
            EnlaceDB enlace = new EnlaceDB();
            dgvServAd.DataSource = enlace.get_ServiciosReservaciones("S", 0, idReserv, 0,0);
        }
    }
}
