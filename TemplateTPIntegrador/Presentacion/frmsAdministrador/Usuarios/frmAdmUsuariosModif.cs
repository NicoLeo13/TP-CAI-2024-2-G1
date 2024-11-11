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
    public partial class frmAdmUsuariosModif : Form
    {
        public UsuarioWS usuario;
        
        public frmAdmUsuariosModif()
        {
            InitializeComponent();
        }


        private void frmAdmUsuariosModif_Load(object sender, EventArgs e)
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

                PresentacionUtils.HabilitarControles(this.grpDatosModif);
                txtBoxNombre.Text = usuario.Nombre;
                txtBoxApellido.Text = usuario.Apellido;
                txtBoxDni.Text = usuario.Dni.ToString();
                txtBoxUserId.Text = usuario.Id.ToString();
                txtBoxHost.Text = usuario.Host.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"\nError al buscar usuario: {ex.Message}");
            }
        }

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            string contraseñaActual = txtBoxContraActual.Text;
            string contraseñaNueva = txtBoxNuevaContra.Text;
            string confirmarContraseña = txtBoxConfrimNuevaContra.Text;

            PresentacionValidaciones validaciones = new PresentacionValidaciones();

            if (usuario == null)
            {
                MessageBox.Show("Busque un usuario antes de modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(!validaciones.ValidarControles(this.grpDatosModif, out string mensajeError))
            {
                MessageBox.Show(mensajeError, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (contraseñaNueva != confirmarContraseña)
            {
                MessageBox.Show("Las contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(contraseñaActual == contraseñaNueva)
            {
                MessageBox.Show("La nueva contraseña no puede ser igual a la actual", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                UsuarioService usuarioService = new UsuarioService();
                usuarioService.ModificarUsuario(usuario.NombreUsuario, contraseñaActual, contraseñaNueva);
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Error en el formato de los datos: {ex.Message} - {ex.Source}", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show($"Error interno:\n{ex.Message} - {ex.Source}", "Error programa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBoxNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
