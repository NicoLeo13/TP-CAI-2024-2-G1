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
    public partial class frmVendReportes : Form
    {
        private static UsuarioWS usuarioActual;
        private readonly UsuarioService _usuarioService;
        private static VentaService ventaService;
        private static ReporteService reporteService;

        public frmVendReportes(UsuarioWS objUsuario)
        {
            InitializeComponent();
            usuarioActual = objUsuario;

            _usuarioService = new UsuarioService();
            ventaService = new VentaService();
            reporteService = new ReporteService();
        }


        private async void frmReportes_Load(object sender, EventArgs e)
        {

        }

        private void ActualizarUI(List<UsuarioWS> usuariosActivos)
        {

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
            List<Venta> ventas = new List<Venta>();

            Venta ventaTest = new Venta(Guid.Parse("c952fa11-9ef6-45d8-8ea1-0182edd8d739"), 10, DateTime.Parse("2024-11-14T16:17:42.5167468"), 1); // Flag-hardcode
            ventas.Add(ventaTest);

            reporteService.GenerarReporteExcelVentas(ventas);
        }

        private void frmVendReporte_Load(object sender, EventArgs e)
        {

        }
    }
}
