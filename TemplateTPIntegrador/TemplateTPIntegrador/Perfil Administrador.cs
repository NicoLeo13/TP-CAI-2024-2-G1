using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemplateTPIntegrador
{
    public partial class Perfil_Administrador : Form
    {
        public Perfil_Administrador()
        {
            InitializeComponent();
        }

        private void btnAdmSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdmVend_Click(object sender, EventArgs e)
        {
            ABM_Administrador ABM_Administrador = new ABM_Administrador
            ABM_Administrador.Show();
        }
    }
}
