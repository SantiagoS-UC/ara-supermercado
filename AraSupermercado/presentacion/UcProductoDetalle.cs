using AraSupermercado.logica;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AraSupermercado.presentacion
{
    public partial class UcProductoDetalle : UserControl
    {
        private Producto producto;
        private Cliente clienteActual;
        private FormMenuCliente menuCliente;
        private int cantidad = 1;

        public UcProductoDetalle(Producto producto, Cliente cliente, FormMenuCliente menu)
        {
            InitializeComponent();
            this.producto = producto;
            this.clienteActual = cliente;
            this.menuCliente = menu;
            CargarDetallesProducto();
        }

        // Cargar detalles del producto
        private void CargarDetallesProducto()
        {
            lblNombre.Text = producto.prodNombre;
            lblDescripcion.Text = producto.prodDescripcion;
            lblPrecio.Text = $"${producto.prodPrecio}";
            lblCantidad.Text = cantidad.ToString();

            // Imagen
            if (File.Exists(producto.prodImagenRuta))
            {
                picProductoDetalle.Image = Image.FromFile(producto.prodImagenRuta);
            }
            else
            {
                picProductoDetalle.Image = Properties.Resources.defaultImage;
            }
        }

        // Aumentar cantidad
        private void btnAumentar_Click(object sender, EventArgs e)
        {
            if (cantidad < producto.prodStock)
            {
                cantidad++;
                lblCantidad.Text = cantidad.ToString();
            }
            else
            {
                MessageBox.Show("No hay suficiente stock.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Disminuir cantidad
        private void btnDisminuir_Click(object sender, EventArgs e)
        {
            if (cantidad > 1)
            {
                cantidad--;
                lblCantidad.Text = cantidad.ToString();
            }
        }

        // Añadir al carrito
        private void btnAnadirCarrito_Click(object sender, EventArgs e)
        {
            try
            {
                Carrito.AgregarProducto(producto, cantidad);
                MessageBox.Show($"{cantidad} x {producto.prodNombre} añadido(s) al carrito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Volver a página principal
                menuCliente.MostrarPaginaPrincipal();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al añadir al carrito: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Cerrar (volver a página principal)
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            menuCliente.MostrarPaginaPrincipal();
        }
    }
}