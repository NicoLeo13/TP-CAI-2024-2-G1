using Datos;
using Negocio;
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
    public partial class BajaUsuario : Form
    {
        public BajaUsuario()
        {
            InitializeComponent();
        }

        private void BajaUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            LoginNegocio login = new LoginNegocio();

            string usuarioBaja = txtUsuario.Text;

            Guid idUsuario = login.TraerUsuario(usuarioBaja);

            MessageBox.Show("ID del usuario a dar de baja: " + idUsuario);
        }
    }
}
