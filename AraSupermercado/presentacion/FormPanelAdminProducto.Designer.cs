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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPanelAdminProducto));
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
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblAsterImg = new System.Windows.Forms.Label();
            this.lblAsterNom = new System.Windows.Forms.Label();
            this.lblAsterCod = new System.Windows.Forms.Label();
            this.lblAsterPrecio = new System.Windows.Forms.Label();
            this.lblAsterEst = new System.Windows.Forms.Label();
            this.lblAsterCat = new System.Windows.Forms.Label();
            this.lblAsterDescrip = new System.Windows.Forms.Label();
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
            this.btnLimpiarBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(111)))), ((int)(((byte)(33)))));
            this.btnLimpiarBusqueda.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarBusqueda.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarBusqueda.Location = new System.Drawing.Point(998, 22);
            this.btnLimpiarBusqueda.Name = "btnLimpiarBusqueda";
            this.btnLimpiarBusqueda.Size = new System.Drawing.Size(159, 33);
            this.btnLimpiarBusqueda.TabIndex = 7;
            this.btnLimpiarBusqueda.Text = "Limpiar Búsqueda";
            this.btnLimpiarBusqueda.UseVisualStyleBackColor = false;
            this.btnLimpiarBusqueda.Click += new System.EventHandler(this.btnLimpiarBusqueda_Click);
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(111)))), ((int)(((byte)(33)))));
            this.btnBuscarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBuscarProducto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProducto.ForeColor = System.Drawing.Color.White;
            this.btnBuscarProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarProducto.Image")));
            this.btnBuscarProducto.Location = new System.Drawing.Point(389, 22);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(72, 35);
            this.btnBuscarProducto.TabIndex = 6;
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
            this.txtBuscarProducto.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarProducto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtBuscarProducto.Location = new System.Drawing.Point(22, 22);
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.Size = new System.Drawing.Size(366, 33);
            this.txtBuscarProducto.TabIndex = 5;
            // 
            // pnlRegistrarProducto
            // 
            this.pnlRegistrarProducto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pnlRegistrarProducto.BackColor = System.Drawing.Color.White;
            this.pnlRegistrarProducto.Controls.Add(this.lblAsterDescrip);
            this.pnlRegistrarProducto.Controls.Add(this.lblAsterCat);
            this.pnlRegistrarProducto.Controls.Add(this.lblAsterEst);
            this.pnlRegistrarProducto.Controls.Add(this.lblAsterPrecio);
            this.pnlRegistrarProducto.Controls.Add(this.lblAsterCod);
            this.pnlRegistrarProducto.Controls.Add(this.lblAsterNom);
            this.pnlRegistrarProducto.Controls.Add(this.lblAsterImg);
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
            this.pnlRegistrarProducto.Location = new System.Drawing.Point(0, 0);
            this.pnlRegistrarProducto.Name = "pnlRegistrarProducto";
            this.pnlRegistrarProducto.Size = new System.Drawing.Size(1182, 653);
            this.pnlRegistrarProducto.TabIndex = 0;
            // 
            // btnLimpiarRegistro
            // 
            this.btnLimpiarRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(111)))), ((int)(((byte)(33)))));
            this.btnLimpiarRegistro.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarRegistro.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarRegistro.Location = new System.Drawing.Point(1019, 78);
            this.btnLimpiarRegistro.Name = "btnLimpiarRegistro";
            this.btnLimpiarRegistro.Size = new System.Drawing.Size(138, 30);
            this.btnLimpiarRegistro.TabIndex = 55;
            this.btnLimpiarRegistro.Text = "Limpiar Campos";
            this.btnLimpiarRegistro.UseVisualStyleBackColor = false;
            this.btnLimpiarRegistro.Click += new System.EventHandler(this.btnLimpiarRegistro_Click);
            // 
            // lblValidarDecrip
            // 
            this.lblValidarDecrip.AutoSize = true;
            this.lblValidarDecrip.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidarDecrip.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblValidarDecrip.Location = new System.Drawing.Point(882, 504);
            this.lblValidarDecrip.Name = "lblValidarDecrip";
            this.lblValidarDecrip.Size = new System.Drawing.Size(143, 13);
            this.lblValidarDecrip.TabIndex = 54;
            this.lblValidarDecrip.Text = "No mayor a 200 caracteres";
            // 
            // lblValidarCat
            // 
            this.lblValidarCat.AutoSize = true;
            this.lblValidarCat.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidarCat.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblValidarCat.Location = new System.Drawing.Point(881, 308);
            this.lblValidarCat.Name = "lblValidarCat";
            this.lblValidarCat.Size = new System.Drawing.Size(124, 13);
            this.lblValidarCat.TabIndex = 53;
            this.lblValidarCat.Text = "Seleccione la categoría";
            // 
            // lblValidarEstado
            // 
            this.lblValidarEstado.AutoSize = true;
            this.lblValidarEstado.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidarEstado.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblValidarEstado.Location = new System.Drawing.Point(882, 179);
            this.lblValidarEstado.Name = "lblValidarEstado";
            this.lblValidarEstado.Size = new System.Drawing.Size(111, 13);
            this.lblValidarEstado.TabIndex = 52;
            this.lblValidarEstado.Text = "Seleccione el estado";
            // 
            // lblValidarNombre
            // 
            this.lblValidarNombre.AutoSize = true;
            this.lblValidarNombre.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidarNombre.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblValidarNombre.Location = new System.Drawing.Point(438, 178);
            this.lblValidarNombre.Name = "lblValidarNombre";
            this.lblValidarNombre.Size = new System.Drawing.Size(117, 13);
            this.lblValidarNombre.TabIndex = 51;
            this.lblValidarNombre.Text = "Solo letras y espacios";
            // 
            // lblValidarPrecio
            // 
            this.lblValidarPrecio.AutoSize = true;
            this.lblValidarPrecio.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidarPrecio.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblValidarPrecio.Location = new System.Drawing.Point(441, 440);
            this.lblValidarPrecio.Name = "lblValidarPrecio";
            this.lblValidarPrecio.Size = new System.Drawing.Size(106, 13);
            this.lblValidarPrecio.TabIndex = 50;
            this.lblValidarPrecio.Text = "Entre 100 y 200.000";
            // 
            // lblValidarCod
            // 
            this.lblValidarCod.AutoSize = true;
            this.lblValidarCod.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidarCod.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblValidarCod.Location = new System.Drawing.Point(436, 313);
            this.lblValidarCod.Name = "lblValidarCod";
            this.lblValidarCod.Size = new System.Drawing.Size(116, 13);
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
            this.cbxCategoria.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(881, 279);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(232, 25);
            this.cbxCategoria.TabIndex = 48;
            // 
            // lblCategoría
            // 
            this.lblCategoría.AutoSize = true;
            this.lblCategoría.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoría.Location = new System.Drawing.Point(878, 255);
            this.lblCategoría.Name = "lblCategoría";
            this.lblCategoría.Size = new System.Drawing.Size(84, 21);
            this.lblCategoría.TabIndex = 47;
            this.lblCategoría.Text = "Categoría";
            // 
            // cbxEstadoProducto
            // 
            this.cbxEstadoProducto.AutoCompleteCustomSource.AddRange(new string[] {
            "Activo",
            "Inactivo"});
            this.cbxEstadoProducto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEstadoProducto.FormattingEnabled = true;
            this.cbxEstadoProducto.Location = new System.Drawing.Point(881, 149);
            this.cbxEstadoProducto.Name = "cbxEstadoProducto";
            this.cbxEstadoProducto.Size = new System.Drawing.Size(232, 25);
            this.cbxEstadoProducto.TabIndex = 46;
            // 
            // lblEstadoProducto
            // 
            this.lblEstadoProducto.AutoSize = true;
            this.lblEstadoProducto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoProducto.Location = new System.Drawing.Point(878, 122);
            this.lblEstadoProducto.Name = "lblEstadoProducto";
            this.lblEstadoProducto.Size = new System.Drawing.Size(163, 21);
            this.lblEstadoProducto.TabIndex = 45;
            this.lblEstadoProducto.Text = "Estado del producto";
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoProducto.Location = new System.Drawing.Point(437, 282);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(232, 25);
            this.txtCodigoProducto.TabIndex = 44;
            // 
            // lblCodigoProducto
            // 
            this.lblCodigoProducto.AutoSize = true;
            this.lblCodigoProducto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoProducto.Location = new System.Drawing.Point(434, 258);
            this.lblCodigoProducto.Name = "lblCodigoProducto";
            this.lblCodigoProducto.Size = new System.Drawing.Size(65, 21);
            this.lblCodigoProducto.TabIndex = 43;
            this.lblCodigoProducto.Text = "Código";
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProducto.Location = new System.Drawing.Point(434, 122);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(175, 21);
            this.lblNombreProducto.TabIndex = 35;
            this.lblNombreProducto.Text = "Nombre del producto";
            // 
            // txtDescripcionProducto
            // 
            this.txtDescripcionProducto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionProducto.Location = new System.Drawing.Point(881, 409);
            this.txtDescripcionProducto.Multiline = true;
            this.txtDescripcionProducto.Name = "txtDescripcionProducto";
            this.txtDescripcionProducto.Size = new System.Drawing.Size(232, 92);
            this.txtDescripcionProducto.TabIndex = 41;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProducto.Location = new System.Drawing.Point(438, 148);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(232, 25);
            this.txtNombreProducto.TabIndex = 36;
            // 
            // lblDescripcionProducto
            // 
            this.lblDescripcionProducto.AutoSize = true;
            this.lblDescripcionProducto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionProducto.Location = new System.Drawing.Point(878, 383);
            this.lblDescripcionProducto.Name = "lblDescripcionProducto";
            this.lblDescripcionProducto.Size = new System.Drawing.Size(100, 21);
            this.lblDescripcionProducto.TabIndex = 40;
            this.lblDescripcionProducto.Text = "Descripción";
            // 
            // btnRegistrarProducto
            // 
            this.btnRegistrarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(111)))), ((int)(((byte)(33)))));
            this.btnRegistrarProducto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarProducto.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarProducto.Location = new System.Drawing.Point(437, 553);
            this.btnRegistrarProducto.Name = "btnRegistrarProducto";
            this.btnRegistrarProducto.Size = new System.Drawing.Size(676, 35);
            this.btnRegistrarProducto.TabIndex = 42;
            this.btnRegistrarProducto.Text = "Guardar Producto";
            this.btnRegistrarProducto.UseVisualStyleBackColor = false;
            this.btnRegistrarProducto.Click += new System.EventHandler(this.btnRegistrarProducto_Click);
            // 
            // lblPrecioProducto
            // 
            this.lblPrecioProducto.AutoSize = true;
            this.lblPrecioProducto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioProducto.Location = new System.Drawing.Point(434, 385);
            this.lblPrecioProducto.Name = "lblPrecioProducto";
            this.lblPrecioProducto.Size = new System.Drawing.Size(83, 21);
            this.lblPrecioProducto.TabIndex = 38;
            this.lblPrecioProducto.Text = "Precio ($)";
            // 
            // lblSeleccionarImagen
            // 
            this.lblSeleccionarImagen.BackColor = System.Drawing.Color.Transparent;
            this.lblSeleccionarImagen.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccionarImagen.ForeColor = System.Drawing.Color.Silver;
            this.lblSeleccionarImagen.Location = new System.Drawing.Point(158, 298);
            this.lblSeleccionarImagen.Name = "lblSeleccionarImagen";
            this.lblSeleccionarImagen.Size = new System.Drawing.Size(121, 23);
            this.lblSeleccionarImagen.TabIndex = 37;
            this.lblSeleccionarImagen.Text = "Cargar imagen";
            this.lblSeleccionarImagen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSeleccionarImagen.Click += new System.EventHandler(this.lblSeleccionarImagen_Click);
            // 
            // picProducto
            // 
            this.picProducto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.picProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picProducto.Location = new System.Drawing.Point(41, 164);
            this.picProducto.Name = "picProducto";
            this.picProducto.Size = new System.Drawing.Size(347, 315);
            this.picProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProducto.TabIndex = 34;
            this.picProducto.TabStop = false;
            this.picProducto.Click += new System.EventHandler(this.picProducto_Click);
            // 
            // lblImagenProducto
            // 
            this.lblImagenProducto.AutoSize = true;
            this.lblImagenProducto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagenProducto.Location = new System.Drawing.Point(37, 140);
            this.lblImagenProducto.Name = "lblImagenProducto";
            this.lblImagenProducto.Size = new System.Drawing.Size(170, 21);
            this.lblImagenProducto.TabIndex = 33;
            this.lblImagenProducto.Text = "Imagen del producto";
            // 
            // lblInformacionProducto
            // 
            this.lblInformacionProducto.AutoSize = true;
            this.lblInformacionProducto.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacionProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(111)))), ((int)(((byte)(33)))));
            this.lblInformacionProducto.Location = new System.Drawing.Point(35, 62);
            this.lblInformacionProducto.Name = "lblInformacionProducto";
            this.lblInformacionProducto.Size = new System.Drawing.Size(310, 32);
            this.lblInformacionProducto.TabIndex = 32;
            this.lblInformacionProducto.Text = "Información del producto";
            // 
            // txtPrecioProducto
            // 
            this.txtPrecioProducto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioProducto.Location = new System.Drawing.Point(438, 409);
            this.txtPrecioProducto.Name = "txtPrecioProducto";
            this.txtPrecioProducto.Size = new System.Drawing.Size(232, 25);
            this.txtPrecioProducto.TabIndex = 39;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // lblAsterImg
            // 
            this.lblAsterImg.AutoSize = true;
            this.lblAsterImg.BackColor = System.Drawing.Color.Transparent;
            this.lblAsterImg.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsterImg.ForeColor = System.Drawing.Color.Red;
            this.lblAsterImg.Location = new System.Drawing.Point(203, 139);
            this.lblAsterImg.Name = "lblAsterImg";
            this.lblAsterImg.Size = new System.Drawing.Size(17, 21);
            this.lblAsterImg.TabIndex = 56;
            this.lblAsterImg.Text = "*";
            // 
            // lblAsterNom
            // 
            this.lblAsterNom.AutoSize = true;
            this.lblAsterNom.BackColor = System.Drawing.Color.Transparent;
            this.lblAsterNom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsterNom.ForeColor = System.Drawing.Color.Red;
            this.lblAsterNom.Location = new System.Drawing.Point(601, 121);
            this.lblAsterNom.Name = "lblAsterNom";
            this.lblAsterNom.Size = new System.Drawing.Size(17, 21);
            this.lblAsterNom.TabIndex = 57;
            this.lblAsterNom.Text = "*";
            // 
            // lblAsterCod
            // 
            this.lblAsterCod.AutoSize = true;
            this.lblAsterCod.BackColor = System.Drawing.Color.Transparent;
            this.lblAsterCod.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsterCod.ForeColor = System.Drawing.Color.Red;
            this.lblAsterCod.Location = new System.Drawing.Point(494, 255);
            this.lblAsterCod.Name = "lblAsterCod";
            this.lblAsterCod.Size = new System.Drawing.Size(17, 21);
            this.lblAsterCod.TabIndex = 58;
            this.lblAsterCod.Text = "*";
            // 
            // lblAsterPrecio
            // 
            this.lblAsterPrecio.AutoSize = true;
            this.lblAsterPrecio.BackColor = System.Drawing.Color.Transparent;
            this.lblAsterPrecio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsterPrecio.ForeColor = System.Drawing.Color.Red;
            this.lblAsterPrecio.Location = new System.Drawing.Point(510, 383);
            this.lblAsterPrecio.Name = "lblAsterPrecio";
            this.lblAsterPrecio.Size = new System.Drawing.Size(17, 21);
            this.lblAsterPrecio.TabIndex = 59;
            this.lblAsterPrecio.Text = "*";
            // 
            // lblAsterEst
            // 
            this.lblAsterEst.AutoSize = true;
            this.lblAsterEst.BackColor = System.Drawing.Color.Transparent;
            this.lblAsterEst.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsterEst.ForeColor = System.Drawing.Color.Red;
            this.lblAsterEst.Location = new System.Drawing.Point(1035, 122);
            this.lblAsterEst.Name = "lblAsterEst";
            this.lblAsterEst.Size = new System.Drawing.Size(17, 21);
            this.lblAsterEst.TabIndex = 60;
            this.lblAsterEst.Text = "*";
            // 
            // lblAsterCat
            // 
            this.lblAsterCat.AutoSize = true;
            this.lblAsterCat.BackColor = System.Drawing.Color.Transparent;
            this.lblAsterCat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsterCat.ForeColor = System.Drawing.Color.Red;
            this.lblAsterCat.Location = new System.Drawing.Point(955, 255);
            this.lblAsterCat.Name = "lblAsterCat";
            this.lblAsterCat.Size = new System.Drawing.Size(17, 21);
            this.lblAsterCat.TabIndex = 61;
            this.lblAsterCat.Text = "*";
            // 
            // lblAsterDescrip
            // 
            this.lblAsterDescrip.AutoSize = true;
            this.lblAsterDescrip.BackColor = System.Drawing.Color.Transparent;
            this.lblAsterDescrip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsterDescrip.ForeColor = System.Drawing.Color.Red;
            this.lblAsterDescrip.Location = new System.Drawing.Point(972, 381);
            this.lblAsterDescrip.Name = "lblAsterDescrip";
            this.lblAsterDescrip.Size = new System.Drawing.Size(17, 21);
            this.lblAsterDescrip.TabIndex = 62;
            this.lblAsterDescrip.Text = "*";
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
        private System.Windows.Forms.Button btnLimpiarBusqueda;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.FlowLayoutPanel flowPanelProductos;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.TextBox txtBuscarProducto;
        //private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Button btnLimpiarRegistro;
        private System.Windows.Forms.Label lblAsterImg;
        private System.Windows.Forms.Label lblAsterDescrip;
        private System.Windows.Forms.Label lblAsterCat;
        private System.Windows.Forms.Label lblAsterEst;
        private System.Windows.Forms.Label lblAsterPrecio;
        private System.Windows.Forms.Label lblAsterCod;
        private System.Windows.Forms.Label lblAsterNom;
    }
}