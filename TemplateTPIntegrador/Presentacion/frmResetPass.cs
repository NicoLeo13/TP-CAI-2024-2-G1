using Negocio.Utils;
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

        private void labelContraseña_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardarUsuario_Click(object sender, EventArgs e)
        {

            string contraseñaActual = txtBoxContraseñaActual.Text;
            string nuevaContraseña = txtBoxNuevaContraseña.Text;
            string reingresoNuevaContraseña = txtBoxReingresoNuevaContraseña.Text;
            
            // Traeme el usuario que está logueado.

            string nombreUsuario = "johndoe1";

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
    }
}
