using Datos;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmAdmUsuariosBaja : Form
    {
        public frmAdmUsuariosBaja()
        {
            InitializeComponent();
        }

        private void BajaUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            LoginUsuario login = new LoginUsuario();

            string usuarioBaja = txtUsuario.Text;

            UsuarioWS usuario = login.TraerUsuario(usuarioBaja);

            MessageBox.Show("ID del usuario a dar de baja: " + usuario.Id);
        }
    }
}
