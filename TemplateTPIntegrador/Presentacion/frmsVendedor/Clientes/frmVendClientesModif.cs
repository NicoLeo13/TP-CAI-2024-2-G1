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
    public partial class frmVendClientesModif : Form
    {
        private Cliente cliente;

        public frmVendClientesModif()
        {
            InitializeComponent();
        }



        private void btnVolver_Click(object sender, EventArgs e)
        {
            PresentacionUtils.VolverFormPrevio((IconButton)sender, PresentacionUtils.FormPrevio, PresentacionUtils.PanelContenedor);
        }

        public void LimpiarCampos()
        {
            txtBoxBuscarClientePorDNI.Text = "";

            txtBoxDireccion.Text = "";
            txtBoxTelefono.Text = "";
            txtBoxEmail.Text = "";
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            if (txtBoxBuscarClientePorDNI.Text == "")
            {
                MessageBox.Show("Por favor ingrese un DNI de cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                int dni = int.Parse(txtBoxBuscarClientePorDNI.Text);

                cliente = ClienteService.BuscarCliente(dni);

                if (cliente == null)
                {
                    MessageBox.Show("El cliente de DNI: " + txtBoxBuscarClientePorDNI.Text + " no fue encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                PresentacionUtils.HabilitarControles(this.grpDatosCliente);

                txtBoxDireccion.Text = cliente.Direccion;
                txtBoxTelefono.Text = cliente.Telefono;
                txtBoxEmail.Text = cliente.Email;


                //cliente.Direccion = txtBoxDireccion.Text;
                //cliente.Telefono = txtBoxTelefono.Text;
                //cliente.Email = txtBoxEmail.Text;

                //ClienteService clienteService = new ClienteService();

                //clienteService.ModificarCliente(cliente.Id, cliente.Direccion, cliente.Telefono, cliente.Email);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar al cliente de DNI: " + txtBoxBuscarClientePorDNI.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"\nError al buscar al cliente de DNI: {txtBoxBuscarClientePorDNI.Text} - {ex.Message}");
            }
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                // Recibo los nuevos valores que editó el usuario.

                string direccion = txtBoxDireccion.Text;
                string telefono = txtBoxTelefono.Text;
                string email = txtBoxEmail.Text;

                // Verificación de que, si NO MODIFIQUÉ ningún campo, no se haga la llamada al WS.

                ClienteService clienteService = new ClienteService();

                clienteService.ModificarCliente(cliente.Id, direccion, telefono, email);

                LimpiarCampos();

                MessageBox.Show($"El cliente fue editado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cliente = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"\nError al modificar el cliente: {ex.Message}");
            }
        }
    }
}
