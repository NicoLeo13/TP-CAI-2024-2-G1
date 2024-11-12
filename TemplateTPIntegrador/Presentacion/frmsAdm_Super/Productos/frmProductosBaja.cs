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
        public UsuarioWS usuario;
        public ProductoWS producto;

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

        private void btnBuscarProducto_click(object sender, EventArgs e)
        {
            if (txtBoxNombreProd.Text == "")
            {
                MessageBox.Show("Ingrese el nombre del producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (producto == null)
            {
                MessageBox.Show("No se ha seleccionado ningun producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
