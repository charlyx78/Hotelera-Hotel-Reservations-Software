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
    public partial class ReporteVentasWindow : Form
    {
        public ReporteVentasWindow()
        {
            InitializeComponent();
        }

        private void historialDeClienteMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usuariosMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ReporteVentasWindow_Load(object sender, EventArgs e)
        {
            EnlaceDB enlace = new EnlaceDB();
            dgvReporteVentas.DataSource = enlace.get_ReporteVentas("", "", 0, "", 0);
            txtPais.DataSource = enlace.get_Combobox("SP_MostrarPaises");
            txtPais.DisplayMember = "nombre";
            txtPais.ValueMember = "cvePais";
            txtCiudad.DataSource = enlace.get_Combobox("SP_MostrarCiudades");
            txtCiudad.DisplayMember = "nombre";
            txtCiudad.ValueMember = "cveCiudad";
            txtHotel.DataSource = enlace.get_Combobox("SP_MostrarHoteles");
            txtHotel.DisplayMember = "nombre";
            txtHotel.ValueMember = "ID";
        }

        private void btnPais_Click(object sender, EventArgs e)
        {
            EnlaceDB enlace = new EnlaceDB();
            dgvReporteVentas.DataSource = enlace.get_ReporteVentas("P", txtPais.SelectedValue.ToString(), 0, "", 0);
        }

        private void btnAño_Click(object sender, EventArgs e)
        {
            EnlaceDB enlace = new EnlaceDB();
            dgvReporteVentas.DataSource = enlace.get_ReporteVentas("A", "", Convert.ToInt32(txtAño.Text), "", 0);
        }

        private void btnCiudad_Click(object sender, EventArgs e)
        {
            EnlaceDB enlace = new EnlaceDB();
            dgvReporteVentas.DataSource = enlace.get_ReporteVentas("C", "", 0, txtCiudad.SelectedValue.ToString(), 0);
        }

        private void btnHotel_Click(object sender, EventArgs e)
        {
            EnlaceDB enlace = new EnlaceDB();
            dgvReporteVentas.DataSource = enlace.get_ReporteVentas("H", txtPais.SelectedValue.ToString(), 0, "", Convert.ToInt32(txtHotel.SelectedValue));
        }

        private void txtAño_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
