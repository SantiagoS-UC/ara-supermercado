/*
namespace AraSupermercado.presentacion
{
    partial class FormMenuAdmin
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
            this.tbcMenuAdmin = new System.Windows.Forms.TabControl();
            this.tbpProductos = new System.Windows.Forms.TabPage();
            this.pnlProductos = new System.Windows.Forms.Panel();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.flowPanelProductos = new System.Windows.Forms.FlowLayoutPanel();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.txtBuscarProducto = new System.Windows.Forms.TextBox();
            this.tbpRegistrarProducto = new System.Windows.Forms.TabPage();
            this.btnRegistrarProducto = new System.Windows.Forms.Button();
            this.lblSeleccionarImagen = new System.Windows.Forms.Label();
            this.picProducto = new System.Windows.Forms.PictureBox();
            this.lblImagenProducto = new System.Windows.Forms.Label();
            this.lblInformacionProducto = new System.Windows.Forms.Label();
            this.lblRegistrarProducto = new System.Windows.Forms.Label();
            this.pnlRegistrarProducto = new System.Windows.Forms.Panel();
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
            this.lblPrecioProducto = new System.Windows.Forms.Label();
            this.txtPrecioProducto = new System.Windows.Forms.TextBox();
            this.tbpPedidos = new System.Windows.Forms.TabPage();
            this.pnlPedidos = new System.Windows.Forms.Panel();
            this.tbpFacturas = new System.Windows.Forms.TabPage();
            this.pnlFacturas = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblValidarCod = new System.Windows.Forms.Label();
            this.lblValidarPrecio = new System.Windows.Forms.Label();
            this.lblValidarNombre = new System.Windows.Forms.Label();
            this.lblValidarEstado = new System.Windows.Forms.Label();
            this.lblValidarCat = new System.Windows.Forms.Label();
            this.lblValidarDecrip = new System.Windows.Forms.Label();
            this.btnLimpiarBusqueda = new System.Windows.Forms.Button();
            this.tbcMenuAdmin.SuspendLayout();
            this.tbpProductos.SuspendLayout();
            this.pnlProductos.SuspendLayout();
            this.flowPanelProductos.SuspendLayout();
            this.tbpRegistrarProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProducto)).BeginInit();
            this.pnlRegistrarProducto.SuspendLayout();
            this.tbpPedidos.SuspendLayout();
            this.tbpFacturas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcMenuAdmin
            // 
            this.tbcMenuAdmin.Controls.Add(this.tbpProductos);
            this.tbcMenuAdmin.Controls.Add(this.tbpRegistrarProducto);
            this.tbcMenuAdmin.Controls.Add(this.tbpPedidos);
            this.tbcMenuAdmin.Controls.Add(this.tbpFacturas);
            this.tbcMenuAdmin.ItemSize = new System.Drawing.Size(60, 18);
            this.tbcMenuAdmin.Location = new System.Drawing.Point(12, 12);
            this.tbcMenuAdmin.Name = "tbcMenuAdmin";
            this.tbcMenuAdmin.SelectedIndex = 0;
            this.tbcMenuAdmin.Size = new System.Drawing.Size(900, 507);
            this.tbcMenuAdmin.TabIndex = 0;
            // 
            // tbpProductos
            // 
            this.tbpProductos.Controls.Add(this.pnlProductos);
            this.tbpProductos.Location = new System.Drawing.Point(4, 25);
            this.tbpProductos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbpProductos.Name = "tbpProductos";
            this.tbpProductos.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbpProductos.Size = new System.Drawing.Size(892, 478);
            this.tbpProductos.TabIndex = 0;
            this.tbpProductos.Text = "Productos";
            this.tbpProductos.UseVisualStyleBackColor = true;
            // 
            // pnlProductos
            // 
            this.pnlProductos.Controls.Add(this.btnLimpiarBusqueda);
            this.pnlProductos.Controls.Add(this.btnBuscarProducto);
            this.pnlProductos.Controls.Add(this.flowPanelProductos);
            this.pnlProductos.Controls.Add(this.txtBuscarProducto);
            this.pnlProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProductos.Location = new System.Drawing.Point(4, 4);
            this.pnlProductos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlProductos.Name = "pnlProductos";
            this.pnlProductos.Size = new System.Drawing.Size(884, 470);
            this.pnlProductos.TabIndex = 0;
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Location = new System.Drawing.Point(495, 2);
            this.btnBuscarProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(100, 28);
            this.btnBuscarProducto.TabIndex = 2;
            this.btnBuscarProducto.Text = "buscar";
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // flowPanelProductos
            // 
            this.flowPanelProductos.AutoScroll = true;
            this.flowPanelProductos.BackColor = System.Drawing.Color.White;
            this.flowPanelProductos.Controls.Add(this.lblMensaje);
            this.flowPanelProductos.Location = new System.Drawing.Point(3, 26);
            this.flowPanelProductos.Name = "flowPanelProductos";
            this.flowPanelProductos.Size = new System.Drawing.Size(756, 351);
            this.flowPanelProductos.TabIndex = 0;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.ForeColor = System.Drawing.Color.DimGray;
            this.lblMensaje.Location = new System.Drawing.Point(4, 0);
            this.lblMensaje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(71, 16);
            this.lblMensaje.TabIndex = 0;
            this.lblMensaje.Text = "Productos:";
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtBuscarProducto.Location = new System.Drawing.Point(273, 4);
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.Size = new System.Drawing.Size(132, 22);
            this.txtBuscarProducto.TabIndex = 1;
            this.txtBuscarProducto.Text = "Buscar";
            // 
            // tbpRegistrarProducto
            // 
            this.tbpRegistrarProducto.Controls.Add(this.btnRegistrarProducto);
            this.tbpRegistrarProducto.Controls.Add(this.lblImagenProducto);
            this.tbpRegistrarProducto.Controls.Add(this.pnlRegistrarProducto);
            this.tbpRegistrarProducto.Location = new System.Drawing.Point(4, 25);
            this.tbpRegistrarProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbpRegistrarProducto.Name = "tbpRegistrarProducto";
            this.tbpRegistrarProducto.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbpRegistrarProducto.Size = new System.Drawing.Size(892, 478);
            this.tbpRegistrarProducto.TabIndex = 1;
            this.tbpRegistrarProducto.Text = "Registrar producto";
            this.tbpRegistrarProducto.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarProducto
            // 
            this.btnRegistrarProducto.Location = new System.Drawing.Point(475, 428);
            this.btnRegistrarProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegistrarProducto.Name = "btnRegistrarProducto";
            this.btnRegistrarProducto.Size = new System.Drawing.Size(165, 28);
            this.btnRegistrarProducto.TabIndex = 17;
            this.btnRegistrarProducto.Text = "Guardar Producto";
            this.btnRegistrarProducto.UseVisualStyleBackColor = true;
            this.btnRegistrarProducto.Click += new System.EventHandler(this.btnRegistrarProducto_Click);
            // 
            // lblSeleccionarImagen
            // 
            this.lblSeleccionarImagen.BackColor = System.Drawing.Color.Transparent;
            this.lblSeleccionarImagen.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccionarImagen.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblSeleccionarImagen.Location = new System.Drawing.Point(115, 422);
            this.lblSeleccionarImagen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSeleccionarImagen.Name = "lblSeleccionarImagen";
            this.lblSeleccionarImagen.Size = new System.Drawing.Size(161, 28);
            this.lblSeleccionarImagen.TabIndex = 12;
            this.lblSeleccionarImagen.Text = "Cargar imagen";
            this.lblSeleccionarImagen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSeleccionarImagen.Click += new System.EventHandler(this.lblSeleccionarImagen_Click);
            // 
            // picProducto
            // 
            this.picProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picProducto.Location = new System.Drawing.Point(64, 366);
            this.picProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picProducto.Name = "picProducto";
            this.picProducto.Size = new System.Drawing.Size(249, 115);
            this.picProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProducto.TabIndex = 6;
            this.picProducto.TabStop = false;
            this.picProducto.Click += new System.EventHandler(this.picProducto_Click);
            // 
            // lblImagenProducto
            // 
            this.lblImagenProducto.AutoSize = true;
            this.lblImagenProducto.Location = new System.Drawing.Point(260, 73);
            this.lblImagenProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImagenProducto.Name = "lblImagenProducto";
            this.lblImagenProducto.Size = new System.Drawing.Size(141, 16);
            this.lblImagenProducto.TabIndex = 4;
            this.lblImagenProducto.Text = "Imagen del producto  *";
            // 
            // lblInformacionProducto
            // 
            this.lblInformacionProducto.AutoSize = true;
            this.lblInformacionProducto.Location = new System.Drawing.Point(61, 159);
            this.lblInformacionProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInformacionProducto.Name = "lblInformacionProducto";
            this.lblInformacionProducto.Size = new System.Drawing.Size(154, 16);
            this.lblInformacionProducto.TabIndex = 3;
            this.lblInformacionProducto.Text = "Información del producto";
            // 
            // lblRegistrarProducto
            // 
            this.lblRegistrarProducto.AutoSize = true;
            this.lblRegistrarProducto.Location = new System.Drawing.Point(61, 125);
            this.lblRegistrarProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegistrarProducto.Name = "lblRegistrarProducto";
            this.lblRegistrarProducto.Size = new System.Drawing.Size(119, 16);
            this.lblRegistrarProducto.TabIndex = 1;
            this.lblRegistrarProducto.Text = "Registrar Producto";
            // 
            // pnlRegistrarProducto
            // 
            this.pnlRegistrarProducto.Controls.Add(this.lblValidarDecrip);
            this.pnlRegistrarProducto.Controls.Add(this.lblValidarCat);
            this.pnlRegistrarProducto.Controls.Add(this.lblValidarEstado);
            this.pnlRegistrarProducto.Controls.Add(this.lblValidarNombre);
            this.pnlRegistrarProducto.Controls.Add(this.lblValidarPrecio);
            this.pnlRegistrarProducto.Controls.Add(this.lblValidarCod);
            this.pnlRegistrarProducto.Controls.Add(this.cbxCategoria);
            this.pnlRegistrarProducto.Controls.Add(this.lblSeleccionarImagen);
            this.pnlRegistrarProducto.Controls.Add(this.lblCategoría);
            this.pnlRegistrarProducto.Controls.Add(this.picProducto);
            this.pnlRegistrarProducto.Controls.Add(this.cbxEstadoProducto);
            this.pnlRegistrarProducto.Controls.Add(this.lblEstadoProducto);
            this.pnlRegistrarProducto.Controls.Add(this.lblInformacionProducto);
            this.pnlRegistrarProducto.Controls.Add(this.txtCodigoProducto);
            this.pnlRegistrarProducto.Controls.Add(this.lblRegistrarProducto);
            this.pnlRegistrarProducto.Controls.Add(this.lblCodigoProducto);
            this.pnlRegistrarProducto.Controls.Add(this.lblNombreProducto);
            this.pnlRegistrarProducto.Controls.Add(this.txtDescripcionProducto);
            this.pnlRegistrarProducto.Controls.Add(this.txtNombreProducto);
            this.pnlRegistrarProducto.Controls.Add(this.lblDescripcionProducto);
            this.pnlRegistrarProducto.Controls.Add(this.lblPrecioProducto);
            this.pnlRegistrarProducto.Controls.Add(this.txtPrecioProducto);
            this.pnlRegistrarProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRegistrarProducto.Location = new System.Drawing.Point(4, 4);
            this.pnlRegistrarProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlRegistrarProducto.Name = "pnlRegistrarProducto";
            this.pnlRegistrarProducto.Size = new System.Drawing.Size(884, 470);
            this.pnlRegistrarProducto.TabIndex = 18;
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
            this.cbxCategoria.Location = new System.Drawing.Point(360, 278);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(160, 24);
            this.cbxCategoria.TabIndex = 24;
            // 
            // lblCategoría
            // 
            this.lblCategoría.AutoSize = true;
            this.lblCategoría.Location = new System.Drawing.Point(356, 263);
            this.lblCategoría.Name = "lblCategoría";
            this.lblCategoría.Size = new System.Drawing.Size(74, 16);
            this.lblCategoría.TabIndex = 23;
            this.lblCategoría.Text = "Categoría *";
            // 
            // cbxEstadoProducto
            // 
            this.cbxEstadoProducto.AutoCompleteCustomSource.AddRange(new string[] {
            "Activo",
            "Inactivo"});
            this.cbxEstadoProducto.FormattingEnabled = true;
            this.cbxEstadoProducto.Location = new System.Drawing.Point(122, 279);
            this.cbxEstadoProducto.Name = "cbxEstadoProducto";
            this.cbxEstadoProducto.Size = new System.Drawing.Size(160, 24);
            this.cbxEstadoProducto.TabIndex = 22;
            // 
            // lblEstadoProducto
            // 
            this.lblEstadoProducto.AutoSize = true;
            this.lblEstadoProducto.Location = new System.Drawing.Point(119, 263);
            this.lblEstadoProducto.Name = "lblEstadoProducto";
            this.lblEstadoProducto.Size = new System.Drawing.Size(136, 16);
            this.lblEstadoProducto.TabIndex = 21;
            this.lblEstadoProducto.Text = "Estado del producto *";
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.Location = new System.Drawing.Point(557, 179);
            this.txtCodigoProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(132, 22);
            this.txtCodigoProducto.TabIndex = 18;
            // 
            // lblCodigoProducto
            // 
            this.lblCodigoProducto.AutoSize = true;
            this.lblCodigoProducto.Location = new System.Drawing.Point(564, 159);
            this.lblCodigoProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoProducto.Name = "lblCodigoProducto";
            this.lblCodigoProducto.Size = new System.Drawing.Size(137, 16);
            this.lblCodigoProducto.TabIndex = 17;
            this.lblCodigoProducto.Text = "Código del producto *";
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Location = new System.Drawing.Point(763, 230);
            this.lblNombreProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(142, 16);
            this.lblNombreProducto.TabIndex = 7;
            this.lblNombreProducto.Text = "Nombre del producto *";
            // 
            // txtDescripcionProducto
            // 
            this.txtDescripcionProducto.Location = new System.Drawing.Point(575, 280);
            this.txtDescripcionProducto.Name = "txtDescripcionProducto";
            this.txtDescripcionProducto.Size = new System.Drawing.Size(110, 20);
            this.txtDescripcionProducto.TabIndex = 16;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(768, 251);
            this.txtNombreProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(132, 22);
            this.txtNombreProducto.TabIndex = 8;
            // 
            // lblDescripcionProducto
            // 
            this.lblDescripcionProducto.AutoSize = true;
            this.lblDescripcionProducto.Location = new System.Drawing.Point(572, 263);
            this.lblDescripcionProducto.Name = "lblDescripcionProducto";
            this.lblDescripcionProducto.Size = new System.Drawing.Size(87, 16);
            this.lblDescripcionProducto.TabIndex = 15;
            this.lblDescripcionProducto.Text = "Descripción *";
            // 
            // lblPrecioProducto
            // 
            this.lblPrecioProducto.AutoSize = true;
            this.lblPrecioProducto.Location = new System.Drawing.Point(467, 230);
            this.lblPrecioProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecioProducto.Name = "lblPrecioProducto";
            this.lblPrecioProducto.Size = new System.Drawing.Size(72, 16);
            this.lblPrecioProducto.TabIndex = 13;
            this.lblPrecioProducto.Text = "Precio ($) *";
            // 
            // txtPrecioProducto
            // 
            this.txtPrecioProducto.Location = new System.Drawing.Point(475, 251);
            this.txtPrecioProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrecioProducto.Name = "txtPrecioProducto";
            this.txtPrecioProducto.Size = new System.Drawing.Size(132, 22);
            this.txtPrecioProducto.TabIndex = 14;
            // 
            // tbpPedidos
            // 
            this.tbpPedidos.Controls.Add(this.pnlPedidos);
            this.tbpPedidos.Location = new System.Drawing.Point(4, 25);
            this.tbpPedidos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbpPedidos.Name = "tbpPedidos";
            this.tbpPedidos.Size = new System.Drawing.Size(892, 478);
            this.tbpPedidos.TabIndex = 2;
            this.tbpPedidos.Text = "Pedidos";
            this.tbpPedidos.UseVisualStyleBackColor = true;
            // 
            // pnlPedidos
            // 
            this.pnlPedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPedidos.Location = new System.Drawing.Point(0, 0);
            this.pnlPedidos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlPedidos.Name = "pnlPedidos";
            this.pnlPedidos.Size = new System.Drawing.Size(892, 478);
            this.pnlPedidos.TabIndex = 0;
            // 
            // tbpFacturas
            // 
            this.tbpFacturas.Controls.Add(this.pnlFacturas);
            this.tbpFacturas.Location = new System.Drawing.Point(4, 25);
            this.tbpFacturas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbpFacturas.Name = "tbpFacturas";
            this.tbpFacturas.Size = new System.Drawing.Size(892, 478);
            this.tbpFacturas.TabIndex = 3;
            this.tbpFacturas.Text = "Facturas";
            this.tbpFacturas.UseVisualStyleBackColor = true;
            // 
            // pnlFacturas
            // 
            this.pnlFacturas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFacturas.Location = new System.Drawing.Point(0, 0);
            this.pnlFacturas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlFacturas.Name = "pnlFacturas";
            this.pnlFacturas.Size = new System.Drawing.Size(892, 478);
            this.pnlFacturas.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // lblValidarCod
            // 
            this.lblValidarCod.AutoSize = true;
            this.lblValidarCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidarCod.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblValidarCod.Location = new System.Drawing.Point(127, 227);
            this.lblValidarCod.Name = "lblValidarCod";
            this.lblValidarCod.Size = new System.Drawing.Size(91, 12);
            this.lblValidarCod.TabIndex = 25;
            this.lblValidarCod.Text = "Entre 1 y 10 números";
            // 
            // lblValidarPrecio
            // 
            this.lblValidarPrecio.AutoSize = true;
            this.lblValidarPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidarPrecio.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblValidarPrecio.Location = new System.Drawing.Point(359, 227);
            this.lblValidarPrecio.Name = "lblValidarPrecio";
            this.lblValidarPrecio.Size = new System.Drawing.Size(86, 12);
            this.lblValidarPrecio.TabIndex = 26;
            this.lblValidarPrecio.Text = "Entre 100 y 200.000";
            // 
            // lblValidarNombre
            // 
            this.lblValidarNombre.AutoSize = true;
            this.lblValidarNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidarNombre.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblValidarNombre.Location = new System.Drawing.Point(576, 226);
            this.lblValidarNombre.Name = "lblValidarNombre";
            this.lblValidarNombre.Size = new System.Drawing.Size(94, 12);
            this.lblValidarNombre.TabIndex = 27;
            this.lblValidarNombre.Text = "Solo letras y espacios";
            // 
            // lblValidarEstado
            // 
            this.lblValidarEstado.AutoSize = true;
            this.lblValidarEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidarEstado.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblValidarEstado.Location = new System.Drawing.Point(123, 302);
            this.lblValidarEstado.Name = "lblValidarEstado";
            this.lblValidarEstado.Size = new System.Drawing.Size(89, 12);
            this.lblValidarEstado.TabIndex = 28;
            this.lblValidarEstado.Text = "Seleccione el estado";
            // 
            // lblValidarCat
            // 
            this.lblValidarCat.AutoSize = true;
            this.lblValidarCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidarCat.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblValidarCat.Location = new System.Drawing.Point(360, 300);
            this.lblValidarCat.Name = "lblValidarCat";
            this.lblValidarCat.Size = new System.Drawing.Size(99, 12);
            this.lblValidarCat.TabIndex = 29;
            this.lblValidarCat.Text = "Seleccione la categoría";
            // 
            // lblValidarDecrip
            // 
            this.lblValidarDecrip.AutoSize = true;
            this.lblValidarDecrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidarDecrip.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblValidarDecrip.Location = new System.Drawing.Point(574, 301);
            this.lblValidarDecrip.Name = "lblValidarDecrip";
            this.lblValidarDecrip.Size = new System.Drawing.Size(106, 12);
            this.lblValidarDecrip.TabIndex = 30;
            this.lblValidarDecrip.Text = "No mayor a 200 palabras";
            // 
            // btnLimpiarBusqueda
            // 
            this.btnLimpiarBusqueda.Location = new System.Drawing.Point(677, 1);
            this.btnLimpiarBusqueda.Name = "btnLimpiarBusqueda";
            this.btnLimpiarBusqueda.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiarBusqueda.TabIndex = 3;
            this.btnLimpiarBusqueda.Text = "Limpiar";
            this.btnLimpiarBusqueda.UseVisualStyleBackColor = true;
            // 
            // FormMenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 528);
            this.Controls.Add(this.tbcMenuAdmin);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormMenuAdmin";
            this.Text = "FormMenuAdmin";
            this.Load += new System.EventHandler(this.FormMenuAdmin_Load);
            this.tbcMenuAdmin.ResumeLayout(false);
            this.tbpProductos.ResumeLayout(false);
            this.pnlProductos.ResumeLayout(false);
            this.pnlProductos.PerformLayout();
            this.flowPanelProductos.ResumeLayout(false);
            this.flowPanelProductos.PerformLayout();
            this.tbpRegistrarProducto.ResumeLayout(false);
            this.tbpRegistrarProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProducto)).EndInit();
            this.pnlRegistrarProducto.ResumeLayout(false);
            this.pnlRegistrarProducto.PerformLayout();
            this.tbpPedidos.ResumeLayout(false);
            this.tbpFacturas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcMenuAdmin;
        private System.Windows.Forms.TabPage tbpProductos;
        private System.Windows.Forms.TabPage tbpRegistrarProducto;
        private System.Windows.Forms.TabPage tbpPedidos;
        private System.Windows.Forms.TabPage tbpFacturas;
        private System.Windows.Forms.Label lblRegistrarProducto;
        private System.Windows.Forms.Label lblImagenProducto;
        private System.Windows.Forms.Label lblInformacionProducto;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.PictureBox picProducto;
        private System.Windows.Forms.Label lblSeleccionarImagen;
        private System.Windows.Forms.TextBox txtDescripcionProducto;
        private System.Windows.Forms.Label lblDescripcionProducto;
        private System.Windows.Forms.TextBox txtPrecioProducto;
        private System.Windows.Forms.Label lblPrecioProducto;
        private System.Windows.Forms.Button btnRegistrarProducto;
        private System.Windows.Forms.Panel pnlProductos;
        private System.Windows.Forms.Panel pnlRegistrarProducto;
        private System.Windows.Forms.Panel pnlPedidos;
        private System.Windows.Forms.Panel pnlFacturas;
        private System.Windows.Forms.Label lblCodigoProducto;
        private System.Windows.Forms.TextBox txtCodigoProducto;
        private System.Windows.Forms.ComboBox cbxEstadoProducto;
        private System.Windows.Forms.Label lblEstadoProducto;
        private System.Windows.Forms.FlowLayoutPanel flowPanelProductos;
        private System.Windows.Forms.Label lblCategoría;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.TextBox txtBuscarProducto;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblValidarPrecio;
        private System.Windows.Forms.Label lblValidarCod;
        private System.Windows.Forms.Label lblValidarEstado;
        private System.Windows.Forms.Label lblValidarNombre;
        private System.Windows.Forms.Label lblValidarDecrip;
        private System.Windows.Forms.Label lblValidarCat;
        private System.Windows.Forms.Button btnLimpiarBusqueda;
    }
}
*/