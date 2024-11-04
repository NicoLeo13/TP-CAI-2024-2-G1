using FontAwesome.Sharp;
using Negocio;
using Datos;
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

namespace Presentacion
{
    public partial class frmVendNuevaVenta : Form
    {
        public frmVendNuevaVenta()
        {
            InitializeComponent();
        }
        
        private void btnVolver_Click(object sender, EventArgs e)
        {
            PresentacionUtils.VolverFormPrevio((IconButton)sender, PresentacionUtils.FormPrevio, PresentacionUtils.PanelContenedor);
        }
        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            PresentacionUtils.LimpiarControles(this);
        }
        private void btnGuardarVenta_Click(object sender, EventArgs e)
        {

            Guid idVenta = Guid.NewGuid();
            Guid idCliente;
            Guid idUsuario;
            Guid idProducto;

            Guid.TryParse(txtClienteID.Text, out idCliente);
            Guid.TryParse(txtProductoID.Text, out idProducto);
            Guid.TryParse(txtBoxUsuario.Text, out idUsuario);

            int cantidad;
            int.TryParse(txtCantidad.Text, out cantidad);

            int estado;
            int.TryParse(txtEstado.Text, out estado);

            DateTime fechaAlta = dtpFechaVenta.Value;

            Datos.Venta venta = new Datos.Venta(idCliente, idProducto, idUsuario, cantidad, estado, fechaAlta);
            VentaService ventaService = new VentaService();

            string respuestaNuevaVenta = ventaService.AgregarVenta(venta);



            MessageBox.Show($"Venta {respuestaNuevaVenta} fue agregada exitosamente!");
        }


        private void btnCargarVenta_Click(object sender, EventArgs e)
        {
            // Código para cargar una venta
        }

        private void btnGuardarUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}
