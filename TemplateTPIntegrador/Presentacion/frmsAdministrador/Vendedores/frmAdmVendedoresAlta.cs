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
    public partial class frmAdmVendedoresAlta : Form
    {

        const int hostVendedor = 1;

        public frmAdmVendedoresAlta()
        {
            InitializeComponent();
            ConfigurarTabIndex();
        }

        public void ConfigurarTabIndex()
        {
            //Agrega los controles al TabIndex segun el orden en el que se encuentran en el formulario
            txtBoxNombre.TabIndex = 0;
            txtBoxApellido.TabIndex = 1;
            txtBoxDireccion.TabIndex = 2;
            txtBoxTelefono.TabIndex = 3;
            txtBoxEmail.TabIndex = 4;
            txtBoxDni.TabIndex = 5;
            dtpFechaNac.TabIndex = 6;
            txtBoxUsuario.TabIndex = 7;
            txtBoxContraseña.TabIndex = 8;
            btnGuardarVendedor.TabIndex = 9;
            btnLimpiarCampos.TabIndex = 10;
            btnVolver.TabIndex = 11;

        }

        private void btnGuardarVendedor_Click(object sender, EventArgs e)
        {
            try
            {
                // Llamo al método de agregar usuario de la capa de negocio
                string nombreUsuario = txtBoxUsuario.Text;

                PresentacionValidaciones validaciones = new PresentacionValidaciones();
                if (!validaciones.ValidarControles(this, out string mensajeError))
                {
                    MessageBox.Show(mensajeError, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                UsuarioService usuarioService = new UsuarioService();
                usuarioService.AgregarUsuario(
                    Guid.NewGuid(),
                    txtBoxNombre.Text,
                    txtBoxApellido.Text,
                    txtBoxDireccion.Text,
                    txtBoxTelefono.Text,
                    txtBoxEmail.Text,
                    dtpFechaNac.Value,
                    txtBoxUsuario.Text,
                    hostVendedor,
                    Convert.ToInt32(txtBoxDni.Text),
                    txtBoxContraseña.Text
                );

                MessageBox.Show($"Vendedor {nombreUsuario} agregado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException ex)
            {
                // Capturar excepciones específicas como FormatException
                MessageBox.Show($"Error en el formato de los datos: {ex.Message} - {ex.Source}", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show($"Error interno:\n{ex.Message} - {ex.Source}", "Error programa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Capturar cualquier otra excepción
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            PresentacionUtils.LimpiarControles(this);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            PresentacionUtils.VolverFormPrevio((IconButton)sender, PresentacionUtils.FormPrevio, PresentacionUtils.PanelContenedor);
        }
    }
}
