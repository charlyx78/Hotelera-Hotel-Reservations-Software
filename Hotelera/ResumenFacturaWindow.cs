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
    public partial class ResumenFacturaWindow : Form
    {
        int cdoReserv;
        public ResumenFacturaWindow(int cdoReservParam)
        {
            cdoReserv = cdoReservParam;
            InitializeComponent();
        }

        private void ResumenFacturaWindow_Load(object sender, EventArgs e)
        {
            EnlaceDB enlace = new EnlaceDB();
            dgvFact.DataSource = enlace.get_DatosFactura(cdoReserv, "F");
            dgvHabs.DataSource = enlace.get_DatosFactura(cdoReserv, "H");
            dgvSa.DataSource = enlace.get_DatosFactura(cdoReserv, "S");

        }

        private void btnTicket_Click(object sender, EventArgs e)
        {
            EnlaceDB.CreaTicket ticket = new EnlaceDB.CreaTicket();
            EnlaceDB enlace = new EnlaceDB();

            float subtotal = 0;
            float total = 0;

            try
            {
                ticket.TextoCentro("HOTELERA");
                ticket.TextoCentro("--------------------------------------------------");
                ticket.TextoIzquierda("");
                ticket.TextoIzquierda("No. de Factura: " + dgvFact.Rows[dgvFact.CurrentRow.Index].Cells[0].Value.ToString());
                ticket.TextoIzquierda("Hotel: " + dgvFact.Rows[dgvFact.CurrentRow.Index].Cells[1].Value.ToString());
                ticket.TextoIzquierda("Cliente: " + dgvFact.Rows[dgvFact.CurrentRow.Index].Cells[2].Value.ToString());
                ticket.TextoIzquierda("Código de reservacion: " + dgvFact.Rows[dgvFact.CurrentRow.Index].Cells[3].Value.ToString());
                ticket.TextoIzquierda("Fecha de llegada: " + dgvFact.Rows[dgvFact.CurrentRow.Index].Cells[4].Value.ToString());
                DateTime fechaActual = new DateTime();
                string fechaActualFormateada = DateTime.Now.ToString("yyyy-MM-dd");
                ticket.TextoIzquierda("Fecha de salida: " + fechaActualFormateada);
                ticket.TextoIzquierda("");
                EnlaceDB.CreaTicket.LineasGuion();
                EnlaceDB.CreaTicket.EncabezadoVenta();

                EnlaceDB.CreaTicket.LineasGuion();
                foreach (DataGridViewRow row in dgvHabs.Rows)
                {
                    if (row.Cells[0].Value != null)
                    {
                        ticket.AgregaArticulo(
                        row.Cells[0].Value.ToString(),
                        Convert.ToDouble(row.Cells[2].Value.ToString()),
                        Convert.ToDouble(row.Cells[1].Value.ToString()),
                        Convert.ToDouble(row.Cells[2].Value.ToString()),
                        0
                        );
                        float valorParseado = 0;
                        float.TryParse(row.Cells[2].Value.ToString(), out valorParseado);
                        subtotal += valorParseado;
                    }

                }
                foreach (DataGridViewRow row in dgvSa.Rows)
                {
                    if (row.Cells[0].Value != null)
                    {
                        ticket.AgregaArticulo(
                        row.Cells[0].Value.ToString(),
                        Convert.ToDouble(row.Cells[1].Value.ToString()),
                        1.0,
                        Convert.ToDouble(row.Cells[1].Value.ToString()),
                        0
                    );
                        float valorParseado = 0;
                        float.TryParse(row.Cells[1].Value.ToString(), out valorParseado);
                        subtotal += valorParseado;
                    }
                }
                EnlaceDB.CreaTicket.LineasGuion();

                ticket.AgregaTotales("Subtotal: ", subtotal);
                ticket.AgregaTotales("Total: ", subtotal);

                ticket.TextoIzquierda("");
                ticket.TextoCentro("--------------------------------------------------");
                ticket.TextoCentro("---------  Gracias por su preferencia :)  --------");
                ticket.TextoCentro("--------------------------------------------------");
                ticket.TextoIzquierda("");

                ticket.ImprimirTiket("Microsoft Print to PDF");
            }
            catch
            {

            }
        }
    }
}
