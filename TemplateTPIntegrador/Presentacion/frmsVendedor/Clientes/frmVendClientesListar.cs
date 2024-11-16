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
    public partial class frmVendClientesListar : Form
    {
        private List<Cliente> clientes;
        /*DataGrid*/
        private DataGridService dataGridService;
        private BindingSource bindingSource;
        private bool sortAscending = true;
        private DataGridViewColumn sortedColumn = null;

        public frmVendClientesListar()
        {
            InitializeComponent();
            dataGridService = new DataGridService();
            clientes = new List<Cliente>();
            CargarProductos();
        }

        private void CargarProductos()
        {
            clientes = ClienteService.BuscarClientesTotales();
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
            lblProveedoresTotales.Text = $"Total: {clientes.Count.ToString()}";

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
            bindingSource.DataSource = clientes.Select(u => new
            {
                u.Nombre,
                u.Apellido,
                u.Dni,
                u.Email,
                u.Host,
                u.FechaAlta,
            }).ToList();

            dgvProveedores.DataSource = bindingSource;
        }

        private void LlenarComboBoxCamposFiltro()
        {
            Dictionary<string, string> datos = new Dictionary<string, string>
            {
                { "Nombre", "Nombre" },
                { "Apellido", "Apellido" },
                { "Dni", "DNI" },
                { "Email", "Email" },
                { "Host", "Host" },
                { "FechaAlta", "FechaAlta" }
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

            clientes = ClienteService.BuscarClientesTotales();

            if (clientes == null)
                MessageBox.Show("Ha ocurrido un error al refrescar clientes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                lblProveedoresTotales.Text = $"Total: {clientes.Count.ToString()}";
                LlenarDataGridView();
            }
        }

        private void dgvProveedores_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn newColumn = dgvProveedores.Columns[e.ColumnIndex];
            if (newColumn != sortedColumn)
                sortAscending = true;


            var columna = dgvProveedores.Columns[e.ColumnIndex].DataPropertyName;
            clientes = dataGridService.OrdenarClientes(clientes, columna, sortAscending);

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
            var clientesFiltrados = dataGridService.FiltrarClientes(clientes, campo, valor);

            bindingSource.DataSource = clientesFiltrados;
            dgvProveedores.DataSource = bindingSource;
        }

    }
}
