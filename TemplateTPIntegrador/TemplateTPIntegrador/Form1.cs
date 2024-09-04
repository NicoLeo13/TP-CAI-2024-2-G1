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
            string txt1 = textBox1.Text;
            string txt2 = textBox2.Text;
            PresentacionValidaciones validaciones = new PresentacionValidaciones();

            if(validaciones.ValidarStringVacio(txt1) == true || validaciones.ValidarStringVacio(txt2) == true)
                MessageBox.Show("Ingrese todos los datos necesarios!");

            Validaciones loginNegocio = new Validaciones();

            if(loginNegocio.Login(txt1) == true)
                MessageBox.Show("El nombre de usuario debe ser mayor a 8 caracteres");
        }
    }
}
