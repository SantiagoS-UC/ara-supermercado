using AraSupermercado.logica;
using System;
using System.Windows.Forms;

namespace AraSupermercado.presentacion
{
    public partial class FormMenuAdmin : Form
    {
        private FormPanelAdminProducto formPanel;
        private Administrador admin;

        public FormMenuAdmin()
        {
            InitializeComponent();
            admin = new Administrador();
        }

        private void FormMenuAdmin_Load(object sender, EventArgs e)
        {
            try
            {
                // Integra el catálogo en pnlContenedor
                formPanel = new FormPanelAdminProducto("Catalogo", admin, this, AbrirSubMenu);
                formPanel.TopLevel = false;  
                formPanel.FormBorderStyle = FormBorderStyle.None;  
                formPanel.Dock = DockStyle.Fill;  
                pnlContenedor.Controls.Add(formPanel);  
                formPanel.Show();  
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar catálogo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void subMenuProductos_Click(object sender, EventArgs e)
        {
            AbrirSubMenu(new FormPanelAdminProducto("Catalogo", admin, this, AbrirSubMenu));
        }

        private void subMenuRegistrarProducto_Click(object sender, EventArgs e)
        {
            AbrirSubMenu(new FormPanelAdminProducto("Registro", admin, this, AbrirSubMenu));
        }

        private void subMenuPedidos_Click(object sender, EventArgs e)
        {
            try
            {
                AbrirSubMenu(new FormConsultarPedidos(this, AbrirSubMenu));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir pedidos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void subMenuFacturas_Click(object sender, EventArgs e)
        {
            try
            {
                AbrirSubMenu(new FormConsultarFacturas(this, AbrirSubMenu));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir facturas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void subMenuCerrarSesion_Click(object sender, EventArgs e)
        {
            // Oculta FormMenuAdmin
            this.Hide();

            // Muestra FormLogin (asume que hay una instancia global o estática; si no, crea una nueva)
            // Opción 1: Si FormLogin es singleton o tienes una referencia
            FormLogin loginForm = Application.OpenForms["FormLogin"] as FormLogin;
            if (loginForm != null)
            {
                loginForm.Show();
            }
            else
            {
                // Opción 2: Crea una nueva instancia si no hay referencia
                new FormLogin().Show();
            }
        }
    }
}