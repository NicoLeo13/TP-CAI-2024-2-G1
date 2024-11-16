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
    public partial class frmAdmUsuariosBaja : Form
    {
        public UsuarioWS usuario;
        
        public frmAdmUsuariosBaja()
        {
            InitializeComponent();
        }


        private void frmAdmUsuariosBaja_Load(object sender, EventArgs e)
        {
        }


        private void btnVolver_Click(object sender, EventArgs e)
        {
            PresentacionUtils.VolverFormPrevio((IconButton)sender, PresentacionUtils.FormPrevio, PresentacionUtils.PanelContenedor);
        }
        
        private void btnBuscarUsuario_click(object sender, EventArgs e)
        {
            if (txtBoxUsuario.Text == "")
            {
                MessageBox.Show("Ingrese un usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                usuario = UsuarioService.BuscarUsuario(txtBoxUsuario.Text);
                if (usuario == null)
                {
                    MessageBox.Show("Usuario no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                lblContNombre.Text = usuario.Nombre;
                lblContApellido.Text = usuario.Apellido;
                lblContDni.Text = usuario.Dni.ToString();
                lblContHost.Text = PresentacionUtils.HostToString(usuario.Host);
                lblContIdUser.Text = usuario.Id.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"\nError al buscar usuario: {ex.Message}");
            }
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (usuario == null)
            {
                MessageBox.Show("No se ha seleccionado un usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Condicional con Mensaje de confirmación para eliminar usuario
                DialogResult dialogResult = MessageBox.Show($"¿Está seguro que desea eliminar al usuario: {usuario.NombreUsuario}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
                if (dialogResult == DialogResult.No)
                    return;

                UsuarioService usuarioService = new UsuarioService();
                usuarioService.EliminarUsuario(usuario);
                LimpiarCamposBaja();
                MessageBox.Show($"Usuario: {usuario.NombreUsuario} eliminado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                usuario = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"\nError al eliminar usuario: {ex.Message}");
            }
        }

        public void LimpiarCamposBaja()
        {
            txtBoxUsuario.Text = "";
            lblContNombre.Text = "";
            lblContApellido.Text = "";
            lblContDni.Text = "";
            lblContHost.Text = "";
            lblContIdUser.Text = "";
        }
    }
}
