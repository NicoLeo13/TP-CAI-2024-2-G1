using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public class PresentacionValidaciones
    {
        public const string COMPLETAR_CAMPOS = "Complete todos los campos";
        public const string ERROR_LONGITUD_USUARIO = "El Usuario debe tener entre 8 y 15 caracteres";
        public const string ERROR_LONGITUD_CLAVE = "La Contraseña debe tener entre 8 y 15 caracteres";

        public bool CamposValidos(string usuario, string clave, out string mensajeError)
        {
            if (EsCampoVacio(usuario) == true || EsCampoVacio(clave) == true)
            {
                mensajeError = COMPLETAR_CAMPOS;
                return false;
            }

            if (ErrorLongitudCampo(usuario, clave, out mensajeError) == true)
                return false;

            mensajeError = string.Empty;
            return true;
        }
        
        public bool EsCampoVacio(string texto)
        {
            if(string.IsNullOrEmpty(texto)) 
                return true;
            return false;
        }

        public bool ErrorLongitudCampo(string usuario, string pass, out string mensaje)
        {
           if (usuario.Length < 8 || usuario.Length > 15)
            {
                mensaje = ERROR_LONGITUD_USUARIO;
                return true;
            }

            if (pass.Length < 8 || pass.Length > 15)
            {
                mensaje = ERROR_LONGITUD_CLAVE;
                return true;
            }

            mensaje = string.Empty;
            return false;
        }

        public bool ValidarControles(Control form, out string mensajeError)
        {
            bool camposValidos = true;
            mensajeError = string.Empty;

            foreach (Control control in form.Controls)
            {
                if (control is TextBox textBox)
                {
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        textBox.BorderStyle = BorderStyle.FixedSingle;
                        textBox.BackColor = System.Drawing.Color.DarkRed;
                        textBox.ForeColor = System.Drawing.Color.White;
                        camposValidos = false;
                    }
                    else
                    {
                        textBox.BorderStyle = BorderStyle.Fixed3D;
                        textBox.BackColor = System.Drawing.Color.White;
                        textBox.ForeColor = System.Drawing.Color.Black;
                    }
                }
                else if (control is ComboBox comboBox)
                {
                    if (comboBox.SelectedIndex == -1)
                    {
                        comboBox.FlatStyle = FlatStyle.Popup;
                        comboBox.BackColor = System.Drawing.Color.DarkRed;
                        comboBox.ForeColor = System.Drawing.Color.White;
                        camposValidos = false;
                    }
                    else
                    {
                        comboBox.FlatStyle = FlatStyle.Standard;
                        comboBox.BackColor = System.Drawing.Color.White;
                        comboBox.ForeColor = System.Drawing.Color.Black;
                    }
                }
                else if (control.HasChildren)
                {
                    bool childCamposValidos = ValidarControles(control, out string childMensajeError);  // Recursividad para controles dentro del control actual
                    if (!childCamposValidos)
                    {
                        camposValidos = false;
                        mensajeError = childMensajeError;
                    }
                }
            }

            if (!camposValidos)
                mensajeError = COMPLETAR_CAMPOS;

            return camposValidos;
        }
    }
}
