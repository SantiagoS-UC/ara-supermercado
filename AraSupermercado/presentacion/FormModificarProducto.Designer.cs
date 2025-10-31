namespace AraSupermercado.presentacion
{
    partial class FormModificarProducto
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
            this.pnlModificarProducto = new System.Windows.Forms.Panel();
            this.btnGuardarModificar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblValidarDecrip = new System.Windows.Forms.Label();
            this.lblValidarCat = new System.Windows.Forms.Label();
            this.lblValidarEstado = new System.Windows.Forms.Label();
            this.lblValidarNombre = new System.Windows.Forms.Label();
            this.lblValidarPrecio = new System.Windows.Forms.Label();
            this.lblValidarCod = new System.Windows.Forms.Label();
            this.cbxCategoriaMod = new System.Windows.Forms.ComboBox();
            this.lblCategoríaMod = new System.Windows.Forms.Label();
            this.cbxEstadoProductoMod = new System.Windows.Forms.ComboBox();
            this.lblEstadoProductoMod = new System.Windows.Forms.Label();
            this.txtCodigoProductoMod = new System.Windows.Forms.TextBox();
            this.lblCodigoProductoMod = new System.Windows.Forms.Label();
            this.lblNombreProductoMod = new System.Windows.Forms.Label();
            this.txtDescripcionProductoMod = new System.Windows.Forms.TextBox();
            this.txtNombreProductoMod = new System.Windows.Forms.TextBox();
            this.lblDescripcionProductoMod = new System.Windows.Forms.Label();
            this.lblPrecioProductoMod = new System.Windows.Forms.Label();
            this.txtPrecioProductoMod = new System.Windows.Forms.TextBox();
            this.picProductoMod = new System.Windows.Forms.PictureBox();
            this.lblImagenProductoMod = new System.Windows.Forms.Label();
            this.lblInformacionProductoMod = new System.Windows.Forms.Label();
            this.lblModificarProducto = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlModificarProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProductoMod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlModificarProducto
            // 
            this.pnlModificarProducto.BackColor = System.Drawing.Color.White;
            this.pnlModificarProducto.Controls.Add(this.btnGuardarModificar);
            this.pnlModificarProducto.Controls.Add(this.btnVolver);
            this.pnlModificarProducto.Controls.Add(this.lblValidarDecrip);
            this.pnlModificarProducto.Controls.Add(this.lblValidarCat);
            this.pnlModificarProducto.Controls.Add(this.lblValidarEstado);
            this.pnlModificarProducto.Controls.Add(this.lblValidarNombre);
            this.pnlModificarProducto.Controls.Add(this.lblValidarPrecio);
            this.pnlModificarProducto.Controls.Add(this.lblValidarCod);
            this.pnlModificarProducto.Controls.Add(this.cbxCategoriaMod);
            this.pnlModificarProducto.Controls.Add(this.lblCategoríaMod);
            this.pnlModificarProducto.Controls.Add(this.cbxEstadoProductoMod);
            this.pnlModificarProducto.Controls.Add(this.lblEstadoProductoMod);
            this.pnlModificarProducto.Controls.Add(this.txtCodigoProductoMod);
            this.pnlModificarProducto.Controls.Add(this.lblCodigoProductoMod);
            this.pnlModificarProducto.Controls.Add(this.lblNombreProductoMod);
            this.pnlModificarProducto.Controls.Add(this.txtDescripcionProductoMod);
            this.pnlModificarProducto.Controls.Add(this.txtNombreProductoMod);
            this.pnlModificarProducto.Controls.Add(this.lblDescripcionProductoMod);
            this.pnlModificarProducto.Controls.Add(this.lblPrecioProductoMod);
            this.pnlModificarProducto.Controls.Add(this.txtPrecioProductoMod);
            this.pnlModificarProducto.Controls.Add(this.picProductoMod);
            this.pnlModificarProducto.Controls.Add(this.lblImagenProductoMod);
            this.pnlModificarProducto.Controls.Add(this.lblInformacionProductoMod);
            this.pnlModificarProducto.Controls.Add(this.lblModificarProducto);
            this.pnlModificarProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlModificarProducto.Location = new System.Drawing.Point(0, 0);
            this.pnlModificarProducto.Name = "pnlModificarProducto";
            this.pnlModificarProducto.Size = new System.Drawing.Size(800, 450);
            this.pnlModificarProducto.TabIndex = 0;
            // 
            // btnGuardarModificar
            // 
            this.btnGuardarModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarModificar.Location = new System.Drawing.Point(484, 362);
            this.btnGuardarModificar.Name = "btnGuardarModificar";
            this.btnGuardarModificar.Size = new System.Drawing.Size(105, 23);
            this.btnGuardarModificar.TabIndex = 50;
            this.btnGuardarModificar.Text = "Guardar Cambios";
            this.btnGuardarModificar.UseVisualStyleBackColor = true;
            this.btnGuardarModificar.Click += new System.EventHandler(this.btnGuardarModificar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(700, 24);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 49;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblValidarDecrip
            // 
            this.lblValidarDecrip.AutoSize = true;
            this.lblValidarDecrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidarDecrip.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblValidarDecrip.Location = new System.Drawing.Point(618, 296);
            this.lblValidarDecrip.Name = "lblValidarDecrip";
            this.lblValidarDecrip.Size = new System.Drawing.Size(106, 12);
            this.lblValidarDecrip.TabIndex = 48;
            this.lblValidarDecrip.Text = "No mayor a 200 palabras";
            // 
            // lblValidarCat
            // 
            this.lblValidarCat.AutoSize = true;
            this.lblValidarCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidarCat.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblValidarCat.Location = new System.Drawing.Point(617, 211);
            this.lblValidarCat.Name = "lblValidarCat";
            this.lblValidarCat.Size = new System.Drawing.Size(99, 12);
            this.lblValidarCat.TabIndex = 47;
            this.lblValidarCat.Text = "Seleccione la categoría";
            // 
            // lblValidarEstado
            // 
            this.lblValidarEstado.AutoSize = true;
            this.lblValidarEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidarEstado.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblValidarEstado.Location = new System.Drawing.Point(358, 297);
            this.lblValidarEstado.Name = "lblValidarEstado";
            this.lblValidarEstado.Size = new System.Drawing.Size(89, 12);
            this.lblValidarEstado.TabIndex = 46;
            this.lblValidarEstado.Text = "Seleccione el estado";
            // 
            // lblValidarNombre
            // 
            this.lblValidarNombre.AutoSize = true;
            this.lblValidarNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidarNombre.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblValidarNombre.Location = new System.Drawing.Point(614, 137);
            this.lblValidarNombre.Name = "lblValidarNombre";
            this.lblValidarNombre.Size = new System.Drawing.Size(94, 12);
            this.lblValidarNombre.TabIndex = 45;
            this.lblValidarNombre.Text = "Solo letras y espacios";
            // 
            // lblValidarPrecio
            // 
            this.lblValidarPrecio.AutoSize = true;
            this.lblValidarPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidarPrecio.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblValidarPrecio.Location = new System.Drawing.Point(364, 214);
            this.lblValidarPrecio.Name = "lblValidarPrecio";
            this.lblValidarPrecio.Size = new System.Drawing.Size(86, 12);
            this.lblValidarPrecio.TabIndex = 44;
            this.lblValidarPrecio.Text = "Entre 100 y 200.000";
            // 
            // lblValidarCod
            // 
            this.lblValidarCod.AutoSize = true;
            this.lblValidarCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidarCod.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblValidarCod.Location = new System.Drawing.Point(356, 138);
            this.lblValidarCod.Name = "lblValidarCod";
            this.lblValidarCod.Size = new System.Drawing.Size(91, 12);
            this.lblValidarCod.TabIndex = 43;
            this.lblValidarCod.Text = "Entre 1 y 10 números";
            // 
            // cbxCategoriaMod
            // 
            this.cbxCategoriaMod.AutoCompleteCustomSource.AddRange(new string[] {
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
            this.cbxCategoriaMod.FormattingEnabled = true;
            this.cbxCategoriaMod.Location = new System.Drawing.Point(617, 189);
            this.cbxCategoriaMod.Name = "cbxCategoriaMod";
            this.cbxCategoriaMod.Size = new System.Drawing.Size(121, 21);
            this.cbxCategoriaMod.TabIndex = 42;
            // 
            // lblCategoríaMod
            // 
            this.lblCategoríaMod.AutoSize = true;
            this.lblCategoríaMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoríaMod.Location = new System.Drawing.Point(613, 174);
            this.lblCategoríaMod.Name = "lblCategoríaMod";
            this.lblCategoríaMod.Size = new System.Drawing.Size(68, 15);
            this.lblCategoríaMod.TabIndex = 41;
            this.lblCategoríaMod.Text = "Categoría *";
            // 
            // cbxEstadoProductoMod
            // 
            this.cbxEstadoProductoMod.AutoCompleteCustomSource.AddRange(new string[] {
            "Activo",
            "Inactivo"});
            this.cbxEstadoProductoMod.FormattingEnabled = true;
            this.cbxEstadoProductoMod.Location = new System.Drawing.Point(357, 274);
            this.cbxEstadoProductoMod.Name = "cbxEstadoProductoMod";
            this.cbxEstadoProductoMod.Size = new System.Drawing.Size(121, 21);
            this.cbxEstadoProductoMod.TabIndex = 40;
            // 
            // lblEstadoProductoMod
            // 
            this.lblEstadoProductoMod.AutoSize = true;
            this.lblEstadoProductoMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoProductoMod.Location = new System.Drawing.Point(354, 258);
            this.lblEstadoProductoMod.Name = "lblEstadoProductoMod";
            this.lblEstadoProductoMod.Size = new System.Drawing.Size(124, 15);
            this.lblEstadoProductoMod.TabIndex = 39;
            this.lblEstadoProductoMod.Text = "Estado del producto *";
            // 
            // txtCodigoProductoMod
            // 
            this.txtCodigoProductoMod.Location = new System.Drawing.Point(357, 115);
            this.txtCodigoProductoMod.Name = "txtCodigoProductoMod";
            this.txtCodigoProductoMod.Size = new System.Drawing.Size(104, 20);
            this.txtCodigoProductoMod.TabIndex = 38;
            // 
            // lblCodigoProductoMod
            // 
            this.lblCodigoProductoMod.AutoSize = true;
            this.lblCodigoProductoMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoProductoMod.Location = new System.Drawing.Point(354, 98);
            this.lblCodigoProductoMod.Name = "lblCodigoProductoMod";
            this.lblCodigoProductoMod.Size = new System.Drawing.Size(125, 15);
            this.lblCodigoProductoMod.TabIndex = 37;
            this.lblCodigoProductoMod.Text = "Código del producto *";
            // 
            // lblNombreProductoMod
            // 
            this.lblNombreProductoMod.AutoSize = true;
            this.lblNombreProductoMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProductoMod.Location = new System.Drawing.Point(610, 98);
            this.lblNombreProductoMod.Name = "lblNombreProductoMod";
            this.lblNombreProductoMod.Size = new System.Drawing.Size(131, 15);
            this.lblNombreProductoMod.TabIndex = 31;
            this.lblNombreProductoMod.Text = "Nombre del producto *";
            // 
            // txtDescripcionProductoMod
            // 
            this.txtDescripcionProductoMod.Location = new System.Drawing.Point(619, 275);
            this.txtDescripcionProductoMod.Name = "txtDescripcionProductoMod";
            this.txtDescripcionProductoMod.Size = new System.Drawing.Size(110, 20);
            this.txtDescripcionProductoMod.TabIndex = 36;
            // 
            // txtNombreProductoMod
            // 
            this.txtNombreProductoMod.Location = new System.Drawing.Point(614, 115);
            this.txtNombreProductoMod.Name = "txtNombreProductoMod";
            this.txtNombreProductoMod.Size = new System.Drawing.Size(100, 20);
            this.txtNombreProductoMod.TabIndex = 32;
            // 
            // lblDescripcionProductoMod
            // 
            this.lblDescripcionProductoMod.AutoSize = true;
            this.lblDescripcionProductoMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionProductoMod.Location = new System.Drawing.Point(616, 258);
            this.lblDescripcionProductoMod.Name = "lblDescripcionProductoMod";
            this.lblDescripcionProductoMod.Size = new System.Drawing.Size(80, 15);
            this.lblDescripcionProductoMod.TabIndex = 35;
            this.lblDescripcionProductoMod.Text = "Descripción *";
            // 
            // lblPrecioProductoMod
            // 
            this.lblPrecioProductoMod.AutoSize = true;
            this.lblPrecioProductoMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioProductoMod.Location = new System.Drawing.Point(355, 174);
            this.lblPrecioProductoMod.Name = "lblPrecioProductoMod";
            this.lblPrecioProductoMod.Size = new System.Drawing.Size(68, 15);
            this.lblPrecioProductoMod.TabIndex = 33;
            this.lblPrecioProductoMod.Text = "Precio ($) *";
            // 
            // txtPrecioProductoMod
            // 
            this.txtPrecioProductoMod.Location = new System.Drawing.Point(361, 191);
            this.txtPrecioProductoMod.Name = "txtPrecioProductoMod";
            this.txtPrecioProductoMod.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioProductoMod.TabIndex = 34;
            // 
            // picProductoMod
            // 
            this.picProductoMod.Location = new System.Drawing.Point(54, 83);
            this.picProductoMod.Name = "picProductoMod";
            this.picProductoMod.Size = new System.Drawing.Size(206, 267);
            this.picProductoMod.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProductoMod.TabIndex = 7;
            this.picProductoMod.TabStop = false;
            this.picProductoMod.Click += new System.EventHandler(this.picProductoMod_DoubleClick);
            // 
            // lblImagenProductoMod
            // 
            this.lblImagenProductoMod.AutoSize = true;
            this.lblImagenProductoMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagenProductoMod.Location = new System.Drawing.Point(97, 67);
            this.lblImagenProductoMod.Name = "lblImagenProductoMod";
            this.lblImagenProductoMod.Size = new System.Drawing.Size(131, 15);
            this.lblImagenProductoMod.TabIndex = 6;
            this.lblImagenProductoMod.Text = "Imagen del producto  *";
            // 
            // lblInformacionProductoMod
            // 
            this.lblInformacionProductoMod.AutoSize = true;
            this.lblInformacionProductoMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacionProductoMod.Location = new System.Drawing.Point(448, 47);
            this.lblInformacionProductoMod.Name = "lblInformacionProductoMod";
            this.lblInformacionProductoMod.Size = new System.Drawing.Size(178, 16);
            this.lblInformacionProductoMod.TabIndex = 5;
            this.lblInformacionProductoMod.Text = "Información del producto";
            // 
            // lblModificarProducto
            // 
            this.lblModificarProducto.AutoSize = true;
            this.lblModificarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(111)))), ((int)(((byte)(33)))));
            this.lblModificarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificarProducto.Location = new System.Drawing.Point(12, 9);
            this.lblModificarProducto.Name = "lblModificarProducto";
            this.lblModificarProducto.Size = new System.Drawing.Size(159, 20);
            this.lblModificarProducto.TabIndex = 0;
            this.lblModificarProducto.Text = "Modificar Producto";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // FormModificarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlModificarProducto);
            this.Name = "FormModificarProducto";
            this.Text = "FormModificarProducto";
            this.Load += new System.EventHandler(this.FormModificarProducto_Load);
            this.pnlModificarProducto.ResumeLayout(false);
            this.pnlModificarProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProductoMod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlModificarProducto;
        private System.Windows.Forms.Label lblModificarProducto;
        private System.Windows.Forms.Label lblImagenProductoMod;
        private System.Windows.Forms.Label lblInformacionProductoMod;
        private System.Windows.Forms.PictureBox picProductoMod;
        private System.Windows.Forms.Label lblValidarDecrip;
        private System.Windows.Forms.Label lblValidarCat;
        private System.Windows.Forms.Label lblValidarEstado;
        private System.Windows.Forms.Label lblValidarNombre;
        private System.Windows.Forms.Label lblValidarPrecio;
        private System.Windows.Forms.Label lblValidarCod;
        private System.Windows.Forms.ComboBox cbxCategoriaMod;
        private System.Windows.Forms.Label lblCategoríaMod;
        private System.Windows.Forms.ComboBox cbxEstadoProductoMod;
        private System.Windows.Forms.Label lblEstadoProductoMod;
        private System.Windows.Forms.TextBox txtCodigoProductoMod;
        private System.Windows.Forms.Label lblCodigoProductoMod;
        private System.Windows.Forms.Label lblNombreProductoMod;
        private System.Windows.Forms.TextBox txtDescripcionProductoMod;
        private System.Windows.Forms.TextBox txtNombreProductoMod;
        private System.Windows.Forms.Label lblDescripcionProductoMod;
        private System.Windows.Forms.Label lblPrecioProductoMod;
        private System.Windows.Forms.TextBox txtPrecioProductoMod;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnGuardarModificar;
    }
}