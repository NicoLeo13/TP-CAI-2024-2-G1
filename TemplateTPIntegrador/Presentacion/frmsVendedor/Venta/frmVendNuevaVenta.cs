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
            ConfigurarTabIndex();
        }

        //Metodo para configurar el TabIndex de los controles (txtBox)
        private void ConfigurarTabIndex()
        {
            //txtVentaID.TabIndex = 0;
            //txtClienteID.TabIndex = 1;
            //txtProductoID.TabIndex = 2;
            //txtDescripcion.TabIndex = 3;
            //txtCantidad.TabIndex = 4;
            //txtEstado.TabIndex = 5;
            //dtpFechaVenta.TabIndex = 6;
            //txtBoxUsuario.TabIndex = 7;
            //txtBoxContraseña.TabIndex = 8;
            //cmbHost.TabIndex = 9;
            //btnCargarVenta.TabIndex = 10;
            //btnLimpiarCampos.TabIndex = 11;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {

            PresentacionUtils.VolverFormPrevio((IconButton)sender, PresentacionUtils.FormPrevio, PresentacionUtils.PanelContenedor);
        }
        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            try
            {
                PresentacionUtils.LimpiarControles(this); 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnGuardarVenta_Click(object sender, EventArgs e)
        {
            //PresentacionValidaciones validaciones = new PresentacionValidaciones();
            //if (!validaciones.ValidarControles(this, out string mensajeError))
            //{
            //    MessageBox.Show(mensajeError, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            //Guid idVenta = Guid.NewGuid();
            //Guid idCliente;
            //Guid idUsuario;
            //Guid idProducto;

            //Guid.TryParse(txtClienteID.Text, out idCliente);
            //Guid.TryParse(txtProductoID.Text, out idProducto);
            //Guid.TryParse(txtBoxUsuario.Text, out idUsuario);

            ////TODO: Añadir metodo validar int de cantidad y estado
            //int cantidad;
            //int.TryParse(txtCantidad.Text, out cantidad);

            //int estado;
            //int.TryParse(txtEstado.Text, out estado);

            //DateTime fechaAlta = dtpFechaVenta.Value;

            //Venta venta = new Venta(idVenta, idCliente, idProducto, cantidad, fechaAlta, estado, idUsuario);
            //VentaService ventaService = new VentaService();

            //string respuestaNuevaVenta = ventaService.AgregarVenta(venta);

            //MessageBox.Show($"Venta {respuestaNuevaVenta} fue agregada exitosamente!");
        }

        private void lblTop_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Buscar producto por Nombre
            ProductoService productoService = new ProductoService();
            //Producto producto = productoService.BuscarProductoPorNombre(txtDescripcion.Text);
        }






        //private void btnAgregarAlCarrito_Click(object sender, EventArgs e)
        //{
        //    Guid idProducto;
        //    Guid.TryParse(txtProductoID.Text, out idProducto);
        //    string descripcion = txtDescripcion.Text;
        //    int cantidad;
        //    int.TryParse(txtCantidad.Text, out cantidad);
        //    decimal precioUnitario;
        //    decimal.TryParse(txtPrecioUnitario.Text, out precioUnitario);

        //    ItemCarrito item = new ItemCarrito(idProducto, descripcion, cantidad, precioUnitario);
        //    carrito.AgregarItem(item);

        //    ActualizarVistaCarrito();
        //}

        //private void btnCargarVenta_Click(object sender, EventArgs e)
        //{
        //    Guid idVenta = Guid.NewGuid();
        //    Guid idCliente;
        //    Guid idUsuario;
        //    Guid.TryParse(txtClienteID.Text, out idCliente);
        //    Guid.TryParse(txtBoxUsuario.Text, out idUsuario);
        //    DateTime fechaAlta = dtpFechaVenta.Value;
        //    int estado;
        //    int.TryParse(txtEstado.Text, out estado);

        //    Venta venta = new Venta(idVenta, idCliente, carrito.Items.Select(i => i.IdProducto).ToList(), carrito.Items.Select(i => i.Cantidad).ToList(), fechaAlta, estado, idUsuario);
        //    VentaService ventaService = new VentaService();

        //    string respuestaNuevaVenta = ventaService.AgregarVenta(venta);

        //    MessageBox.Show($"Venta {respuestaNuevaVenta} fue agregada exitosamente!");
        //    carrito.LimpiarCarrito();
        //    ActualizarVistaCarrito();
        //}
    }
}
