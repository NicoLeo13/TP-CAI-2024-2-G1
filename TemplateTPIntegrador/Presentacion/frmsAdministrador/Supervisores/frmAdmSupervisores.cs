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
    public partial class frmAdmSupervisores : Form
    {
        private readonly UsuarioService _usuarioService;

        public frmAdmSupervisores()
        {
            InitializeComponent();
            _usuarioService = new UsuarioService();
        }

        private async void frmAdmSuperv_Load(object sender, EventArgs e)
        {

        }

        private void ActualizarUI(List<UsuarioWS> usuariosActivos)
        {
            //Filtro por host = 2 (Supervisor)
            string supervisoresActivos = usuariosActivos.Where(u => u.Host == 2).Count().ToString();
            lblSupervActivos.Text = supervisoresActivos;
        }
        
        private void btnAltaSuperv_Click(object sender, EventArgs e)
        {
            PresentacionUtils.AbrirForm((IconButton)sender, new frmAdmSupervisoresAlta(), PresentacionUtils.PanelContenedor);
        }

        private void btnModSuperv_Click(object sender, EventArgs e)
        {
            PresentacionUtils.AbrirForm((IconButton)sender, new frmAdmSupervisoresModif(), PresentacionUtils.PanelContenedor);
        }
        
        private void btnBajaSuperv_Click(object sender, EventArgs e)
        {
            PresentacionUtils.AbrirForm((IconButton)sender, new frmAdmSupervisoresBaja(), PresentacionUtils.PanelContenedor);
        }

    }
}
