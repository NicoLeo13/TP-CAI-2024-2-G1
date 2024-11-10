using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using FontAwesome.Sharp;
using Presentacion.Utils;
using Persistencia;
using Negocio;

namespace Presentacion
{
    public partial class frmMenuReportes : Form
    {
        private static UsuarioWS usuarioActual;
        private readonly UsuarioService _usuarioService;

        public frmMenuReportes(UsuarioWS objUsuario)
        {
            InitializeComponent();
            usuarioActual = objUsuario;

            _usuarioService = new UsuarioService();
        }


        private async void frmReportes_Load(object sender, EventArgs e)
        {
            //Cargar la cantidad de usuarios activos
            var (usuariosActivos, msg) = await _usuarioService.CargarUsuariosActivosAsync();
            if (msg == null)
                ActualizarUI(usuariosActivos);
            else
                MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            //Cargar la cantidad de productos Activos

            //Cargar la cantidad de productos en stock critico
        }

        private void ActualizarUI(List<UsuarioWS> usuariosActivos)
        {
            //Llenar label Usuarios la cantidad de usuarios activos
            string vendedoresActivos = usuariosActivos.Where(u => u.Host == 1).Count().ToString();
            lblVendActivos.Text = vendedoresActivos;
        }
        
        private void btnAltaSuperv_Click(object sender, EventArgs e)
        {
            PresentacionUtils.AbrirForm((IconButton)sender, new frmAdmSupervisoresAlta(), PresentacionUtils.PanelContenedor);
        }

        private void btnModSuperv_Click(object sender, EventArgs e)
        {
            PresentacionUtils.AbrirForm((IconButton)sender, new frmAdmSupervisoresModif(), PresentacionUtils.PanelContenedor);
        }
        
        private void btnBajaSuperv_Click(object sender, EventArgs e)
        {
            PresentacionUtils.AbrirForm((IconButton)sender, new frmAdmSupervisoresBaja(), PresentacionUtils.PanelContenedor);
        }

        private void btnAltaProducto_Click(object sender, EventArgs e)
        {
            PresentacionUtils.AbrirForm((IconButton)sender, new frmProductosAlta(usuarioActual), PresentacionUtils.PanelContenedor);
        }

        private void btnModProducto_Click(object sender, EventArgs e)
        {
            PresentacionUtils.AbrirForm((IconButton)sender, new frmProductosModif(), PresentacionUtils.PanelContenedor);
        }

        private void btnBajaProd_Click(object sender, EventArgs e)
        {
            PresentacionUtils.AbrirForm((IconButton)sender, new frmProductosBaja(), PresentacionUtils.PanelContenedor);
        }

        private void btnReporteStockCritico_Click(object sender, EventArgs e)
        {

        }

        private void btnReporteVtasVendedor_Click(object sender, EventArgs e)
        {

        }

        private void btnReporteProdTopVentas_Click(object sender, EventArgs e)
        {

        }
    }
}
