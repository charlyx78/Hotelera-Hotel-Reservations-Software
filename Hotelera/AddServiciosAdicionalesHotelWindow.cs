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
    public partial class AddServiciosAdicionalesHotelWindow : Form
    {
        int idHotel;
        public AddServiciosAdicionalesHotelWindow(int idHotelParam)
        {
            idHotel = idHotelParam;
            InitializeComponent();
        }

        private void AddServiciosAdicionalesHotelWindow_Load(object sender, EventArgs e)
        {
            actualizar();
        }

        private void btnAggServAdicionales_Click(object sender, EventArgs e)
        {
            if (lbServAdicionalesDisp.SelectedIndex != -1)
            {
                EnlaceDB enlace = new EnlaceDB();
                if (enlace.Gestion_ServAdicionalesAdded("I", 0, idHotel, Convert.ToInt32(lbServAdicionalesDisp.SelectedValue)))
                {
                    MessageBox.Show("Servicio adicional agregado exitosamente al hotel!", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    actualizar();
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un servicio adicional para agregar al hotel", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarServAdicionalesAgg_Click(object sender, EventArgs e)
        {
            if (lbServAdicionalesAgg.SelectedIndex != -1)
            {
                if (MessageBox.Show("¿Está seguro de que desea eliminar este servicio adicional agregado al hotel? Una vez eliminado, su información solo podrá ser recuperada por el SA", "Alerta!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    EnlaceDB enlace = new EnlaceDB();
                    if (enlace.Gestion_ServAdicionalesAdded("D", Convert.ToInt32(lbServAdicionalesAgg.SelectedValue), idHotel, 0))
                    {
                        this.Controls.Clear();
                        MessageBox.Show("Servicio adicional del hotel eliminado exitosamente!", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.InitializeComponent();
                        actualizar();
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un servicio adicional del hotel para eliminar", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void actualizar()
        {
            EnlaceDB enlace = new EnlaceDB();
            lbServAdicionalesAgg.DataSource = enlace.get_ServAdicionalesAdded("S",idHotel);
            lbServAdicionalesAgg.DisplayMember = "nombre";
            lbServAdicionalesAgg.ValueMember = "ID";
            lbServAdicionalesDisp.DataSource = enlace.get_ServAdicionales();
            lbServAdicionalesDisp.DisplayMember = "nombre";
            lbServAdicionalesDisp.ValueMember = "ID";
        }
    }
}
