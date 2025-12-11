using System;
using AraSupermercado.logica;
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
    public partial class FormDetallePedido : Form
    {
        private Pedido pedidoLogica;
        private Pedido pedidoActual;
        private int pedidoCodigo;
        private FormMenuAdmin formMenuAdmin;
        private Action<Form> AbrirSubMenu;
        private string estadoOriginal;

        public FormDetallePedido(int pedCodigo, FormMenuAdmin parent, Action<Form> abrirSubMenu)
        {
            InitializeComponent();
            this.pedidoCodigo = pedCodigo;
            this.formMenuAdmin = parent;
            this.AbrirSubMenu = abrirSubMenu;
            this.pedidoLogica = new Pedido();

            ConfigurarDataGridView();
            CargarEstadosComboBox();
            CargarDetallePedido();
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

            // Columnas
            dgvProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ProductoNombre",
                HeaderText = "Producto",
                Name = "colProducto",
                Width = 250
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

        private void CargarEstadosComboBox()
        {
            cbxEstadoActual.Items.Add("Pendiente");
            cbxEstadoActual.Items.Add("Confirmado");
            cbxEstadoActual.Items.Add("Enviado");
            cbxEstadoActual.Items.Add("Entregado");
            cbxEstadoActual.Items.Add("Cancelado");
        }

        private void CargarDetallePedido()
        {
            try
            {
                // Cargar info del pedido
                pedidoActual = pedidoLogica.ObtenerDetallePedido(pedidoCodigo);

                if (pedidoActual == null)
                {
                    MessageBox.Show("No se encontró el pedido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }

                // Cargar datos en controles
                lblIdPedidoValor.Text = $"# {pedidoActual.pedCodigo}";
                lblFechaValor.Text = pedidoActual.pedFechaCreacion.ToString("dd/MM/yyyy HH:mm");
                cbxEstadoActual.SelectedItem = pedidoActual.pedEstado;
                estadoOriginal = pedidoActual.pedEstado;

                // Cargar productos
                List<DetallePedidoItem> productos = pedidoLogica.ObtenerProductosPedido(pedidoCodigo);
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

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            if (cbxEstadoActual.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un estado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nuevoEstado = cbxEstadoActual.SelectedItem.ToString();

            // Verificar si cambió el estado
            if (nuevoEstado == estadoOriginal)
            {
                MessageBox.Show("No se detectaron cambios en el estado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Validar transiciones de estado permitidas
            if (!ValidarTransicionEstado(estadoOriginal, nuevoEstado))
            {
                MessageBox.Show($"No se puede cambiar de '{estadoOriginal}' a '{nuevoEstado}'.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirmar cambio
            DialogResult result = MessageBox.Show(
                $"¿Confirma el cambio de estado de '{estadoOriginal}' a '{nuevoEstado}'?",
                "Confirmar Cambio",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    bool exito = pedidoLogica.ActualizarEstadoPedido(pedidoCodigo, nuevoEstado);

                    if (exito)
                    {
                        MessageBox.Show("Estado actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Volver a la lista de pedidos
                        AbrirSubMenu(new FormConsultarPedidos(formMenuAdmin, AbrirSubMenu));
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Validar transiciones de estado permitidas
        private bool ValidarTransicionEstado(string estadoActual, string nuevoEstado)
        {
            // Reglas de negocio para transiciones de estado
            switch (estadoActual)
            {
                case "Pendiente":
                    return nuevoEstado == "Confirmado" || nuevoEstado == "Cancelado";

                case "Confirmado":
                    return nuevoEstado == "Enviado" || nuevoEstado == "Cancelado";

                case "Enviado":
                    return nuevoEstado == "Entregado" || nuevoEstado == "Cancelado";

                case "Entregado":
                case "Cancelado":
                    return false; // Estados finales, no se pueden cambiar

                default:
                    return false;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            // Volver a la lista de pedidos
            AbrirSubMenu(new FormConsultarPedidos(formMenuAdmin, AbrirSubMenu));
            this.Close();
        }
    }
}
