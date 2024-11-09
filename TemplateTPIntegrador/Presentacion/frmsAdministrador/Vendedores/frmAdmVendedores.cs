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
    public partial class frmAdmVendedores : Form
    {
        private readonly UsuarioService _usuarioService;
        private frmPerfilSupervisor mainForm;

        public frmAdmVendedores()
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
            string vendedoresActivos = usuariosActivos.Where(u => u.Host == 1).Count().ToString();
            lblVendActivos.Text = vendedoresActivos;
        }
        
        private void btnAltaVend_Click(object sender, EventArgs e)
        {
            PresentacionUtils.AbrirForm((IconButton)sender, new frmAdmVendedoresAlta(), PresentacionUtils.PanelContenedor);
        }


        private void btnModVend_Click(object sender, EventArgs e)
        {
            PresentacionUtils.AbrirForm((IconButton)sender, new frmAdmVendedoresModif(), PresentacionUtils.PanelContenedor);
        }
        
        private void btnBajaVend_Click(object sender, EventArgs e)
        {
            PresentacionUtils.AbrirForm((IconButton)sender, new frmAdmVendedoresBaja(), PresentacionUtils.PanelContenedor);
        }

    }
}
