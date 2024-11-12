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

namespace Presentacion
{
    public partial class frmSupervDevoluciones : Form
    {
        public UsuarioWS usuario;
        public VentaWS venta;
        
        public frmSupervDevoluciones()
        {
            InitializeComponent();
        }

        public void LimpiarCamposBaja()
        {
            txtBoxIdVenta.Text = "";
            lblContVendId.Text = "";
            lblContProductoId.Text = "";
            lblContProducto.Text = "";
            lblContCantidad.Text = "";
            lblContPrecio.Text = "";
            lblContClienteId.Text = "";
            lblContClienteNombre.Text = "";
            lblContClienteApellido.Text = "";
            lblContClienteDni.Text = "";
            lblContClienteEmail.Text = "";
        }

        private void btnBuscarVenta_click(object sender, EventArgs e)
        {
            if (txtBoxIdVenta.Text == "")
            {
                MessageBox.Show("Ingrese el ID de la Venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnDevolverVenta_Click(object sender, EventArgs e)
        {
            if (venta == null)
            {
                MessageBox.Show("No se ha seleccionado ninguna venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
