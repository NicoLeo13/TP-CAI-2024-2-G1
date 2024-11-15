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
    public partial class frmAdmProveedoresBaja : Form
    {
        private Proveedor proveedor;
        PresentacionValidaciones validaciones = new PresentacionValidaciones();

        public frmAdmProveedoresBaja()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            PresentacionUtils.VolverFormPrevio((IconButton)sender, PresentacionUtils.FormPrevio, PresentacionUtils.PanelContenedor);
        }

        public void LimpiarCamposBaja()
        {
            txtBoxCUITProveedor.Text = "";
            txtBoxNombreProveedorRellenar.Text = "";
            txtBoxApellidoProveedorRellenar.Text = "";
            txtBoxEmailProveedorRellenar.Text = "";
            txtBoxCuitProveedorRellenar.Text = "";
            txtBoxFechaAltaProveedorRellenar.Text = "";
            txtBoxFechaBajaProveedorRellenar.Text = "";
        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            if (txtBoxCUITProveedor.Text == "")
            {
                MessageBox.Show("Por favor ingrese un CUIT de proveedor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(!validaciones.ValidarCuit(txtBoxCUITProveedor.Text))
            {
                MessageBox.Show("El CUIT debe ser numerico, contener 11 caracteres y no contener guiones", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                proveedor = ProveedorService.BuscarProveedor(txtBoxCUITProveedor.Text);

                // usuario = UsuarioService.BuscarUsuario(txtBoxCUITProveedor.Text);
                if (proveedor == null)
                {
                    MessageBox.Show("El proveedor de CUIT: " + txtBoxCUITProveedor.Text + " no fue encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                txtBoxNombreProveedorRellenar.Text = proveedor.Nombre;
                txtBoxApellidoProveedorRellenar.Text = proveedor.Apellido;
                txtBoxEmailProveedorRellenar.Text = proveedor.Email;
                txtBoxCuitProveedorRellenar.Text = proveedor.CUIT;
                txtBoxFechaAltaProveedorRellenar.Text = proveedor.FechaAlta.ToString("dd/MM/yyyy");
                txtBoxFechaBajaProveedorRellenar.Text = proveedor.FechaBaja?.ToString("dd/MM/yyyy") ?? "N/A";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el proveedor de CUIT: " + txtBoxCUITProveedor.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"\nError al buscar el proveedor de CUIT: {txtBoxCUITProveedor.Text} - {ex.Message}");
            }
        }

        private void btnEliminarProveedor_Click(object sender, EventArgs e)
        {
            if (proveedor == null)
            {
                MessageBox.Show("No se ha seleccionado un proveedor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Condicional con mensaje de confirmación para eliminar un proveedor
                DialogResult dialogResult = MessageBox.Show($"¿Está seguro que desea eliminar al proveedor: {proveedor.Nombre} {proveedor.Apellido} - CUIT: {proveedor.CUIT}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.No)
                    return;

                ProveedorService proveedorService = new ProveedorService();

                proveedorService.EliminarProveedor(proveedor);

                LimpiarCamposBaja();

                MessageBox.Show($"Proveedor: {proveedor.Nombre} {proveedor.Apellido} - CUIT: {proveedor.CUIT} eliminado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                proveedor = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el proveedor:\n {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"\nError al eliminar el proveedor: {ex.Message}");
            }
        }
    }
}
