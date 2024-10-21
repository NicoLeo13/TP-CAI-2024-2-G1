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
    public partial class PerfilAdministrador : Form
    {
        public PerfilAdministrador()
        {
            InitializeComponent();
        }

        private void btnAdmVend_Click(object sender, EventArgs e)
        {
            ABM_Administrador ABM_Administrador = new ABM_Administrador();
            ABM_Administrador.Show();
        }

        private void btnAdmSup_Click(object sender, EventArgs e)
        {
            ABM_Administrador ABM_Administrador = new ABM_Administrador();
            ABM_Administrador.Show();
        }

        private void btnAdmProv_Click(object sender, EventArgs e)
        {
            ABM_Administrador ABM_Administrador = new ABM_Administrador();
            ABM_Administrador.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
