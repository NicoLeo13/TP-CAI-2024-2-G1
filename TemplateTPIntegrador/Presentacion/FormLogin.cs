using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio.Utils;
using Datos;
using Negocio;

namespace Presentacion
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Crea el ToolTip y asigna al linkLabelForgotPass
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(linkLabelForgotPass, "Haz clic aquí si olvidaste tu contraseña.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = txtBoxUser.Text;
            string clave = txtBoxPass.Text;
            PresentacionValidaciones validaciones = new PresentacionValidaciones();

            if(validaciones.ValidarStringVacio(usuario) == true || validaciones.ValidarStringVacio(clave) == true)
            {
                MessageBox.Show("Complete todos los campos", "Campos Vacios");
                return;
            }

            NegocioValidaciones loginValidacion = new NegocioValidaciones();
      

            if(loginValidacion.Login(usuario) == true)
            {
                MessageBox.Show("El nombre de usuario debe ser mayor a 8 caracteres");
                return;
            }

            LoginNegocio login = new LoginNegocio();
            string idUser = login.Login(usuario, clave);

            Perfil_Administrador perfilAdmin = new Perfil_Administrador();
            {
                perfilAdmin.Show();
                this.Hide();
            }

            MessageBox.Show(idUser);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
