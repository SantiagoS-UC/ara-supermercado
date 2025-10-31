namespace AraSupermercado.presentacion
{
    partial class UcProductoDetalle
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlImagen = new System.Windows.Forms.Panel();
            this.btnAnadirCarrito = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.picProductoDetalle = new System.Windows.Forms.PictureBox();
            this.btnDisminuir = new System.Windows.Forms.Button();
            this.btnAumentar = new System.Windows.Forms.Button();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.pnlImagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProductoDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlImagen
            // 
            this.pnlImagen.Controls.Add(this.btnDisminuir);
            this.pnlImagen.Controls.Add(this.btnAnadirCarrito);
            this.pnlImagen.Controls.Add(this.lblCantidad);
            this.pnlImagen.Controls.Add(this.btnCerrar);
            this.pnlImagen.Controls.Add(this.btnAumentar);
            this.pnlImagen.Controls.Add(this.lblDescripcion);
            this.pnlImagen.Controls.Add(this.lblPrecio);
            this.pnlImagen.Controls.Add(this.lblNombre);
            this.pnlImagen.Controls.Add(this.picProductoDetalle);
            this.pnlImagen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlImagen.Location = new System.Drawing.Point(0, 0);
            this.pnlImagen.Name = "pnlImagen";
            this.pnlImagen.Size = new System.Drawing.Size(1394, 700);
            this.pnlImagen.TabIndex = 1;
            // 
            // btnAnadirCarrito
            // 
            this.btnAnadirCarrito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(111)))), ((int)(((byte)(33)))));
            this.btnAnadirCarrito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnadirCarrito.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnadirCarrito.ForeColor = System.Drawing.Color.White;
            this.btnAnadirCarrito.Location = new System.Drawing.Point(320, 556);
            this.btnAnadirCarrito.Name = "btnAnadirCarrito";
            this.btnAnadirCarrito.Size = new System.Drawing.Size(203, 52);
            this.btnAnadirCarrito.TabIndex = 7;
            this.btnAnadirCarrito.Text = "Añadir al Carrito";
            this.btnAnadirCarrito.UseVisualStyleBackColor = false;
            this.btnAnadirCarrito.Click += new System.EventHandler(this.btnAnadirCarrito_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(111)))), ((int)(((byte)(33)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(1161, 558);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(230, 51);
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.Text = "Cerrar Información";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(875, 119);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(400, 180);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "descripción";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.ForeColor = System.Drawing.Color.Red;
            this.lblPrecio.Location = new System.Drawing.Point(873, 78);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(78, 31);
            this.lblPrecio.TabIndex = 3;
            this.lblPrecio.Text = "precio";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(1009, 22);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(120, 38);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "nombre";
            // 
            // picProductoDetalle
            // 
            this.picProductoDetalle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picProductoDetalle.Location = new System.Drawing.Point(3, 3);
            this.picProductoDetalle.Name = "picProductoDetalle";
            this.picProductoDetalle.Size = new System.Drawing.Size(620, 547);
            this.picProductoDetalle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProductoDetalle.TabIndex = 0;
            this.picProductoDetalle.TabStop = false;
            // 
            // btnDisminuir
            // 
            this.btnDisminuir.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisminuir.Location = new System.Drawing.Point(91, 558);
            this.btnDisminuir.Name = "btnDisminuir";
            this.btnDisminuir.Size = new System.Drawing.Size(55, 51);
            this.btnDisminuir.TabIndex = 6;
            this.btnDisminuir.Text = "-";
            this.btnDisminuir.UseVisualStyleBackColor = true;
            this.btnDisminuir.Click += new System.EventHandler(this.btnDisminuir_Click);
            // 
            // btnAumentar
            // 
            this.btnAumentar.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAumentar.Location = new System.Drawing.Point(217, 556);
            this.btnAumentar.Name = "btnAumentar";
            this.btnAumentar.Size = new System.Drawing.Size(55, 50);
            this.btnAumentar.TabIndex = 5;
            this.btnAumentar.Text = "+";
            this.btnAumentar.UseVisualStyleBackColor = true;
            this.btnAumentar.Click += new System.EventHandler(this.btnAumentar_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(168, 568);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(30, 32);
            this.lblCantidad.TabIndex = 4;
            this.lblCantidad.Text = "#";
            this.lblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UcProductoDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlImagen);
            this.Name = "UcProductoDetalle";
            this.Size = new System.Drawing.Size(1394, 700);
            this.pnlImagen.ResumeLayout(false);
            this.pnlImagen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProductoDetalle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlImagen;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnAnadirCarrito;
        private System.Windows.Forms.Button btnDisminuir;
        private System.Windows.Forms.Button btnAumentar;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.PictureBox picProductoDetalle;
    }
}
