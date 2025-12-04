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
    public partial class FormConsultarFacturas : Form
    {
        private Factura facturaLogica;
        private FormMenuAdmin formMenuAdmin;
        private Action<Form> AbrirSubMenu;

        public FormConsultarFacturas(FormMenuAdmin parent, Action<Form> abrirSubMenu)
        {
            InitializeComponent();
            this.formMenuAdmin = parent;
            this.AbrirSubMenu = abrirSubMenu;
            this.facturaLogica = new Factura();

            ConfigurarDataGridView();
            _ = CargarFacturasAsync();
        }

        private void ConfigurarDataGridView()
        {
            // Configuración general
            dgvFacturas.AutoGenerateColumns = false;
            dgvFacturas.AllowUserToAddRows = false;
            dgvFacturas.AllowUserToDeleteRows = false;
            dgvFacturas.ReadOnly = true;
            dgvFacturas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFacturas.MultiSelect = false;
            dgvFacturas.RowHeadersVisible = false;
            dgvFacturas.BackgroundColor = Color.White;
            dgvFacturas.BorderStyle = BorderStyle.None;
            dgvFacturas.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvFacturas.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 224, 192);
            dgvFacturas.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvFacturas.EnableHeadersVisualStyles = false;
            dgvFacturas.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 111, 33);
            dgvFacturas.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvFacturas.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvFacturas.ColumnHeadersHeight = 40;
            dgvFacturas.RowTemplate.Height = 35;

            // Columnas según tu imagen
            dgvFacturas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ventCodigo",
                HeaderText = "Código",
                Name = "colCodigo",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });

            dgvFacturas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "pedEstado",
                HeaderText = "Estado",
                Name = "colEstado",
                Width = 150
            });

            dgvFacturas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ventFecha",
                HeaderText = "Fecha Creación",
                Name = "colFecha",
                Width = 150,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" }
            });

            dgvFacturas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "pedDireccionEnvio",
                HeaderText = "Dirección Envío",
                Name = "colDireccion",
                Width = 250
            });

            dgvFacturas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "pedMetodoPago",
                HeaderText = "Método Pago",
                Name = "colMetodoPago",
                Width = 180
            });

            // Evento de doble clic
            dgvFacturas.CellDoubleClick += DgvFacturas_CellDoubleClick;
        }

        private async Task CargarFacturasAsync()
        {
            dgvFacturas.DataSource = null;
            lblMensaje.Text = "Cargando facturas...";
            lblMensaje.Visible = true;

            try
            {
                List<Factura> facturas = await Task.Run(() => facturaLogica.ObtenerTodasFacturas());

                if (facturas.Count == 0)
                {
                    lblMensaje.Text = "No se encontraron facturas.";
                    lblMensaje.Visible = true;
                }
                else
                {
                    lblMensaje.Visible = false;
                    dgvFacturas.DataSource = facturas;
                }
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Error al cargar facturas.";
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvFacturas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int ventCodigo = Convert.ToInt32(dgvFacturas.Rows[e.RowIndex].Cells["colCodigo"].Value);
                AbrirFormDetalle(ventCodigo);
            }
        }

        private void AbrirFormDetalle(int ventCodigo)
        {
            FormDetalleFactura formDetalle = new FormDetalleFactura(ventCodigo, formMenuAdmin, AbrirSubMenu);
            AbrirSubMenu(formDetalle);
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            await CargarFacturasAsync();
        }
    }
}