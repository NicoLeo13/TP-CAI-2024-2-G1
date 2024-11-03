using FontAwesome.Sharp;
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
using Datos;



namespace Presentacion
{
    public partial class PerfilVendedor : Form
    {
        private NuevaVenta frmPerfilVendedor;
        public PerfilVendedor()
        {
            InitializeComponent();


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            PresentacionUtils.VolverFormPrevio((IconButton)sender, PresentacionUtils.FormPrevio, PresentacionUtils.PanelContenedor);
        }

        private void btnNuevaVenta_Click(object sender, EventArgs e)
        {
            if (frmPerfilVendedor == null || frmPerfilVendedor.IsDisposed)
            {
                frmPerfilVendedor = new NuevaVenta();
                PresentacionUtils.AbrirForm((IconButton)sender, frmPerfilVendedor,this);
            }
            else
            {
                frmPerfilVendedor.BringToFront();
            }
        }
    }
}
