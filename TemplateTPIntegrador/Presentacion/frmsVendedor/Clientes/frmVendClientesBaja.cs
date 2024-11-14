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
    public partial class frmVendClientesBaja : Form
    {
        public UsuarioWS usuario;
        
        public frmVendClientesBaja()
        {
            InitializeComponent();
        }

        private void frmVendClientesBaja_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            PresentacionUtils.VolverFormPrevio((IconButton)sender, PresentacionUtils.FormPrevio, PresentacionUtils.PanelContenedor);
        }
        
        private void btnBuscarUsuario_click(object sender, EventArgs e)
        {

        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {

        }

        public void LimpiarCamposBaja()
        {
            txtBoxCliente.Text = "";
            lblContNombre.Text = "";
            lblContApellido.Text = "";
            lblContDni.Text = "";
            lblContIdCliente.Text = "";
            lblContFechaAlta.Text = "";
            lblContEstado.Text = "";
        }

        private void btnBuscarCliente_click(object sender, EventArgs e)
        {

        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {

        }
    }
}
