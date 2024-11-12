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
        public UsuarioWS usuario;
        public ProductoWS producto;

        public frmProductosModif()
        {
            InitializeComponent();
        }

        private void frmProductosModif_Load(object sender, EventArgs e)
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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            PresentacionUtils.VolverFormPrevio((IconButton)sender, PresentacionUtils.FormPrevio, PresentacionUtils.PanelContenedor);
        }

        public void LimpiarCamposBaja()
        {
            //txtBoxUsuario.Text = "";
            //lblContNombre.Text = "";
            //lblContApellido.Text = "";
            //lblContDni.Text = "";
            //lblContHost.Text = "";
            //lblContIdUser.Text = "";
            //lblContEstado.Text = "";
        }

        private void btnBuscarProducto_click(object sender, EventArgs e)
        {
            if (txtBoxNombreProd.Text == "")
            {
                MessageBox.Show("Ingrese el nombre del producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            if (producto == null)
            {
                MessageBox.Show("No se ha seleccionado ningun producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
