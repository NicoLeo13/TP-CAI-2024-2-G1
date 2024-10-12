using Datos;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemplateTPIntegrador
{
    public partial class Alta_de_Usuario : Form
    {
        public Alta_de_Usuario()
        {
            InitializeComponent();
        }

        private void Alta_de_Usuario_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            // Datos personales

            string nombre = txtnombre.Text;
            string apellido = txtapellido.Text;
            string direccion = txtdireccion.Text;
            string telefono = txttel.Text;
            string email = txtemail.Text;
            string dni = txtdni.Text;
            DateTime fechaNacimiento = fnacDatePicker.Value;

            // Creación de usuario

            string usuario = txtuser.Text;
            string clave = txtpass.Text;
            int host = 0;
            
            // Validación y asignación de tipo de usuario

            if (btnRadioAdmin.Checked)
            {
                host = 3;
            }
            else
            if (btnRadioSupervisor.Checked)
            {
                host = 2;
            }
            else
            if (btnRadioVendedor.Checked)
            {
                host = 1;
            };

            // Clase de: Datos -> UsuarioLocal.cs

            UsuarioLocal nuevoUsuario = new UsuarioLocal
            {
                IdUsuario = Guid.NewGuid(),
                Host = host,
                Nombre = nombre,
                Apellido = apellido,
                Dni = int.TryParse(dni, out int dniValue) ? dniValue : 0,
                Direccion = direccion,
                Telefono = telefono,
                Email = email,
                FechaNacimiento = fechaNacimiento.ToUniversalTime(),
                NombreUsuario = usuario,
                Contraseña = clave
            };

            // Habría que mover AltaUsuario de LoginNegocio, pero lo hice ahí para simplificar de momento.

            LoginNegocio login = new LoginNegocio();
            string user = login.AltaUsuario(nuevoUsuario);

            MessageBox.Show(user);
        }

    }
}
