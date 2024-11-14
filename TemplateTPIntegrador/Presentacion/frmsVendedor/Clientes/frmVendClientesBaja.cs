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
            PresentacionUtils.VolverFormPrevio((IconButton)sender, PresentacionUtils.FormPrevio, PresentacionUtils.PanelContenedor);
        }
        
        private void btnBuscarUsuario_click(object sender, EventArgs e)
        {

        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {

        }

        public void LimpiarCamposBaja()
        {
            txtBoxCliente.Text = "";
            lblContNombre.Text = "";
            lblContApellido.Text = "";
            lblContDni.Text = "";
            lblContIdCliente.Text = "";
            lblContFechaAlta.Text = "";
            lblContEstado.Text = "";
        }

        private async void btnBuscarCliente_click(object sender, EventArgs e)
        {
            //int dni = int.Parse(txtDni.Text); 
            //ClienteService clienteService = new ClienteService();
            //cliente = await clienteService.BuscarCliente(dni);

            //if (cliente != null)
            //{
            //    lblContNombre.Text = cliente.Nombre;
            //    lblContApellido.Text = cliente.Apellido;
            //    lblContDni.Text = cliente.Dni.ToString();
            //    lblContIdCliente.Text = cliente.IdCliente.ToString();
            //    lblContFechaAlta.Text = cliente.FechaAlta.ToString();
            //    lblContEstado.Text = cliente.Estado.ToString();
            //}
            //else
            //{
            //    MessageBox.Show("Cliente no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

        }

        private async void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            //if (cliente == null)
            //{
            //    MessageBox.Show("No se ha seleccionado un cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            try
            {
                //DialogResult dialogResult = MessageBox.Show($"¿Está seguro que desea eliminar al cliente: {cliente.IdCliente}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //if (dialogResult == DialogResult.No)
                //    return;

                //ClienteService clienteService = new ClienteService();
                //await clienteService.EliminarCliente(cliente.IdCliente);
                //LimpiarCamposBaja();
                //MessageBox.Show($"Cliente: {cliente.IdCliente} eliminado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //cliente = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"\nError al eliminar cliente: {ex.Message}");
            }
        }
            
    }
}
