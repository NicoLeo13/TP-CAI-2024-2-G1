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
        private DataGridService dataGridService;
        private BindingSource bindingSource;
        private bool sortAscending = true;
        private DataGridViewColumn sortedColumn = null;

        public frmProductosListar()
        {
            InitializeComponent();
            dataGridService = new DataGridService();
        }

        private async void CargarProductos()
        {
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

        }

        private void LlenarDataGridView()
        {
        }

        private void LlenarComboBoxCamposFiltro()
        {
            //Dictionary<string, string> datos = new Dictionary<string, string>
            //{
            //    { "NombreUsuario", "Usuario" },
            //    { "Id", "ID" },
            //    { "Nombre", "Nombre" },
            //    { "Apellido", "Apellido" },
            //    { "Dni", "DNI" },
            //    { "Host", "Host" }
            //};

            //cmbFiltros.DataSource = new BindingSource(datos, null);
            //cmbFiltros.DisplayMember = "Value";
            //cmbFiltros.ValueMember = "Key";
            //cmbFiltros.SelectedIndex = 0;
        }
        private void cmbFiltros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtBoxFiltro.Text != "")
                txtBoxFiltro.Text = "";
        }

        private async void btnRefrescar_Click(object sender, EventArgs e)
        {
            //if (txtBoxFiltro.Text != "")
            //    txtBoxFiltro.Text = "";

            //lblClientesTotales.Text = "Total: Cargando...";
            //bindingSource.DataSource = new List<UsuarioWS>();
            //dgvUsuarios.DataSource = bindingSource;

            //var msg = "";
            //(usuariosActivos, msg) = await _usuarioService.CargarUsuariosActivosAsync();

            //if (msg != null)
            //    MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //else
            //{
            //    lblClientesTotales.Text = $"Total: {usuariosActivos.Count.ToString()}";
            //    LlenarDataGridView();
            //}
        }

        private void dgvUsuarios_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //DataGridViewColumn newColumn = dgvUsuarios.Columns[e.ColumnIndex];
            //if (newColumn != sortedColumn)
            //    sortAscending = true;

            
            //var columna = dgvUsuarios.Columns[e.ColumnIndex].DataPropertyName;
            //usuariosActivos = dataGridService.OrdenarUsuarios(usuariosActivos, columna, sortAscending);
            
            //sortAscending = !sortAscending;
            //bindingSource.DataSource = usuariosActivos;
            //dgvUsuarios.DataSource = bindingSource;

            //// Actualizar el indicador visual
            //sortedColumn = dgvUsuarios.Columns[e.ColumnIndex];
            //foreach (DataGridViewColumn column in dgvUsuarios.Columns)
            //{
            //    if (column != sortedColumn)
            //        column.HeaderCell.SortGlyphDirection = SortOrder.None;
            //}
            //sortedColumn.HeaderCell.SortGlyphDirection = sortAscending ? SortOrder.Ascending : SortOrder.Descending;
        }

        private void txtBoxFiltro_TextChanged(object sender, EventArgs e)
        {
            //string campo = cmbFiltros.SelectedValue.ToString();
            //string valor = txtBoxFiltro.Text.ToLower();
            //var usuariosFiltrados = dataGridService.FiltrarUsuarios(usuariosActivos, campo, valor);

            //bindingSource.DataSource = usuariosFiltrados;
            //dgvUsuarios.DataSource = bindingSource;
        }

    }
}
