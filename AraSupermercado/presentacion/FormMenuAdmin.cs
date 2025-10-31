/*
using AraSupermercado.accesoDatos;
using AraSupermercado.logica;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace AraSupermercado.presentacion
{
    public partial class FormMenuAdmin : Form
    {
        private Administrador admin;
        public FormMenuAdmin()
        { 
            InitializeComponent();
            admin = new Administrador();
            // Configurar TabControl para carga automática
            tbcMenuAdmin.SelectedIndexChanged += tbcMenuAdmin_SelectedIndexChanged;
            this.Load += AdminDashboard_Load; // Evento Load para inicializar

            // Evento para el botón de búsqueda
            btnBuscarProducto.Click += btnBuscarProducto_Click;

            // Evento para limpiar búsqueda
            btnLimpiarBusqueda.Click += BtnLimpiarBusqueda_Click;
        }

        // Carga automática de productos al iniciar el formulario
        private async void AdminDashboard_Load(object sender, EventArgs e)
        {
            if (tbcMenuAdmin.SelectedTab == tbpProductos)
            {
                await CargarProductosAsync();  // Carga automática al iniciar
            }
        }

        private async void tbcMenuAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbcMenuAdmin.SelectedTab == tbpProductos)
            {
                await CargarProductosAsync();  // Carga asíncrona para mejor rendimiento
            }
        }

        // Método asíncrono para cargar productos
        private async Task CargarProductosAsync(string filtroNombre = "")
        {
            flowPanelProductos.Controls.Clear();
            flowPanelProductos.Refresh();
            lblMensaje.Text = "Cargando productos...";

            List<Producto> productos;
            if (string.IsNullOrEmpty(filtroNombre))
            {
                productos = await Task.Run(() => admin.VerProductosAdmin());
            }
            else
            {
                productos = await Task.Run(() => admin.BuscarProductos(filtroNombre));
            }
            if (productos.Count == 0)
            {
                lblMensaje.Text = string.IsNullOrEmpty(filtroNombre) ? "No hay productos registrados." : "No se encontraron productos con ese nombre.";
                return;
            }
            lblMensaje.Text = $"{productos.Count} producto(s) encontrado(s).";

            txtBuscarProducto.Clear(); // Limpiar búsqueda después de cargar

            foreach (var prod in productos)
            {
                // Crear panel estilizado para cada producto
                Panel panelProducto = CrearPanelProducto(prod);
                flowPanelProductos.Controls.Add(panelProducto);
            }
        }

        // Método para crear un panel atractivo para cada producto
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

        // Método separado para abrir el formulario (para reutilización)
        private void AbrirFormModificar(Producto prod)
        {
            FormModificarProducto formModificar = new FormModificarProducto(prod);
            formModificar.ShowDialog();
            // Opcional: Recargar productos después
            // await CargarProductosAsync();
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


        private void btnRegistrarProducto_Click(object sender, EventArgs e)
        {
            // Limpiar errores previos
            errorProvider1.Clear();

            bool hayErrores = false;

            // Validación: Código
            if (string.IsNullOrWhiteSpace(txtCodigoProducto.Text))
            {
                errorProvider1.SetError(txtCodigoProducto, "El código es obligatorio.");
                hayErrores = true;
            }
            else if (!int.TryParse(txtCodigoProducto.Text, out int codigo))
            {
                errorProvider1.SetError(txtCodigoProducto, "El código debe ser un número entero.");
                hayErrores = true;
            }
            else if (codigo <= 0)
            {
                errorProvider1.SetError(txtCodigoProducto, "El código debe ser mayor a 0.");
                hayErrores = true;
            }
            else if (txtCodigoProducto.Text.Length > 10)
            {
                errorProvider1.SetError(txtCodigoProducto, "El código no debe exceder 10 dígitos.");
                hayErrores = true;
            }

            // Validación: Nombre
            if (string.IsNullOrWhiteSpace(txtNombreProducto.Text))
            {
                errorProvider1.SetError(txtNombreProducto, "El nombre es obligatorio.");
                hayErrores = true;
            }
            else if (!Regex.IsMatch(txtNombreProducto.Text, @"^[a-zA-Z\s]+$"))
            {
                errorProvider1.SetError(txtNombreProducto, "El nombre debe contener solo letras y espacios.");
                hayErrores = true;
            }
            else if (txtNombreProducto.Text.Length > 50)
            {
                errorProvider1.SetError(txtNombreProducto, "El nombre no debe exceder 50 caracteres.");
                hayErrores = true;
            }

            // Validación: Precio
            if (string.IsNullOrWhiteSpace(txtPrecioProducto.Text))
            {
                errorProvider1.SetError(txtPrecioProducto, "El precio es obligatorio.");
                hayErrores = true;
            }
            else if (!decimal.TryParse(txtPrecioProducto.Text, out decimal precio))
            {
                errorProvider1.SetError(txtPrecioProducto, "El precio debe ser un número.");
                hayErrores = true;
            }
            else if (precio < 100m)
            {
                errorProvider1.SetError(txtPrecioProducto, "El precio debe ser al menos 100.");
                hayErrores = true;
            }
            else if (precio > 200000m)
            {
                errorProvider1.SetError(txtPrecioProducto, "El precio no debe exceder 200000.");
                hayErrores = true;
            }

            // Validación: Descripción
            if (string.IsNullOrWhiteSpace(txtDescripcionProducto.Text))
            {
                errorProvider1.SetError(txtDescripcionProducto, "La descripción es obligatoria.");
                hayErrores = true;
            }
            else if (txtDescripcionProducto.Text.Length > 200)
            {
                errorProvider1.SetError(txtDescripcionProducto, "La descripción no debe exceder 200 caracteres.");
                hayErrores = true;
            }

            // Validación: Estado
            if (cbxEstadoProducto.SelectedItem == null)
            {
                errorProvider1.SetError(cbxEstadoProducto, "Debes seleccionar un estado para el producto.");
                hayErrores = true;
            }

            // Validación: Categoría
            if (cbxCategoria.SelectedItem == null)
            {
                errorProvider1.SetError(cbxCategoria, "Debes seleccionar una categoría para el producto.");
                hayErrores = true;
            }

            // Validación: Imagen
            if (picProducto.Tag == null)
            {
                errorProvider1.SetError(picProducto, "Debes seleccionar una imagen para el producto.");
                hayErrores = true;
            }

            // Si hay errores, mostrar mensaje y no continuar
            if (hayErrores)
            {
                MessageBox.Show("Por favor corregir los campos señalados.", "Errores de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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

                // Preparar los parámetros para el procedimiento almacenado
                var conexion = new ConexionOracle();

                string procedimiento = "pa_registrar_producto";

                using (OracleConnection conn = conexion.ObtenerConexion())
                using (OracleCommand cmd = new OracleCommand(procedimiento, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("p_codigo", OracleDbType.Int32).Value = Convert.ToInt32(txtCodigoProducto.Text);
                    cmd.Parameters.Add("p_nombre", OracleDbType.Varchar2).Value = txtNombreProducto.Text;
                    cmd.Parameters.Add("p_descripcion", OracleDbType.Varchar2).Value = txtDescripcionProducto.Text;
                    cmd.Parameters.Add("p_estado", OracleDbType.Varchar2).Value = cbxEstadoProducto.SelectedItem.ToString();
                    cmd.Parameters.Add("p_precio", OracleDbType.Decimal).Value = Convert.ToDecimal(txtPrecioProducto.Text);
                    cmd.Parameters.Add("p_imagen_ruta", OracleDbType.Varchar2).Value = rutaDestino;  // Usa rutaDestino o rutaRelativa según tu SP
                    cmd.Parameters.Add("p_categoria", OracleDbType.Varchar2).Value = cbxCategoria.SelectedItem.ToString();

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

                MessageBox.Show("Producto registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar campos
                LimpiarCampos();
            }
            catch (OracleException ex)
            {
                MessageBox.Show($"Error de Oracle: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error general: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void FormMenuAdmin_Load(object sender, EventArgs e)
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
            string[] categorias = {"Frutas y Verduras","Carnes y Pescados","Lácteos y Huevos","Panadería y Pastelería","Abarrotes y Enlatados","Bebidas","Limpieza y Hogar","Cuidado Personal","Snacks y Dulces","Otros"};
            cbxCategoria.Items.AddRange(categorias);
        }

        private async void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            string filtro = txtBuscarProducto.Text.Trim();
            await CargarProductosAsync(filtro);  // Procede con la carga
        }

        private async void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscarProducto.Text.Trim();
            await CargarProductosAsync(filtro);
        }

        private async void BtnLimpiarBusqueda_Click(object sender, EventArgs e)
        {
            txtBuscarProducto.Text = "";  // Limpiar el TextBox de búsqueda
            await CargarProductosAsync();  // Cargar todos los productos sin filtro
        }
    }
}
*/