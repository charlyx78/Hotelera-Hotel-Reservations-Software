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
        public ReservacionesWindow()
        {
            InitializeComponent();
        }

        private void clientesMenuItem_Click(object sender, EventArgs e)
        {
            ClientesWindow clientesWindow = new ClientesWindow();
            clientesWindow.Show();
            this.Hide();
        }

        private void reservacionesMenuItem_Click(object sender, EventArgs e)
        {
            ReservacionesWindow reservacionesWindow = new ReservacionesWindow();
            reservacionesWindow.Show();
            this.Hide();
        }

        private void salirMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
