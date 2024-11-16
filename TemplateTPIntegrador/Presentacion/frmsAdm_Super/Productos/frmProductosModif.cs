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
    public partial class frmProductosModif : Form
    {
        private UsuarioWS usuario;
        private Producto producto;
        private ProductoService productoService;

        public frmProductosModif()
        {
            InitializeComponent();
        }

        private void frmProductosModif_Load(object sender, EventArgs e)
        {
            productoService = new ProductoService();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            PresentacionUtils.VolverFormPrevio((IconButton)sender, PresentacionUtils.FormPrevio, PresentacionUtils.PanelContenedor);
        }

        public void LimpiarCamposModif()
        {
            txtBoxProd.Text = "";
            txtBoxPrecioProd.Text = "";
            txtBoxStockProd.Text = "";
        }

        private void btnBuscarProducto_click(object sender, EventArgs e)
        {
            if (txtBoxProd.Text == "")
            {
                MessageBox.Show("Ingrese el nombre del producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                producto = ProductoService.BuscarProducto(txtBoxProd.Text);

                if (producto == null)
                {
                    MessageBox.Show("El producto de nombre: " + txtBoxProd.Text + " no fue encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                PresentacionUtils.HabilitarControles(grpDatosProd);

                txtBoxPrecioProd.Text = producto.Precio.ToString();
                txtBoxStockProd.Text = producto.Stock.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el producto de nombre: " + txtBoxProd.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"\nError al buscar el producto de nombre: {txtBoxProd.Text} - {ex.Message}");
            }
        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            if (producto == null)
            {
                MessageBox.Show("No se ha seleccionado ningun producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Validar si el campo Precio es numerico
            if (!double.TryParse(txtBoxPrecioProd.Text, out double precio))
            {
                MessageBox.Show("El campo Precio debe ser numerico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtBoxStockProd.Text, out int stock))
            {
                MessageBox.Show("El campo Precio debe ser numerico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (producto.Precio == precio && producto.Stock == stock)
            {
                MessageBox.Show("No se han realizado cambios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            producto.Precio = precio;
            producto.Stock = stock;

            try
            {
                productoService.ModificarProducto(producto);
                
                MessageBox.Show("Producto modificado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PresentacionUtils.DeshabilitarControles(grpDatosProd);
                LimpiarCamposModif();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"\nError al modificar el producto: {ex.Message}");
            }
        }
    }
}
