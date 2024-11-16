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
    public partial class frmAdmUsuariosReactivar : Form
    {
        public UsuarioWS usuario;
        
        public frmAdmUsuariosReactivar()
        {
            InitializeComponent();
        }

        private void frmAdmUsuariosReactivar_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            PresentacionUtils.VolverFormPrevio((IconButton)sender, PresentacionUtils.FormPrevio, PresentacionUtils.PanelContenedor);
        }

        private void btnReactivarUsuario_Click(object sender, EventArgs e)
        {
            if(txtBoxIDUsuarioAReactivar.Text == "")
            {
                MessageBox.Show("Debe ingresar un ID de usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                UsuarioService usuarioService = new UsuarioService();

                Guid idUsuarioAReactivar = Guid.Parse(txtBoxIDUsuarioAReactivar.Text);

                //usuario = UsuarioService.BuscarUsuario(username);

                usuarioService.ReactivarUsuario(idUsuarioAReactivar);

                MessageBox.Show($"Usuario reactivado con éxito:\nID: {txtBoxIDUsuarioAReactivar.Text}", "Usuario reactivado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Error en el formato de los datos: {ex.Message} - {ex.Source}", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
