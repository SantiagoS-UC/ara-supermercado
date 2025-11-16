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
                formPanel = new FormPanelAdminProducto("Catalogo", admin);
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

        private void subMenuProductos_Click(object sender, EventArgs e)
        {
            AbrirSubMenu(new FormPanelAdminProducto("Catalogo", admin));
        }

        private void subMenuRegistrarProducto_Click(object sender, EventArgs e)
        {
            AbrirSubMenu(new FormPanelAdminProducto("Registro", admin));
        }
    }
}