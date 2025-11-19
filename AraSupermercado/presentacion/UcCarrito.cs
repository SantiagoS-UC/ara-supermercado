using AraSupermercado.logica;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

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
            CargarCarrito();
        }

        private void CargarCarrito()
        {
            flpCarrito.Controls.Clear();  

            var items = Carrito.ObtenerItems();
            if (items.Count == 0)
            {
                Label lblVacio = new Label
                {
                    Text = "El carrito está vacío.",
                    AutoSize = true,
                    Font = new Font("Arial", 12, FontStyle.Italic)
                };
                flpCarrito.Controls.Add(lblVacio);
                lblTotal.Text = "Total: $0";
                return;
            }

            foreach (var item in items)
            {
                // Crear card horizontal para cada item
                Panel card = new Panel
                {
                    Size = new Size(400, 100),  
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(10)
                };

                // Imagen pequeña (clickeable para detalle)
                PictureBox picProducto = new PictureBox
                {
                    Size = new Size(80, 80),
                    Location = new Point(10, 10),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Cursor = Cursors.Hand  // Indica clickeable
                };
                if (File.Exists(item.Producto.prodImagenRuta))
                {
                    picProducto.Image = Image.FromFile(item.Producto.prodImagenRuta);
                }
                else
                {
                    picProducto.Image = Properties.Resources.defaultImage;
                }
                picProducto.Click += (s, e) => menuCliente.MostrarProductoDetalle(item.Producto);  // Click para detalle
                card.Controls.Add(picProducto);

                // Nombre (clickeable)
                Label lblNombre = new Label
                {
                    Text = item.Producto.prodNombre,
                    Location = new Point(100, 10),
                    AutoSize = true,
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    Cursor = Cursors.Hand
                };
                lblNombre.Click += (s, e) => menuCliente.MostrarProductoDetalle(item.Producto);  // Click para detalle
                card.Controls.Add(lblNombre);

                // Precio unitario
                Label lblPrecio = new Label
                {
                    Text = $"Precio: ${item.Producto.prodPrecio}",
                    Location = new Point(100, 30),
                    AutoSize = true
                };
                card.Controls.Add(lblPrecio);

                // Cantidad
                Label lblCantidad = new Label
                {
                    Text = $"Cantidad: {item.Cantidad}",
                    Location = new Point(100, 50),
                    AutoSize = true
                };
                card.Controls.Add(lblCantidad);

                // Subtotal
                Label lblSubtotal = new Label
                {
                    Text = $"Subtotal: ${item.Subtotal}",
                    Location = new Point(200, 50),
                    AutoSize = true,
                    Font = new Font("Arial", 9, FontStyle.Italic)
                };
                card.Controls.Add(lblSubtotal);

                // Botón Quitar
                Button btnQuitar = new Button
                {
                    Text = "Quitar",
                    Location = new Point(300, 30),
                    Size = new Size(80, 30)
                };
                btnQuitar.Click += (s, e) => QuitarItem(item.Producto.prodCodigo);
                card.Controls.Add(btnQuitar);

                flpCarrito.Controls.Add(card);
            }

            lblTotal.Text = $"Total: ${Carrito.ObtenerTotal()}";
        }

        // Quitar item del carrito
        private void QuitarItem(int prodCodigo)
        {
            var item = Carrito.ObtenerItems().Find(i => i.Producto.prodCodigo == prodCodigo);
            if (item != null)
            {
                Carrito.QuitarProducto(prodCodigo, item.Cantidad);
                CargarCarrito(); 
            }
        }

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

        // Volver a página principal
        private void btnVolver_Click(object sender, EventArgs e)
        {
            menuCliente.MostrarPaginaPrincipal();
        }
    }
}
