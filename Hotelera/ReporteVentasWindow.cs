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
        int idUsuario;
        public ReporteVentasWindow(int idUsuarioParam)
        {
            idUsuario = idUsuarioParam;
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

        private void hotelesMenuItem_Click(object sender, EventArgs e)
        {
            HotelesWindow hotelesWindow = new HotelesWindow(idUsuario);
            hotelesWindow.Show();
            this.Close();
        }

        private void amHabMenuItem_Click(object sender, EventArgs e)
        {
            AmenidadesHabitacionWindow amenidadesHabitacion = new AmenidadesHabitacionWindow(idUsuario);
            amenidadesHabitacion.Show();
            this.Close();
        }

        private void caractHabMenuItem_Click(object sender, EventArgs e)
        {
            CaracteristicasHabitacionWindow caracteristicasHabitacion = new CaracteristicasHabitacionWindow(idUsuario);
            this.Close();
            caracteristicasHabitacion.Show();
        }

        private void usuariosMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void habilitarInhabilitarUsuarioMenuItem_Click(object sender, EventArgs e)
        {
            UsuariosWindow usuariosWindow = new UsuariosWindow(idUsuario);
            usuariosWindow.Show();
            this.Close();
        }

        private void cancelarReservacionMenuItem_Click(object sender, EventArgs e)
        {
            CancelacionWindow cancelacionWindow = new CancelacionWindow(idUsuario);
            cancelacionWindow.Show();
            this.Close();
        }

        private void reporteDeOcupaciónPorHotelMenuItem_Click(object sender, EventArgs e)
        {
            ReporteOcupacionWindow reporteOcupacion = new ReporteOcupacionWindow(idUsuario);
            reporteOcupacion.Show();
            this.Close();
        }

        private void reporteDeVentasMenuItem_Click(object sender, EventArgs e)
        {
            ReporteVentasWindow reporteVentasWindow = new ReporteVentasWindow(idUsuario);
            reporteVentasWindow.Show();
            this.Close();
        }

        private void historialDeClienteMenuItem_Click_1(object sender, EventArgs e)
        {
            HistorialClienteWindow historialClienteWindow = new HistorialClienteWindow(idUsuario);
            historialClienteWindow.Show();
            this.Close();
        }

        private void salirMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void dgvReporteVentas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 4 && e.Value != null)
            {
                e.Value = "$" + e.Value.ToString();
                e.FormattingApplied = true;
            }
            if (e.ColumnIndex == 5 && e.Value != null)
            {
                e.Value = "$" + e.Value.ToString();
                e.FormattingApplied = true;
            }
            if (e.ColumnIndex == 6 && e.Value != null)
            {
                e.Value = "$" + e.Value.ToString();
                e.FormattingApplied = true;
            }
        }
    }
}
