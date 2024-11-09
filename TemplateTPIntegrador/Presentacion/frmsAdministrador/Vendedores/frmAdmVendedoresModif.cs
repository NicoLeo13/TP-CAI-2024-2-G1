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
    public partial class frmAdmVendedoresModif : Form
    {
        public UsuarioWS usuario;
        
        public frmAdmVendedoresModif()
        {
            InitializeComponent();
        }


        private void frmAdmUsuariosModif_Load(object sender, EventArgs e)
        {
        }


        private void btnVolver_Click(object sender, EventArgs e)
        {
            PresentacionUtils.VolverFormPrevio((IconButton)sender, PresentacionUtils.FormPrevio, PresentacionUtils.PanelContenedor);
        }
        
        private void btnBuscarVendedor_click(object sender, EventArgs e)
        {

        }

        public void LimpiarCamposBaja()
        {
            //txtBoxUsuario.Text = "";
            //lblContNombre.Text = "";
            //lblContApellido.Text = "";
            //lblContDni.Text = "";
            //lblContHost.Text = "";
            //lblContIdUser.Text = "";
            //lblContEstado.Text = "";
        }

        private void txtBoxNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnModificarVendedor_Click(object sender, EventArgs e)
        {

        }

    }
}
