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
    public partial class frmAdmProveedoresListar : Form
    {
        private List<Proveedor> proveedores;
        /*DataGrid*/
        private DataGridService dataGridService;
        private BindingSource bindingSource;
        private bool sortAscending = true;
        private DataGridViewColumn sortedColumn = null;

        public frmAdmProveedoresListar()
        {
            InitializeComponent();
            dataGridService = new DataGridService();
            proveedores = new List<Proveedor>();
            CargarProductos();
        }

        private void CargarProductos()
        {
            proveedores = ProveedorService.BuscarProveedoresTotales();
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
            lblProveedoresTotales.Text = $"Total: {proveedores.Count.ToString()}";

            // Habilitar ordenamiento
            foreach (DataGridViewColumn column in dgvProveedores.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Programmatic;
            }
        }

        private void LlenarDataGridView()
        {
            // Usar BindingSource para permitir filtrado
            bindingSource = new BindingSource();
            bindingSource.DataSource = proveedores.Select(u => new
            {
                u.Nombre,
                u.Apellido,
                u.Email,
                u.CUIT,
                u.FechaAlta,
                u.FechaBaja,
            }).ToList();

            dgvProveedores.DataSource = bindingSource;
        }

        private void LlenarComboBoxCamposFiltro()
        {
            Dictionary<string, string> datos = new Dictionary<string, string>
            {
                { "Nombre", "Nombre" },
                { "Apellido", "Apellido" },
                { "Email", "Email" },
                { "CUIT", "CUIT" },
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

            lblProveedoresTotales.Text = "Total: Cargando...";
            bindingSource.DataSource = new List<UsuarioWS>();
            dgvProveedores.DataSource = bindingSource;

            proveedores = ProveedorService.BuscarProveedoresTotales();

            if (proveedores == null)
                MessageBox.Show("Ha ocurrido un error al refrescar proveedores", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                lblProveedoresTotales.Text = $"Total: {proveedores.Count.ToString()}";
                LlenarDataGridView();
            }
        }

        private void dgvProveedores_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn newColumn = dgvProveedores.Columns[e.ColumnIndex];
            if (newColumn != sortedColumn)
                sortAscending = true;


            var columna = dgvProveedores.Columns[e.ColumnIndex].DataPropertyName;
            proveedores = dataGridService.OrdenarProveedores(proveedores, columna, sortAscending);

            sortAscending = !sortAscending;
            LlenarDataGridView();

            // Actualizar el indicador visual
            sortedColumn = dgvProveedores.Columns[e.ColumnIndex];
            foreach (DataGridViewColumn column in dgvProveedores.Columns)
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
            var proveedoresFiltrados = dataGridService.FiltrarProveedores(proveedores, campo, valor);

            bindingSource.DataSource = proveedoresFiltrados;
            dgvProveedores.DataSource = bindingSource;
        }

    }
}
