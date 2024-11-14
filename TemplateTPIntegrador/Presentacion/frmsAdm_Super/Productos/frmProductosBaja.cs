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
    public partial class frmProductosBaja : Form
    {
        //public UsuarioWS usuario;
        public Producto producto;

        public frmProductosBaja()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            PresentacionUtils.VolverFormPrevio((IconButton)sender, PresentacionUtils.FormPrevio, PresentacionUtils.PanelContenedor);
        }

        public void LimpiarCamposBaja()
        {
            txtBoxNombreProd.Text = "";
            lblContCategoria.Text = "";
            lblContNombre.Text = "";
            lblContPrecio.Text = "";
            lblContHost.Text = "";
            lblContFechaAlta.Text = "";
            lblContEstado.Text = "";
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            if (txtBoxNombreProd.Text == "")
            {
                MessageBox.Show("Ingrese el nombre del producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                //proveedor = ProveedorService.BuscarProveedor(txtBoxCUITProveedor.Text);
                producto = ProductoService.BuscarProducto(txtBoxNombreProd.Text);

                // usuario = UsuarioService.BuscarUsuario(txtBoxCUITProveedor.Text);
                if (producto == null)
                {
                    MessageBox.Show("El producto de nombre: " + txtBoxNombreProd.Text + " no fue encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // ID del proveedor si hiciera falta
                //txtBox ??? = proveedor.Id.ToString();

                //lblContIdProd = producto.
                lblContCategoria.Text = producto.idCategoria.ToString();
                lblContNombre.Text = producto.nombre;
                lblContPrecio.Text = producto.precio.ToString();
                lblContStock.Text = producto.stock.ToString();
                lblContFechaAlta.Text = producto.FechaAlta.ToString();
                lblContIdProd.Text= producto.idCategoria.ToString();



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el producto de nombre: " + txtBoxNombreProd.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"\nError al buscar el producto de nombre: {txtBoxNombreProd.Text} - {ex.Message}");
            }
        }
    }

        //private void btnEliminarProd_Click(object sender, EventArgs e)
        //{
            //if (producto == null)
            //{
                //MessageBox.Show("No se ha seleccionado ningun producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return;
            //}
        //}
    
}

