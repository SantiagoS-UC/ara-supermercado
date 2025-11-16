using AraSupermercado.accesoDatos;
using AraSupermercado.logica;
using System;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AraSupermercado.presentacion
{
    public partial class FormModificarProducto : Form
    {
        private Producto producto;
        private Administrador admin;
        private ConexionOracle conexion;
        private string nuevaRutaImagen;  

        public FormModificarProducto(Producto prod)
        {
            InitializeComponent();
            producto = prod;
            admin = new Administrador();
            conexion = new ConexionOracle();
            nuevaRutaImagen = prod.prodImagenRuta;  
        }

        private void FormModificarProducto_Load(object sender, EventArgs e)
        {
            CargarEstados();
            CargarCategorias();
            CargarDatosProducto();  
        }

        private void CargarEstados()
        {
            cbxEstadoProductoMod.Items.Add("Activo");
            cbxEstadoProductoMod.Items.Add("Inactivo");
        }

        private void CargarCategorias()
        {
            string[] categorias = { "Frutas y Verduras", "Carnes y Pescados", "Lácteos y Huevos", "Panadería y Pastelería", "Abarrotes y Enlatados", "Bebidas", "Limpieza y Hogar", "Cuidado Personal", "Snacks y Dulces", "Otros" };
            cbxCategoriaMod.Items.AddRange(categorias);
        }

        // Cargar datos del producto en los controles
        private void CargarDatosProducto()
        {
            txtCodigoProductoMod.Text = producto.prodCodigo.ToString();
            txtNombreProductoMod.Text = producto.prodNombre;
            txtPrecioProductoMod.Text = producto.prodPrecio.ToString("F2");
            cbxEstadoProductoMod.SelectedItem = producto.prodEstado;
            txtDescripcionProductoMod.Text = producto.prodDescripcion;
            cbxCategoriaMod.SelectedItem = producto.prodCategoria;

            // Cargar imagen
            try
            {
                picProductoMod.Image = Image.FromFile(producto.prodImagenRuta);
                picProductoMod.Tag = producto.prodImagenRuta;  
            }
            catch
            {
                //picProductoMod.Image = Image.FromFile("Resources/no-image.png");
                picProductoMod.Tag = null;  
            }
        }

        // Evento para seleccionar nueva imagen
        private void picProductoMod_DoubleClick(object sender, EventArgs e)  
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    nuevaRutaImagen = openFileDialog.FileName;
                    picProductoMod.Image = Image.FromFile(nuevaRutaImagen);
                }
            }
        }

        private void btnGuardarModificar_Click(object sender, EventArgs e)  
        {
            if (!ValidarCamposRegistro())
            {
                return; 
            }

            // Asignar valores del formulario al objeto producto
            producto.prodCodigo = int.Parse(txtCodigoProductoMod.Text);
            producto.prodNombre = txtNombreProductoMod.Text.Trim();
            producto.prodPrecio = decimal.Parse(txtPrecioProductoMod.Text);
            producto.prodEstado = cbxEstadoProductoMod.SelectedItem.ToString();
            producto.prodDescripcion = txtDescripcionProductoMod.Text.Trim();
            producto.prodCategoria = cbxCategoriaMod.SelectedItem.ToString();
            producto.prodImagenRuta = nuevaRutaImagen;  
            picProductoMod.Tag = nuevaRutaImagen;  

            // Validar que la imagen no sea null
            if (string.IsNullOrWhiteSpace(producto.prodImagenRuta) || !File.Exists(producto.prodImagenRuta))
            {
                MessageBox.Show("Debes seleccionar una imagen válida para el producto.", "Error de Imagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Llamar al método para actualizar el producto
            if (admin.ActualizarProducto(producto, cbxCategoriaMod.SelectedItem?.ToString()))
            {
                MessageBox.Show("Producto modificado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al modificar el producto. Revisa los logs.", "Error");
            }
        }

        private bool ValidarCamposRegistro()
        {
            bool esValido = true;

            // Limpiar errores previos
            errorProvider1.Clear();

            // Validación: Código
            if (string.IsNullOrWhiteSpace(txtCodigoProductoMod.Text))
            {
                errorProvider1.SetError(txtCodigoProductoMod, "El código es obligatorio.");
                esValido = false;
            }
            else if (!int.TryParse(txtCodigoProductoMod.Text, out int codigo))
            {
                errorProvider1.SetError(txtCodigoProductoMod, "El código debe ser un número entero.");
                esValido = false;
            }
            else if (codigo <= 0)
            {
                errorProvider1.SetError(txtCodigoProductoMod, "El código debe ser mayor a 0.");
                esValido = false;
            }
            else if (txtCodigoProductoMod.Text.Length > 10)
            {
                errorProvider1.SetError(txtCodigoProductoMod, "El código no debe exceder 10 dígitos.");
                esValido = false;
            }

            // Validación: Nombre
            if (string.IsNullOrWhiteSpace(txtNombreProductoMod.Text))
            {
                errorProvider1.SetError(txtNombreProductoMod, "El nombre es obligatorio.");
                esValido = false;
            }
            else if (!Regex.IsMatch(txtNombreProductoMod.Text, @"^[a-zA-Z\d\sÀ-ÿ]+$"))
            {
                errorProvider1.SetError(txtNombreProductoMod, "El nombre debe contener solo letras y espacios.");
                esValido = false;
            }
            else if (txtNombreProductoMod.Text.Length > 50)
            {
                errorProvider1.SetError(txtNombreProductoMod, "El nombre no debe exceder 50 caracteres.");
                esValido = false;
            }

            // Validación: Precio
            if (string.IsNullOrWhiteSpace(txtPrecioProductoMod.Text))
            {
                errorProvider1.SetError(txtPrecioProductoMod, "El precio es obligatorio.");
                esValido = false;
            }
            else if (!decimal.TryParse(txtPrecioProductoMod.Text, out decimal precio))
            {
                errorProvider1.SetError(txtPrecioProductoMod, "El precio debe ser un número.");
                esValido = false;
            }
            else if (precio < 100m)
            {
                errorProvider1.SetError(txtPrecioProductoMod, "El precio debe ser al menos 100.");
                esValido = false;
            }
            else if (precio > 200000m)
            {
                errorProvider1.SetError(txtPrecioProductoMod, "El precio no debe exceder 200000.");
                esValido = false;
            }

            // Validación: Descripción
            if (string.IsNullOrWhiteSpace(txtDescripcionProductoMod.Text))
            {
                errorProvider1.SetError(txtDescripcionProductoMod, "La descripción es obligatoria.");
                esValido = false;
            }
            else if (txtDescripcionProductoMod.Text.Length > 200)
            {
                errorProvider1.SetError(txtDescripcionProductoMod, "La descripción no debe exceder 200 caracteres.");
                esValido = false;
            }

            // Validación: Estado
            if (cbxEstadoProductoMod.SelectedItem == null)
            {
                errorProvider1.SetError(cbxEstadoProductoMod, "Debes seleccionar un estado para el producto.");
                esValido = false;
            }

            // Validación: Categoría
            if (cbxCategoriaMod.SelectedItem == null)
            {
                errorProvider1.SetError(cbxCategoriaMod, "Debes seleccionar una categoría para el producto.");
                esValido = false;
            }

            // Validación: Imagen
            if (picProductoMod.Tag == null)
            {
                errorProvider1.SetError(picProductoMod, "Debes seleccionar una imagen para el producto.");
                esValido = false;
            }

            if (!esValido)
            {
                MessageBox.Show("Por favor corregir los campos señalados.", "Errores de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return esValido;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
