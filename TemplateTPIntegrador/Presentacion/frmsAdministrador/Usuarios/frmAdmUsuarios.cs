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
    public partial class frmAdmUsuarios : Form
    {
        private readonly UsuarioService _usuarioService;

        public frmAdmUsuarios()
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
            lblActivos.Text = usuariosActivos.Count.ToString();
            lblSupervActivos.Text = usuariosActivos.Where(u => u.Host == 2).Count().ToString();
            lblVendActivos.Text = usuariosActivos.Where(u => u.Host == 1).Count().ToString();
        }

        private void btnListarUsuarios_Click(object sender, EventArgs e)
        {

        }

        private void btnAltaUsuario_Click(object sender, EventArgs e)
        {
            PresentacionUtils.AbrirForm((IconButton)sender, new frmAdmUsuariosAlta(), PresentacionUtils.PanelContenedor);
        }

        private void btnModUsuario_Click(object sender, EventArgs e)
        {
            PresentacionUtils.AbrirForm((IconButton)sender, new frmAdmUsuariosModif(), PresentacionUtils.PanelContenedor);
        }

        private void btnBajaUsuario_Click(object sender, EventArgs e)
        {
            PresentacionUtils.AbrirForm((IconButton)sender, new frmAdmUsuariosBaja(), PresentacionUtils.PanelContenedor);
        }
    }
}
