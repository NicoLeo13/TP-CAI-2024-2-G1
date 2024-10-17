using Negocio;
using Negocio.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemplateTPIntegrador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = txtBoxUser.Text;
            string clave = txtBoxPass.Text;
            string nombre = txtBoxNombre.Text;   
            string apellido = txtBoxApellido.Text;
            PresentacionValidaciones validaciones = new PresentacionValidaciones();

            if(validaciones.ValidarStringVacio(usuario) == true || validaciones.ValidarStringVacio(clave) == true)
            {
                MessageBox.Show("Ingrese todos los datos necesarios!");
                return;
            }
<<<<<<< Updated upstream
                        
            if (usuario.Length < 8 || usuario.Length > 15)
=======

            NegocioValidaciones loginNegocio = new NegocioValidaciones();

            if (loginNegocio.Login(usuario) == true)
>>>>>>> Stashed changes
            {
                MessageBox.Show("El nombre de usuario debe tener entre 8 y 15 caracteres.");
                return;
            }
<<<<<<< Updated upstream

            if (usuario.Contains(nombre, StringComparison.OrdinalIgnoreCase) || usuario.Contains(apellido, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("El nombre de usuario no puede contener su nombre o apellido.");
                return;
            }

            NegocioValidaciones loginNegocio = new NegocioValidaciones();
                        
            if (!loginNegocio.ExisteUsuario(usuario))
            {
                MessageBox.Show("El nombre de usuario no existe.");
                return;
            }

            try
            {
                if (loginNegocio.Login(usuario, clave))
                {
                    MessageBox.Show("Login exitoso.");
                }
                else
                {
                    MessageBox.Show("Error en el login. Usuario o contraseña incorrectos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al intentar iniciar sesión: " + ex.Message);
            }

            if (!clave.Any(char.IsUpper) || !clave.Any(char.IsDigit))
            {
                MessageBox.Show("La contraseña debe tener al menos una letra mayúscula y al menos un número.");
                return;
            }


=======
            
            NegocioValidaciones claveNegocio = new NegocioValidaciones();
            if(!clave.Any(char.IsUpper) || !clave.Any(char.IsDigit))
            {
                MessageBox.Show("La contraseña debe tener al menos una letra mayscula y al menos un número");
                return;
            }
>>>>>>> Stashed changes
        }
    }
}
