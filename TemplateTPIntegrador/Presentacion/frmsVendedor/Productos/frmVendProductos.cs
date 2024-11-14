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
    public partial class frmVendProductos : Form
    {
        public frmVendProductos()
        {
            InitializeComponent();
        }

        private void btnListarProductos_Click(object sender, EventArgs e)
        {
            PresentacionUtils.AbrirForm(btnListarProductos, new frmVendProductosListar(), PresentacionUtils.PanelContenedor);
        }
    }
}
