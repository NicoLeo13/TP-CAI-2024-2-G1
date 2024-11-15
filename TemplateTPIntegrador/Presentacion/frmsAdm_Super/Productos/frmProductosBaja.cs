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
            lblContFechaAlta.Text = "";
            lblContIdProd.Text = "";
            lblContStock.Text = "";
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
                producto = ProductoService.BuscarProducto(txtBoxNombreProd.Text);

                if (producto == null)
                {
                    MessageBox.Show("El producto de nombre: " + txtBoxNombreProd.Text + " no fue encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                lblContIdProd.Text= producto.Id.ToString();
                lblContCategoria.Text = producto.IdCategoria.ToString();
                lblContNombre.Text = producto.Nombre;
                lblContPrecio.Text = producto.Precio.ToString();
                lblContStock.Text = producto.Stock.ToString();
                lblContFechaAlta.Text = producto.FechaAlta.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el producto de nombre: " + txtBoxNombreProd.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"\nError al buscar el producto de nombre: {txtBoxNombreProd.Text} - {ex.Message}");
            }
        }

        private void btnEliminarProd_Click(object sender, EventArgs e)
        {
            if (txtBoxNombreProd.Text == null)
            {
                MessageBox.Show("Primero debe buscar un producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Condicional con mensaje de confirmación para eliminar un producto
                DialogResult dialogResult = MessageBox.Show($"¿Está seguro que desea eliminar al producto: {producto.Nombre}?", "Confirmacion",MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.No)
                    return;

                ProductoService productoService = new ProductoService();
                productoService.EliminarProducto(producto);

                LimpiarCamposBaja();

                MessageBox.Show($"Producto: {producto.Nombre}  eliminado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                producto = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"\nError al eliminar el producto: {ex.Message}");
            }
        }
    }      
    
}
    
