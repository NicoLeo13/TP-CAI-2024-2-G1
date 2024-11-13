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

        private async void btnDevolverVenta_Click(object sender, EventArgs e)
        {
            if (venta == null)
            {
                MessageBox.Show("No se ha seleccionado ninguna venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (usuario == null)  //Para evitar error de referencia nula.
            {
                MessageBox.Show("El usuario no está autenticado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int id = int.Parse(txtBoxIdVenta.Text); 
            Guid idUsuario = usuario.Id;
            VentaService ventaNegocio = new VentaService();
            bool result = await ventaNegocio.DevolverVenta(id, idUsuario);
            if (result)
            {
                MessageBox.Show("Venta devuelta con éxito.");
                LimpiarCamposBaja();
            }
            else
            {
                MessageBox.Show("Error al devolver la venta.");
            }
        }
        
    }
}
