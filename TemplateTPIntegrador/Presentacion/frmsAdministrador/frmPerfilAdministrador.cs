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

namespace Presentacion
{
    public partial class frmPerfilAdministrador : Form
    {
        private static IconButton botonSeleccionado;
        private static UsuarioWS usuarioActual;
        private frmAdmInicio frmAdmInicioInstance;
        private frmAdmUsuarios frmAdmUsuariosInstance;
        private frmAdmProveedores frmAdmProveedInstance;
        private frmMenuProductos frmAdmProductosInstance;
        private frmMenuReportes frmAdmReportesInstance;

        public frmPerfilAdministrador(UsuarioWS objUsuario)
        {
            InitializeComponent();
            usuarioActual = objUsuario;

            this.lblAdmUser.Text = usuarioActual.NombreUsuario;

            frmAdmInicioInstance = new frmAdmInicio();
            PresentacionUtils.AbrirForm(btnAdmInicio, frmAdmInicioInstance, panelContenedor);
            btn_MouseDown(btnAdmInicio, null);
        }

        // Método para manejar el evento Hover de los botones
        private void btn_MouseHover(object sender, EventArgs e)
        {
            IconButton boton = (IconButton)sender;

            // Si el botón actual no está seleccionado, aplicar el efecto hover
            if (boton != botonSeleccionado)
                boton.FlatAppearance.MouseOverBackColor = Color.LightGray;
            else
                boton.FlatAppearance.MouseOverBackColor = Color.Teal;
        }

        // Método para manejar el evento Click de los botones
        private void btn_MouseDown(object sender, MouseEventArgs e)
        {
            if (botonSeleccionado != null) // Color original
            {
                botonSeleccionado.BackColor = Color.WhiteSmoke;
                botonSeleccionado.IconColor = Color.Black;
                botonSeleccionado.ForeColor = Color.Black;
            }

            // Color del botón activo
            botonSeleccionado = (IconButton)sender;
            botonSeleccionado.BackColor = Color.Teal;
            botonSeleccionado.FlatAppearance.MouseOverBackColor = Color.Teal;
            botonSeleccionado.IconColor = Color.WhiteSmoke;
            botonSeleccionado.ForeColor = Color.WhiteSmoke;
        }

        private void btnAdmLogout_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Está seguro que desea cerrar sesión?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                PresentacionUtils.isFormClosing = true;
                this.Close();

                PresentacionUtils.isFormClosing = false;
            }
        }

        private void btnAdmInicio_Click(object sender, EventArgs e)
        {
            // Verificar si la instancia ya existe
            if (frmAdmInicioInstance == null || frmAdmInicioInstance.IsDisposed)
            {
                frmAdmInicioInstance = new frmAdmInicio();
                PresentacionUtils.AbrirForm((IconButton)sender, frmAdmInicioInstance, panelContenedor);
            }
            else
                PresentacionUtils.AbrirForm((IconButton)sender, frmAdmInicioInstance, panelContenedor);
        }

        private void btnAdmUsuarios_Click(object sender, EventArgs e)
        {
            // Verificar si la instancia ya existe
            if (frmAdmUsuariosInstance == null || frmAdmUsuariosInstance.IsDisposed)
            {
                frmAdmUsuariosInstance = new frmAdmUsuarios();
                PresentacionUtils.AbrirForm((IconButton)sender, frmAdmUsuariosInstance, panelContenedor);
            }
            else
                PresentacionUtils.AbrirForm((IconButton)sender, frmAdmUsuariosInstance, panelContenedor);
            //frmAdmUsuariosInstance.BringToFront();
        }
        
        private void btnAdmProveed_Click(object sender, EventArgs e)
        {
            // Verificar si la instancia ya existe
            if (frmAdmProveedInstance == null || frmAdmProveedInstance.IsDisposed)
            {
                frmAdmProveedInstance = new frmAdmProveedores();
                PresentacionUtils.AbrirForm((IconButton)sender, frmAdmProveedInstance, panelContenedor);
            }
            else
                PresentacionUtils.AbrirForm((IconButton)sender, frmAdmProveedInstance, panelContenedor);
        }

        private void btnAdmProduct_Click(object sender, EventArgs e)
        {
            // Verificar si la instancia ya existe
            if (frmAdmProductosInstance == null || frmAdmProductosInstance.IsDisposed)
            {
                frmAdmProductosInstance = new frmMenuProductos(usuarioActual);
                PresentacionUtils.AbrirForm((IconButton)sender, frmAdmProductosInstance, panelContenedor);
            }
            else
                PresentacionUtils.AbrirForm((IconButton)sender, frmAdmProductosInstance, panelContenedor);
        }

        private void btnAdmReportes_Click(object sender, EventArgs e)
        {
            // Verificar si la instancia ya existe
            if (frmAdmReportesInstance == null || frmAdmReportesInstance.IsDisposed)
            {
                frmAdmReportesInstance = new frmMenuReportes(usuarioActual);
                PresentacionUtils.AbrirForm((IconButton)sender, frmAdmReportesInstance, panelContenedor);
            }
            else
                PresentacionUtils.AbrirForm((IconButton)sender, frmAdmReportesInstance, panelContenedor);
        }

    }
}
