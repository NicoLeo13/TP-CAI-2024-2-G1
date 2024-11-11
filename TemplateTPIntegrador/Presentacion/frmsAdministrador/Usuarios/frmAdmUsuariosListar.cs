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
    public partial class frmAdmUsuariosListar : Form
    {
        private List<UsuarioWS> usuariosActivos;
        private BindingSource bindingSource;
        private bool sortAscending = true;
        private DataGridViewColumn prevColumn = null;
        private DataGridViewColumn sortedColumn = null;

        public frmAdmUsuariosListar(Task<List<UsuarioWS>> usuariosActivosTask)
        {
            InitializeComponent();
            CargarUsuarios(usuariosActivosTask);
        }

        private async void CargarUsuarios(Task<List<UsuarioWS>> usuariosActivosTask)
        {
            usuariosActivos = await usuariosActivosTask;
            ConfigurarDataGridView();
            LlenarDataGridView();
        }

        private void ConfigurarDataGridView()
        {
            lblUsuariosTotales.Text = $"Total: {usuariosActivos.Count.ToString()}";

            // Habilitar ordenamiento
            foreach (DataGridViewColumn column in dgvUsuarios.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Programmatic;
            }
        }

        private void LlenarDataGridView()
        {
            // Usar BindingSource para permitir filtrado
            bindingSource = new BindingSource();
            bindingSource.DataSource = usuariosActivos.Select(u => new
            {
                u.Id,
                u.Nombre,
                u.Apellido,
                u.Dni,
                u.NombreUsuario,
                u.Host
            }).ToList();

            dgvUsuarios.DataSource = bindingSource;
        }

        private void dgvUsuarios_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn newColumn = dgvUsuarios.Columns[e.ColumnIndex];
            string columnName = dgvUsuarios.Columns[e.ColumnIndex].DataPropertyName;

            if(newColumn != sortedColumn)
                sortAscending = true;

            if (sortAscending)
                usuariosActivos = usuariosActivos.OrderBy(u => u.GetType().GetProperty(columnName).GetValue(u, null)).ToList();
            else
                usuariosActivos = usuariosActivos.OrderByDescending(u => u.GetType().GetProperty(columnName).GetValue(u, null)).ToList();

            sortAscending = !sortAscending;
            LlenarDataGridView();

            // Actualizar el indicador visual
            sortedColumn = dgvUsuarios.Columns[e.ColumnIndex];
            foreach (DataGridViewColumn column in dgvUsuarios.Columns)
            {
                if (column != sortedColumn)
                    column.HeaderCell.SortGlyphDirection = SortOrder.None;
            }
            sortedColumn.HeaderCell.SortGlyphDirection = sortAscending ? SortOrder.Ascending : SortOrder.Descending;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            PresentacionUtils.VolverFormPrevio((IconButton)sender, PresentacionUtils.FormPrevio, PresentacionUtils.PanelContenedor);
        }
    }
}
