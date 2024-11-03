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
using Presentacion.Utils;

namespace Presentacion
{
    public partial class FormLogin : Form
    {
        private const string TOOLTIP_OLVIDAR_CONTRASEÑA = "Haz clic aquí si olvidaste tu contraseña.";
        private const string ERROR_SHOW = "Error";
        private const string USER_NOT_FOUND = "Usuario no encontrado";
        private const bool skipLogin = true;

        public FormLogin()
        {
            InitializeComponent();
            SugerenciaService.ConfigurarAutoComplete(txtBoxUser, "usuarios_sugerencias");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Crea el ToolTip y asigna al linkLabelForgotPass
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(linkLabelForgotPass, TOOLTIP_OLVIDAR_CONTRASEÑA);
        }

        private void SkipLogin(string nombreUsuario)
        {
            //Datos de un usuario para probar la pantalla de administrador, supervisor o vendedor
            //int host = 3; //Probando con Administrador (se puede con los otros tambien)

            if (int.TryParse(nombreUsuario, out int host))
            {
                //Validar si txtBoxUser es un int (entre 1 y 3) y si es asi, asignar a host. Si no, mostrar mensaje de error
                if (host < 1 || host > 3)
                {
                    MessageBox.Show("El valor ingresado no es válido. Ingrese un número entre 1 y 3.\nAdmin: 3\nSupervisor: 2\nVendedor: 1", "Modo Prueba Activo - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (host == 3)
                {
                    UsuarioWS usuario = new UsuarioWS(id: Guid.NewGuid(), nombre: "adminTest", apellido: "Test", dni: 12345678, nombreUsuario: "PruebaCAI1", host: host);
                    Form pantallaInicial = PresentacionUtils.PantallaInicialUsuario(usuario);
                    pantallaInicial.FormClosing += new FormClosingEventHandler(frm_FormClosing);
                    pantallaInicial.Show();
                    this.Hide();
                }
                else if (host == 2)
                {
                    MessageBox.Show("Supervisor no implementado aun.", "Modo Prueba Activo - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                    //UsuarioWS usuario = new UsuarioWS(id: Guid.NewGuid(), nombre: "supervTest", apellido: "Test", dni: 12345678, nombreUsuario: "PruebaCAI1", host: host);
                    //Form pantallaInicial = PresentacionUtils.PantallaInicialUsuario(usuario);
                    //pantallaInicial.FormClosing += new FormClosingEventHandler(frm_FormClosing);
                    //pantallaInicial.Show();
                    //this.Hide();
                }
                else if (host == 1)
                {
                    UsuarioWS usuario = new UsuarioWS(id: Guid.NewGuid(), nombre: "vendTest", apellido: "Test", dni: 12345678, nombreUsuario: "PruebaCAI1", host: host);
                    Form pantallaInicial = PresentacionUtils.PantallaInicialUsuario(usuario);
                    pantallaInicial.FormClosing += new FormClosingEventHandler(frm_FormClosing);
                    pantallaInicial.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar un numero de Host.", "Modo Prueba Activo - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonIniciarSesion_Click(object sender, EventArgs e)
        {
            bool loginExitoso = false;
            string nombreUsuario = txtBoxUser.Text;
            string claveUsuario = txtBoxPass.Text;

            //Saltea login para probar pantallas directamente
            if (skipLogin)
            {
                SkipLogin(nombreUsuario);
                return;
            }

            PresentacionValidaciones presentacionValidaciones = new PresentacionValidaciones();

            if (presentacionValidaciones.CamposValidos(nombreUsuario, claveUsuario, out string mensajeError) == false)
            {
                MessageBox.Show(mensajeError, ERROR_SHOW, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            LoginUsuario loginUsuario = new LoginUsuario();
            UsuarioWS usuario = null;

            try
            {
                usuario = loginUsuario.TraerUsuario(nombreUsuario);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ERROR_SHOW, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (usuario == null)
            {
                MessageBox.Show(USER_NOT_FOUND, ERROR_SHOW, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Bloque try-catch para manejar excepciones en login
            try
            {
                (string idUsuario, string responseBody) = loginUsuario.Login(nombreUsuario, claveUsuario);

                if (!string.IsNullOrEmpty(idUsuario))
                {
                    //MessageBox.Show(idUsuario, "Login Exitoso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loginExitoso = true;
                    SugerenciaService.GuardarSugerencia(nombreUsuario, "usuarios_sugerencias");
                }
                else
                {
                    MessageBox.Show(responseBody, ERROR_SHOW, MessageBoxButtons.OK, MessageBoxIcon.Error);  //Muestra error en caso de que no se haya encontrado el usuario
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ERROR_SHOW, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (loginExitoso)
            {
                try
                {
                    Form pantallaInicial = PresentacionUtils.PantallaInicialUsuario(usuario);
                    pantallaInicial.FormClosing += new FormClosingEventHandler(frm_FormClosing);
                    pantallaInicial.Show();
                    this.Hide();
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message, ERROR_SHOW, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ERROR_SHOW, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Cierra la aplicación si el usuario cierra la ventan
            if (this.DialogResult == DialogResult.Cancel || e.CloseReason == CloseReason.UserClosing && !PresentacionUtils.isFormClosing)
            {
                DialogResult result = MessageBox.Show("¿Está seguro que desea salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
                if (result == DialogResult.No)
                    e.Cancel = true;  // Cancela el evento de cierre
                else
                {
                    Application.Exit();
                    //PresentacionUtils.isFormClosing = true;
                }
            }
            //  Muestra el formulario de login si el usuario cierra la sesion con boton
            else if (e.CloseReason != CloseReason.ApplicationExitCall)
            {
                this.txtBoxUser.Clear();
                this.txtBoxPass.Clear();
                this.Show();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Implementar logica");
        }
        private void txtBoxUser_Focus(object sender, EventArgs e)
        {
            this.AcceptButton = txtBoxPass.Text.Length > 0 ? btnIniciarSesion : null;   // Permite iniciar sesión con Enter si hay texto en el campo de contraseña
        }

        private void txtBoxPass_Focus(object sender, EventArgs e)
        {
            this.AcceptButton = btnIniciarSesion;
        }

        private void txtBoxUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
