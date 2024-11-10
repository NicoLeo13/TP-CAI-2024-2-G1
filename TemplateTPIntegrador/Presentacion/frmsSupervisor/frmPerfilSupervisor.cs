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
    public partial class frmPerfilSupervisor : Form
    {
        private static IconButton botonSeleccionado;
        private static UsuarioWS usuarioActual;
        private frmSupervInicio frmSupervInicioInstance;
        private frmMenuProductos frmMenuProductosInstance;
        private frmMenuReportes frmMenuReportesInstance;
        private frmSupervDevoluciones frmSupervDevolucionesInstance;

        public frmPerfilSupervisor(UsuarioWS objUsuario)
        {
            InitializeComponent();
            usuarioActual = objUsuario;

            this.lblAdmUser.Text = usuarioActual.NombreUsuario;

            frmSupervInicioInstance = new frmSupervInicio();
            PresentacionUtils.AbrirForm(btnSupervInicio, frmSupervInicioInstance, panelContenedor);
            btn_MouseDown(btnSupervInicio, null);
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

        private void btnSupLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea Cerrar Sesión?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                PresentacionUtils.isFormClosing = true;
                this.Close();

                PresentacionUtils.isFormClosing = false;
            }
        }

        private void btnSupervInicio_Click(object sender, EventArgs e)
        {
            //Verificar si la instancia ya existe
            if (frmSupervInicioInstance == null || frmSupervInicioInstance.IsDisposed)
            {
                frmSupervInicioInstance = new frmSupervInicio();
                PresentacionUtils.AbrirForm((IconButton)sender, frmSupervInicioInstance, panelContenedor);
            }
            else
            {
                PresentacionUtils.AbrirForm((IconButton)sender, frmSupervInicioInstance, panelContenedor);
            }
        }

        private void btnSupProduct_Click(object sender, EventArgs e)
        {
            //Verificar si la instancia ya existe
            if (frmMenuProductosInstance == null || frmMenuProductosInstance.IsDisposed)
            {
                frmMenuProductosInstance = new frmMenuProductos(usuarioActual);
                PresentacionUtils.AbrirForm((IconButton)sender, frmMenuProductosInstance, panelContenedor);
            }
            else
            {
                PresentacionUtils.AbrirForm((IconButton)sender, frmMenuProductosInstance, panelContenedor);
            }
        }

        private void btnSupDevoluciones_Click(object sender, EventArgs e)
        {
            //Verificar si la instancia ya existe
            if (frmSupervDevolucionesInstance == null || frmSupervDevolucionesInstance.IsDisposed)
            {
                frmSupervDevolucionesInstance = new frmSupervDevoluciones();
                PresentacionUtils.AbrirForm((IconButton)sender, frmSupervDevolucionesInstance, panelContenedor);
            }
            else
            {
                PresentacionUtils.AbrirForm((IconButton)sender, frmSupervDevolucionesInstance, panelContenedor);
            }
        }

        private void btnSupReportes_Click(object sender, EventArgs e)
        {
            //Verificar si la instancia ya existe
            if (frmMenuReportesInstance == null || frmMenuReportesInstance.IsDisposed)
            {
                frmMenuReportesInstance = new frmMenuReportes(usuarioActual);
                PresentacionUtils.AbrirForm((IconButton)sender, frmMenuReportesInstance, panelContenedor);
            }
            else
            {
                PresentacionUtils.AbrirForm((IconButton)sender, frmMenuReportesInstance, panelContenedor);
            }
        }
    }
}
