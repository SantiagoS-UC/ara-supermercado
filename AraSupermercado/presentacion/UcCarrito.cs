using AraSupermercado.logica;
using System;
using System.Drawing;
using System.IO;
using System.Linq; 
using System.Windows.Forms;
using static AraSupermercado.logica.Carrito;

namespace AraSupermercado.presentacion
{
    public partial class UcCarrito : UserControl
    {
        private Cliente clienteActual;
        private FormMenuCliente menuCliente;

        public UcCarrito(Cliente cliente, FormMenuCliente menu)
        {
            InitializeComponent();
            clienteActual = cliente;
            menuCliente = menu;
            // Asegúrate de que flpCarrito y lblTotal ya están inicializados en InitializeComponent()
            CargarCarrito();
        }

        private void CargarCarrito()
        {
            flpCarrito.Controls.Clear();  // Limpiar el contenedor de items

            var items = Carrito.ObtenerItems();
            int totalProductos = 0;

            if (items.Count == 0)
            {
                Label lblVacio = new Label
                {
                    Text = "El carrito está vacío.",
                    AutoSize = true,
                    Font = new Font("Arial", 12, FontStyle.Italic)
                };
                flpCarrito.Controls.Add(lblVacio);
                // Asegúrate de que tienes un Label para el total en tu diseñador llamado lblTotal
                lblTotal.Text = "$ 0";
                return;
            }

            foreach (var item in items)
            {
                Panel itemCard = CrearItemCarrito(item);
                flpCarrito.Controls.Add(itemCard);
                totalProductos += item.Cantidad; // Calcular el número total de productos
            }

            // Actualizar el total y el contador de productos
            lblTotal.Text = $"$ {Carrito.ObtenerTotal().ToString("N0")}";
        }

        /// <summary>
        /// Crea un Panel que representa un ítem del carrito, simulando el diseño horizontal.
        /// </summary>
        private Panel CrearItemCarrito(ItemCarrito item)
        {
            // Usamos la altura de 120 para centrar mejor
            int cardHeight = 120;
            int cardWidth = 1180;
            int center_Y = cardHeight / 2; // El centro vertical es 60

            // Panel principal del item (simula una fila)
            Panel card = new Panel
            {
                Size = new Size(cardWidth, cardHeight),
                BorderStyle = BorderStyle.None,
                Margin = new Padding(0, 5, 0, 5),
                BackColor = Color.White
            };

            // Simula el separador con un borde inferior o un Panel/Label de línea
            Panel separator = new Panel
            {
                Size = new Size(card.Width, 1),
                Location = new Point(0, card.Height - 1),
                BackColor = Color.LightGray
            };
            card.Controls.Add(separator);

            // --- 1. Imagen (Aumentada a 80x80) ---
            int picSize = 80;
            int picY = center_Y - (picSize / 2); // Centrado verticalmente: 60 - 40 = 20

            PictureBox picProducto = new PictureBox
            {
                Size = new Size(picSize, picSize),
                Location = new Point(20, picY), // Aumentamos la separación izquierda
                SizeMode = PictureBoxSizeMode.StretchImage,
                Cursor = Cursors.Hand
            };
            if (File.Exists(item.Producto.prodImagenRuta))
            {
                picProducto.Image = Image.FromFile(item.Producto.prodImagenRuta);
            }
            else
            {
                picProducto.Image = Properties.Resources.defaultImage;
            }
            picProducto.Click += (s, e) => menuCliente.MostrarProductoDetalle(item.Producto);
            card.Controls.Add(picProducto);

            // --- 2. Nombre (Ubicado a la derecha de la imagen) ---
            Label lblNombre = new Label
            {
                Text = item.Producto.prodNombre,
                Location = new Point(picProducto.Right + 20, picY + 10), // A 20px de la imagen, con offset
                AutoSize = true,
                Font = new Font("Arial", 12, FontStyle.Bold), // Hacemos el nombre más grande
                Cursor = Cursors.Hand
            };
            lblNombre.Click += (s, e) => menuCliente.MostrarProductoDetalle(item.Producto);
            card.Controls.Add(lblNombre);

            // --- 3. Precio unitario (Ubicado debajo del nombre) ---
            Label lblPrecio = new Label
            {
                Text = $"$ {item.Producto.prodPrecio.ToString("N0")}",
                Location = new Point(lblNombre.Left, lblNombre.Bottom + 5), // Debajo del nombre
                AutoSize = true,
                Font = new Font("Arial", 11, FontStyle.Regular)
            };
            card.Controls.Add(lblPrecio);

            // --- 4. Controles de Cantidad (Grupo de botones y Label) ---

            // Movemos el grupo de cantidad mucho más a la derecha para usar el nuevo ancho.
            int x_start = cardWidth - 300; 
            int btnSize = 35; // Botones más grandes
            int labelWidth = 45; // Label de cantidad más ancho
            int controlY = center_Y - (btnSize / 2); // Centrado verticalmente

            // Botón Menos (-)
            Button btnMenos = new Button
            {
                Text = "-",
                Size = new Size(btnSize, btnSize),
                Location = new Point(x_start, controlY),
                Tag = item.Producto.prodCodigo,
                Font = new Font("Arial", 14, FontStyle.Bold) // Fuente más grande
            };
            btnMenos.Click += (s, e) => AjustarCantidad(((Button)s).Tag.ToString(), -1);
            card.Controls.Add(btnMenos);

            // Label de Cantidad
            Label lblCantidad = new Label
            {
                Text = item.Cantidad.ToString(),
                Size = new Size(labelWidth, btnSize),
                Location = new Point(btnMenos.Right, controlY),
                TextAlign = ContentAlignment.MiddleCenter,
                BorderStyle = BorderStyle.FixedSingle,
                Font = new Font("Arial", 12, FontStyle.Regular)
            };
            lblCantidad.Tag = item.Producto.prodCodigo;
            card.Controls.Add(lblCantidad);

            // Botón Más (+)
            Button btnMas = new Button
            {
                Text = "+",
                Size = new Size(btnSize, btnSize),
                Location = new Point(lblCantidad.Right, controlY),
                Tag = item.Producto.prodCodigo,
                Font = new Font("Arial", 14, FontStyle.Bold)
            };
            btnMas.Click += (s, e) => AjustarCantidad(((Button)s).Tag.ToString(), 1);
            card.Controls.Add(btnMas);

            // --- 5. Botón de Eliminar (Papelera) ---
            int btnTrashSize = 40;

            Button btnEliminar = new Button
            {
                Text = "🗑️",
                Size = new Size(btnTrashSize, btnTrashSize),
                Location = new Point(cardWidth - btnTrashSize - 30, center_Y - (btnTrashSize / 2)), // Posicionado cerca del borde derecho
                FlatStyle = FlatStyle.Flat,
                FlatAppearance = { BorderSize = 0, MouseOverBackColor = Color.Transparent },
                BackColor = Color.Transparent,
                Font = new Font("Segoe UI Symbol", 16), // Asegura que el ícono se vea bien
                Tag = item.Producto.prodCodigo
            };
            btnEliminar.Click += (s, e) => QuitarItemCompleto(((Button)s).Tag.ToString());
            card.Controls.Add(btnEliminar);

            return card;
        }

        // Nuevo: Función para ajustar la cantidad (incrementar/decrementar)
        private void AjustarCantidad(string prodCodigoString, int cambio)
        {
            if (int.TryParse(prodCodigoString, out int prodCodigo))
            {
                var item = Carrito.ObtenerItems().FirstOrDefault(i => i.Producto.prodCodigo == prodCodigo);
                if (item != null)
                {
                    int nuevaCantidad = item.Cantidad + cambio;

                    if (nuevaCantidad > 0)
                    {                        
                        if (cambio == 1)
                        {
                            Carrito.AgregarProducto(item.Producto, 1);
                        }
                        else if (cambio == -1)
                        {
                            Carrito.QuitarProducto(prodCodigo, 1);
                        }
                    }
                    else if (nuevaCantidad == 0)
                    {
                        // Si la cantidad llega a 0, eliminar el ítem completo
                        QuitarItemCompleto(prodCodigo.ToString());
                        return;
                    }

                    CargarCarrito(); // Recargar el carrito para actualizar la UI
                }
            }
        }

        // Modificado: Función para quitar el ítem completo (usada por el botón de papelera)
        private void QuitarItemCompleto(string prodCodigoString)
        {
            if (int.TryParse(prodCodigoString, out int prodCodigo))
            {
                var item = Carrito.ObtenerItems().FirstOrDefault(i => i.Producto.prodCodigo == prodCodigo);
                if (item != null)
                {
                    // Quitar toda la cantidad
                    Carrito.QuitarProducto(prodCodigo, item.Cantidad);
                    CargarCarrito(); // Recargar el carrito
                }
            }
        }


        // Mantener el evento de Confirmar Pedido
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (Carrito.ObtenerItems().Count == 0)
            {
                MessageBox.Show("El carrito está vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Muestra UC en modal
            using (Form modal = new Form { Text = "Datos de Envío y Pago", Size = new Size(450, 400), StartPosition = FormStartPosition.CenterParent })
            {
                UcDatosEnvioPago ucDatos = new UcDatosEnvioPago(clienteActual);
                ucDatos.DatosConfirmados += (s, args) =>
                {
                    try
                    {
                        int pedCodigo = Carrito.ConfirmarPedido(ucDatos.DireccionSeleccionada, ucDatos.MetodoPagoSeleccionado);

                        if (pedCodigo <= 0)
                        {
                            MessageBox.Show("Error: No se pudo generar el código del pedido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        using (Form modalFactura = new Form { Text = "Factura del Pedido", Size = new Size(600, 500), StartPosition = FormStartPosition.CenterParent })
                        {
                            UcFacturaPedido ucFactura = new UcFacturaPedido(pedCodigo, clienteActual, ucDatos.DireccionSeleccionada, ucDatos.MetodoPagoSeleccionado, menuCliente);

                            ucFactura.AceptarSolicitado += (send, evt) =>
                            {
                                modalFactura.Close();
                                menuCliente.MostrarPaginaPrincipal();
                            };

                            ucFactura.VerPedidosSolicitado += (send, evt) =>
                            {
                                modalFactura.Close();
                                menuCliente.AbrirSubMenu(new UcVerPedidos(clienteActual, menuCliente));
                            };

                            modalFactura.Controls.Add(ucFactura);
                            modalFactura.ShowDialog();
                        }
                        modal.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al confirmar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    modal.Close();
                };

                modal.Controls.Add(ucDatos);
                modal.ShowDialog();
            }
        }

        // Mantener el evento de Volver
        private void btnVolver_Click(object sender, EventArgs e)
        {
            menuCliente.MostrarPaginaPrincipal();
        }
    }
}