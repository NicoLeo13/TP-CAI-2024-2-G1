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

namespace TemplateTPIntegrador
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

        private void btnCrear_Click(object sender, EventArgs e)
        {
            string nombre = txtnombre.Text;
            string apellido = txtapellido.Text;
            string usuario = txtuser.Text;
            string contraseña = txtpass.Text;

            NegocioValidaciones validarusuario= new NegocioValidaciones();
            //NegocioValidaciones validarpass=new NegocioValidaciones();

            //bool usuariovalido; para el do
            //bool contraseñavalida; para el do

            if (validarusuario.ValidarUsuario(usuario, nombre, apellido) == true)
            {
                MessageBox.Show("El usuario creado no debe contener el nombre y apellido de la persona");
            }
            else
            {
                MessageBox.Show("Usuario Ok");
            }

            //if (validarpass.ValidarContraseña(contraseña) == true)
            //{
            //    MessageBox.Show("Ok");
            //}
            //else
            //{
            //    MessageBox.Show("La contraseña debe tener entre 8 y 15 caracteres");
            //}

            //if (validarusuario.ValidarUsuario(usuario, nombre, apellido) == true)
            //{
            //    MessageBox.Show("El usuario creado no debe contener el nombre y el apellido de la persona");
            //}
            //else if (validarpass.ValidarContraseña(contraseña) == true)
            //{
            //    MessageBox.Show("La contraseña debe tener entre 8 y 15 caracteres");
            //}
            //else
            //{
            //    MessageBox.Show("Ok");
            //}





        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
