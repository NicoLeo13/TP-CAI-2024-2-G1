using FontAwesome.Sharp;
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
        private CarritoService carritoService;
        /*DataGrid*/
        private CarritoService dataGridCarrito;
        private DataGridService dataGridService;
        private BindingSource bindingSource;
        private bool sortAscending = true;
        private DataGridViewColumn sortedColumn = null;
        private UsuarioWS usuario;

        public frmVendNuevaVenta(UsuarioWS usuarioWs)
        {
            InitializeComponent();
            ConfigurarTabIndex();
            dataGridService = new DataGridService();
            usuario = usuarioWs;
        }

        //Metodo para configurar el TabIndex de los controles (txtBox)
        private void ConfigurarTabIndex()
        {

        }

        private void InstanciarCarritoService()
        {
            if (carritoService == null)
                carritoService = new CarritoService();
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            //Buscar producto por Nombre
            LimpiarCamposProducto();

            if (clienteBusqueda == null)
            {
                MessageBox.Show("Primero debe buscar un cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBoxDniCliente.Focus();
                return;
            }

            if (txtBoxNombreProd.Text == "")
            {
                MessageBox.Show("Ingrese el nombre del producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBoxNombreProd.Focus();
                return;
            }

            try
            {
                InstanciarCarritoService();
                productoBusqueda = ProductoService.BuscarProducto(txtBoxNombreProd.Text);

                if (productoBusqueda == null)
                {
                    MessageBox.Show("El producto de nombre: " + txtBoxNombreProd.Text + " no fue encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                ItemCarrito itemYaEnCarrito = carritoService.ProductoYaAgregadoCarrito(productoBusqueda);
                if (itemYaEnCarrito != null)
                {
                    productoBusqueda.Stock -= itemYaEnCarrito.Cantidad;
                }

                if (productoBusqueda.Stock <= 0)
                {
                    MessageBox.Show("El producto seleccionado no tiene stock disponible", "Falta de Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                lblContIdProd.Text = productoBusqueda.Id.ToString();
                lblContPrecio.Text = $"$ {productoBusqueda.Precio}";
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
            lblContPrecioFinal.Text = "";
            lblContStockFinal.Text = "";
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
            if (clienteBusqueda == null)
            {
                MessageBox.Show("Primero debe buscar un cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBoxDniCliente.Focus();
                return;
            }
            else if (productoBusqueda == null)
            {
                MessageBox.Show("Primero debe buscar un producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBoxNombreProd.Focus();
                return;
            }
            else if (cmbCantidad.SelectedIndex <= -1)
            {
                MessageBox.Show("Seleccione una cantidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                InstanciarCarritoService();
                //InstanciarDataGridCarrito();
                //Ver para mandarle lo que requiere la API + Datos adicionales para mostrar en datagridview
                int cantidad = int.Parse(cmbCantidad.Text);
                carritoService.AgregarProducto(productoBusqueda, cantidad, clienteBusqueda);
                carritoService.GuardarStockProductoLocal(productoBusqueda, cantidad);
                txtBoxNombreProd.Text = "";
                LimpiarCamposProducto();
                LlenarDataGridView();
                ActualizarLabelTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el producto al carrito", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"\nError al agregar el producto al carrito - {ex.Message}");
            }
        }

        private void ActualizarLabelTotal()
        {
            if (carritoService == null || carritoService.CantidadProductosEnCarrito() == 0)
            {
                if (lblTotal.Text != "Total: $ 0")
                    lblTotal.Text = "Total: $ 0";
                return;
            }
            lblTotal.Text = $"Total: $ {carritoService.CalcularTotalCarrito()}";
        }

        private void btnGuardarVenta_Click(object sender, EventArgs e)
        {
            if (clienteBusqueda == null)
            {
                MessageBox.Show("Primero debe buscar un cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBoxDniCliente.Focus();
                return;
            }
            else if (productoBusqueda == null)
            {
                MessageBox.Show("Primero debe buscar un producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBoxNombreProd.Focus();
                return;
            }
            else if (carritoService == null || carritoService.CantidadProductosEnCarrito() == 0)
            {
                MessageBox.Show("El carrito esta vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                const String userPrueba = "ff738cd6-cc08-42e9-b15f-1f258084b0f9"; // Flag-hardcode
                Guid idUserPrueba = Guid.Parse(userPrueba);

                DialogResult dialogResult = MessageBox.Show("¿Está seguro que desea guardar la venta?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.No)
                    return;

                VentaService ventaService = new VentaService();
                List<ItemCarrito> itemsCarrito = carritoService.ObtenerItemsCarrito();
                foreach (ItemCarrito item in itemsCarrito)
                {
                    Venta venta = new Venta(item.IdCliente, usuario.Id, item.IdProducto, item.Cantidad);
                    //Venta venta = new Venta(item.IdCliente, idUserPrueba, item.IdProducto, item.Cantidad);
                    ventaService.AgregarVenta(venta);
                }

                MessageBox.Show($"Venta fue agregada exitosamente!\nCliente DNI: {clienteBusqueda.Dni}\nTotal: ${carritoService.CalcularTotalCarrito()}", "Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FinalizarOperacion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar la venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"\nError al guardar la venta - {ex.Message}");
            }
        }

        private void btnEliminarDelCarrito_Click(object sender, EventArgs e)
        {
            if (carritoService == null || carritoService.CantidadProductosEnCarrito() == 0)
            {
                MessageBox.Show("El carrito esta vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (dgvCarrito.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un item del carrito", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Message box para confirmar eliminacion de item
            DialogResult dialogResult = MessageBox.Show("¿Está seguro que desea eliminar el item del carrito?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.No)
                return;

            try
            {
                //Obtener el item seleccionado
                ItemCarrito itemSeleccionado = carritoService.ObtenerItemsCarrito().ElementAt(dgvCarrito.CurrentRow.Index);
                carritoService.EliminarItemCarrito(itemSeleccionado);
                LlenarDataGridView();
                ActualizarLabelTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el item del carrito", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"\nError al eliminar el item del carrito - {ex.Message}");
            }
        }

        private void EliminarItemCarrito(ItemCarrito item)
        {
            try
            {
                carritoService.EliminarItemCarrito(item);
                LlenarDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el item del carrito", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"\nError al eliminar el item del carrito - {ex.Message}");
            }
        }

        private void btnCancelarOperacion_Click(object sender, EventArgs e)
        {
            //Message box para confirmar cancelacion de operacion
            DialogResult dialogResult = MessageBox.Show("¿Está seguro que desea cancelar la operación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
                return;

            //Cancelar operacion y limpiar controles
            FinalizarOperacion();
        }

        private void FinalizarOperacion()
        {
            txtBoxNombreProd.Text = "";
            LimpiarCamposProducto();
            txtBoxDniCliente.Text = "";
            LimpiarCamposCliente();
            carritoService = null;
            productoBusqueda = null;
            clienteBusqueda = null;

            PresentacionUtils.HabilitarControles(txtBoxDniCliente);
            btnBuscarCliente.Enabled = true;
            ActualizarLabelTotal();

            //Limpiar DataGridView
            dgvCarrito.DataSource = null;
        }

        /******
              Logica DataGrid
        ******/
        private void ConfigurarDataGridView()
        {
            //lblUsuariosTotales.Text = $"Total: {usuariosActivos.Count.ToString()}";

            // Habilitar ordenamiento
            foreach (DataGridViewColumn column in dgvCarrito.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Programmatic;
            }
        }

        private void LlenarDataGridView()
        {
            // Usar BindingSource para permitir filtrado
            bindingSource = new BindingSource();
            dataGridCarrito = carritoService;

            bindingSource.DataSource = dataGridCarrito.ObtenerItemsCarrito().Select(item => new
            {
                item.Categoria,
                item.Descripcion,
                item.Cantidad,
                item.PrecioUnitario,
                item.Subtotal
            }).ToList();

            dgvCarrito.DataSource = bindingSource;
        }

        private void dgvCarrito_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewColumn newColumn = dgvCarrito.Columns[e.ColumnIndex];
                if (newColumn != sortedColumn)
                    sortAscending = true;

                var columna = dgvCarrito.Columns[e.ColumnIndex].DataPropertyName;
                dataGridCarrito.CarritoManager.carrito.Items = dataGridService.OrdenarCarrito(dataGridCarrito.ObtenerItemsCarrito(), columna, sortAscending);

                sortAscending = !sortAscending;
                LlenarDataGridView();

                // Actualizar el indicador visual
                sortedColumn = dgvCarrito.Columns[e.ColumnIndex];
                foreach (DataGridViewColumn column in dgvCarrito.Columns)
                {
                    if (column != sortedColumn)
                        column.HeaderCell.SortGlyphDirection = SortOrder.None;
                }
                sortedColumn.HeaderCell.SortGlyphDirection = sortAscending ? SortOrder.Ascending : SortOrder.Descending;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ordenar la tabla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"\nError al ordenar la tabla - {ex.Message}");
            }
        }

        private void cmbCantidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (productoBusqueda != null && cmbCantidad.SelectedIndex > -1)
            {
                int cantidad = int.Parse(cmbCantidad.Text);
                lblContPrecioFinal.Text = $"$ {productoBusqueda.Precio * cantidad}";

                lblContStockFinal.Text = (productoBusqueda.Stock - cantidad).ToString();
            }
        }
    }
}
