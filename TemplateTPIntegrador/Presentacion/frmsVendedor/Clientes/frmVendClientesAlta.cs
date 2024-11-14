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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net;
using System.Web;

namespace Presentacion
{
    public partial class frmVendClientesAlta : Form
    {
        public frmVendClientesAlta()
        {
            InitializeComponent();
            ConfigurarTabIndex();
        }

        private void frmVendClientesAlta_Load(object sender, EventArgs e)
        {

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
            btnGuardarUsuario.TabIndex = 7;
            btnLimpiarCampos.TabIndex = 8;
            btnVolver.TabIndex = 9;

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            PresentacionUtils.VolverFormPrevio((IconButton)sender, PresentacionUtils.FormPrevio, PresentacionUtils.PanelContenedor);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            PresentacionUtils.LimpiarControles(this);
        }

        private async void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                //validar campos
                PresentacionValidaciones validaciones = new PresentacionValidaciones();
                if (!validaciones.ValidarControles(this, out string mensajeError))
                {
                    MessageBox.Show(mensajeError, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                Guid id = Guid.NewGuid();
                string nombre = txtBoxNombre.Text;
                string apellido = txtBoxApellido.Text;
                string direccion = txtBoxDireccion.Text;
                string telefono = txtBoxTelefono.Text;
                string email = txtBoxEmail.Text;
                int dni = int.Parse(txtBoxDni.Text);
                DateTime fechaNacimiento = dtpFechaNac.Value;
                DateTime? fechaAlta = null;
                DateTime? fechaBaja = null;
                string host = "10";

                ClienteService clienteService = new ClienteService();
                clienteService.CrearCliente(id,nombre, dni, apellido, direccion, telefono, email, fechaNacimiento, host, fechaAlta, fechaBaja);

                MessageBox.Show($"Cliente {nombre} {apellido} - {dni} agregado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
