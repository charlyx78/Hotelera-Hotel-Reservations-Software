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
        public HistorialClienteWindow()
        {
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
    }
}
