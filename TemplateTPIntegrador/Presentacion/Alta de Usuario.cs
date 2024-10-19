using Negocio.Utils;
﻿using Datos;
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

namespace Presentacion
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
            ABM_Administrador aBM_Administrador = new ABM_Administrador();
            aBM_Administrador.Show();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCrearUser_Click(object sender, EventArgs e)
        {
            // Datos personales

            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string direccion = txtDireccion.Text;
            string telefono = txtTelefono.Text;
            string email = txtEmail.Text;
            string dni = txtDni.Text;
            DateTime fechaNacimiento = datepickerFechaNacimiento.Value;

            // Creación de usuario

            string usuario = txtUsuario.Text;
            string clave = txtContraseña.Text;
            int host = 0;

            NegocioValidaciones validarusuario = new NegocioValidaciones();
            NegocioValidaciones validarpass = new NegocioValidaciones();

            if (validarusuario.ValidarUsuario(usuario, nombre, apellido) == true)
            {
                MessageBox.Show("El usuario creado no debe contener el nombre y apellido de la persona");
            }
            else if (validarusuario.ValidarTexto(usuario) == true)
            {
                MessageBox.Show("El usuario debe tener entre 8 y 15 caracteres");
            }
            else if (validarpass.ValidarTexto(clave) == true)
            {
                MessageBox.Show("La Contraseña debe tener entre 8 y 15 caracteres");
            }

            // Validación y asignación de tipo de usuario

            if (btnradioAdministrador.Checked)
            {
                host = 3;
            }
            else
            if (btnradioSupervisor.Checked)
            {
                host = 2;
            }
            else
            if (btnradioVendedor.Checked)
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
            
            // Comentado para no llamar innecesariamente al WS hasta tener todas las valdiaciones
/*            LoginNegocio login = new LoginNegocio();
            string user = login.AltaUsuario(nuevoUsuario);

            MessageBox.Show(user);*/
        }
    }
}
