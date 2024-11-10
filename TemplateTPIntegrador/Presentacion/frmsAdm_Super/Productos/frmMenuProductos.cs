using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using FontAwesome.Sharp;
using Presentacion.Utils;
using Persistencia;
using Negocio;

namespace Presentacion
{
    public partial class frmMenuProductos : Form
    {
        private static UsuarioWS usuarioActual;
        private readonly UsuarioService _usuarioService;

        public frmMenuProductos(UsuarioWS objUsuario)
        {
            InitializeComponent();
            usuarioActual = objUsuario;

            _usuarioService = new UsuarioService();
        }

        private async void frmProductos_Load(object sender, EventArgs e)
        {
            //var (usuariosActivos, msg) = await _usuarioService.CargarUsuariosActivosAsync();
            //if (msg == null)
            //    ActualizarUI(usuariosActivos);
            //else
            //    MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void ActualizarUI(List<UsuarioWS> usuariosActivos)
        {
            //Filtro por host = 2 (Supervisor)
            //string supervisoresActivos = usuariosActivos.Where(u => u.Host == 2).Count().ToString();
            //lblProdActivos.Text = supervisoresActivos;
        }

        private void btnAltaProducto_Click(object sender, EventArgs e)
        {
            PresentacionUtils.AbrirForm((IconButton)sender, new frmProductosAlta(usuarioActual), PresentacionUtils.PanelContenedor);
        }

        private void btnModProducto_Click(object sender, EventArgs e)
        {
            PresentacionUtils.AbrirForm((IconButton)sender, new frmProductosModif(), PresentacionUtils.PanelContenedor);
        }

        private void btnBajaProd_Click(object sender, EventArgs e)
        {
            PresentacionUtils.AbrirForm((IconButton)sender, new frmProductosBaja(), PresentacionUtils.PanelContenedor);
        }

    }
}
