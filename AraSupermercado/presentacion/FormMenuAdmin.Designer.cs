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
            this.tbcMenuAdmin = new System.Windows.Forms.TabControl();
            this.tbpProductos = new System.Windows.Forms.TabPage();
            this.pnlProductos = new System.Windows.Forms.Panel();
            this.tbpRegistrarProducto = new System.Windows.Forms.TabPage();
            this.btnRegistrarProducto = new System.Windows.Forms.Button();
            this.lblSeleccionarImagen = new System.Windows.Forms.Label();
            this.picProducto = new System.Windows.Forms.PictureBox();
            this.lblImagenProducto = new System.Windows.Forms.Label();
            this.lblInformacionProducto = new System.Windows.Forms.Label();
            this.lblRegistrarProducto = new System.Windows.Forms.Label();
            this.pnlRegistrarProducto = new System.Windows.Forms.Panel();
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
            this.flowPanelProductos = new System.Windows.Forms.FlowLayoutPanel();
            this.lblCategoría = new System.Windows.Forms.Label();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.tbcMenuAdmin.SuspendLayout();
            this.tbpProductos.SuspendLayout();
            this.pnlProductos.SuspendLayout();
            this.tbpRegistrarProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProducto)).BeginInit();
            this.pnlRegistrarProducto.SuspendLayout();
            this.tbpPedidos.SuspendLayout();
            this.tbpFacturas.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcMenuAdmin
            // 
            this.tbcMenuAdmin.Controls.Add(this.tbpProductos);
            this.tbcMenuAdmin.Controls.Add(this.tbpRegistrarProducto);
            this.tbcMenuAdmin.Controls.Add(this.tbpPedidos);
            this.tbcMenuAdmin.Controls.Add(this.tbpFacturas);
            this.tbcMenuAdmin.Location = new System.Drawing.Point(12, 12);
            this.tbcMenuAdmin.Name = "tbcMenuAdmin";
            this.tbcMenuAdmin.SelectedIndex = 0;
            this.tbcMenuAdmin.Size = new System.Drawing.Size(776, 412);
            this.tbcMenuAdmin.TabIndex = 0;
            // 
            // tbpProductos
            // 
            this.tbpProductos.Controls.Add(this.pnlProductos);
            this.tbpProductos.Location = new System.Drawing.Point(4, 22);
            this.tbpProductos.Name = "tbpProductos";
            this.tbpProductos.Padding = new System.Windows.Forms.Padding(3);
            this.tbpProductos.Size = new System.Drawing.Size(768, 386);
            this.tbpProductos.TabIndex = 0;
            this.tbpProductos.Text = "Productos";
            this.tbpProductos.UseVisualStyleBackColor = true;
            // 
            // pnlProductos
            // 
            this.pnlProductos.Controls.Add(this.flowPanelProductos);
            this.pnlProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProductos.Location = new System.Drawing.Point(3, 3);
            this.pnlProductos.Name = "pnlProductos";
            this.pnlProductos.Size = new System.Drawing.Size(762, 380);
            this.pnlProductos.TabIndex = 0;
            // 
            // tbpRegistrarProducto
            // 
            this.tbpRegistrarProducto.Controls.Add(this.btnRegistrarProducto);
            this.tbpRegistrarProducto.Controls.Add(this.lblSeleccionarImagen);
            this.tbpRegistrarProducto.Controls.Add(this.picProducto);
            this.tbpRegistrarProducto.Controls.Add(this.lblImagenProducto);
            this.tbpRegistrarProducto.Controls.Add(this.lblInformacionProducto);
            this.tbpRegistrarProducto.Controls.Add(this.lblRegistrarProducto);
            this.tbpRegistrarProducto.Controls.Add(this.pnlRegistrarProducto);
            this.tbpRegistrarProducto.Location = new System.Drawing.Point(4, 22);
            this.tbpRegistrarProducto.Name = "tbpRegistrarProducto";
            this.tbpRegistrarProducto.Padding = new System.Windows.Forms.Padding(3);
            this.tbpRegistrarProducto.Size = new System.Drawing.Size(768, 386);
            this.tbpRegistrarProducto.TabIndex = 1;
            this.tbpRegistrarProducto.Text = "Registrar producto";
            this.tbpRegistrarProducto.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarProducto
            // 
            this.btnRegistrarProducto.Location = new System.Drawing.Point(356, 348);
            this.btnRegistrarProducto.Name = "btnRegistrarProducto";
            this.btnRegistrarProducto.Size = new System.Drawing.Size(124, 23);
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
            this.lblSeleccionarImagen.Location = new System.Drawing.Point(398, 112);
            this.lblSeleccionarImagen.Name = "lblSeleccionarImagen";
            this.lblSeleccionarImagen.Size = new System.Drawing.Size(121, 23);
            this.lblSeleccionarImagen.TabIndex = 12;
            this.lblSeleccionarImagen.Text = "Cargar imagen";
            this.lblSeleccionarImagen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSeleccionarImagen.Click += new System.EventHandler(this.lblSeleccionarImagen_Click);
            // 
            // picProducto
            // 
            this.picProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picProducto.Location = new System.Drawing.Point(363, 79);
            this.picProducto.Name = "picProducto";
            this.picProducto.Size = new System.Drawing.Size(187, 94);
            this.picProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProducto.TabIndex = 6;
            this.picProducto.TabStop = false;
            this.picProducto.Click += new System.EventHandler(this.picProducto_Click);
            // 
            // lblImagenProducto
            // 
            this.lblImagenProducto.AutoSize = true;
            this.lblImagenProducto.Location = new System.Drawing.Point(195, 59);
            this.lblImagenProducto.Name = "lblImagenProducto";
            this.lblImagenProducto.Size = new System.Drawing.Size(114, 13);
            this.lblImagenProducto.TabIndex = 4;
            this.lblImagenProducto.Text = "Imagen del producto  *";
            // 
            // lblInformacionProducto
            // 
            this.lblInformacionProducto.AutoSize = true;
            this.lblInformacionProducto.Location = new System.Drawing.Point(134, 37);
            this.lblInformacionProducto.Name = "lblInformacionProducto";
            this.lblInformacionProducto.Size = new System.Drawing.Size(124, 13);
            this.lblInformacionProducto.TabIndex = 3;
            this.lblInformacionProducto.Text = "Información del producto";
            // 
            // lblRegistrarProducto
            // 
            this.lblRegistrarProducto.AutoSize = true;
            this.lblRegistrarProducto.Location = new System.Drawing.Point(360, 11);
            this.lblRegistrarProducto.Name = "lblRegistrarProducto";
            this.lblRegistrarProducto.Size = new System.Drawing.Size(95, 13);
            this.lblRegistrarProducto.TabIndex = 1;
            this.lblRegistrarProducto.Text = "Registrar Producto";
            // 
            // pnlRegistrarProducto
            // 
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
            this.pnlRegistrarProducto.Controls.Add(this.lblPrecioProducto);
            this.pnlRegistrarProducto.Controls.Add(this.txtPrecioProducto);
            this.pnlRegistrarProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRegistrarProducto.Location = new System.Drawing.Point(3, 3);
            this.pnlRegistrarProducto.Name = "pnlRegistrarProducto";
            this.pnlRegistrarProducto.Size = new System.Drawing.Size(762, 380);
            this.pnlRegistrarProducto.TabIndex = 18;
            // 
            // cbxEstadoProducto
            // 
            this.cbxEstadoProducto.AutoCompleteCustomSource.AddRange(new string[] {
            "Activo",
            "Inactivo"});
            this.cbxEstadoProducto.FormattingEnabled = true;
            this.cbxEstadoProducto.Location = new System.Drawing.Point(122, 271);
            this.cbxEstadoProducto.Name = "cbxEstadoProducto";
            this.cbxEstadoProducto.Size = new System.Drawing.Size(121, 21);
            this.cbxEstadoProducto.TabIndex = 22;
            // 
            // lblEstadoProducto
            // 
            this.lblEstadoProducto.AutoSize = true;
            this.lblEstadoProducto.Location = new System.Drawing.Point(119, 255);
            this.lblEstadoProducto.Name = "lblEstadoProducto";
            this.lblEstadoProducto.Size = new System.Drawing.Size(109, 13);
            this.lblEstadoProducto.TabIndex = 21;
            this.lblEstadoProducto.Text = "Estado del producto *";
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.Location = new System.Drawing.Point(128, 204);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoProducto.TabIndex = 18;
            // 
            // lblCodigoProducto
            // 
            this.lblCodigoProducto.AutoSize = true;
            this.lblCodigoProducto.Location = new System.Drawing.Point(125, 187);
            this.lblCodigoProducto.Name = "lblCodigoProducto";
            this.lblCodigoProducto.Size = new System.Drawing.Size(109, 13);
            this.lblCodigoProducto.TabIndex = 17;
            this.lblCodigoProducto.Text = "Código del producto *";
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Location = new System.Drawing.Point(572, 187);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(113, 13);
            this.lblNombreProducto.TabIndex = 7;
            this.lblNombreProducto.Text = "Nombre del producto *";
            // 
            // txtDescripcionProducto
            // 
            this.txtDescripcionProducto.Location = new System.Drawing.Point(577, 272);
            this.txtDescripcionProducto.Name = "txtDescripcionProducto";
            this.txtDescripcionProducto.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcionProducto.TabIndex = 16;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(576, 204);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(100, 20);
            this.txtNombreProducto.TabIndex = 8;
            // 
            // lblDescripcionProducto
            // 
            this.lblDescripcionProducto.AutoSize = true;
            this.lblDescripcionProducto.Location = new System.Drawing.Point(572, 255);
            this.lblDescripcionProducto.Name = "lblDescripcionProducto";
            this.lblDescripcionProducto.Size = new System.Drawing.Size(70, 13);
            this.lblDescripcionProducto.TabIndex = 15;
            this.lblDescripcionProducto.Text = "Descripción *";
            // 
            // lblPrecioProducto
            // 
            this.lblPrecioProducto.AutoSize = true;
            this.lblPrecioProducto.Location = new System.Drawing.Point(350, 187);
            this.lblPrecioProducto.Name = "lblPrecioProducto";
            this.lblPrecioProducto.Size = new System.Drawing.Size(59, 13);
            this.lblPrecioProducto.TabIndex = 13;
            this.lblPrecioProducto.Text = "Precio ($) *";
            // 
            // txtPrecioProducto
            // 
            this.txtPrecioProducto.Location = new System.Drawing.Point(356, 204);
            this.txtPrecioProducto.Name = "txtPrecioProducto";
            this.txtPrecioProducto.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioProducto.TabIndex = 14;
            // 
            // tbpPedidos
            // 
            this.tbpPedidos.Controls.Add(this.pnlPedidos);
            this.tbpPedidos.Location = new System.Drawing.Point(4, 22);
            this.tbpPedidos.Name = "tbpPedidos";
            this.tbpPedidos.Size = new System.Drawing.Size(768, 386);
            this.tbpPedidos.TabIndex = 2;
            this.tbpPedidos.Text = "Pedidos";
            this.tbpPedidos.UseVisualStyleBackColor = true;
            // 
            // pnlPedidos
            // 
            this.pnlPedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPedidos.Location = new System.Drawing.Point(0, 0);
            this.pnlPedidos.Name = "pnlPedidos";
            this.pnlPedidos.Size = new System.Drawing.Size(768, 386);
            this.pnlPedidos.TabIndex = 0;
            // 
            // tbpFacturas
            // 
            this.tbpFacturas.Controls.Add(this.pnlFacturas);
            this.tbpFacturas.Location = new System.Drawing.Point(4, 22);
            this.tbpFacturas.Name = "tbpFacturas";
            this.tbpFacturas.Size = new System.Drawing.Size(768, 386);
            this.tbpFacturas.TabIndex = 3;
            this.tbpFacturas.Text = "Facturas";
            this.tbpFacturas.UseVisualStyleBackColor = true;
            // 
            // pnlFacturas
            // 
            this.pnlFacturas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFacturas.Location = new System.Drawing.Point(0, 0);
            this.pnlFacturas.Name = "pnlFacturas";
            this.pnlFacturas.Size = new System.Drawing.Size(768, 386);
            this.pnlFacturas.TabIndex = 0;
            // 
            // flowPanelProductos
            // 
            this.flowPanelProductos.AutoScroll = true;
            this.flowPanelProductos.BackColor = System.Drawing.Color.LightGray;
            this.flowPanelProductos.Location = new System.Drawing.Point(3, 3);
            this.flowPanelProductos.Name = "flowPanelProductos";
            this.flowPanelProductos.Size = new System.Drawing.Size(756, 374);
            this.flowPanelProductos.TabIndex = 0;
            this.flowPanelProductos.WrapContents = false;
            // 
            // lblCategoría
            // 
            this.lblCategoría.AutoSize = true;
            this.lblCategoría.Location = new System.Drawing.Point(356, 255);
            this.lblCategoría.Name = "lblCategoría";
            this.lblCategoría.Size = new System.Drawing.Size(61, 13);
            this.lblCategoría.TabIndex = 23;
            this.lblCategoría.Text = "Categoría *";
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
            this.cbxCategoria.Location = new System.Drawing.Point(360, 270);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(121, 21);
            this.cbxCategoria.TabIndex = 24;
            // 
            // FormMenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 429);
            this.Controls.Add(this.tbcMenuAdmin);
            this.Name = "FormMenuAdmin";
            this.Text = "FormMenuAdmin";
            this.Load += new System.EventHandler(this.FormMenuAdmin_Load);
            this.tbcMenuAdmin.ResumeLayout(false);
            this.tbpProductos.ResumeLayout(false);
            this.pnlProductos.ResumeLayout(false);
            this.tbpRegistrarProducto.ResumeLayout(false);
            this.tbpRegistrarProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProducto)).EndInit();
            this.pnlRegistrarProducto.ResumeLayout(false);
            this.pnlRegistrarProducto.PerformLayout();
            this.tbpPedidos.ResumeLayout(false);
            this.tbpFacturas.ResumeLayout(false);
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
    }
}