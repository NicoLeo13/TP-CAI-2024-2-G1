using FontAwesome.Sharp;
using Negocio;
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
            PresentacionUtils.LimpiarControles(this);
        }
        private void btnGuardarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                Guid idVenta = Guid.NewGuid();
                Guid idCliente;
                Guid idProducto;
                Guid idUsuario;

                Guid.TryParse(txtClienteID.Text, out idCliente);
                Guid.TryParse(txtProductoID.Text, out idProducto);
                Guid.TryParse(txtBoxUsuario.Text, out idUsuario);

                int cantidad;
                int.TryParse(txtCantidad.Text, out cantidad);

                int estado;
                int.TryParse(txtEstado.Text, out estado);

                DateTime fechaAlta = dtpFechaVenta.Value;

                //VentaService ventaService = new VentaService();
                //ventaService.AgregarVenta(
                //    idVenta,
                //    idCliente,
                //    idProducto,
                //    cantidad,
                //    fechaAlta,
                //    estado,
                //    idUsuario
                //);

                MessageBox.Show($"Venta {idVenta} agregada exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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


        private void btnCargarVenta_Click(object sender, EventArgs e)
        {
            // Código para cargar una venta
        }
    }
}
