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

        public frmAdmProveedoresBaja()
        {
            InitializeComponent();
        }



        private void btnVolver_Click(object sender, EventArgs e)
        {
            PresentacionUtils.VolverFormPrevio((IconButton)sender, PresentacionUtils.FormPrevio, PresentacionUtils.PanelContenedor);
        }
        
        private void btnBuscarVendedor_click(object sender, EventArgs e)
        {

        }

        private void btnEliminarVendedor_Click(object sender, EventArgs e)
        {

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

            try
            {
                proveedor = ProveedorService.BuscarProveedor(txtBoxCUITProveedor.Text);

                // usuario = UsuarioService.BuscarUsuario(txtBoxCUITProveedor.Text);
                if (proveedor == null)
                {
                    MessageBox.Show("El proveedor de CUIT: " + txtBoxCUITProveedor.Text + " no fue encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                txtBoxFechaAltaProveedorRellenar.Text = proveedor.IdProveedor.ToString();
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

        }
    }
}
