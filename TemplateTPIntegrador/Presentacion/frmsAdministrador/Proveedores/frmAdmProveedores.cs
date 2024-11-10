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
    public partial class frmAdmProveedores : Form
    {
        private readonly UsuarioService _usuarioService;

        public frmAdmProveedores()
        {
            InitializeComponent();
            _usuarioService = new UsuarioService();
        }

        private async void frmAdmUsuarios_Load(object sender, EventArgs e)
        {
            var (usuariosActivos, msg) = await _usuarioService.CargarUsuariosActivosAsync();
            if (msg == null)
                ActualizarUI(usuariosActivos);
            else
                MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void ActualizarUI(List<UsuarioWS> usuariosActivos)
        {
            //Filtro por host = 1 (Vendedor)
            //string vendedoresActivos = usuariosActivos.Where(u => u.Host == 1).Count().ToString();
            //lblProveeActivos.Text = vendedoresActivos;
        }
        
        private void btnAltaProve_Click(object sender, EventArgs e)
        {
            PresentacionUtils.AbrirForm((IconButton)sender, new frmAdmProveedoresAlta(), PresentacionUtils.PanelContenedor);
        }

        private void btnModProve_Click(object sender, EventArgs e)
        {
            PresentacionUtils.AbrirForm((IconButton)sender, new frmAdmProveedoresModif(), PresentacionUtils.PanelContenedor);
        }

        private void btnBajaProve_Click(object sender, EventArgs e)
        {
            PresentacionUtils.AbrirForm((IconButton)sender, new frmAdmProveedoresBaja(), PresentacionUtils.PanelContenedor);
        }
    }
}
