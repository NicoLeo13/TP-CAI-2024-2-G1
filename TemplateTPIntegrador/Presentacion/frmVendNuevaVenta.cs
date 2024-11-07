using FontAwesome.Sharp;
using Negocio;
using Datos;
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

namespace Presentacion
{
    public partial class frmVendNuevaVenta : Form
    {
        public frmVendNuevaVenta()
        {
            InitializeComponent();
        }
        
        private void btnVolver_Click(object sender, EventArgs e)
        {

            PresentacionUtils.VolverFormPrevio((IconButton)sender, PresentacionUtils.FormPrevio, PresentacionUtils.PanelContenedor);
        }
        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            try
            {
                PresentacionUtils.LimpiarControles(this); 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        //Genera datos de prueba para la venta
        private void btnGenerarDatos_Click(object sender, EventArgs e)
        {
            txtClienteID.Text = "1";
            txtProductoID.Text = "1";
            txtCantidad.Text = "1";
            txtEstado.Text = "1";
            txtBoxUsuario.Text = "1";
        }

        private void btnGuardarVenta_Click(object sender, EventArgs e)
        {

            Guid idVenta = Guid.NewGuid();
            Guid idCliente;
            Guid idUsuario;
            Guid idProducto;

            Guid.TryParse(txtClienteID.Text, out idCliente);
            Guid.TryParse(txtProductoID.Text, out idProducto);
            Guid.TryParse(txtBoxUsuario.Text, out idUsuario);

            //TODO: Añadir metodo validar int de cantidad y estado
            int cantidad;
            int.TryParse(txtCantidad.Text, out cantidad);

            int estado;
            int.TryParse(txtEstado.Text, out estado);

            DateTime fechaAlta = dtpFechaVenta.Value;

            Venta venta = new Venta(idVenta, idCliente, idProducto, cantidad, fechaAlta, estado, idUsuario);
            VentaService ventaService = new VentaService();

            string respuestaNuevaVenta = ventaService.AgregarVenta(venta);

            MessageBox.Show($"Venta {respuestaNuevaVenta} fue agregada exitosamente!");
        }

        // Método para limpiar controles
        private void LimpiarControles(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
                else if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = -1;
                }
                else if (control is DateTimePicker)
                {
                    ((DateTimePicker)control).Value = DateTime.Now;
                }
                else if (control.HasChildren)
                {
                    LimpiarControles(control);
                }
            }
        }

    }
}
