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
using Persistencia.Utils;
using Negocio;

namespace Presentacion
{
    public partial class frmMenuReportes : Form
    {
        private static UsuarioWS usuarioActual;
        private readonly UsuarioService _usuarioService;
        private static VentaService ventaService;
        private static ReporteService reporteService;

        private static Random random = new Random();
        public List<Producto> productos = new List<Producto>();
        private int stockCritico;
        private List<Producto> productosEnStockCritico;

        private List<Venta> ventas = new List<Venta>();

        public frmMenuReportes(UsuarioWS objUsuario)
        {
            InitializeComponent();
            usuarioActual = objUsuario;
            stockCritico = random.Next(1, 8);
            productos = ProductoFactory.GenerarProductosRandom(35);
            ventas = VentaFactory.GenerarVentasRandom(28);

            _usuarioService = new UsuarioService();
            ventaService = new VentaService();
            reporteService = new ReporteService();
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
            productosEnStockCritico = reporteService.ComprobarStockCritico(productos, stockCritico);
            if (productosEnStockCritico.Count > 0)
            {
                lblProdCriticos.Text = productosEnStockCritico.Count.ToString();
                pnlStockCritico.Visible = true;
            }
            else
                lblProdCriticos.Text = "0";

        }

        private void ActualizarUI(List<UsuarioWS> usuariosActivos)
        {
            //Llenar label Usuarios la cantidad de usuarios activos
            string vendedoresActivos = usuariosActivos.Where(u => u.Host == 1).Count().ToString();
            lblVendActivos.Text = vendedoresActivos;
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
            if (productosEnStockCritico.Count > 0)
                reporteService.GenerarReporteExcelStockCritico(productosEnStockCritico, stockCritico);
            else
                MessageBox.Show("No hay productos en stock crítico", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnReporteVtasVendedor_Click(object sender, EventArgs e)
        {
            reporteService.GenerarReporteExcelVentasPorVendedor(ventas);
        }

        private void btnReporteProdTopVentas_Click(object sender, EventArgs e)
        {
            reporteService.GenerarReporteExcelVentasPorVendedor(ventas);
        }
    }
}
