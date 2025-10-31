using AraSupermercado.logica;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AraSupermercado.presentacion
{
    public partial class UcPaginaPrincipal : UserControl
    {
        private Cliente clienteActual;
        private FormMenuCliente menuCliente;
        private List<Producto> todosProductos;  // Todos los productos
        private string categoriaActual = "Todas";  // Categoría seleccionada

        public UcPaginaPrincipal(Cliente cliente, FormMenuCliente menu, string categoria = "Todas")
        {
            InitializeComponent();
            clienteActual = cliente;
            menuCliente = menu;
            categoriaActual = categoria;
            CargarProductos();
            ConfigurarComboBox();
        }

        // Configurar ComboBox con categorías
        private void ConfigurarComboBox()
        {
            cbxCategoria.Items.AddRange(new string[] {
            "Todas", "Frutas y Verduras", "Carnes y Pescados", "Lácteos y Huevos",
            "Panadería y Pastelería", "Abarrotes y Enlatados", "Bebidas",
            "Limpieza y Hogar", "Cuidado Personal e Higiene", "Snacks y Dulces", "Otros"
        });
            cbxCategoria.SelectedItem = categoriaActual;
            cbxCategoria.SelectedIndexChanged += CbxCategoria_SelectedIndexChanged;
        }

        // Evento al cambiar categoría
        private void CbxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            categoriaActual = cbxCategoria.SelectedItem.ToString();
            FiltrarProductos();
        }

        // Cargar todos los productos inicialmente
        private void CargarProductos()
        {
            try
            {
                Producto productoHelper = new Producto();
                todosProductos = productoHelper.ObtenerTodosProductos();
                FiltrarProductos();  // Aplica filtro inicial
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Mostrar productos en el FlowLayoutPanel
        private void MostrarProductos(List<Producto> listaProductos)
        {
            flpProductos.Controls.Clear();  // Limpia productos previos

            foreach (var producto in listaProductos)
            {
                try
                {
                    // Crear un "card" para cada producto (Panel con controles)
                    Panel card = new Panel
                    {
                        Size = new Size(220, 280),
                        BackColor = Color.White,
                        BorderStyle = BorderStyle.None,
                        Margin = new Padding(15),
                        Padding = new Padding(10)
                    };

                    card.BackColor = Color.FromArgb(248, 249, 250); // tono gris claro

                    // sombra sutil (truco: borde oscuro simulado)
                    card.Paint += (s, e) =>
                    {
                        ControlPaint.DrawBorder(e.Graphics, card.ClientRectangle,
                        Color.LightGray, 1, ButtonBorderStyle.Solid,
                        Color.LightGray, 1, ButtonBorderStyle.Solid,
                        Color.Gray, 2, ButtonBorderStyle.Solid,
                        Color.Gray, 2, ButtonBorderStyle.Solid);
                    };

                    // Imagen del producto (usando ruta completa desde BD)
                    PictureBox picProducto = new PictureBox
                    {
                        Size = new Size(180, 120),
                        Location = new Point(10, 10),
                        SizeMode = PictureBoxSizeMode.StretchImage
                    };
                    if (File.Exists(producto.prodImagenRuta))  // Ruta completa desde BD
                    {
                        picProducto.Image = Image.FromFile(producto.prodImagenRuta);
                    }
                    else
                    {
                        picProducto.Image = Properties.Resources.defaultImage;  // Imagen por defecto si no existe
                    }
                    card.Controls.Add(picProducto);

                    // Nombre
                    Label lblNombre = new Label
                    {
                        Text = producto.prodNombre,
                        Location = new Point(10, 140),
                        AutoSize = true
                    };
                    card.Controls.Add(lblNombre);

                    // Precio
                    Label lblPrecio = new Label
                    {
                        Text = $"${producto.prodPrecio}",
                        Location = new Point(10, 160),
                        AutoSize = true,
                        Font = new Font("Arial", 10, FontStyle.Bold)
                    };
                    card.Controls.Add(lblPrecio);

                    // Botón Añadir al Carrito
                    Button btnAnadir = new Button
                    {
                        Text = "Añadir al Carrito",
                        Location = new Point(10, 180),
                        Size = new Size(180, 30)
                    };
                    btnAnadir.Click += (s, e) => AnadirAlCarrito(producto);
                    btnAnadir.BackColor = Color.FromArgb(255, 105, 0);
                    btnAnadir.ForeColor = Color.White;
                    btnAnadir.FlatStyle = FlatStyle.Flat;
                    btnAnadir.FlatAppearance.BorderSize = 0;
                    btnAnadir.Cursor = Cursors.Hand;
                    btnAnadir.MouseEnter += (s, e) => btnAnadir.BackColor = Color.FromArgb(255, 128, 0);
                    btnAnadir.MouseLeave += (s, e) => btnAnadir.BackColor = Color.FromArgb(255, 105, 0);
                    card.Controls.Add(btnAnadir);

                    // Click en el card para vista detallada
                    card.Click += (s, e) => AbrirDetalleProducto(producto);

                    flpProductos.Controls.Add(card);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error creando card: " + ex.Message);
                }
            }
        }

        // Añadir producto al carrito
        private void AnadirAlCarrito(Producto producto)
        {
            Carrito.AgregarProducto(producto);
            MessageBox.Show($"{producto.prodNombre} añadido al carrito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Abrir vista detallada del producto
        private void AbrirDetalleProducto(Producto producto)
        {
            ((FormMenuCliente)this.ParentForm).MostrarProductoDetalle(producto);
        }

        // Filtrar y mostrar productos por categoría
        private void FiltrarProductos()
        {
            List<Producto> productosFiltrados;
            if (categoriaActual == "Todas")
            {
                productosFiltrados = todosProductos;
            }
            else
            {
                Producto productoHelper = new Producto();
                productosFiltrados = productoHelper.ObtenerProductosPorCategoria(categoriaActual);
            }
            MostrarProductos(productosFiltrados);
        }
    }
}
