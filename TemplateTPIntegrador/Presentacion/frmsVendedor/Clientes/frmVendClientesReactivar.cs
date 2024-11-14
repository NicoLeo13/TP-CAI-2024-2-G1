using Presentacion.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Negocio;
using Datos;
using Persistencia;

namespace Presentacion
{
    public partial class frmVendClientesReactivar : Form
    {
        public UsuarioWS usuario;
        
        public frmVendClientesReactivar()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            PresentacionUtils.VolverFormPrevio((IconButton)sender, PresentacionUtils.FormPrevio, PresentacionUtils.PanelContenedor);
        }

        private void frmVendClientesReactivar_Load(object sender, EventArgs e)
        {

        }

        private void btnReactivarCliente_Click(object sender, EventArgs e)
        {

        }
    }
}
