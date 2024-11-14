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

namespace Presentacion
{
    public partial class frmVendClientesAlta : Form
    {
        public frmVendClientesAlta()
        {
            InitializeComponent();
            ConfigurarTabIndex();
        }

        private void frmVendClientesAlta_Load(object sender, EventArgs e)
        {

        }

        public void ConfigurarTabIndex()
        {
            //Agrega los controles al TabIndex segun el orden en el que se encuentran en el formulario
            txtBoxNombre.TabIndex = 0;
            txtBoxApellido.TabIndex = 1;
            txtBoxDireccion.TabIndex = 2;
            txtBoxTelefono.TabIndex = 3;
            txtBoxEmail.TabIndex = 4;
            txtBoxDni.TabIndex = 5;
            dtpFechaNac.TabIndex = 6;
            btnGuardarUsuario.TabIndex = 7;
            btnLimpiarCampos.TabIndex = 8;
            btnVolver.TabIndex = 9;

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            PresentacionUtils.VolverFormPrevio((IconButton)sender, PresentacionUtils.FormPrevio, PresentacionUtils.PanelContenedor);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            PresentacionUtils.LimpiarControles(this);
        }

        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {

        }
    }
}
