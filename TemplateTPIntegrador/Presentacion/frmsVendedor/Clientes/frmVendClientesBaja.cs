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
using System.Net;

namespace Presentacion
{
    public partial class frmVendClientesBaja : Form
    {
        public UsuarioWS usuario;
        public Cliente cliente;

        public frmVendClientesBaja()
        {
            InitializeComponent();
        }

        private void frmVendClientesBaja_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            PresentacionUtils.VolverFormPrevio((IconButton)sender, PresentacionUtils.FormPrevio,
                PresentacionUtils.PanelContenedor);
        }

        private void btnBuscarUsuario_click(object sender, EventArgs e)
        {

        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {

        }

        public void LimpiarCamposBaja()
        {
            txtBoxBuscarClientePorDNI.Text = "";
            lblContNombre.Text = "";
            lblContApellido.Text = "";
            lblContDni.Text = "";
            lblContFechaAlta.Text = "";
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            if (txtBoxBuscarClientePorDNI.Text == "")
            {
                MessageBox.Show("Por favor ingrese un DNI de cliente.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            try
            {
                int dni = int.Parse(txtBoxBuscarClientePorDNI.Text);

                cliente = ClienteService.BuscarCliente(dni);

                if (cliente == null)
                {
                    MessageBox.Show("El cliente de DNI: " + txtBoxBuscarClientePorDNI.Text + " no fue encontrado.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                lblContNombre.Text = cliente.Nombre;
                lblContApellido.Text = cliente.Apellido;
                lblContDni.Text = cliente.Dni.ToString();
                lblContFechaAlta.Text = cliente.FechaAlta.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar al cliente de DNI: " + txtBoxBuscarClientePorDNI.Text, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(
                    $"\nError al buscar al cliente de DNI: {txtBoxBuscarClientePorDNI.Text} - {ex.Message}");
            }
        }

        private async void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            if (txtBoxBuscarClientePorDNI.Text == null)
            {
                MessageBox.Show("El DNI del cliente no es válido para eliminar.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Condicional con mensaje de confirmación para eliminar un cliente
                DialogResult dialogResult =
                    MessageBox.Show(
                        $"¿Está seguro que desea eliminar al cliente: {cliente.Nombre} {cliente.Apellido} - DNI: {cliente.Dni}?",
                        "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.No)
                    return;

                ClienteService clienteService = new ClienteService();

                clienteService.EliminarCliente(cliente.Id);

                LimpiarCamposBaja();

                MessageBox.Show(
                    $"Cliente: {cliente.Nombre} {cliente.Apellido} - DNI: {cliente.Dni} eliminado con éxito.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                cliente = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}
