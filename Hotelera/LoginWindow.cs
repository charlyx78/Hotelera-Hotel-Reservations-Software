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

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if(chbAdministrador.Checked)
            {
                EnlaceDB enlace = new EnlaceDB();
                if (enlace.Autentificar(txtUsuario.Text.Trim(), txtContraseña.Text.Trim(), "A") != 0)
                {
                    int idUsuario = enlace.Autentificar(txtUsuario.Text.Trim(), txtContraseña.Text.Trim(), "A");
                    HotelesWindow hotelesWindow = new HotelesWindow(idUsuario);
                    this.Hide();
                    hotelesWindow.Show();
                }
                else
                {
                    MessageBox.Show("Correo o contraseña incorrectos, intentelo nuevamente", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                EnlaceDB enlace = new EnlaceDB();
                if (enlace.Autentificar(txtUsuario.Text.Trim(), txtContraseña.Text.Trim(), "O") != 0)
                {
                    int idUsuario = enlace.Autentificar(txtUsuario.Text.Trim(), txtContraseña.Text.Trim(), "O");
                    ClientesWindow clientesWindow = new ClientesWindow(idUsuario, dtpFechaOps.Value.ToString());
                    this.Hide();
                    clientesWindow.Show();
                }
                else
                {
                    MessageBox.Show("Correo o contraseña incorrectos, intentelo nuevamente", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
