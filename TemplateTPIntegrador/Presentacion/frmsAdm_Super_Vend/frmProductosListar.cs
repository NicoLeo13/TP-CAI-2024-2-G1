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
    public partial class frmProductosListar : Form
    {
        private List<Producto> productos;
        /*DataGrid*/
        private DataGridService dataGridService;
        private BindingSource bindingSource;
        private bool sortAscending = true;
        private DataGridViewColumn sortedColumn = null;

        public frmProductosListar()
        {
            InitializeComponent();
            dataGridService = new DataGridService();
            productos = new List<Producto>();
            CargarProductos();
        }

        private void CargarProductos()
        {
            productos = ProductoService.BuscarProductosTotales();
            ConfigurarDataGridView();
            LlenarDataGridView();
            LlenarComboBoxCamposFiltro();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            PresentacionUtils.VolverFormPrevio((IconButton)sender, PresentacionUtils.FormPrevio, PresentacionUtils.PanelContenedor);
        }

        private void ConfigurarDataGridView()
        {
            lblProductosTotales.Text = $"Total: {productos.Count.ToString()}";

            // Habilitar ordenamiento
            foreach (DataGridViewColumn column in dgvProductos.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Programmatic;
            }
        }

        private void LlenarDataGridView()
        {
            // Usar BindingSource para permitir filtrado
            bindingSource = new BindingSource();
            bindingSource.DataSource = productos.Select(u => new
            {
                u.Nombre,
                u.IdCategoria,
                u.Precio,
                u.Stock,
                u.FechaAlta,
                u.FechaBaja,
            }).ToList();

            dgvProductos.DataSource = bindingSource;
        }

        private void LlenarComboBoxCamposFiltro()
        {
            Dictionary<string, string> datos = new Dictionary<string, string>
            {
                { "Nombre", "Nombre" },
                { "IdCategoria", "ID Categoria" },
                { "Precio", "Precio" },
                { "Stock", "Stock" },
                { "FechaAlta", "FechaAlta" },
                { "FechaBaja", "FechaBaja" }
            };

            cmbFiltros.DataSource = new BindingSource(datos, null);
            cmbFiltros.DisplayMember = "Value";
            cmbFiltros.ValueMember = "Key";
            cmbFiltros.SelectedIndex = 0;
        }
        private void cmbFiltros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtBoxFiltro.Text != "")
                txtBoxFiltro.Text = "";
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            if (txtBoxFiltro.Text != "")
                txtBoxFiltro.Text = "";

            lblProductosTotales.Text = "Total: Cargando...";
            bindingSource.DataSource = new List<UsuarioWS>();
            dgvProductos.DataSource = bindingSource;

            productos = ProductoService.BuscarProductosTotales();

            if (productos == null)
                MessageBox.Show("Ha ocurrido un error al refrescar productos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                lblProductosTotales.Text = $"Total: {productos.Count.ToString()}";
                LlenarDataGridView();
            }
        }

        private void dgvProductos_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn newColumn = dgvProductos.Columns[e.ColumnIndex];
            if (newColumn != sortedColumn)
                sortAscending = true;


            var columna = dgvProductos.Columns[e.ColumnIndex].DataPropertyName;
            productos = dataGridService.OrdenarProductos(productos, columna, sortAscending);

            sortAscending = !sortAscending;
            LlenarDataGridView();

            // Actualizar el indicador visual
            sortedColumn = dgvProductos.Columns[e.ColumnIndex];
            foreach (DataGridViewColumn column in dgvProductos.Columns)
            {
                if (column != sortedColumn)
                    column.HeaderCell.SortGlyphDirection = SortOrder.None;
            }
            sortedColumn.HeaderCell.SortGlyphDirection = sortAscending ? SortOrder.Ascending : SortOrder.Descending;
        }

        private void txtBoxFiltro_TextChanged(object sender, EventArgs e)
        {
            string campo = cmbFiltros.SelectedValue.ToString();
            string valor = txtBoxFiltro.Text.ToLower();
            var productosFiltrados = dataGridService.FiltrarProductos(productos, campo, valor);

            bindingSource.DataSource = productosFiltrados;
            dgvProductos.DataSource = bindingSource;
        }
    }
}
