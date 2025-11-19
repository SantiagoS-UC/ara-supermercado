using AraSupermercado.accesoDatos;
using AraSupermercado.logica;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace AraSupermercado.presentacion
{
    public partial class UcFacturaPedido : UserControl
    {
        private Cliente clienteActual;
        private int pedCodigo;
        private string direccionEnvio;
        private string metodoPago;
        private FormMenuCliente menuCliente;  

        private Label lblTitulo;
        private Label lblCliente;
        private Label lblDireccion;
        private Label lblMetodoPago;
        private ListView lvDetalles;  
        private Label lblTotal;
        private Button btnAceptar;
        private Button btnVerPedidos;

        // Constructor
        public UcFacturaPedido(int pedCodigo, Cliente cliente, string direccion, string metodo, FormMenuCliente menu)
        {
            this.pedCodigo = pedCodigo;
            this.clienteActual = cliente;
            this.direccionEnvio = direccion;
            this.metodoPago = metodo;
            this.menuCliente = menu;

            InicializarComponentes();
            CargarFactura();
        }

        public event EventHandler VerPedidosSolicitado;

        public event EventHandler AceptarSolicitado;


        private void InicializarComponentes()
        {
            this.Dock = DockStyle.Fill;
            this.BackColor = Color.WhiteSmoke;

            lblTitulo = new Label()
            {
                Text = "Resumen del Pedido",
                Font = new Font("Segoe UI", 18, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(40, 20)
            };

            lblCliente = new Label()
            {
                Text = $"Cliente: {clienteActual.cliPrimerNombre} {clienteActual.cliPrimerApellido}",
                Font = new Font("Segoe UI", 12),
                AutoSize = true,
                Location = new Point(40, 60)
            };

            lblDireccion = new Label()
            {
                Text = $"Dirección de Envío: {direccionEnvio}",
                Font = new Font("Segoe UI", 12),
                AutoSize = true,
                Location = new Point(40, 90)
            };

            lblMetodoPago = new Label()
            {
                Text = $"Método de Pago: {metodoPago}",
                Font = new Font("Segoe UI", 12),
                AutoSize = true,
                Location = new Point(40, 120)
            };

            lvDetalles = new ListView()
            {
                Location = new Point(40, 160),
                Size = new Size(500, 200),
                View = View.Details,
                FullRowSelect = true
            };
            lvDetalles.Columns.Add("Producto", 200);
            lvDetalles.Columns.Add("Cantidad", 80);
            lvDetalles.Columns.Add("Precio Unitario", 100);
            lvDetalles.Columns.Add("Subtotal", 100);

            lblTotal = new Label()
            {
                Text = "Total: Calculando...",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(40, 380)
            };

            btnAceptar = new Button()
            {
                Text = "Aceptar",
                Location = new Point(40, 420),
                Size = new Size(120, 40),
                BackColor = Color.FromArgb(244, 119, 26),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            btnAceptar.Click += (s, e) => AceptarSolicitado?.Invoke(this, EventArgs.Empty); 

            btnVerPedidos = new Button()
            {
                Text = "Ver Pedidos",
                Location = new Point(180, 420),
                Size = new Size(120, 40),
                BackColor = Color.Gray,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            btnVerPedidos.Click += (s, e) => VerPedidosSolicitado?.Invoke(this, EventArgs.Empty);  

            this.Controls.AddRange(new Control[] { lblTitulo, lblCliente, lblDireccion, lblMetodoPago, lvDetalles, lblTotal, btnAceptar, btnVerPedidos });
        }

        // Carga detalles desde BD usando SP
        private void CargarFactura()
        {
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
                MessageBox.Show("Error al cargar factura: " + ex.Message);
            }
        }
    }
}