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
    public partial class CheckInWindow : Form
    {
        int idUsuario;
        string fechaOps;
        public CheckInWindow(int idUsuarioParam, string fechaOpsParam)
        {
            idUsuario = idUsuarioParam;
            fechaOps = fechaOpsParam;
            InitializeComponent();
        }

        private void CheckInWindow_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirmarCheckIn_Click(object sender, EventArgs e)
        {
            EnlaceDB enlace = new EnlaceDB();
            if (txtCdoReserv.Text == "")
            {
                MessageBox.Show("Por favor, introduzca un código de resevación para continuar", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (enlace.Gestion_Reservaciones("CHI", Convert.ToInt32(txtCdoReserv.Text), "", dtpInvisible.Value.ToString(), dtpInvisible.Value.ToString(), 0, 0, 0, 0, 0, 0, dtpInvisible.Value.ToString(),fechaOps,1000))
                {                 
                    dgvHabsReserv.DataSource = enlace.get_HabitacionesReservaciones("S", 0, Convert.ToInt32(txtCdoReserv.Text), 0, 0, 0, 0, 0);
                    MessageBox.Show("Check In realizado correctamente", "EXITO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }
    }
}
