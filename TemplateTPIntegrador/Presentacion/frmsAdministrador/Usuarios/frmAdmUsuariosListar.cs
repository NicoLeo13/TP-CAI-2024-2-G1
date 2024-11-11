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

        public frmAdmUsuariosListar(Task<List<UsuarioWS>> usuariosActivosTask)
        {
            InitializeComponent();
            CargarUsuarios(usuariosActivosTask);
        }

        private async void CargarUsuarios(Task<List<UsuarioWS>> usuariosActivosTask)
        {
            usuariosActivos = await usuariosActivosTask;
            LlenarDataGridView();
        }

        private void LlenarDataGridView()
        {
            dgvUsuarios.DataSource = usuariosActivos.Select(u => new
            {
                u.Id,
                u.Nombre,
                u.Apellido,
                u.Dni,
                u.NombreUsuario,
                u.Host
            }).ToList();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            PresentacionUtils.VolverFormPrevio((IconButton)sender, PresentacionUtils.FormPrevio, PresentacionUtils.PanelContenedor);
        }
    }
}
