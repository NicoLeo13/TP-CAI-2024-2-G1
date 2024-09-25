using Negocio;
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
            PresentacionValidaciones validaciones = new PresentacionValidaciones();

            if(validaciones.ValidarStringVacio(usuario) == true || validaciones.ValidarStringVacio(clave) == true)
            {
                MessageBox.Show("Ingrese todos los datos necesarios!");
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
            MessageBox.Show(idUser);
        }
    }
}
