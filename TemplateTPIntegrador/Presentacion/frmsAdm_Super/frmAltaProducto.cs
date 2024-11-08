using Datos;
using Negocio;
using Persistencia;
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
    public partial class frmAltaProducto : Form
    {
        
        public frmAltaProducto()
        {
            InitializeComponent();
        }

        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {

            int idcategoria = int.Parse(txtBoxIDCategoria.Text);
            Guid idusuario = Guid.Parse(txtBoxIDUsuario.Text);
            Guid idproveedor = Guid.Parse(txtBoxIDProveedor.Text);
            string nombre = txtBoxNombre.Text;
            int precio = int.Parse(txtBoxPrecio.Text);
            int stock = int.Parse(txtBoxStock.Text);   

            Producto producto = new Producto(idcategoria, idusuario, idproveedor, nombre, precio, stock);
            ProductoService productoService = new ProductoService();

            string respuestaAltaProducto = productoService.AgregarProducto(producto);

            
            MessageBox.Show("Se guardo el producto correctamente" + respuestaAltaProducto);
        }
    }
}
