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
    public partial class HistorialClienteWindow : Form
    {
        int idUsuario;
        public HistorialClienteWindow(int idUsuarioParam)
        {
            idUsuario = idUsuarioParam;
            InitializeComponent();
        }

        private void HistorialClienteWindow_Load(object sender, EventArgs e)
        {
            EnlaceDB enlace = new EnlaceDB();
            dgvHistorialCliente.DataSource = enlace.get_ReporteHistorialCliente("", 0, 0);
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            EnlaceDB enlace = new EnlaceDB();
            lbClientes.Enabled = false;
            lbClientes.DataSource = enlace.get_BusqClientes("A", "", txtCliente.Text, "");
            lbClientes.ValueMember = "ID";
            lbClientes.DisplayMember = "Nombre";
            lbClientes.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EnlaceDB enlace = new EnlaceDB();
            lbClientes.Enabled = false;
            lbClientes.DataSource = enlace.get_BusqClientes("C", txtCliente.Text, "", "");
            lbClientes.ValueMember = "ID";
            lbClientes.DisplayMember = "Correo";
            lbClientes.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EnlaceDB enlace = new EnlaceDB();
            lbClientes.Enabled = false;
            lbClientes.DataSource = enlace.get_BusqClientes("R", "", "", txtCliente.Text);
            lbClientes.ValueMember = "ID";
            lbClientes.DisplayMember = "RFC";
            lbClientes.Enabled = true;
        }

        private void btnAño_Click(object sender, EventArgs e)
        {
            if(txtAño.Text!="")
            {
                EnlaceDB enlace = new EnlaceDB();
                dgvHistorialCliente.DataSource = enlace.get_ReporteHistorialCliente("A", 0, Convert.ToInt32(txtAño.Text));
            }
        }

        private void lbClientes_SelectedValueChanged(object sender, EventArgs e)
        {
            EnlaceDB enlace = new EnlaceDB();
            try
            {
                int idCliente = Convert.ToInt32(lbClientes.SelectedValue);
                if (lbClientes.SelectedIndex > -1)
                {
                    dgvHistorialCliente.DataSource = enlace.get_ReporteHistorialCliente("C", Convert.ToInt32(lbClientes.SelectedValue), 0);
                }
            }
            catch
            {
            }
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

        private void dgvHistorialCliente_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 10 && e.Value != null)
            {
                e.Value = "$" + e.Value.ToString();
                e.FormattingApplied = true;
            }
            if (e.ColumnIndex == 11 && e.Value != null)
            {
                e.Value = "$" + e.Value.ToString();
                e.FormattingApplied = true;
            }
            if (e.ColumnIndex == 12 && e.Value != null)
            {
                e.Value = "$" + e.Value.ToString();
                e.FormattingApplied = true;
            }
            if (e.ColumnIndex == 13 && e.Value != null)
            {
                e.Value = "$" + e.Value.ToString();
                e.FormattingApplied = true;
            }
            if (e.ColumnIndex == 14 && e.Value != null)
            {
                e.Value = "$" + e.Value.ToString();
                e.FormattingApplied = true;
            }
        }
    }
}
