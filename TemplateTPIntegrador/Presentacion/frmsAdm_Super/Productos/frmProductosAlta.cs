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
    public partial class frmProductosAlta : Form
    {
        private static UsuarioWS usuarioActual;

        public frmProductosAlta(UsuarioWS objUsuario)
        {
            InitializeComponent();
            usuarioActual = objUsuario;
            ConfigurarTabIndex();
        }

        private void frmProductosAlta_Load(object sender, EventArgs e)
        {
            Dictionary<int, string> categorias = new Dictionary<int, string>
            {
                { 1, "1 - Audio" },
                { 2, "2 - Celulares" },
                { 3, "3 - Electro Hogar" },
                { 4, "4 - Informatica" },
                { 5, "5 - Smart TV" }
            };

            cmbCategoria.DataSource = new BindingSource(categorias, null);
            cmbCategoria.DisplayMember = "Value";
            cmbCategoria.ValueMember = "Key";
            cmbCategoria.SelectedIndex = -1;
        }

        public void ConfigurarTabIndex()
        {
            cmbCategoria.TabIndex = 0;
            txtBoxNombre.TabIndex = 1;
            txtBoxPrecio.TabIndex = 2;
            txtBoxStock.TabIndex = 3;
            txtBoxProvCuit.TabIndex = 4;
            btnProdBuscarProv.TabIndex = 5;
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

        private void btnProdBuscarProv_Click(object sender, EventArgs e)
        {
            if (txtBoxProvCuit.Text == "")
            {
                MessageBox.Show("Ingrese un CUIT de Proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            PresentacionValidaciones validaciones = new PresentacionValidaciones();
            if (!validaciones.ValidarControles(this, out string mensajeError))
            {
                MessageBox.Show(mensajeError, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idcategoria = (int)cmbCategoria.SelectedValue;
            //Guid idusuario = usuarioActual.Id;
            Guid idusuario = Guid.Parse("7a06c9f0-8887-4b4f-b635-1ef5fe4d116f");        //Hardcode para probar (borrar despues)
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
