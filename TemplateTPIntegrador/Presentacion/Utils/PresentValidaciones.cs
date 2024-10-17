﻿using System;
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

        // Contador de intentos de login
/*        public void ContadorIntentosLogin(int intentos, out string mensaje)
        {
            if (intentos == 3)
            {
                mensaje = "Se ha superado el límite de intentos";
                MessageBox.Show(mensaje);
            }
            mensaje = string.Empty;
        }*/

    }
}
