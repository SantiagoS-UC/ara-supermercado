using AraSupermercado.accesoDatos;
using AraSupermercado.logica;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AraSupermercado.presentacion
{
    public partial class FormPanelAdminProducto : Form
    {
        private Administrador administrador;
        private Producto prod = new Producto();
        private string opcionActual;
        private ErrorProvider errorProvider = new ErrorProvider();

        public FormPanelAdminProducto(string modo, Administrador admin)  // "Catalogo" o "Registro"
        {
            InitializeComponent();
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            this.opcionActual = modo;
            this.administrador = admin ?? throw new ArgumentNullException(nameof(admin));

            CargarVista();
        }

        private void CargarVista()
        {
            // Oculta todos los paneles
            pnlProductos.Visible = false;
            pnlRegistrarProducto.Visible = false;

            // Muestra el panel correspondiente y carga datos
            switch (opcionActual)
            {
                case "Catalogo":
                    pnlProductos.Visible = true;
                    // Carga catálogo automáticamente
                    _ = CargarProductosAsync();  // Llama asíncrona sin await
                    break;
                case "Registro":
                    pnlRegistrarProducto.Visible = true;
                    // No carga datos adicionales para registro
                    break;
            }
        }

        public void ActualizarVista(string nuevaOpcion)
        {
            this.opcionActual = nuevaOpcion;
            CargarVista();
        }

        // Método para cargar productos (filtrado opcional)
        private async Task CargarProductosAsync(string filtroNombre = "")
        {
            flowPanelProductos.Controls.Clear();
            flowPanelProductos.Refresh();
            lblMensaje.Text = "Cargando productos...";

            List<Producto> productos;
            if (string.IsNullOrEmpty(filtroNombre))
            {
                productos = await Task.Run(() => administrador.VerProductosAdmin());
            }
            else
            {
                productos = await Task.Run(() => administrador.BuscarProductos(filtroNombre));
            }

            if (productos.Count == 0)
            {
                lblMensaje.Text = string.IsNullOrEmpty(filtroNombre) ? "No hay productos registrados." : "No se encontraron productos.";
                return;
            }

            lblMensaje.Text = "";

            foreach (var prod in productos)
            {
                Panel panelProducto = CrearPanelProducto(prod);
                flowPanelProductos.Controls.Add(panelProducto);
            }
        }

        // Método para crear panel de producto
        private Panel CrearPanelProducto(Producto prod)
        {
            // Verifica si ya existe un panel con este código
            foreach (Control ctrl in flowPanelProductos.Controls)
            {
                if (ctrl is Panel panelProd && panelProd.Tag != null && (int)panelProd.Tag == prod.prodCodigo)
                {
                    return panelProd;  // Ya existe, no crear nuevo
                }
            }

            Panel panel = new Panel  // Asigna Tag para identificar
            {
                Size = new Size(280, 280),
                BackColor = Color.White,
                BorderStyle = BorderStyle.None,
                Margin = new Padding(15),
                Padding = new Padding(10),
                Tag = prod.prodCodigo
            };

            // PictureBox para imagen
            PictureBox pbImagen = new PictureBox
            {
                Size = new Size(120, 120),
                Location = new Point(10, 10),
                SizeMode = PictureBoxSizeMode.Zoom,  // Mantiene proporción
                BorderStyle = BorderStyle.None,
                BackColor = Color.White
            };
            try
            {
                pbImagen.Image = Image.FromFile(prod.prodImagenRuta);
            }
            catch
            {
                //pbImagen.Image = Image.FromFile("Resources/no-image.png");  // Imagen por defecto en carpeta Resources
            }
            panel.Controls.Add(pbImagen);

            // Labels con estilo

            // Nombre del producto
            Label lblNombre = new Label
            {
                Text = prod.prodNombre,
                Location = new Point(10, 140),
                AutoSize = true,
                MaximumSize = new Size(120, 0),
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = Color.Black
            };
            panel.Controls.Add(lblNombre);

            // Precio del producto
            Label lblPrecio = new Label
            {
                Text = $"${prod.prodPrecio:F2}",
                Location = new Point(10, lblNombre.Bottom + 5),
                AutoSize = true,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = Color.Black
            };
            panel.Controls.Add(lblPrecio);

            //Doble click a el panel para modificar
            panel.DoubleClick += (s, e) => AbrirFormModificar(prod);

            // Doble click a los controles internos para modificar
            pbImagen.DoubleClick += (s, e) => AbrirFormModificar(prod);
            lblNombre.DoubleClick += (s, e) => AbrirFormModificar(prod);
            lblPrecio.DoubleClick += (s, e) => AbrirFormModificar(prod);

            return panel;
        }


        // Método para abrir FormModificarProducto
        private async void AbrirFormModificar(Producto prod)
        {
            FormModificarProducto formModificar = new FormModificarProducto(prod);
            formModificar.ShowDialog();
            // Recargar catálogo después de modificar
            await CargarProductosAsync();
        }

        // Eventos para búsqueda en pnlProductos
        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            string filtro = txtBuscarProducto.Text.Trim();
            await CargarProductosAsync(filtro);
        }

        private async void btnLimpiarBusqueda_Click(object sender, EventArgs e)
        {
            txtBuscarProducto.Text = "";
            await CargarProductosAsync();
        }

        // Método para validar campos de registro de producto
        private bool ValidarCamposRegistro()
        {
            bool esValido = true;

            // Limpiar errores previos
            errorProvider.Clear();

            // Validación: Código
            if (string.IsNullOrWhiteSpace(txtCodigoProducto.Text))
            {
                errorProvider.SetError(txtCodigoProducto, "El código es obligatorio.");
                esValido = false;
            }
            else if (!int.TryParse(txtCodigoProducto.Text, out int codigo))
            {
                errorProvider.SetError(txtCodigoProducto, "El código debe ser un número entero.");
                esValido = false;
            }
            else if (codigo <= 0)
            {
                errorProvider.SetError(txtCodigoProducto, "El código debe ser mayor a 0.");
                esValido = false;
            }
            else if (txtCodigoProducto.Text.Length > 10)
            {
                errorProvider.SetError(txtCodigoProducto, "El código no debe exceder 10 dígitos.");
                esValido = false;
            }

            // Validación: Nombre
            if (string.IsNullOrWhiteSpace(txtNombreProducto.Text))
            {
                errorProvider.SetError(txtNombreProducto, "El nombre es obligatorio.");
                esValido = false;
            }
            else if (!Regex.IsMatch(txtNombreProducto.Text, @"^[a-zA-Z\d\s]+$"))
            {
                errorProvider.SetError(txtNombreProducto, "El nombre debe contener solo letras y espacios.");
                esValido = false;
            }
            else if (txtNombreProducto.Text.Length > 50)
            {
                errorProvider.SetError(txtNombreProducto, "El nombre no debe exceder 50 caracteres.");
                esValido = false;
            }

            // Validación: Precio
            if (string.IsNullOrWhiteSpace(txtPrecioProducto.Text))
            {
                errorProvider.SetError(txtPrecioProducto, "El precio es obligatorio.");
                esValido = false;
            }
            else if (!decimal.TryParse(txtPrecioProducto.Text, out decimal precio))
            {
                errorProvider.SetError(txtPrecioProducto, "El precio debe ser un número.");
                esValido = false;
            }
            else if (precio < 100m)
            {
                errorProvider.SetError(txtPrecioProducto, "El precio debe ser al menos 100.");
                esValido = false;
            }
            else if (precio > 200000m)
            {
                errorProvider.SetError(txtPrecioProducto, "El precio no debe exceder 200000.");
                esValido = false;
            }

            // Validación: Descripción
            if (string.IsNullOrWhiteSpace(txtDescripcionProducto.Text))
            {
                errorProvider.SetError(txtDescripcionProducto, "La descripción es obligatoria.");
                esValido = false;
            }
            else if (txtDescripcionProducto.Text.Length > 200)
            {
                errorProvider.SetError(txtDescripcionProducto, "La descripción no debe exceder 200 caracteres.");
                esValido = false;
            }

            // Validación: Estado
            if (cbxEstadoProducto.SelectedItem == null)
            {
                errorProvider.SetError(cbxEstadoProducto, "Debes seleccionar un estado para el producto.");
                esValido = false;
            }

            // Validación: Categoría
            if (cbxCategoria.SelectedItem == null)
            {
                errorProvider.SetError(cbxCategoria, "Debes seleccionar una categoría para el producto.");
                esValido = false;
            }

            // Validación: Imagen
            if (picProducto.Tag == null)
            {
                errorProvider.SetError(picProducto, "Debes seleccionar una imagen para el producto.");
                esValido = false;
            }

            // Si hay errores, mostrar mensaje y no continuar
            if (!esValido)
            {
                MessageBox.Show("Por favor corregir los campos señalados.", "Errores de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return esValido;
        }

        // Evento para registrar producto (asume btnRegistrarProducto)
        private void btnRegistrarProducto_Click(object sender, EventArgs e)
        {
            if (!ValidarCamposRegistro())
                return;

            try
            {
                // Copiar imagen al directorio del proyecto
                string carpetaDestino = Path.Combine(Application.StartupPath, "ImagenesProductos");
                if (!Directory.Exists(carpetaDestino))
                    Directory.CreateDirectory(carpetaDestino);

                string nombreArchivo = Path.GetFileName(picProducto.Tag.ToString());
                string rutaDestino = Path.Combine(carpetaDestino, nombreArchivo);

                // Evitar sobreescritura
                if (!File.Exists(rutaDestino))
                    File.Copy(picProducto.Tag.ToString(), rutaDestino, false);

                // Ruta relativa para almacenar en la base de datos
                string rutaRelativa = Path.Combine("ImagenesProductos", nombreArchivo);

                // Llamar a la función RegistrarProducto
                Administrador admin = new Administrador();
                if (admin.RegistrarProducto(
                    Convert.ToInt32(txtCodigoProducto.Text),
                    0,
                    txtNombreProducto.Text,
                    txtDescripcionProducto.Text,
                    cbxEstadoProducto.SelectedItem.ToString(),
                    Convert.ToDecimal(txtPrecioProducto.Text),
                    0,
                    rutaDestino,
                    cbxCategoria.SelectedItem.ToString()))
                {
                    MessageBox.Show("Producto registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al registrar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            txtCodigoProducto.Clear();
            txtNombreProducto.Clear();
            txtDescripcionProducto.Clear();
            txtPrecioProducto.Clear();
            cbxEstadoProducto.SelectedIndex = -1;
            picProducto.Image = null;
            picProducto.Tag = null;
            lblSeleccionarImagen.Visible = true;
            cbxCategoria.SelectedIndex = -1;
        }

        private void picProducto_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp";
            open.Title = "Seleccionar imagen del producto";

            if (open.ShowDialog() == DialogResult.OK)
            {
                // Validar archivo
                if (!File.Exists(open.FileName) || new FileInfo(open.FileName).Length == 0)
                {
                    MessageBox.Show("Archivo inválido o vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    using (var fs = new FileStream(open.FileName, FileMode.Open, FileAccess.Read, FileShare.Read))
                    using (var ms = new MemoryStream())
                    {
                        fs.CopyTo(ms);
                        ms.Position = 0;
                        using (var tmp = Image.FromStream(ms))
                        {
                            picProducto.Image?.Dispose();
                            picProducto.Image = new Bitmap(tmp); // copia independiente
                        }
                    }

                    lblSeleccionarImagen.Visible = false;
                    picProducto.Tag = open.FileName;
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("El archivo seleccionado no es una imagen válida o está corrupto.", "Imagen no válida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar la imagen: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void lblSeleccionarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp";
            open.Title = "Seleccionar imagen del producto";

            if (open.ShowDialog() == DialogResult.OK)
            {
                // Validar archivo
                if (!File.Exists(open.FileName) || new FileInfo(open.FileName).Length == 0)
                {
                    MessageBox.Show("Archivo inválido o vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    using (var fs = new FileStream(open.FileName, FileMode.Open, FileAccess.Read, FileShare.Read))
                    using (var ms = new MemoryStream())
                    {
                        fs.CopyTo(ms);
                        ms.Position = 0;
                        using (var tmp = Image.FromStream(ms))
                        {
                            picProducto.Image?.Dispose();
                            picProducto.Image = new Bitmap(tmp); // copia independiente
                        }
                    }

                    lblSeleccionarImagen.Visible = false;
                    picProducto.Tag = open.FileName;
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("El archivo seleccionado no es una imagen válida o está corrupto.", "Imagen no válida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar la imagen: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FormPanelAdminProducto_Load(object sender, EventArgs e)
        {
            CargarEstados();
            CargarCategorias();
        }

        private void CargarEstados()
        {
            cbxEstadoProducto.Items.Add("Activo");
            cbxEstadoProducto.Items.Add("Inactivo");
        }

        private void CargarCategorias()
        {
            string[] categorias = { "Frutas y Verduras", "Carnes y Pescados", "Lácteos y Huevos", "Panadería y Pastelería", "Abarrotes y Enlatados", "Bebidas", "Limpieza y Hogar", "Cuidado Personal", "Snacks y Dulces", "Otros" };
            cbxCategoria.Items.AddRange(categorias);
        }

        private void btnLimpiarRegistro_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}