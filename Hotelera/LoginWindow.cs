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
    public partial class LoginWindow : Form
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void btnIrARegistro_Click(object sender, EventArgs e)
        {
            RegistroWindow registroWindow = new RegistroWindow();
            this.Hide();
            registroWindow.Show();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            HomeOperativoWindow homeOperativoWindow = new HomeOperativoWindow();
            this.Hide();
            homeOperativoWindow.Show();
        }
    }
}
