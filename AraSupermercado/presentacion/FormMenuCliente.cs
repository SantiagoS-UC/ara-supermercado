using AraSupermercado.logica;
using System;
using System.Drawing;
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
        }

        private void AbrirSubMenu(Form subMenu)
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

        private void subMenuAdminCuenta_Click(object sender, EventArgs e)
        {
            AbrirSubMenu(new FormPanelUsuario("AdministrarCuenta", clienteActual));
        }

        private void subMenuVerPedidos_Click(object sender, EventArgs e)
        {
            AbrirSubMenu(new FormPanelUsuario("VerPedidos", clienteActual));
        }

        private void subMenuCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
        }
    }
}