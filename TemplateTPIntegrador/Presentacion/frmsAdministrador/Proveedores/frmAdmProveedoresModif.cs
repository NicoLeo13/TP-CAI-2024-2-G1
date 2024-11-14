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
            txtBoxFechaAltaProveedorRellenar.Text = "";
            txtBoxFechaBajaProveedorRellenar.Text = "";
        }

        private void txtBoxNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnModificarProveedor_Click(object sender, EventArgs e)
        {
            try
            {
                // Recibo los nuevos valores que editó el usuario.

                string nombre = txtBoxNombreProveedorRellenar.Text;
                string apellido = txtBoxApellidoProveedorRellenar.Text;
                string email = txtBoxEmailProveedorRellenar.Text;
                string cuit = txtBoxCuitProveedorRellenar.Text;

                // El WS no recibe las fechas, no son modificables.

                //DateTime fechaAlta = Convert.ToDateTime(txtBoxFechaAltaProveedorRellenar.Text);
                //DateTime? fechaBaja = txtBoxFechaBajaProveedorRellenar.Text == "N/A" ? (DateTime?)null : Convert.ToDateTime(txtBoxFechaBajaProveedorRellenar.Text);


                // Verificación de que, si NO MODIFIQUÉ ningún campo, no se haga la llamada al WS.


                // Creo un nuevo objeto Proveedor con los nuevos valores.

                proveedor.Nombre = nombre;
                proveedor.Apellido = apellido;
                proveedor.Email = email;
                proveedor.CUIT = cuit;
                //proveedor.FechaAlta = fechaAlta;
                //proveedor.FechaBaja = fechaBaja;

                ProveedorService proveedorService = new ProveedorService();

                proveedorService.ModificarProveedor(proveedor);

                LimpiarCamposBaja();

                MessageBox.Show($"El proveedor fue editado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                proveedor = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                txtBoxFechaAltaProveedorRellenar.Text = proveedor.FechaAlta.ToString("dd/MM/yyyy");
                txtBoxFechaBajaProveedorRellenar.Text = proveedor.FechaBaja?.ToString("dd/MM/yyyy") ?? "N/A";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el proveedor de CUIT: " + txtBoxCUITProveedor.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"\nError al buscar el proveedor de CUIT: {txtBoxCUITProveedor.Text} - {ex.Message}");
            }


        }

    }
}
