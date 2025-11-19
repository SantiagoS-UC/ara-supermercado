namespace AraSupermercado.presentacion
{
    partial class FormPanelAdminProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlProductos = new System.Windows.Forms.Panel();
            this.btnLimpiarBusqueda = new System.Windows.Forms.Button();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.flowPanelProductos = new System.Windows.Forms.FlowLayoutPanel();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.txtBuscarProducto = new System.Windows.Forms.TextBox();
            this.pnlRegistrarProducto = new System.Windows.Forms.Panel();
            this.btnLimpiarRegistro = new System.Windows.Forms.Button();
            this.lblValidarDecrip = new System.Windows.Forms.Label();
            this.lblValidarCat = new System.Windows.Forms.Label();
            this.lblValidarEstado = new System.Windows.Forms.Label();
            this.lblValidarNombre = new System.Windows.Forms.Label();
            this.lblValidarPrecio = new System.Windows.Forms.Label();
            this.lblValidarCod = new System.Windows.Forms.Label();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.lblCategoría = new System.Windows.Forms.Label();
            this.cbxEstadoProducto = new System.Windows.Forms.ComboBox();
            this.lblEstadoProducto = new System.Windows.Forms.Label();
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.lblCodigoProducto = new System.Windows.Forms.Label();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.txtDescripcionProducto = new System.Windows.Forms.TextBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.lblDescripcionProducto = new System.Windows.Forms.Label();
            this.btnRegistrarProducto = new System.Windows.Forms.Button();
            this.lblPrecioProducto = new System.Windows.Forms.Label();
            this.lblSeleccionarImagen = new System.Windows.Forms.Label();
            this.picProducto = new System.Windows.Forms.PictureBox();
            this.lblImagenProducto = new System.Windows.Forms.Label();
            this.lblInformacionProducto = new System.Windows.Forms.Label();
            this.txtPrecioProducto = new System.Windows.Forms.TextBox();
            this.lblRegistrarProducto = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlProductos.SuspendLayout();
            this.flowPanelProductos.SuspendLayout();
            this.pnlRegistrarProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlProductos
            // 
            this.pnlProductos.BackColor = System.Drawing.Color.White;
            this.pnlProductos.Controls.Add(this.btnLimpiarBusqueda);
            this.pnlProductos.Controls.Add(this.btnBuscarProducto);
            this.pnlProductos.Controls.Add(this.flowPanelProductos);
            this.pnlProductos.Controls.Add(this.txtBuscarProducto);
            this.pnlProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProductos.Location = new System.Drawing.Point(0, 0);
            this.pnlProductos.Name = "pnlProductos";
            this.pnlProductos.Size = new System.Drawing.Size(1182, 653);
            this.pnlProductos.TabIndex = 0;
            // 
            // btnLimpiarBusqueda
            // 
            this.btnLimpiarBusqueda.BackColor = System.Drawing.Color.Gainsboro;
            this.btnLimpiarBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarBusqueda.Location = new System.Drawing.Point(1082, 18);
            this.btnLimpiarBusqueda.Name = "btnLimpiarBusqueda";
            this.btnLimpiarBusqueda.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiarBusqueda.TabIndex = 7;
            this.btnLimpiarBusqueda.Text = "Limpiar";
            this.btnLimpiarBusqueda.UseVisualStyleBackColor = false;
            this.btnLimpiarBusqueda.Click += new System.EventHandler(this.btnLimpiarBusqueda_Click);
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(111)))), ((int)(((byte)(33)))));
            this.btnBuscarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBuscarProducto.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProducto.Location = new System.Drawing.Point(394, 18);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(82, 23);
            this.btnBuscarProducto.TabIndex = 6;
            this.btnBuscarProducto.Text = "Buscar";
            this.btnBuscarProducto.UseVisualStyleBackColor = false;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // flowPanelProductos
            // 
            this.flowPanelProductos.AutoScroll = true;
            this.flowPanelProductos.BackColor = System.Drawing.Color.White;
            this.flowPanelProductos.Controls.Add(this.lblMensaje);
            this.flowPanelProductos.Location = new System.Drawing.Point(12, 62);
            this.flowPanelProductos.Name = "flowPanelProductos";
            this.flowPanelProductos.Size = new System.Drawing.Size(1158, 466);
            this.flowPanelProductos.TabIndex = 4;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.ForeColor = System.Drawing.Color.DimGray;
            this.lblMensaje.Location = new System.Drawing.Point(3, 0);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(58, 13);
            this.lblMensaje.TabIndex = 0;
            this.lblMensaje.Text = "Productos:";
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtBuscarProducto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtBuscarProducto.Location = new System.Drawing.Point(22, 22);
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.Size = new System.Drawing.Size(366, 20);
            this.txtBuscarProducto.TabIndex = 5;
            // 
            // pnlRegistrarProducto
            // 
            this.pnlRegistrarProducto.Controls.Add(this.btnLimpiarRegistro);
            this.pnlRegistrarProducto.Controls.Add(this.lblValidarDecrip);
            this.pnlRegistrarProducto.Controls.Add(this.lblValidarCat);
            this.pnlRegistrarProducto.Controls.Add(this.lblValidarEstado);
            this.pnlRegistrarProducto.Controls.Add(this.lblValidarNombre);
            this.pnlRegistrarProducto.Controls.Add(this.lblValidarPrecio);
            this.pnlRegistrarProducto.Controls.Add(this.lblValidarCod);
            this.pnlRegistrarProducto.Controls.Add(this.cbxCategoria);
            this.pnlRegistrarProducto.Controls.Add(this.lblCategoría);
            this.pnlRegistrarProducto.Controls.Add(this.cbxEstadoProducto);
            this.pnlRegistrarProducto.Controls.Add(this.lblEstadoProducto);
            this.pnlRegistrarProducto.Controls.Add(this.txtCodigoProducto);
            this.pnlRegistrarProducto.Controls.Add(this.lblCodigoProducto);
            this.pnlRegistrarProducto.Controls.Add(this.lblNombreProducto);
            this.pnlRegistrarProducto.Controls.Add(this.txtDescripcionProducto);
            this.pnlRegistrarProducto.Controls.Add(this.txtNombreProducto);
            this.pnlRegistrarProducto.Controls.Add(this.lblDescripcionProducto);
            this.pnlRegistrarProducto.Controls.Add(this.btnRegistrarProducto);
            this.pnlRegistrarProducto.Controls.Add(this.lblPrecioProducto);
            this.pnlRegistrarProducto.Controls.Add(this.lblSeleccionarImagen);
            this.pnlRegistrarProducto.Controls.Add(this.picProducto);
            this.pnlRegistrarProducto.Controls.Add(this.lblImagenProducto);
            this.pnlRegistrarProducto.Controls.Add(this.lblInformacionProducto);
            this.pnlRegistrarProducto.Controls.Add(this.txtPrecioProducto);
            this.pnlRegistrarProducto.Controls.Add(this.lblRegistrarProducto);
            this.pnlRegistrarProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRegistrarProducto.Location = new System.Drawing.Point(0, 0);
            this.pnlRegistrarProducto.Name = "pnlRegistrarProducto";
            this.pnlRegistrarProducto.Size = new System.Drawing.Size(1182, 653);
            this.pnlRegistrarProducto.TabIndex = 0;
            // 
            // btnLimpiarRegistro
            // 
            this.btnLimpiarRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarRegistro.Location = new System.Drawing.Point(1029, 43);
            this.btnLimpiarRegistro.Name = "btnLimpiarRegistro";
            this.btnLimpiarRegistro.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiarRegistro.TabIndex = 55;
            this.btnLimpiarRegistro.Text = "Limpiar";
            this.btnLimpiarRegistro.UseVisualStyleBackColor = true;
            this.btnLimpiarRegistro.Click += new System.EventHandler(this.btnLimpiarRegistro_Click);
            // 
            // lblValidarDecrip
            // 
            this.lblValidarDecrip.AutoSize = true;
            this.lblValidarDecrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidarDecrip.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblValidarDecrip.Location = new System.Drawing.Point(773, 336);
            this.lblValidarDecrip.Name = "lblValidarDecrip";
            this.lblValidarDecrip.Size = new System.Drawing.Size(115, 12);
            this.lblValidarDecrip.TabIndex = 54;
            this.lblValidarDecrip.Text = "No mayor a 200 caracteres";
            // 
            // lblValidarCat
            // 
            this.lblValidarCat.AutoSize = true;
            this.lblValidarCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidarCat.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblValidarCat.Location = new System.Drawing.Point(772, 216);
            this.lblValidarCat.Name = "lblValidarCat";
            this.lblValidarCat.Size = new System.Drawing.Size(99, 12);
            this.lblValidarCat.TabIndex = 53;
            this.lblValidarCat.Text = "Seleccione la categoría";
            // 
            // lblValidarEstado
            // 
            this.lblValidarEstado.AutoSize = true;
            this.lblValidarEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidarEstado.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblValidarEstado.Location = new System.Drawing.Point(773, 136);
            this.lblValidarEstado.Name = "lblValidarEstado";
            this.lblValidarEstado.Size = new System.Drawing.Size(89, 12);
            this.lblValidarEstado.TabIndex = 52;
            this.lblValidarEstado.Text = "Seleccione el estado";
            // 
            // lblValidarNombre
            // 
            this.lblValidarNombre.AutoSize = true;
            this.lblValidarNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidarNombre.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblValidarNombre.Location = new System.Drawing.Point(354, 136);
            this.lblValidarNombre.Name = "lblValidarNombre";
            this.lblValidarNombre.Size = new System.Drawing.Size(94, 12);
            this.lblValidarNombre.TabIndex = 51;
            this.lblValidarNombre.Text = "Solo letras y espacios";
            // 
            // lblValidarPrecio
            // 
            this.lblValidarPrecio.AutoSize = true;
            this.lblValidarPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidarPrecio.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblValidarPrecio.Location = new System.Drawing.Point(360, 304);
            this.lblValidarPrecio.Name = "lblValidarPrecio";
            this.lblValidarPrecio.Size = new System.Drawing.Size(86, 12);
            this.lblValidarPrecio.TabIndex = 50;
            this.lblValidarPrecio.Text = "Entre 100 y 200.000";
            // 
            // lblValidarCod
            // 
            this.lblValidarCod.AutoSize = true;
            this.lblValidarCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidarCod.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblValidarCod.Location = new System.Drawing.Point(356, 219);
            this.lblValidarCod.Name = "lblValidarCod";
            this.lblValidarCod.Size = new System.Drawing.Size(91, 12);
            this.lblValidarCod.TabIndex = 49;
            this.lblValidarCod.Text = "Entre 1 y 10 números";
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.AutoCompleteCustomSource.AddRange(new string[] {
            "Frutas y Verduras",
            "Carnes y Pescados",
            "Lácteos y Huevos",
            "Panadería y Pastelería",
            "Abarrotes y Enlatados",
            "Bebidas",
            "Limpieza y Hogar",
            "Cuidado Personal",
            "Snacks y Dulces",
            "Otros",
            ""});
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(772, 194);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(145, 21);
            this.cbxCategoria.TabIndex = 48;
            // 
            // lblCategoría
            // 
            this.lblCategoría.AutoSize = true;
            this.lblCategoría.Location = new System.Drawing.Point(768, 179);
            this.lblCategoría.Name = "lblCategoría";
            this.lblCategoría.Size = new System.Drawing.Size(61, 13);
            this.lblCategoría.TabIndex = 47;
            this.lblCategoría.Text = "Categoría *";
            // 
            // cbxEstadoProducto
            // 
            this.cbxEstadoProducto.AutoCompleteCustomSource.AddRange(new string[] {
            "Activo",
            "Inactivo"});
            this.cbxEstadoProducto.FormattingEnabled = true;
            this.cbxEstadoProducto.Location = new System.Drawing.Point(772, 113);
            this.cbxEstadoProducto.Name = "cbxEstadoProducto";
            this.cbxEstadoProducto.Size = new System.Drawing.Size(145, 21);
            this.cbxEstadoProducto.TabIndex = 46;
            // 
            // lblEstadoProducto
            // 
            this.lblEstadoProducto.AutoSize = true;
            this.lblEstadoProducto.Location = new System.Drawing.Point(769, 97);
            this.lblEstadoProducto.Name = "lblEstadoProducto";
            this.lblEstadoProducto.Size = new System.Drawing.Size(109, 13);
            this.lblEstadoProducto.TabIndex = 45;
            this.lblEstadoProducto.Text = "Estado del producto *";
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.Location = new System.Drawing.Point(357, 196);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(145, 20);
            this.txtCodigoProducto.TabIndex = 44;
            // 
            // lblCodigoProducto
            // 
            this.lblCodigoProducto.AutoSize = true;
            this.lblCodigoProducto.Location = new System.Drawing.Point(354, 179);
            this.lblCodigoProducto.Name = "lblCodigoProducto";
            this.lblCodigoProducto.Size = new System.Drawing.Size(109, 13);
            this.lblCodigoProducto.TabIndex = 43;
            this.lblCodigoProducto.Text = "Código del producto *";
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Location = new System.Drawing.Point(350, 97);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(113, 13);
            this.lblNombreProducto.TabIndex = 35;
            this.lblNombreProducto.Text = "Nombre del producto *";
            // 
            // txtDescripcionProducto
            // 
            this.txtDescripcionProducto.Location = new System.Drawing.Point(771, 281);
            this.txtDescripcionProducto.Multiline = true;
            this.txtDescripcionProducto.Name = "txtDescripcionProducto";
            this.txtDescripcionProducto.Size = new System.Drawing.Size(145, 52);
            this.txtDescripcionProducto.TabIndex = 41;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(354, 114);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(145, 20);
            this.txtNombreProducto.TabIndex = 36;
            // 
            // lblDescripcionProducto
            // 
            this.lblDescripcionProducto.AutoSize = true;
            this.lblDescripcionProducto.Location = new System.Drawing.Point(768, 264);
            this.lblDescripcionProducto.Name = "lblDescripcionProducto";
            this.lblDescripcionProducto.Size = new System.Drawing.Size(70, 13);
            this.lblDescripcionProducto.TabIndex = 40;
            this.lblDescripcionProducto.Text = "Descripción *";
            // 
            // btnRegistrarProducto
            // 
            this.btnRegistrarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(111)))), ((int)(((byte)(33)))));
            this.btnRegistrarProducto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarProducto.Location = new System.Drawing.Point(566, 485);
            this.btnRegistrarProducto.Name = "btnRegistrarProducto";
            this.btnRegistrarProducto.Size = new System.Drawing.Size(135, 30);
            this.btnRegistrarProducto.TabIndex = 42;
            this.btnRegistrarProducto.Text = "Guardar Producto";
            this.btnRegistrarProducto.UseVisualStyleBackColor = false;
            this.btnRegistrarProducto.Click += new System.EventHandler(this.btnRegistrarProducto_Click);
            // 
            // lblPrecioProducto
            // 
            this.lblPrecioProducto.AutoSize = true;
            this.lblPrecioProducto.Location = new System.Drawing.Point(351, 264);
            this.lblPrecioProducto.Name = "lblPrecioProducto";
            this.lblPrecioProducto.Size = new System.Drawing.Size(59, 13);
            this.lblPrecioProducto.TabIndex = 38;
            this.lblPrecioProducto.Text = "Precio ($) *";
            // 
            // lblSeleccionarImagen
            // 
            this.lblSeleccionarImagen.BackColor = System.Drawing.Color.Transparent;
            this.lblSeleccionarImagen.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccionarImagen.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblSeleccionarImagen.Location = new System.Drawing.Point(105, 206);
            this.lblSeleccionarImagen.Name = "lblSeleccionarImagen";
            this.lblSeleccionarImagen.Size = new System.Drawing.Size(121, 23);
            this.lblSeleccionarImagen.TabIndex = 37;
            this.lblSeleccionarImagen.Text = "Cargar imagen";
            this.lblSeleccionarImagen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSeleccionarImagen.Click += new System.EventHandler(this.lblSeleccionarImagen_Click);
            // 
            // picProducto
            // 
            this.picProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picProducto.Location = new System.Drawing.Point(38, 98);
            this.picProducto.Name = "picProducto";
            this.picProducto.Size = new System.Drawing.Size(256, 260);
            this.picProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProducto.TabIndex = 34;
            this.picProducto.TabStop = false;
            this.picProducto.Click += new System.EventHandler(this.picProducto_Click);
            // 
            // lblImagenProducto
            // 
            this.lblImagenProducto.AutoSize = true;
            this.lblImagenProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagenProducto.Location = new System.Drawing.Point(105, 81);
            this.lblImagenProducto.Name = "lblImagenProducto";
            this.lblImagenProducto.Size = new System.Drawing.Size(114, 13);
            this.lblImagenProducto.TabIndex = 33;
            this.lblImagenProducto.Text = "Imagen del producto  *";
            // 
            // lblInformacionProducto
            // 
            this.lblInformacionProducto.AutoSize = true;
            this.lblInformacionProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacionProducto.Location = new System.Drawing.Point(512, 43);
            this.lblInformacionProducto.Name = "lblInformacionProducto";
            this.lblInformacionProducto.Size = new System.Drawing.Size(178, 16);
            this.lblInformacionProducto.TabIndex = 32;
            this.lblInformacionProducto.Text = "Información del producto";
            // 
            // txtPrecioProducto
            // 
            this.txtPrecioProducto.Location = new System.Drawing.Point(357, 281);
            this.txtPrecioProducto.Name = "txtPrecioProducto";
            this.txtPrecioProducto.Size = new System.Drawing.Size(145, 20);
            this.txtPrecioProducto.TabIndex = 39;
            // 
            // lblRegistrarProducto
            // 
            this.lblRegistrarProducto.AutoSize = true;
            this.lblRegistrarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(111)))), ((int)(((byte)(33)))));
            this.lblRegistrarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrarProducto.ForeColor = System.Drawing.Color.Black;
            this.lblRegistrarProducto.Location = new System.Drawing.Point(18, 23);
            this.lblRegistrarProducto.Name = "lblRegistrarProducto";
            this.lblRegistrarProducto.Size = new System.Drawing.Size(160, 20);
            this.lblRegistrarProducto.TabIndex = 31;
            this.lblRegistrarProducto.Text = "Registrar Producto";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FormPanelAdminProducto
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.pnlProductos);
            this.Controls.Add(this.pnlRegistrarProducto);
            this.Name = "FormPanelAdminProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPanelAdminProducto";
            this.Load += new System.EventHandler(this.FormPanelAdminProducto_Load);
            this.pnlProductos.ResumeLayout(false);
            this.pnlProductos.PerformLayout();
            this.flowPanelProductos.ResumeLayout(false);
            this.flowPanelProductos.PerformLayout();
            this.pnlRegistrarProducto.ResumeLayout(false);
            this.pnlRegistrarProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlProductos;
        private System.Windows.Forms.Panel pnlRegistrarProducto;
        private System.Windows.Forms.Label lblValidarDecrip;
        private System.Windows.Forms.Label lblValidarCat;
        private System.Windows.Forms.Label lblValidarEstado;
        private System.Windows.Forms.Label lblValidarNombre;
        private System.Windows.Forms.Label lblValidarPrecio;
        private System.Windows.Forms.Label lblValidarCod;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.Label lblCategoría;
        private System.Windows.Forms.ComboBox cbxEstadoProducto;
        private System.Windows.Forms.Label lblEstadoProducto;
        private System.Windows.Forms.TextBox txtCodigoProducto;
        private System.Windows.Forms.Label lblCodigoProducto;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.TextBox txtDescripcionProducto;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label lblDescripcionProducto;
        private System.Windows.Forms.Button btnRegistrarProducto;
        private System.Windows.Forms.Label lblPrecioProducto;
        private System.Windows.Forms.Label lblSeleccionarImagen;
        private System.Windows.Forms.PictureBox picProducto;
        private System.Windows.Forms.Label lblImagenProducto;
        private System.Windows.Forms.Label lblInformacionProducto;
        private System.Windows.Forms.TextBox txtPrecioProducto;
        private System.Windows.Forms.Label lblRegistrarProducto;
        private System.Windows.Forms.Button btnLimpiarBusqueda;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.FlowLayoutPanel flowPanelProductos;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.TextBox txtBuscarProducto;
        //private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Button btnLimpiarRegistro;
    }
}