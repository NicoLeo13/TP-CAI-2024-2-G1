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
    public partial class frmVendClientesReactivar : Form
    {
        public Cliente cliente;
        
        public frmVendClientesReactivar()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            PresentacionUtils.VolverFormPrevio((IconButton)sender, PresentacionUtils.FormPrevio, PresentacionUtils.PanelContenedor);
        }

        private void frmVendClientesReactivar_Load(object sender, EventArgs e)
        {

        }

        private void btnReactivarCliente_Click(object sender, EventArgs e)
        {
            if (txtBoxIdClienteAReactivar.Text == "")
            {
                MessageBox.Show("Debe ingresar un ID de cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Guid idVenta = Guid.Parse(txtBoxIdClienteAReactivar.Text);

                ClienteService clienteService = new ClienteService();

                clienteService.ReactivarCliente(idVenta);

                MessageBox.Show($"Cliente reactivado con éxito:\n ID: {txtBoxIdClienteAReactivar.Text}", "Cliente reactivado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
