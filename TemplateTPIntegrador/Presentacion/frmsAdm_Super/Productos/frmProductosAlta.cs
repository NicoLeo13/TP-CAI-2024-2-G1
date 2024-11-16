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
        private static Proveedor proveedor;
        private static ProveedorService proveedorService;

        public frmProductosAlta(UsuarioWS objUsuario)
        {
            InitializeComponent();
            usuarioActual = objUsuario;
            ConfigurarTabIndex();
            proveedorService = new ProveedorService();
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
                MessageBox.Show("Ingrese un CUIT de proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                proveedor = ProveedorService.BuscarProveedor(txtBoxProvCuit.Text);

                if (proveedor == null)
                {
                    MessageBox.Show("No se encontró el proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                lblContProvNombre.Text = proveedor.Nombre.ToString();
                lblContProvApellido.Text = proveedor.Apellido.ToString();
                lblContProvEmail.Text = proveedor.Email.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar al proveedor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            //Guid idusuario = usuarioActual.Id;
            Guid idusuario = Guid.Parse("7a06c9f0-8887-4b4f-b635-1ef5fe4d116f");        //Hardcode para probar (borrar despues)
            Guid idproveedor = proveedor.Id;
            int idcategoria = (int)cmbCategoria.SelectedValue;
            string nombre = txtBoxNombre.Text;
            int precio = int.Parse(txtBoxPrecio.Text);
            int stock = int.Parse(txtBoxStock.Text);
            DateTime fechaalta = DateTime.Now;
            DateTime? fechabaja = null;

            Producto producto = new Producto(idcategoria, idusuario, idproveedor, nombre, precio, stock, fechaalta, fechabaja);
            ProductoService productoService = new ProductoService();

            string respuestaAltaProducto = productoService.AgregarProducto(producto);

            MessageBox.Show($"Se guardo el producto correctamente: {txtBoxNombre.Text}", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            PresentacionUtils.LimpiarControles(this);
            lblContProvNombre.Text = "";
            lblContProvApellido.Text = "";
            lblContProvEmail.Text = "";
        }
    }
}
