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
    public partial class AddHabitacionHotelWindow : Form
    {
        int idHotel, idUsuario, cantPisos;
        public AddHabitacionHotelWindow(int idHotelParam, int idUsuarioParam, int cantPisosParam)
        {
            cantPisos = cantPisosParam;
            idUsuario = idUsuarioParam;
            idHotel = idHotelParam;
            InitializeComponent();
        }
        private void AddTipoHabitacionHotelWindow_Load(object sender, EventArgs e)
        {
            actualizar();
        }

        private void btnNuevaHab_Click(object sender, EventArgs e)
        {
            if(txtTipoHab.Text==""||txtPiso.Text==""||txtNoHab.Text=="")
            {
                MessageBox.Show("Llene todos los campos para registrar una habitacion", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(Convert.ToInt32(txtPiso.Text) > cantPisos)
            {
                MessageBox.Show("El piso digitado está fuera del rango de cantidad de pisos del hotel", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                EnlaceDB enlace = new EnlaceDB();
                if (enlace.Gestion_Hab("I",0,Convert.ToInt32(txtNoHab.Text),Convert.ToInt32(txtPiso.Text),idHotel,Convert.ToInt32(txtTipoHab.SelectedValue),1,idUsuario))
                {
                    this.Controls.Clear();
                    MessageBox.Show("Habitacion registrada exitosamente!", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.InitializeComponent();
                    actualizar();
                }
            }
        }

        private void btnEditarHab_Click(object sender, EventArgs e)
        {
            if (dgvHabitaciones.CurrentRow.Index < 0)
            {
                MessageBox.Show("Seleccione una habitación a eliminar", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtTipoHab.Text == "" || txtPiso.Text == "" || txtNoHab.Text == "")
                {
                    MessageBox.Show("Llene todos los campos para actualizar una habitacion", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    EnlaceDB enlace = new EnlaceDB();
                    if (enlace.Gestion_Hab("U", Convert.ToInt32(dgvHabitaciones.Rows[dgvHabitaciones.CurrentRow.Index].Cells[0].Value), Convert.ToInt32(txtNoHab.Text), Convert.ToInt32(txtPiso.Text), idHotel, Convert.ToInt32(txtTipoHab.SelectedValue), 1, idUsuario))
                    {
                        this.Controls.Clear();
                        MessageBox.Show("Habitacion actualizada exitosamente!", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.InitializeComponent();
                        actualizar();
                    }
                }
            }
        }

        private void btnEliminarHab_Click(object sender, EventArgs e)
        {
            if (dgvHabitaciones.CurrentRow.Index < 0)
            {
                MessageBox.Show("Seleccione una habitación a eliminar", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                EnlaceDB enlace = new EnlaceDB();
                if(enlace.Gestion_Hab("D", Convert.ToInt32(dgvHabitaciones.Rows[dgvHabitaciones.CurrentRow.Index].Cells[0].Value),0,0,0,0,0,0))
                {
                    this.Controls.Clear();
                    MessageBox.Show("Habitacion eliminada exitosamente!", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.InitializeComponent();
                    actualizar();
                }
            }
        }

        private void dgvHabitaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTipoHab.Text = dgvHabitaciones.Rows[dgvHabitaciones.CurrentRow.Index].Cells[1].Value.ToString();
            txtNoHab.Text = dgvHabitaciones.Rows[dgvHabitaciones.CurrentRow.Index].Cells[2].Value.ToString();
            txtPiso.Text = dgvHabitaciones.Rows[dgvHabitaciones.CurrentRow.Index].Cells[3].Value.ToString();
        }

        private void actualizar()
        {
            EnlaceDB enlace = new EnlaceDB();
            dgvHabitaciones.DataSource = enlace.get_Hab("S", idHotel);
            txtTipoHab.DataSource = enlace.get_Combobox("SP_MostrarTiposHab");
            txtTipoHab.DisplayMember = "nombre";
            txtTipoHab.ValueMember = "ID";
        }
    }
}
