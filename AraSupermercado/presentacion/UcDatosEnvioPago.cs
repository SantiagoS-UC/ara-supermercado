using AraSupermercado.accesoDatos;  
using AraSupermercado.logica;       
using Oracle.ManagedDataAccess.Client;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AraSupermercado.presentacion
{
    public partial class UcDatosEnvioPago : UserControl
    {
        private Cliente clienteActual;
        private Label lblTitulo;
        private Label lblDireccion;
        private ComboBox cbDirecciones;
        private TextBox txtNuevaDireccion;
        private Label lblMetodoPago;
        private ComboBox cbMetodoPago;
        private Button btnContinuar;

        public string DireccionSeleccionada { get; private set; }
        public string MetodoPagoSeleccionado { get; private set; }
        public event EventHandler DatosConfirmados;

        public UcDatosEnvioPago()
        {
            InicializarComponentes();
            ConfigurarEventos();
        }

        public UcDatosEnvioPago(Cliente cliente) : this()  
        {
            clienteActual = cliente;
            CargarDirecciones();  
        }

        private void InicializarComponentes()
        {
            this.Dock = DockStyle.Fill;
            this.BackColor = Color.WhiteSmoke;

            lblTitulo = new Label()
            {
                Text = "Datos de Envío y Método de Pago",
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(40, 30)
            };

            lblDireccion = new Label()
            {
                Text = "Dirección de envío:",
                Font = new Font("Segoe UI", 11),
                AutoSize = true,
                Location = new Point(40, 90)
            };

            cbDirecciones = new ComboBox()
            {
                Location = new Point(40, 120),
                Width = 350,
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cbDirecciones.Items.Add("Ingresar nueva dirección...");

            txtNuevaDireccion = new TextBox()
            {
                Location = new Point(40, 160),
                Width = 350,
                Visible = false
            };

            lblMetodoPago = new Label()
            {
                Text = "Método de Pago:",
                Font = new Font("Segoe UI", 11),
                AutoSize = true,
                Location = new Point(40, 220)
            };

            cbMetodoPago = new ComboBox()
            {
                Location = new Point(40, 250),
                Width = 350,
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cbMetodoPago.Items.AddRange(new string[] { "Tarjeta de crédito", "Transferencia", "PSE" });
            cbMetodoPago.SelectedIndex = 0;

            btnContinuar = new Button()
            {
                Text = "Continuar",
                Location = new Point(40, 330),
                Width = 160,
                Height = 40,
                BackColor = Color.FromArgb(244, 119, 26),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };

            this.Controls.AddRange(new Control[] { lblTitulo, lblDireccion, cbDirecciones, txtNuevaDireccion, lblMetodoPago, cbMetodoPago, btnContinuar });
        }

        private void ConfigurarEventos()
        {
            cbDirecciones.SelectedIndexChanged += (s, e) =>
            {
                txtNuevaDireccion.Visible = (cbDirecciones.SelectedItem?.ToString() == "Ingresar nueva dirección...");
            };

            btnContinuar.Click += (s, e) =>
            {
                if (cbDirecciones.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione una dirección de envío");
                    return;
                }

                if (cbDirecciones.SelectedItem.ToString() == "Ingresar nueva dirección..." && string.IsNullOrWhiteSpace(txtNuevaDireccion.Text))
                {
                    MessageBox.Show("Ingrese una nueva dirección válida.");
                    return;
                }

                DireccionSeleccionada = cbDirecciones.SelectedItem.ToString() == "Ingresar nueva dirección..." ? txtNuevaDireccion.Text : cbDirecciones.SelectedItem.ToString();
                MetodoPagoSeleccionado = cbMetodoPago.SelectedItem.ToString();
                DatosConfirmados?.Invoke(this, EventArgs.Empty);
            };
        }

        // Carga direcciones del cliente desde BD
        private void CargarDirecciones()
        {
            if (clienteActual == null) return;

            try
            {
                using (OracleConnection conn = new ConexionOracle().ObtenerConexion())
                {
                    conn.Open();
                    using (OracleCommand cmd = new OracleCommand("SELECT dir_cliente FROM direccion WHERE cli_id = :cli_id", conn))
                    {
                        cmd.Parameters.Add("cli_id", OracleDbType.Int32).Value = clienteActual.cliId;
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cbDirecciones.Items.Add(reader.GetString(0));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar direcciones: " + ex.Message);
            }
        }
    }
}
