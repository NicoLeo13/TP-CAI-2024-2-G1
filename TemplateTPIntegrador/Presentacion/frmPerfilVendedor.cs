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
    public partial class frmPerfilVendedor : Form
    {
        private static IconButton botonSeleccionado;
        private static UsuarioWS usuarioActual;
        private frmVendNuevaVenta frmVendVentaInstance;

        public frmPerfilVendedor(UsuarioWS objUsuario)
        {
            InitializeComponent();
            usuarioActual = objUsuario;

            this.lblVendUser.Text = usuarioActual.NombreUsuario;
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

        private void btnVendVenta_Click(object sender, EventArgs e)
        {
            // Verificar si la instancia ya existe
            if (frmVendVentaInstance == null || frmVendVentaInstance.IsDisposed)
            {
                frmVendVentaInstance = new frmVendNuevaVenta();
                PresentacionUtils.AbrirForm((IconButton)sender, frmVendVentaInstance, panelContenedor);
            }
            else
                PresentacionUtils.AbrirForm((IconButton)sender, frmVendVentaInstance, panelContenedor);
        }

        private void btnVendProduct_Click(object sender, EventArgs e)
        {

        }

        private void btnVendReportes_Click(object sender, EventArgs e)
        {

        }

        private void btnVendLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea Cerrar Sesión?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                PresentacionUtils.isFormClosing = true;
                this.Close();

                PresentacionUtils.PanelContenedor = null;
                PresentacionUtils.FormPrevio = null;
                PresentacionUtils.isFormClosing = false;
            }
        }

        private void frmPerfilVendedor_Load(object sender, EventArgs e)
        {

        }
    }
}
