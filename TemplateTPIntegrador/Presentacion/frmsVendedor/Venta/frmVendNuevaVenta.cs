﻿using FontAwesome.Sharp;
using Negocio;
using Datos;
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
using Persistencia;

namespace Presentacion
{
    
    public partial class frmVendNuevaVenta : Form
    {
        private Producto productoBusqueda;
        private Cliente clienteBusqueda;
        private CarritoService carrito;

        public frmVendNuevaVenta()
        {
            InitializeComponent();
            ConfigurarTabIndex();
        }

        //Metodo para configurar el TabIndex de los controles (txtBox)
        private void ConfigurarTabIndex()
        {
            //txtVentaID.TabIndex = 0;
            //txtClienteID.TabIndex = 1;
            //txtProductoID.TabIndex = 2;
            //txtDescripcion.TabIndex = 3;
            //txtCantidad.TabIndex = 4;
            //txtEstado.TabIndex = 5;
            //dtpFechaVenta.TabIndex = 6;
            //txtBoxUsuario.TabIndex = 7;
            //txtBoxContraseña.TabIndex = 8;
            //cmbHost.TabIndex = 9;
            //btnCargarVenta.TabIndex = 10;
            //btnLimpiarCampos.TabIndex = 11;
        }

        //private void btnLimpiarCampos_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        PresentacionUtils.LimpiarControles(this); 
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error: {ex.Message}");
        //    }
        //}

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Buscar producto por Nombre
            LimpiarCamposProducto();

            if(clienteBusqueda == null)
            {
                MessageBox.Show("Primero debe buscar un cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtBoxNombreProd.Text == "")
            {
                MessageBox.Show("Ingrese el nombre del producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                productoBusqueda = ProductoService.BuscarProducto(txtBoxNombreProd.Text);

                if (productoBusqueda == null)
                {
                    MessageBox.Show("El producto de nombre: " + txtBoxNombreProd.Text + " no fue encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                if (productoBusqueda.Stock == 0)
                {
                    MessageBox.Show("El producto seleccionado no tiene stock disponible", "Falta de Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                lblContIdProd.Text = productoBusqueda.Id.ToString();
                lblContPrecio.Text = productoBusqueda.Precio.ToString();
                lblContStock.Text = productoBusqueda.Stock.ToString();

                LlenarComboBoxCantidad();
                PresentacionUtils.HabilitarControles(this.grpVenta);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el producto de nombre: " + txtBoxNombreProd.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"\nError al buscar el producto de nombre: {txtBoxNombreProd.Text} - {ex.Message}");
            }
        }

        private void LimpiarCamposProducto()
        {
            cmbCantidad.Items.Clear();
            cmbCantidad.Text = "";
            cmbCantidad.SelectedIndex = -1;
            lblContIdProd.Text = "";
            lblContPrecio.Text = "";
            lblContStock.Text = "";
        }

        //Llenar combobox dependiendo del stock del producto
        private void LlenarComboBoxCantidad()
        {
            cmbCantidad.Items.Clear();
            cmbCantidad.Text = "";
            cmbCantidad.SelectedIndex = -1;

            int stock = productoBusqueda.Stock;

            for (int i = 1; i <= stock; i++)
                cmbCantidad.Items.Add(i);
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            LimpiarCamposCliente();

            if (txtBoxDniCliente.Text == "")
            {
                MessageBox.Show("Ingrese el DNI del cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                clienteBusqueda = ClienteService.BuscarCliente(int.Parse(txtBoxDniCliente.Text));

                if (clienteBusqueda == null)
                {
                    MessageBox.Show("El cliente con DNI: " + txtBoxDniCliente.Text + " no fue encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                lblContNombreApellido.Text = clienteBusqueda.Nombre + " " + clienteBusqueda.Apellido;
                lblContClienteDireccion.Text = clienteBusqueda.Direccion;
                lblContClienteTelefono.Text = clienteBusqueda.Telefono;

                PresentacionUtils.DeshabilitarControles(txtBoxDniCliente);
                btnBuscarCliente.Enabled = false;   //Deshabilitar boton de busqueda de cliente una vez encontrado y operando con el mismo
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el cliente con DNI: " + txtBoxDniCliente.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"\nError al buscar el cliente con DNI: {txtBoxDniCliente.Text} - {ex.Message}");
            }
        }

        private void LimpiarCamposCliente()
        {
            lblContNombreApellido.Text = "";
            lblContClienteDireccion.Text = "";
            lblContClienteTelefono.Text = "";
        }

        private void btnAgregarAlCarrito_Click(object sender, EventArgs e)
        {
            if(productoBusqueda == null)
            {
                MessageBox.Show("Primero debe buscar un producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(cmbCantidad.SelectedIndex <= -1)
            {
                MessageBox.Show("Seleccione una cantidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (clienteBusqueda == null)
            {
                MessageBox.Show("Primero debe buscar un cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            


        }

        private void btnEliminarDelCarrito_Click(object sender, EventArgs e)
        {

        }

        //private void btnAgregarAlCarrito_Click(object sender, EventArgs e)
        //{
        //    Guid idProducto;
        //    Guid.TryParse(txtProductoID.Text, out idProducto);
        //    string descripcion = txtDescripcion.Text;
        //    int cantidad;
        //    int.TryParse(txtCantidad.Text, out cantidad);
        //    decimal precioUnitario;
        //    decimal.TryParse(txtPrecioUnitario.Text, out precioUnitario);

        //    ItemCarrito item = new ItemCarrito(idProducto, descripcion, cantidad, precioUnitario);
        //    carrito.AgregarItem(item);

        //    ActualizarVistaCarrito();
        //}

        //private void btnCargarVenta_Click(object sender, EventArgs e)
        //{
        //    Guid idVenta = Guid.NewGuid();
        //    Guid idCliente;
        //    Guid idUsuario;
        //    Guid.TryParse(txtClienteID.Text, out idCliente);
        //    Guid.TryParse(txtBoxUsuario.Text, out idUsuario);
        //    DateTime fechaAlta = dtpFechaVenta.Value;
        //    int estado;
        //    int.TryParse(txtEstado.Text, out estado);

        //    Venta venta = new Venta(idVenta, idCliente, carrito.Items.Select(i => i.IdProducto).ToList(), carrito.Items.Select(i => i.Cantidad).ToList(), fechaAlta, estado, idUsuario);
        //    VentaService ventaService = new VentaService();

        //    string respuestaNuevaVenta = ventaService.AgregarVenta(venta);

        //    MessageBox.Show($"Venta {respuestaNuevaVenta} fue agregada exitosamente!");
        //    carrito.LimpiarCarrito();
        //    ActualizarVistaCarrito();
        //}

        private void btnGuardarVenta_Click(object sender, EventArgs e)
        {
            //PresentacionValidaciones validaciones = new PresentacionValidaciones();
            //if (!validaciones.ValidarControles(this, out string mensajeError))
            //{
            //    MessageBox.Show(mensajeError, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            //Guid idVenta = Guid.NewGuid();
            //Guid idCliente;
            //Guid idUsuario;
            //Guid idProducto;

            //Guid.TryParse(txtClienteID.Text, out idCliente);
            //Guid.TryParse(txtProductoID.Text, out idProducto);
            //Guid.TryParse(txtBoxUsuario.Text, out idUsuario);

            ////TODO: Añadir metodo validar int de cantidad y estado
            //int cantidad;
            //int.TryParse(txtCantidad.Text, out cantidad);

            //int estado;
            //int.TryParse(txtEstado.Text, out estado);

            //DateTime fechaAlta = dtpFechaVenta.Value;

            //Venta venta = new Venta(idVenta, idCliente, idProducto, cantidad, fechaAlta, estado, idUsuario);
            //VentaService ventaService = new VentaService();

            //string respuestaNuevaVenta = ventaService.AgregarVenta(venta);

            //MessageBox.Show($"Venta {respuestaNuevaVenta} fue agregada exitosamente!");
        }

        private void btnCancelarOperacion_Click(object sender, EventArgs e)
        {
            //Message box para confirmar cancelacion de operacion
            DialogResult dialogResult = MessageBox.Show("¿Está seguro que desea cancelar la operación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
                return;

            //Cancelar operacion y limpiar controles
            txtBoxNombreProd.Text = "";
            LimpiarCamposProducto();
            txtBoxDniCliente.Text = "";
            LimpiarCamposCliente();
            carrito = null;
            productoBusqueda = null;
            clienteBusqueda = null;

            PresentacionUtils.HabilitarControles(txtBoxDniCliente);
            btnBuscarCliente.Enabled = true;
        }


    }
}
