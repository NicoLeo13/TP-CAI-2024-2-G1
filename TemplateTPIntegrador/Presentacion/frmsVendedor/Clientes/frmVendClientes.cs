using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentacion.Utils;
using FontAwesome.Sharp;

namespace Presentacion.frmsVendedor
{
    public partial class frmVendClientes : Form
    {
        public frmVendClientes()
        {
            InitializeComponent();
        }

        private void btnListarClientes_Click(object sender, EventArgs e)
        {
            PresentacionUtils.AbrirForm((IconButton)sender, new frmVendClientesListar(), PresentacionUtils.PanelContenedor);
        }

        private void btnReactivarCliente_Click(object sender, EventArgs e)
        {
            PresentacionUtils.AbrirForm((IconButton)sender, new frmVendClientesReactivar(), PresentacionUtils.PanelContenedor);
        }

        private void btnAltaCliente_Click(object sender, EventArgs e)
        {
            PresentacionUtils.AbrirForm((IconButton)sender, new frmVendClientesAlta(), PresentacionUtils.PanelContenedor);
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            PresentacionUtils.AbrirForm((IconButton)sender, new frmVendClientesModif(), PresentacionUtils.PanelContenedor);
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            PresentacionUtils.AbrirForm((IconButton)sender, new frmVendClientesBaja(), PresentacionUtils.PanelContenedor);
        }
    }
}
