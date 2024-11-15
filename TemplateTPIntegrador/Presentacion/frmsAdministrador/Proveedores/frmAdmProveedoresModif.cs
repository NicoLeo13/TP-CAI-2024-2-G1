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
    public partial class frmAdmProveedoresModif : Form
    {
        private Proveedor proveedor;

        public frmAdmProveedoresModif()
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
        }

        private void btnModificarProveedor_Click(object sender, EventArgs e)
        {
            try
            {
                // Recibo los nuevos valores que editó el usuario.
                Proveedor proveedorOld = proveedor;

                string nombre = txtBoxNombreProveedorRellenar.Text;
                string apellido = txtBoxApellidoProveedorRellenar.Text;
                string email = txtBoxEmailProveedorRellenar.Text;
                string cuit = txtBoxCuitProveedorRellenar.Text;

                proveedor.Nombre = nombre;
                proveedor.Apellido = apellido;
                proveedor.Email = email;
                proveedor.CUIT = cuit;

                if(proveedorOld == proveedor)
                {
                    MessageBox.Show("No se realizaron cambios en el proveedor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                ProveedorService proveedorService = new ProveedorService();
                proveedorService.ModificarProveedor(proveedor);

                MessageBox.Show($"El proveedor fue editado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCamposBaja();
                PresentacionUtils.DeshabilitarControles(this.grpDatosProveedor);

                proveedor = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar el proveedor:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"\nError al modificar el proveedor: {ex.Message}");
            }
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

                PresentacionUtils.HabilitarControles(this.grpDatosProveedor);

                // Tenemos el ID si lo necesitáramos.
                // lbl.??? = proveedor.Id.ToString(); 
                txtBoxNombreProveedorRellenar.Text = proveedor.Nombre;
                txtBoxApellidoProveedorRellenar.Text = proveedor.Apellido;
                txtBoxEmailProveedorRellenar.Text = proveedor.Email;
                txtBoxCuitProveedorRellenar.Text = proveedor.CUIT;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el proveedor de CUIT: " + txtBoxCUITProveedor.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"\nError al buscar el proveedor de CUIT: {txtBoxCUITProveedor.Text} - {ex.Message}");
            }


        }

    }
}
