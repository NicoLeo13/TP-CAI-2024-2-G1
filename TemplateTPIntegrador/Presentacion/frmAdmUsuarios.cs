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

namespace Presentacion
{
    public partial class frmAdmUsuarios : Form
    {
        private frmPerfilAdministrador mainForm;

        public frmAdmUsuarios()
        {
            InitializeComponent();
        }

        private void btnAltaUsuario_Click(object sender, EventArgs e)
        {
            PresentacionUtils.AbrirForm((IconButton)sender, new frmAdmUsuariosAlta(), PresentacionUtils.PanelContenedor);

            //frmAdmAltaUsuarios altausuario = new frmAdmAltaUsuarios();
            //altausuario.Show();
        }

        private void btnModUsuario_Click(object sender, EventArgs e)
        {
            //frmModifUsuarios modusuario = new frmModifUsuarios();
            //modusuario.Show();
        }

        private void btnBajaUsuario_Click(object sender, EventArgs e)
        {
            //BajaUsuario bajaUsuario = new BajaUsuario();
            //bajaUsuario.Show();
        }

    }
}
