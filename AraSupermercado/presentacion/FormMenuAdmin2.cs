using AraSupermercado.accesoDatos;
using AraSupermercado.logica;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace AraSupermercado.presentacion
{
    // En FormMenuAdmin2.cs
    public partial class FormMenuAdmin2 : Form
    {
        private FormPanelAdminProducto formPanel;
        private Administrador admin;

        public FormMenuAdmin2()
        {
            InitializeComponent();
            admin = new Administrador();

        }

        // Evento Load para mostrar catálogo automáticamente
        private void FormMenuAdmin2_Load(object sender, EventArgs e)
        {
            try
            {
                // Integra el catálogo en pnlContenedor
                formPanel = new FormPanelAdminProducto("Catalogo", admin);
                formPanel.TopLevel = false;  // No es formulario independiente
                formPanel.FormBorderStyle = FormBorderStyle.None;  // Sin bordes
                formPanel.Dock = DockStyle.Fill;  // Llena el contenedor
                pnlContenedor.Controls.Add(formPanel);  // Agrega al panel
                formPanel.Show();  // Muestra
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

        // Evento para submenú "Ver Productos" (abre FormPanelAdminProducto en modo catálogo)
        private void subMenuProductos_Click(object sender, EventArgs e)
        {
            AbrirSubMenu(new FormPanelAdminProducto("Catalogo", admin));
        }

        // Evento para submenú "Registrar Producto" (abre FormPanelAdminProducto en modo registro)
        private void subMenuRegistrarProducto_Click(object sender, EventArgs e)
        {
            AbrirSubMenu(new FormPanelAdminProducto("Registro", admin));
        }
    }
}