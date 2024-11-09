using Datos;
using FontAwesome.Sharp;
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
//using Presentacion.frmsSupervisor;
using Presentacion.frmsVendedor;

namespace Presentacion
{
    public partial class frmPerfliSupervisor : Form
    {
        private static IconButton botonSeleccionado;
        private static UsuarioWS usuarioActual;
        private frmVendNuevaVenta frmVendVentaInstance;
        //private frmSuperReportes frmSuperReportesInstance;

        public frmPerfliSupervisor(UsuarioWS objUsuario)
        {
            InitializeComponent();
            usuarioActual = objUsuario;

            this.lblSupUser.Text = usuarioActual.NombreUsuario;
        }

        private void lblVendRol_Click(object sender, EventArgs e)
        {

        }

        private void frmPerfliSupervisor_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            BienvSup.Visible = false;
            frmMenuProductos frmMenuProductos = new frmMenuProductos();
            frmMenuProductos.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //BienvSup.Visible = false;

            //if (frmSuperReportesInstance == null || frmSuperReportesInstance.IsDisposed)
            //{
            //    frmSuperReportesInstance = new frmSuperReportes();
            //    PresentacionUtils.AbrirForm((IconButton)sender, frmSuperReportesInstance, panelContenedor);
            //}
            //else
            //    PresentacionUtils.AbrirForm((IconButton)sender, frmSuperReportesInstance, panelContenedor);
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BienvSup_Click(object sender, EventArgs e)
        {
            
        }
    }
}
