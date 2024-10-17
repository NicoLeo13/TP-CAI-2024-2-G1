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
        public const string TOOLTIP_OLVIDAR_CONTRASEÑA = "Haz clic aquí si olvidaste tu contraseña.";
        public const string ERROR_SHOW = "Error";


        public FormLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Crea el ToolTip y asigna al linkLabelForgotPass
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(linkLabelForgotPass, TOOLTIP_OLVIDAR_CONTRASEÑA);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = txtBoxUser.Text;
            string clave = txtBoxPass.Text;
            PresentacionValidaciones presentacionValidaciones = new PresentacionValidaciones();

            if (presentacionValidaciones.CamposValidos(usuario, clave, out string mensajeError) == false)
            {
                MessageBox.Show(mensajeError, ERROR_SHOW, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            LoginUsuario loginUsuario = new LoginUsuario();

            Guid userGuid = loginUsuario.TraerUsuario(usuario);
            if (userGuid == Guid.Empty)
            {
                MessageBox.Show("Usuario no encontrado", ERROR_SHOW, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            (string idUsuario, string responseBody) = loginUsuario.Login(usuario, clave);

            if (!string.IsNullOrEmpty(idUsuario))
                MessageBox.Show(idUsuario, "Usuario Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
                MessageBox.Show(responseBody, ERROR_SHOW, MessageBoxButtons.OK, MessageBoxIcon.Error);

            //Perfil_Administrador perfilAdmin = new Perfil_Administrador();
            //{
            //    perfilAdmin.Show();
            //    this.Hide();
            //}
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Implementar logica");
        }
    }
}
