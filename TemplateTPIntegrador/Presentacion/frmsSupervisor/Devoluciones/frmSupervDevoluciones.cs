using Presentacion.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Negocio;
using Datos;
using Persistencia;
using static Negocio.VentaService;
using System.Net.Http;

namespace Presentacion
{
    public partial class frmSupervDevoluciones : Form
    {
        public UsuarioWS usuario;
        public Venta venta;
        public Guid id;
        
        public frmSupervDevoluciones()
        {
            InitializeComponent();
        }

        public void LimpiarCampos()
        {
            txtBoxIdVenta.Text = "";

            lblContEstadoVenta.Text = "";
            lblContFechaAltaVenta.Text = "";
            lblContCantidadVenta.Text = "";
        }

        private void btnBuscarVenta_Click(object sender, EventArgs e)
        {
            if (txtBoxIdVenta.Text == "")
            {
                MessageBox.Show("Por favor ingrese un ID de venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Guid idVenta = Guid.Parse(txtBoxIdVenta.Text);

                VentaService ventaService = new VentaService();

                Dictionary<string, object> venta = ventaService.ObtenerVentaPorVenta(idVenta);

                if (venta == null)
                {
                    MessageBox.Show("La venta de ID: " + txtBoxIdVenta.Text + " no fue encontrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                id = Guid.Parse(venta["id"].ToString());

                int estado = Convert.ToInt32(venta["estado"]);
                DateTime fechaAlta = Convert.ToDateTime(venta["fechaAlta"]);
                int cantidad = Convert.ToInt32(venta["cantidad"]);

                lblContEstadoVenta.Text = estado.ToString();
                lblContFechaAltaVenta.Text = fechaAlta.ToString();
                lblContCantidadVenta.Text = cantidad.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el ID de venta: " + txtBoxIdVenta.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"\nError al buscar el ID de venta: {txtBoxIdVenta.Text} - {ex.Message}");
            }
        }

        private async void btnDevolverVenta_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBoxIdVenta == null)
                {
                    MessageBox.Show("No se ha seleccionado ninguna venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                id = Guid.Parse(txtBoxIdVenta.Text);

                VentaService ventaNegocio = new VentaService();

                ventaNegocio.DevolverVenta(id);

                MessageBox.Show("La venta fue devuelta con éxito.");
                LimpiarCampos();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"\nError al devolver la venta: {ex.Message}");
            }
        }

    }
}
