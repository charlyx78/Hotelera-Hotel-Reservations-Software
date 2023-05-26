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
    public partial class ReporteOcupacionWindow : Form
    {
        int idUsuario;
        public ReporteOcupacionWindow(int idUsuarioParam)
        {
            idUsuario = idUsuarioParam;
            InitializeComponent();
        }

        private void hotelesMenuItem_Click(object sender, EventArgs e)
        {
            HotelesWindow hotelesWindow = new HotelesWindow(idUsuario);
            hotelesWindow.Show();
            this.Close();
        }

        private void serviciosAdicionalesDeHotelMenuItem_Click(object sender, EventArgs e)
        {
            ServiciosAdicionalesWindow serviciosAdicionalesWindow = new ServiciosAdicionalesWindow(idUsuario);
            serviciosAdicionalesWindow.Show();
            this.Close();
        }

        private void tiposHabMenuItem_Click(object sender, EventArgs e)
        {
            TiposHabitacionWindow tiposHabitacion = new TiposHabitacionWindow(idUsuario);
            tiposHabitacion.Show();
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

        private void historialDeClienteMenuItem_Click(object sender, EventArgs e)
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

        private void btnIrALogin_Click(object sender, EventArgs e)
        {

        }

        private void ReporteOcupacionWindow_Load(object sender, EventArgs e)
        {
            EnlaceDB enlace = new EnlaceDB();
            dataGridView1.DataSource = enlace.get_ReporteOcupacion("", "", 0, "", 0);
            dataGridView2.DataSource = enlace.get_ReporteOcupacion("R", "", 0, "", 0);
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

            dataGridView1.DataSource = enlace.get_ReporteOcupacion("P", txtPais.SelectedValue.ToString(), 0, "", 0);
            dataGridView2.DataSource = enlace.get_ReporteOcupacion("PR", txtPais.SelectedValue.ToString(), 0, "", 0);
        }

        private void btnAno_Click(object sender, EventArgs e)
        {
            EnlaceDB enlace = new EnlaceDB();
            dataGridView1.DataSource = enlace.get_ReporteOcupacion("A", "", Convert.ToInt32(txtAno.Text), "", 0);
            dataGridView2.DataSource = enlace.get_ReporteOcupacion("AR", "", Convert.ToInt32(txtAno.Text), "", 0);
        }

        private void btnCd_Click(object sender, EventArgs e)
        {
            EnlaceDB enlace = new EnlaceDB();
            dataGridView1.DataSource = enlace.get_ReporteOcupacion("C", "", 0, txtCiudad.SelectedValue.ToString(), 0);
            dataGridView2.DataSource = enlace.get_ReporteOcupacion("CR", "", 0, txtCiudad.SelectedValue.ToString(), 0);
        }

        private void btnHotel_Click(object sender, EventArgs e)
        {
            EnlaceDB enlace = new EnlaceDB();
            dataGridView1.DataSource = enlace.get_ReporteOcupacion("H", "", 0, "", Convert.ToInt32(txtHotel.SelectedValue));
            dataGridView2.DataSource = enlace.get_ReporteOcupacion("HR", "", 0, "", Convert.ToInt32(txtHotel.SelectedValue));
        }
    }
}
