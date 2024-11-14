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
    public partial class frmVendClientesModif : Form
    {
        private Proveedor proveedor;

        public frmVendClientesModif()
        {
            InitializeComponent();
        }



        private void btnVolver_Click(object sender, EventArgs e)
        {
            PresentacionUtils.VolverFormPrevio((IconButton)sender, PresentacionUtils.FormPrevio, PresentacionUtils.PanelContenedor);
        }

        public void LimpiarCampos()
        {
            txtBoxIdCliente.Text = "";

            txtBoxDireccion.Text = "";
            txtBoxTelefono.Text = "";
            txtBoxEmail.Text = "";
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {

        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {

        }
    }
}
