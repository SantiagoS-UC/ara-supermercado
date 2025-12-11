using AraSupermercado.accesoDatos;
using AraSupermercado.logica;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace AraSupermercado.presentacion
{
    public partial class UcVerPedidos : UserControl
    {
        private Cliente clienteActual;
        private FormMenuCliente menuCliente;
        private ListView lvPedidos;

        public UcVerPedidos(Cliente cliente, FormMenuCliente menu)
        {
            clienteActual = cliente;
            menuCliente = menu;
            InicializarComponentes();
            CargarPedidos();
        }

        private void InicializarComponentes()
        {
            // --- Configuración del UserControl padre ---
            this.Dock = DockStyle.Fill; 
            this.BackColor = Color.WhiteSmoke;
            this.SuspendLayout(); 

            // Título
            Label lblTitulo = new Label()
            {
                Text = "Mis Pedidos",
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(40, 20)
            };

            // --- ListView de Pedidos (Ajuste de Estiramiento) ---
            lvPedidos = new ListView()
            {
                Location = new Point(40, 60),
                Size = new Size(100, 100),
                View = View.Details,
                FullRowSelect = true,
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right
            };

            // Definición de columnas
            lvPedidos.Columns.Add("Código", 80);
            lvPedidos.Columns.Add("Estado", 100);
            lvPedidos.Columns.Add("Fecha Creación", 150);
            lvPedidos.Columns.Add("Dirección Envío", 200); 
            lvPedidos.Columns.Add("Método Pago", 150);     

            lvPedidos.DoubleClick += LvPedidos_DoubleClick;

            this.Controls.AddRange(new Control[] { lblTitulo, lvPedidos });
            this.ResumeLayout(); 
        }

        // Carga pedidos usando SP
        private void CargarPedidos()
        {
            lvPedidos.Items.Clear();
            try
            {
                using (OracleConnection conn = new ConexionOracle().ObtenerConexion())
                {
                    conn.Open();
                    using (OracleCommand cmd = new OracleCommand("pkg_pedido.pa_obtener_pedidos_cliente", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("p_cli_id", OracleDbType.Int32).Value = clienteActual.cliId;
                        cmd.Parameters.Add("p_result", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int codigo = reader.GetInt32(0);
                                string estado = reader.GetString(1);
                                DateTime fecha = reader.GetDateTime(2);
                                string direccion = reader.GetString(3);
                                string metodo = reader.GetString(4);

                                ListViewItem item = new ListViewItem(codigo.ToString());
                                item.SubItems.Add(estado);
                                item.SubItems.Add(fecha.ToString("dd/MM/yyyy"));
                                item.SubItems.Add(direccion);
                                item.SubItems.Add(metodo);
                                lvPedidos.Items.Add(item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar pedidos: " + ex.Message);
            }
        }

        // Evento doble clic: Muestra detalles en modal
        private void LvPedidos_DoubleClick(object sender, EventArgs e)
        {
            if (lvPedidos.SelectedItems.Count > 0)
            {
                int pedCodigo = int.Parse(lvPedidos.SelectedItems[0].Text);

                // Usamos un tamaño más grande para el modal de detalles
                using (Form modal = new Form { Text = "Detalles del Pedido", Size = new Size(600, 500), StartPosition = FormStartPosition.CenterParent })
                {
                    UcDetallePedido ucDetalle = new UcDetallePedido(pedCodigo);
                    modal.Controls.Add(ucDetalle);
                    modal.ShowDialog();
                }
            }
        }
    }

    public class UcDetallePedido : UserControl
    {
        private int pedCodigo;
        private ListView lvDetalles;
        private Label lblTotal;

        public UcDetallePedido(int pedCodigo)
        {
            this.pedCodigo = pedCodigo;
            InicializarComponentes();
            CargarDetalles();
        }

        private void InicializarComponentes()
        {
            // --- Configuración del UserControl padre ---
            this.Dock = DockStyle.Fill;
            this.BackColor = Color.WhiteSmoke;
            this.SuspendLayout();

            // Suscribirse al evento Load para fijar la posición después del redimensionamiento
            this.Load += UcDetallePedido_Load;

            // --- ListView de Detalles (Ajuste de Estiramiento) ---
            lvDetalles = new ListView()
            {
                Location = new Point(20, 20),
                Size = new Size(100, 100), // Tamaño inicial de marcador
                View = View.Details,
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom
            };
            lvDetalles.Columns.Add("Producto", 200);
            lvDetalles.Columns.Add("Cantidad", 80);
            lvDetalles.Columns.Add("Precio Unitario", 100);
            lvDetalles.Columns.Add("Subtotal", 100);

            // --- Label de Total ---
            lblTotal = new Label()
            {
                Text = "Total: Calculando...",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                Location = new Point(450, 440),
                AutoSize = true,
                Anchor = AnchorStyles.Bottom | AnchorStyles.Right
            };

            this.Controls.AddRange(new Control[] { lvDetalles, lblTotal });
            this.ResumeLayout();
        }

        /// <summary>
        /// Evento que se dispara después de que el UC ha sido agregado al modal y redimensionado.
        /// Aquí podemos asegurar que la posición inicial del Label sea correcta.
        /// </summary>
        private void UcDetallePedido_Load(object sender, EventArgs e)
        {
            const int MARGEN_DERECHO = 20;
            const int MARGEN_INFERIOR = 20;

            int newX = this.Width - lblTotal.Width - MARGEN_DERECHO;

            int newY = this.Height - lblTotal.Height - MARGEN_INFERIOR;

            lblTotal.Location = new Point(newX, newY);
            lvDetalles.Height = newY - 30; 
        }

        private void CargarDetalles()
        {
            lvDetalles.Items.Clear();
            decimal total = 0;
            try
            {
                using (OracleConnection conn = new ConexionOracle().ObtenerConexion())
                {
                    conn.Open();
                    using (OracleCommand cmd = new OracleCommand("pkg_pedido.pa_obtener_detalle_pedido", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("p_ped_codigo", OracleDbType.Int32).Value = pedCodigo;
                        cmd.Parameters.Add("p_result", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string producto = reader.GetString(1);
                                int cantidad = reader.GetInt32(2);
                                decimal precio = reader.GetDecimal(3);
                                decimal subtotal = reader.GetDecimal(4);

                                ListViewItem item = new ListViewItem(producto);
                                item.SubItems.Add(cantidad.ToString());
                                item.SubItems.Add($"${precio:F2}");
                                item.SubItems.Add($"${subtotal:F2}");
                                lvDetalles.Items.Add(item);

                                total += subtotal;
                            }
                        }
                    }
                }
                lblTotal.Text = $"Total: ${total:F2}";
            }
            catch (Exception ex)
            {
                lblTotal.Text = "Total: Error";
                MessageBox.Show("Error al cargar detalles: " + ex.Message);
            }
        }
    }
}