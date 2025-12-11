using AraSupermercado.logica;
using System;
using System.Windows.Forms;

namespace AraSupermercado.presentacion
{
    public partial class FormMenuCliente : Form
    {
        private Cliente clienteActual;

        public FormMenuCliente(Cliente cliente)
        {
            InitializeComponent();
            clienteActual = cliente;
            Carrito.EstablecerCliente(clienteActual.cliId);
            MostrarPaginaPrincipal();
        }

        public void AbrirSubMenu(Form subMenu)
        {
            // Limpia cualquier control previo en el panel
            pnlContenedor.Controls.Clear();

            // Configura el formulario hijo
            subMenu.TopLevel = false;
            subMenu.FormBorderStyle = FormBorderStyle.None;
            subMenu.Dock = DockStyle.Fill;

            // Agrega el formulario al panel y lo muestra
            pnlContenedor.Controls.Add(subMenu);
            pnlContenedor.Tag = subMenu;
            subMenu.Show();
        }

        public void AbrirSubMenu(UserControl subMenu)
        {
            pnlContenedor.Controls.Clear();
            subMenu.Dock = DockStyle.Fill;
            pnlContenedor.Controls.Add(subMenu);
            pnlContenedor.Tag = subMenu;
        }

        private void subMenuAdminCuenta_Click(object sender, EventArgs e)
        {
            AbrirSubMenu(new FormPanelUsuario("AdministrarCuenta", clienteActual));
        }

        private void subMenuVerPedidos_Click(object sender, EventArgs e)
        {
            AbrirSubMenu(new UcVerPedidos(clienteActual, this));
        }

        private void subMenuCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
        }

        private void subMenuPaginaPrincipal_Click(object sender, EventArgs e)
        {
            MostrarPaginaPrincipal();
        }

        public void MostrarProductoDetalle(Producto producto)
        {
            pnlContenedor.Controls.Clear();
            UcProductoDetalle detalle = new UcProductoDetalle(producto, clienteActual, this);
            detalle.Dock = DockStyle.Fill;
            pnlContenedor.Controls.Add(detalle);
        }

        private void subMenuCarrito_Click(object sender, EventArgs e)
        {
            pnlContenedor.Controls.Clear();
            UcCarrito carrito = new UcCarrito(clienteActual, this);
            carrito.Dock = DockStyle.Fill;
            pnlContenedor.Controls.Add(carrito);
        }

        public void MostrarPaginaPrincipal(string categoria = "Todas")
        {
            pnlContenedor.Controls.Clear();
            UcPaginaPrincipal pagina = new UcPaginaPrincipal(clienteActual, this, categoria);
            pagina.Dock = DockStyle.Fill;
            pnlContenedor.Controls.Add(pagina);
        }

        // Eventos para categorías 
        private void subMenuFrutasVerduras_Click(object sender, EventArgs e)
        {
            MostrarPaginaPrincipal("Frutas y Verduras");
        }

        private void subMenuCarnesPescados_Click(object sender, EventArgs e)
        {
            MostrarPaginaPrincipal("Carnes y Pescados");
        }

        private void subMenuLacteosHuevos_Click(object sender, EventArgs e)
        {
            MostrarPaginaPrincipal("Lácteos y Huevos");
        }

        private void subMenuPanaderiaPasteleria_Click(object sender, EventArgs e)
        {
            MostrarPaginaPrincipal("Panadería y Pastelería");
        }

        private void subMenuAbarrotesEnlatados_Click(object sender, EventArgs e)
        {
            MostrarPaginaPrincipal("Abarrotes y Enlatados");
        }

        private void subMenuBebidas_Click(object sender, EventArgs e)
        {
            MostrarPaginaPrincipal("Bebidas");
        }

        private void subMenuLimpiezaHogar_Click(object sender, EventArgs e)
        {
            MostrarPaginaPrincipal("Limpieza y Hogar");
        }

        private void subMenuHigiene_Click(object sender, EventArgs e)
        {
            MostrarPaginaPrincipal("Cuidado Personal e Higiene");
        }

        private void subMenuSnacks_Click(object sender, EventArgs e)
        {
            MostrarPaginaPrincipal("Snacks y Dulces");
        }

        private void subMenuOtros_Click(object sender, EventArgs e)
        {
            MostrarPaginaPrincipal("Otros");
        }
    }
}