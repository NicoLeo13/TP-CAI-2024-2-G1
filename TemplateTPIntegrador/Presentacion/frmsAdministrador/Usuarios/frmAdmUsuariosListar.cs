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
            // Configurar columnas manualmente
            //dgvUsuarios.AutoGenerateColumns = false;
            //dgvUsuarios.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "ID", DataPropertyName = "ID" });
            //dgvUsuarios.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Nombre", DataPropertyName = "Nombre" });
            //dgvUsuarios.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Apellido", DataPropertyName = "Apellido" });
            //dgvUsuarios.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "DNI", DataPropertyName = "DNI" });
            //dgvUsuarios.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Nombre de Usuario", DataPropertyName = "NombreUsuario" });
            //dgvUsuarios.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Host", DataPropertyName = "Host" });

            // Habilitar ordenamiento
            foreach (DataGridViewColumn column in dgvUsuarios.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Automatic;
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

        //private void btnFiltrar_Click(object sender, EventArgs e)
        //{
        //    // Aplicar filtro
        //    string filtro = txtFiltro.Text;
        //    bindingSource.Filter = $"Nombre LIKE '%{filtro}%' OR Apellido LIKE '%{filtro}%'";
        //}



        private void btnVolver_Click(object sender, EventArgs e)
        {
            PresentacionUtils.VolverFormPrevio((IconButton)sender, PresentacionUtils.FormPrevio, PresentacionUtils.PanelContenedor);
        }
    }
}
