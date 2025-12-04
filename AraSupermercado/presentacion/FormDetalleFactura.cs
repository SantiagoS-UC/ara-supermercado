using AraSupermercado.logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AraSupermercado.presentacion
{
    public partial class FormDetalleFactura : Form
    {
        private Factura facturaLogica;
        private Factura facturaActual;
        private int ventCodigo;
        private FormMenuAdmin formMenuAdmin;
        private Action<Form> AbrirSubMenu;

        public FormDetalleFactura(int codigoVenta, FormMenuAdmin parent, Action<Form> abrirSubMenu)
        {
            InitializeComponent();
            this.ventCodigo = codigoVenta;
            this.formMenuAdmin = parent;
            this.AbrirSubMenu = abrirSubMenu;
            this.facturaLogica = new Factura();

            ConfigurarDataGridView();
            CargarDetalleFactura();
        }

        private void ConfigurarDataGridView()
        {
            // Configuración general
            dgvProductos.AutoGenerateColumns = false;
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.ReadOnly = true;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.RowHeadersVisible = false;
            dgvProductos.BackgroundColor = Color.White;
            dgvProductos.BorderStyle = BorderStyle.FixedSingle;
            dgvProductos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvProductos.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 224, 192);
            dgvProductos.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvProductos.EnableHeadersVisualStyles = false;
            dgvProductos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 111, 33);
            dgvProductos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvProductos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            dgvProductos.ColumnHeadersHeight = 35;
            dgvProductos.RowTemplate.Height = 30;

            // Columnas según tu imagen
            dgvProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ProductoNombre",
                HeaderText = "Producto",
                Name = "colProducto",
                Width = 300
            });

            dgvProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Cantidad",
                HeaderText = "Cantidad",
                Name = "colCantidad",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });

            dgvProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "PrecioUnitario",
                HeaderText = "Precio Unitario",
                Name = "colPrecioUnitario",
                Width = 150,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "$#,##0.00", Alignment = DataGridViewContentAlignment.MiddleRight }
            });

            dgvProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Subtotal",
                HeaderText = "Subtotal",
                Name = "colSubtotal",
                Width = 150,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "$#,##0.00", Alignment = DataGridViewContentAlignment.MiddleRight }
            });
        }

        private void CargarDetalleFactura()
        {
            try
            {
                // Cargar información de la factura
                facturaActual = facturaLogica.ObtenerFacturaCompleta(ventCodigo);

                if (facturaActual == null)
                {
                    MessageBox.Show("No se encontró la factura.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }

                // Cargar datos en controles según tu imagen
                lblCodigoValor.Text = $"# {facturaActual.pedCodigo}";
                lblClienteValor.Text = facturaActual.clienteNombre;
                lblDireccionValor.Text = facturaActual.pedDireccionEnvio;
                lblIdPedidoValor.Text = $"# {facturaActual.pedCodigo}";
                lblFechaValor.Text = facturaActual.ventFecha.ToString("dd/MM/yyyy HH:mm");
                lblEstadoValor.Text = facturaActual.pedEstado;
                lblMetodoPagoValor.Text = facturaActual.pedMetodoPago;

                // Aplicar color al estado
                switch (facturaActual.pedEstado)
                {
                    case "Confirmado":
                        lblEstadoValor.BackColor = Color.FromArgb(209, 231, 255);
                        break;
                    case "Procesando":
                    case "En proceso":
                        lblEstadoValor.BackColor = Color.FromArgb(209, 231, 255);
                        break;
                    case "Enviado":
                        lblEstadoValor.BackColor = Color.FromArgb(230, 224, 255);
                        break;
                    case "Entregado":
                        lblEstadoValor.BackColor = Color.FromArgb(209, 250, 229);
                        break;
                    default:
                        lblEstadoValor.BackColor = Color.White;
                        break;
                }

                // Cargar productos
                List<DetalleFacturaItem> productos = facturaLogica.ObtenerProductosFactura(ventCodigo);
                dgvProductos.DataSource = productos;

                // Calcular y mostrar total
                decimal total = 0;
                foreach (var item in productos)
                {
                    total += item.Subtotal;
                }
                lblTotalValor.Text = string.Format("$ {0:#,##0.00}", total);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar detalle: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            // Volver a la lista de facturas
            AbrirSubMenu(new FormConsultarFacturas(formMenuAdmin, AbrirSubMenu));
            this.Close();
        }
    }
}
