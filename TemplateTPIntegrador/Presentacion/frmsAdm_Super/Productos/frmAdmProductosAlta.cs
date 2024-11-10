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

namespace Presentacion
{
    public partial class frmAdmProductosAlta : Form
    {
        private static UsuarioWS usuarioActual;

        public frmAdmProductosAlta(UsuarioWS objUsuario)
        {
            InitializeComponent();
            usuarioActual = objUsuario;
            ConfigurarTabIndex();
        }

        private void frmProductosAlta_Load(object sender, EventArgs e)
        {
            //Llenar combo de categorias con valores del 1 al 5
            for (int i = 1; i <= 5; i++)
            {
                cmbCategoria.Items.Add(i);
            }
        }

        public void ConfigurarTabIndex()
        {
            cmbCategoria.TabIndex = 0;
            txtBoxNombre.TabIndex = 1;
            txtBoxPrecio.TabIndex = 2;
            txtBoxStock.TabIndex = 3;
            txtBoxProvCuit.TabIndex = 4;
            btnBuscarProv.TabIndex = 5;
            btnGuardarProducto.TabIndex = 6;
            btnLimpiarCampos.TabIndex = 7;
            btnVolver.TabIndex = 8;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            PresentacionUtils.LimpiarControles(this);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            PresentacionUtils.VolverFormPrevio((IconButton)sender, PresentacionUtils.FormPrevio, PresentacionUtils.PanelContenedor);
        }

        private void btnBuscarProv_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            int idcategoria = int.Parse(cmbCategoria.Text);
            //Guid idusuario = usuarioActual.Id;
            Guid idusuario = Guid.Parse("7a06c9f0-8887-4b4f-b635-1ef5fe4d116f");        //Harcode para probar (borrar despues)
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
