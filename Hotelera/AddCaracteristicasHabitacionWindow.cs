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
    public partial class AddCaracteristicasHabitacionWindow : Form
    {
        int idHab;
        public AddCaracteristicasHabitacionWindow(int idHabParam)
        {
            idHab = idHabParam;
            InitializeComponent();
        }

        private void AddCaracteristicasHabitacionWindow_Load(object sender, EventArgs e)
        {
            EnlaceDB enlace = new EnlaceDB();
            lbCaractHabDisp.DataSource = enlace.get_CaractHab();
            lbCaractHabDisp.DisplayMember = "Nombre";
            lbCaractHabDisp.ValueMember = "ID";
            actualizar();
        }
        private void btnAggCaractHab_Click(object sender, EventArgs e)
        {
            if (lbCaractHabDisp.SelectedIndex != -1)
            {
                EnlaceDB enlace = new EnlaceDB();
                if (enlace.Gestion_CaractHabAdded(0, idHab, Convert.ToInt32(lbCaractHabDisp.SelectedValue), "I"))
                {
                    MessageBox.Show("Característica agregada exitosamente a la habitación!", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    actualizar();
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una característica para agregar a la habitación", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnEliminarCaractHabAgg_Click(object sender, EventArgs e)
        {
            if (lbCaractHabAg.SelectedIndex != -1)
            {
                if (MessageBox.Show("¿Está seguro de que desea eliminar este característica agregada a la habitación? Una vez eliminada, su información solo podrá ser recuperada por el SA", "Alerta!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    EnlaceDB enlace = new EnlaceDB();
                    if (enlace.Gestion_CaractHabAdded(Convert.ToInt32(lbCaractHabAg.SelectedValue), idHab, 0, "D"))
                    {
                        MessageBox.Show("Característica eliminada exitosamente de la habitación!", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            lbCaractHabAg.DataSource = enlace.get_CaractHabAdded(idHab);
            lbCaractHabAg.DisplayMember = "nombre";
            lbCaractHabAg.ValueMember = "idTipoHab_CaractHab";
        }
    }
}
