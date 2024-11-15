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
using System.Security.Policy;

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
                PresentacionValidaciones validaciones = new PresentacionValidaciones();
                if (!validaciones.ValidarControles(this, out string mensajeError))
                {
                    MessageBox.Show(mensajeError, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Seteo un GUID random para que no perturbe a Cliente.cs en el futuro.

                Guid id = Guid.NewGuid();

                string nombre = txtBoxNombre.Text;
                string apellido = txtBoxApellido.Text;
                string direccion = txtBoxDireccion.Text;
                string telefono = txtBoxTelefono.Text;
                string email = txtBoxEmail.Text;
                int dni = int.Parse(txtBoxDni.Text);
                DateTime fechaNacimiento = dtpFechaNac.Value;

                // La fecha alta la va a setear el WS, y la de baja se dará cuando lo den de baja...

                DateTime? fechaAlta = null;
                DateTime? fechaBaja = null;

                // Asignamos cualquier host, simplemente porque lo pide. Pero no es admin, ni supervisor, ni vendedor...
                string host = "10";

                //Validaciones
                if (!string.IsNullOrWhiteSpace(nombre) && nombre.Length <= 30 &&!string.IsNullOrWhiteSpace(apellido) && apellido.Length <= 30)
                {
                    // Los campos son válidos: no están vacíos y tienen hasta 30 caracteres
                }
                else
                {
                    MessageBox.Show("El nombre y/o el apellido NO es válido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (!string.IsNullOrWhiteSpace(direccion) && direccion.Length <= 50)
                {
                    // La dirección es válida: no está vacía y tiene hasta 50 caracteres
                }
                else
                {
                    MessageBox.Show("La dirección no es válida.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (!string.IsNullOrWhiteSpace(telefono) && telefono.Length <= 20 && telefono.All(char.IsDigit))
                {
                    // El teléfono es válido: contiene solo dígitos y tiene hasta 20 caracteres
                }
                else
                {
                    MessageBox.Show("El teléfono debe contener solo números y tener hasta 20 dígitos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (!string.IsNullOrWhiteSpace(email) && email.Length <= 50 && email.Contains("@"))
                {
                    // El email es válido: es un string con hasta 50 caracteres y contiene el símbolo '@'
                }
                else
                {
                    MessageBox.Show("El email NO es válido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (int.TryParse(txtBoxDni.Text, out dni) && dni > 0 && txtBoxDni.Text.Length == 8)
                {
                    // El DNI es válido: número positivo y de 8 dígitos
                }
                else
                {
                    MessageBox.Show("El DNI debe ser un número positivo de 8 dígitos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                DateTime fechaActual = DateTime.Now;
                int edad = fechaActual.Year - fechaNacimiento.Year;
                if (fechaNacimiento.Date > fechaActual.AddYears(-edad).Date)
                {
                    edad--;
                }
                if (edad >= 18 && edad <= 130)
                {
                    // La edad es válida, está dentro del rango
                }
                else
                {
                    MessageBox.Show("Debe ser mayor de edad.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

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
