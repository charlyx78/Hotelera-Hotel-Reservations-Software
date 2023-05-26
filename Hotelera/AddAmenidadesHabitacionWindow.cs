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
    public partial class AddAmenidadesHabitacionWindow : Form
    {
        int idHab;
        public AddAmenidadesHabitacionWindow(int idHabParam)
        {
            idHab = idHabParam;
            InitializeComponent();
        }

        private void AddAmenidadesHabitacionWindow_Load(object sender, EventArgs e)
        {
            EnlaceDB enlace = new EnlaceDB();
            lbAmHabDisp.DataSource = enlace.get_AmHab();
            lbAmHabDisp.DisplayMember = "Nombre";
            lbAmHabDisp.ValueMember = "ID";
            actualizar();
        }
        private void btnNuevoTipoHab_Click(object sender, EventArgs e)
        {
            if (lbAmHabDisp.SelectedIndex != -1)
            {
                EnlaceDB enlace = new EnlaceDB();
                if (enlace.Gestion_AmHabAdded(0, idHab, Convert.ToInt32(lbAmHabDisp.SelectedValue), "I"))
                {
                    MessageBox.Show("Amenidad agregada exitosamente a la habitación!", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    actualizar();
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una amenidad para agregar a la habitación", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnEliminarAmHabAg_Click(object sender, EventArgs e)
        {
            if (lbAmHabAg.SelectedIndex != -1)
            {
                if (MessageBox.Show("¿Está seguro de que desea eliminar este amenidad agregada a la habitación? Una vez eliminada, su información solo podrá ser recuperada por el SA", "Alerta!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    EnlaceDB enlace = new EnlaceDB();
                    if (enlace.Gestion_AmHabAdded(Convert.ToInt32(lbAmHabAg.SelectedValue), idHab, 0, "D"))
                    {
                        MessageBox.Show("Amenidad eliminada exitosamente de la habitación!", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        actualizar();
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una amenidad agregada en la habitación para eliminar", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void actualizar()
        {
            EnlaceDB enlace = new EnlaceDB();
            lbAmHabAg.DataSource = enlace.get_AmHabAdded(idHab);
            lbAmHabAg.DisplayMember = "nombre";
            lbAmHabAg.ValueMember = "idTipoHab_AmenHab";
        }
    }
}
