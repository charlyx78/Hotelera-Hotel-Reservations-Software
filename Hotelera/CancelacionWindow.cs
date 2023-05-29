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
    public partial class CancelacionWindow : Form
    {
        int idUsuario;
        public CancelacionWindow(int idUsuarioParam)
        {
            idUsuario = idUsuarioParam;
            InitializeComponent();
        }

        private void hotelesMenuItem_Click(object sender, EventArgs e)
        {
            //HotelesWindow hotelesWindow = new HotelesWindow(idUsuario);
            //hotelesWindow.Show();
            //this.Close();
        }

        private void amHabMenuItem_Click(object sender, EventArgs e)
        {
            //AmenidadesHabitacionWindow amenidadesHabitacion = new AmenidadesHabitacionWindow(idUsuario);
            //amenidadesHabitacion.Show();
            //this.Close();
        }

        private void caractHabMenuItem_Click(object sender, EventArgs e)
        {
            //CaracteristicasHabitacionWindow caracteristicasHabitacion = new CaracteristicasHabitacionWindow(idUsuario);
            //this.Close();
            //caracteristicasHabitacion.Show();
        }

        private void habilitarInhabilitarUsuarioMenuItem_Click(object sender, EventArgs e)
        {
            //UsuariosWindow usuariosWindow = new UsuariosWindow(idUsuario);
            //usuariosWindow.Show();
            //this.Close();
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
    }
}
