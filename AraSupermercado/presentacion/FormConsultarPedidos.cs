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
    public partial class FormConsultarPedidos : Form
    {
        private Pedido pedidoLogica;
        private FormMenuAdmin formMenuAdmin;
        private Action<Form> AbrirSubMenu;

        public FormConsultarPedidos(FormMenuAdmin parent, Action<Form> abrirSubMenu)
        {
            InitializeComponent();
            this.formMenuAdmin = parent;
            this.AbrirSubMenu = abrirSubMenu;
            this.pedidoLogica = new Pedido();

            ConfigurarDataGridView();
            CargarEstadosComboBox();
            _ = CargarPedidosAsync();
        }

        private void ConfigurarDataGridView()
        {
            // Configuración general
            dgvPedidos.AutoGenerateColumns = false;
            dgvPedidos.AllowUserToAddRows = false;
            dgvPedidos.AllowUserToDeleteRows = false;
            dgvPedidos.ReadOnly = true;
            dgvPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPedidos.MultiSelect = false;
            dgvPedidos.RowHeadersVisible = false;
            dgvPedidos.BackgroundColor = Color.White;
            dgvPedidos.BorderStyle = BorderStyle.None;
            dgvPedidos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPedidos.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 224, 192);
            dgvPedidos.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvPedidos.EnableHeadersVisualStyles = false;
            dgvPedidos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 111, 33);
            dgvPedidos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvPedidos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvPedidos.ColumnHeadersHeight = 40;
            dgvPedidos.RowTemplate.Height = 35;

            // Columnas
            dgvPedidos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "pedCodigo",
                HeaderText = "ID Pedido",
                Name = "colCodigo",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });

            dgvPedidos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "cliNombreCompleto",
                HeaderText = "Cliente",
                Name = "colCliente",
                Width = 250
            });

            dgvPedidos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "pedFechaCreacion",
                HeaderText = "Fecha",
                Name = "colFecha",
                Width = 150,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy HH:mm" }
            });

            // Columna Estado con colores (se pinta manualmente)
            dgvPedidos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "pedEstado",
                HeaderText = "Estado",
                Name = "colEstado",
                Width = 150
            });

            dgvPedidos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "pedTotal",
                HeaderText = "Total",
                Name = "colTotal",
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "$#,##0.00", Alignment = DataGridViewContentAlignment.MiddleRight }
            });

            // Evento para pintar celdas de estado con colores
            dgvPedidos.CellPainting += DgvPedidos_CellPainting;

            // Evento de doble clic para abrir detalles
            dgvPedidos.CellDoubleClick += DgvPedidos_CellDoubleClick;
        }

        private void CargarEstadosComboBox()
        {
            cbxFiltroEstado.Items.Add("Todos");
            cbxFiltroEstado.Items.Add("Pendiente");
            cbxFiltroEstado.Items.Add("Confirmado");
            cbxFiltroEstado.Items.Add("Enviado");
            cbxFiltroEstado.Items.Add("Entregado");
            cbxFiltroEstado.Items.Add("Cancelado");
            cbxFiltroEstado.SelectedIndex = 0;
        }

        private async Task CargarPedidosAsync(string estadoFiltro = null)
        {
            dgvPedidos.DataSource = null;
            lblMensaje.Text = "Cargando pedidos...";
            lblMensaje.Visible = true;

            try
            {
                List<Pedido> pedidos;

                if (string.IsNullOrEmpty(estadoFiltro) || estadoFiltro == "Todos")
                {
                    pedidos = await Task.Run(() => pedidoLogica.ObtenerTodosPedidos());
                }
                else
                {
                    pedidos = await Task.Run(() => pedidoLogica.ObtenerPedidosPorEstado(estadoFiltro));
                }

                if (pedidos.Count == 0)
                {
                    lblMensaje.Text = "No se encontraron pedidos.";
                    lblMensaje.Visible = true;
                }
                else
                {
                    lblMensaje.Visible = false;
                    dgvPedidos.DataSource = pedidos;
                }
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Error al cargar pedidos.";
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Pintar celdas de estado con colores según tu imagen
        private void DgvPedidos_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == dgvPedidos.Columns["colEstado"].Index && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.ContentForeground);

                string estado = e.Value?.ToString();
                if (!string.IsNullOrEmpty(estado))
                {
                    Color colorFondo = Color.White;
                    Color colorTexto = Color.Black;

                    switch (estado)
                    {
                        case "Pendiente":
                            colorFondo = Color.FromArgb(255, 243, 205); // Amarillo suave
                            break;
                        case "Confirmado":
                        case "Enviado":
                            colorFondo = Color.FromArgb(230, 224, 255); // Morado suave
                            break;
                        case "Entregado":
                            colorFondo = Color.FromArgb(209, 250, 229); // Verde suave
                            break;
                        case "Cancelado":
                            colorFondo = Color.FromArgb(254, 226, 226); // Rojo suave
                            break;
                    }

                    // Dibujar rectángulo con padding (estilo badge)
                    Rectangle badgeRect = new Rectangle(
                        e.CellBounds.X + 10,
                        e.CellBounds.Y + 5,
                        e.CellBounds.Width - 20,
                        e.CellBounds.Height - 10
                    );

                    using (SolidBrush brush = new SolidBrush(colorFondo))
                    {
                        e.Graphics.FillRectangle(brush, badgeRect);
                    }

                    // Dibujar texto centrado
                    TextRenderer.DrawText(
                        e.Graphics,
                        estado,
                        e.CellStyle.Font,
                        badgeRect,
                        colorTexto,
                        TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
                    );
                }

                e.Handled = true;
            }
        }

        // Doble clic para abrir detalle
        private void DgvPedidos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int pedidoCodigo = Convert.ToInt32(dgvPedidos.Rows[e.RowIndex].Cells["colCodigo"].Value);
                AbrirFormDetalle(pedidoCodigo);
            }
        }

        private void AbrirFormDetalle(int pedidoCodigo)
        {
            FormDetallePedido formDetalle = new FormDetallePedido(pedidoCodigo, formMenuAdmin, AbrirSubMenu);
            AbrirSubMenu(formDetalle);
        }

        private async void cbxFiltroEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            string estadoSeleccionado = cbxFiltroEstado.SelectedItem.ToString();
            await CargarPedidosAsync(estadoSeleccionado == "Todos" ? null : estadoSeleccionado);
        }

        private async void btnLimpiarFiltro_Click(object sender, EventArgs e)
        {
            cbxFiltroEstado.SelectedIndex = 0;
            await CargarPedidosAsync();
        }
    }
}
