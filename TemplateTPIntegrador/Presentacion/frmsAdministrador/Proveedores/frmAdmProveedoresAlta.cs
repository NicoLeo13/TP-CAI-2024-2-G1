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
using Negocio.Utils;

namespace Presentacion
{
    public partial class frmAdmProveedoresAlta : Form
    {

        const int hostVendedor = 1;

        public frmAdmProveedoresAlta()
        {
            InitializeComponent();
            ConfigurarTabIndex();
        }

        public void ConfigurarTabIndex()
        {
            //Agrega los controles al TabIndex segun el orden en el que se encuentran en el formulario
            txtBoxNombre.TabIndex = 0;
            txtBoxApellido.TabIndex = 1;
            txtBoxEmail.TabIndex = 2;
            txtBoxCuit.TabIndex = 3;
            btnGuardarProveedor.TabIndex = 4;
            btnLimpiarCampos.TabIndex = 5;
            btnVolver.TabIndex = 6;

        }

        private void btnGuardarVendedor_Click(object sender, EventArgs e)
        {

        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            PresentacionUtils.LimpiarControles(this);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            PresentacionUtils.VolverFormPrevio((IconButton)sender, PresentacionUtils.FormPrevio, PresentacionUtils.PanelContenedor);
        }

        private void btnGuardarProveedor_Click(object sender, EventArgs e)
        {
            PresentacionValidaciones validaciones = new PresentacionValidaciones();
            if (!validaciones.ValidarControles(this, out string mensajeError))
            {
                MessageBox.Show(mensajeError, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            //Guid idproveedor = Guid.Parse(""); //no esta en el form para agregar el id
            DateTime fechaalta = DateTime.Now;
            DateTime? fechabaja = null;
            Guid id = Guid.Empty;

            string nombre = txtBoxNombre.Text;
            string apellido = txtBoxApellido.Text;
            string email = txtBoxEmail.Text;    
            string cuit = txtBoxCuit.Text;

            NegocioValidaciones negocioValidaciones = new NegocioValidaciones();

            if (negocioValidaciones.CorreoValido(email) == false)
            {
                MessageBox.Show("El campo 'Email' debe contener un '@'. ");
                return;
            }

            Proveedor proveedor = new Proveedor(id, nombre, apellido, email, cuit, fechaalta, fechabaja);
            ProveedorService proveedorService = new ProveedorService();

            string respuestaAltaProveedor = proveedorService.AgregarProveedor(proveedor);

            MessageBox.Show("Se guardo el proveedor correctamente" + respuestaAltaProveedor);
        }

        private void txtBoxEmail_TextChanged(object sender, EventArgs e)
        {
            
            
            
        }
    }
    
}
