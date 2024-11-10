using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.frmsVendedor
{
    public partial class frmVendReportes : Form
    {
        public frmVendReportes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblFechaVenta_Click(object sender, EventArgs e)
        {

        }

        private void dtpFechaVenta_ValueChanged(object sender, EventArgs e)
        {

        }

        private async void btnBuscarVenta_Click(object sender, EventArgs e)
        {
            //Buscar ventas del Cliente y Mostrar en pantalla
            int clienteId = Convert.ToInt32(txtCliente.Text);
            string empresa = txtEmpresa.Text;
            DateTime fechaCompra = dtpFechaVenta.Value;

            var ventaService = new VentaService();
            var ventas = await ventaService.BuscarVentasCliente(clienteId, empresa, fechaCompra);

            if (ventas != null)
            {
                 dgvVentas.DataSource = ventas;
            }
            else
            {
                MessageBox.Show("No se encontraron ventas para los criterios especificados.");
            }

        }
    }
}
