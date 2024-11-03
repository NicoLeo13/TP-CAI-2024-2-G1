using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Persistencia.Utils;
using Datos;
using FontAwesome.Sharp;


namespace Presentacion.Utils
{
    internal class PresentacionUtils
    {
        private static bool formClosing = false;
        private static Form formActivo = null;
        private static Form formPrevio = null;
        private static IconButton menuActivo = null;
        private static Panel panelContenedor = null;

        public static bool isFormClosing { get; set; }
        public static Panel PanelContenedor { get; set; }
        public static Form FormPrevio { get; set; }

        //Metodo para devolver a que pantalla redirigir segun el perfil del usuario, devolviendo el objeto de la pantalla
        public static Form PantallaInicialUsuario(UsuarioWS usuario)
        {
            switch (usuario.Host)
            {
                case 1: // Vendedor
                    return new frmPerfilVendedor(usuario);
                case 2: // Supervisor
                    return new frmPerfliSupervisor(usuario);
                case 3: // Administrador
                    return new frmPerfilAdministrador(usuario);
                default:
                    throw new ArgumentException("Inicio de sesión correcto.\nPerfil de usuario no reconocido.");
            }
        }

        public static void AbrirForm(IconButton boton, Form form, Panel contenedor)
        {
            if (formActivo != null)
            {
                if (formActivo.Text == form.Text)
                {
                    //formActivo.Hide();
                    return;
                }
                formActivo.Hide();
            }

            FormPrevio = formActivo;
            formActivo = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            contenedor.Controls.Add(form);
            PanelContenedor = contenedor;
            PanelContenedor.Controls.Add(form);
            form.Show();
        }

        public static void VolverFormPrevio(IconButton boton, Form form, Panel contenedor)
        {
            if (formActivo != null)
            {
                if (formActivo.Text == form.Text)
                {
                    //formActivo.Hide();
                    return;
                }
                formActivo.Hide();
            }
            contenedor.Controls.Clear();

            formActivo = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            contenedor.Controls.Add(form);
            PanelContenedor = contenedor;
            PanelContenedor.Controls.Add(form);
            if (!PanelContenedor.Controls.Contains(form))
            {
                PanelContenedor.Controls.Add(form);
            }
            form.Show();
        }

        public static void LimpiarControles(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
                else if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = -1;
                }
                else if (control is DateTimePicker)
                {
                    ((DateTimePicker)control).Value = DateTime.Now;
                }
                else if (control.HasChildren)
                {
                    LimpiarControles(control);
                }
            }
        }
    }
}
