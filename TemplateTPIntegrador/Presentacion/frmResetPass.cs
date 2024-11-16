using FontAwesome.Sharp;
using Negocio.Utils;
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

namespace Presentacion
{
    public partial class frmResetPass : Form
    {

        public frmResetPass()
        {
            InitializeComponent();
        }

        private void btnGuardarUsuario_Click(object sender, EventArgs e)
        {
            PresentacionValidaciones validaciones = new PresentacionValidaciones();
            if (!validaciones.ValidarControles(this, out string mensajeError))
            {
                MessageBox.Show(mensajeError, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            string contraseñaActual = txtBoxContraseñaActual.Text;
            string nuevaContraseña = txtBoxNuevaContraseña.Text;
            string reingresoNuevaContraseña = txtBoxReingresoNuevaContraseña.Text;
            
            // Traeme el usuario que está logueado.

            string nombreUsuario = "johndoe1"; // Flag-hardcode

            NegocioValidaciones negocioValidaciones = new NegocioValidaciones();
            string resultValidarPass = negocioValidaciones.ValidarPass(nombreUsuario, contraseñaActual, nuevaContraseña, reingresoNuevaContraseña);

            MessageBox.Show(resultValidarPass);


            //if (negocioValidaciones.ValidarPass (contraseñaactual, contraseñanueva) == true)
            //{
            //    MessageBox.Show("La nueva contraseña no debe ser igual a la contraseña actual. Reingrese");
            //}
            //else 
            //{
            //    MessageBox.Show("Se ha generado una nueva contraseña");
            //}

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
