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
    public partial class HabitacionesReservacion : Form
    {
        int idReserv;
        public HabitacionesReservacion(int idReservParam)
        {
            idReserv = idReservParam;
            InitializeComponent();
        }
        private void HabitacionesReservacion_Load(object sender, EventArgs e)
        {
            actualizar();
        }
        private void btnEliminarHabReserv_Click(object sender, EventArgs e)
        {
            EnlaceDB enlace = new EnlaceDB();
            if (dgvHabReserv.CurrentRow == null)
            {
                MessageBox.Show("Por favor, seleccione una habitación de la reservación a eliminar", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (enlace.Gestion_HabitacionesReservaciones("D", Convert.ToInt32(dgvHabReserv.Rows[dgvHabReserv.CurrentRow.Index].Cells[0].Value), 0, 0, 0, 0, 0, 0, "2025-02-25","2025-02-25"))
                {
                    MessageBox.Show("Habitación de la reservación eliminada exitosamente!", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    actualizar();                
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void actualizar()
        {
            EnlaceDB enlace = new EnlaceDB();
            dgvHabReserv.DataSource = enlace.get_HabitacionesReservaciones("S", 0, idReserv, 0, 0, 0, 0, 0);
        }
    }
}
