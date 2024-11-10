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
    public partial class frmAdmSupervisoresAlta : Form
    {

        const int hostVendedor = 1;

        public frmAdmSupervisoresAlta()
        {
            InitializeComponent();
            ConfigurarTabIndex();
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
            txtBoxUsuario.TabIndex = 7;
            txtBoxContraseña.TabIndex = 8;
            btnGuardarSuperv.TabIndex = 9;
            btnLimpiarCampos.TabIndex = 10;
            btnVolver.TabIndex = 11;

        }

        private void frmAdmUsuariosAlta_Load(object sender, EventArgs e)
        {
            
        }

        private void btnGuardarVendedor_Click(object sender, EventArgs e)
        {

        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            PresentacionUtils.LimpiarControles(this);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            PresentacionUtils.VolverFormPrevio((IconButton)sender, PresentacionUtils.FormPrevio, PresentacionUtils.PanelContenedor);
        }

        private void btnGuardarSupervisor_Click(object sender, EventArgs e)
        {

        }
    }
}
