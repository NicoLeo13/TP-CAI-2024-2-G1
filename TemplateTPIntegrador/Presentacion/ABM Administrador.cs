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
    public partial class ABM_Administrador : Form
    {
        public ABM_Administrador()
        {
            InitializeComponent();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            Alta_de_Usuario altausuario = new Alta_de_Usuario();
            altausuario.Show();
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            Modificacion_de_Usuario modusuario = new Modificacion_de_Usuario();
            modusuario.Show();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            BajaUsuario bajaUsuario = new BajaUsuario();
            bajaUsuario.Show();
        }

        private void btnvolver1_Click(object sender, EventArgs e)
        {
            PerfilAdministrador perfil_Administrador = new PerfilAdministrador();
            perfil_Administrador.Show();
        }
    }
}
