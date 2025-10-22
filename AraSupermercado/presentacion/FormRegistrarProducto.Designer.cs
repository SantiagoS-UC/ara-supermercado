namespace AraSupermercado.presentacion
{
    partial class FormRegistrarProducto
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
            this.pnlRegistrarProducto = new System.Windows.Forms.Panel();
            this.lblSeleccionarImagen = new System.Windows.Forms.Label();
            this.btnRegistrarProducto = new System.Windows.Forms.Button();
            this.txtDescripcionProducto = new System.Windows.Forms.TextBox();
            this.lblDescripcionProducto = new System.Windows.Forms.Label();
            this.txtPrecioProducto = new System.Windows.Forms.TextBox();
            this.lblPrecioProducto = new System.Windows.Forms.Label();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.lblImagenProducto = new System.Windows.Forms.Label();
            this.lblInformacionProducto = new System.Windows.Forms.Label();
            this.lblRegistrarProducto = new System.Windows.Forms.Label();
            this.picProducto = new System.Windows.Forms.PictureBox();
            this.pnlRegistrarProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlRegistrarProducto
            // 
            this.pnlRegistrarProducto.Controls.Add(this.lblSeleccionarImagen);
            this.pnlRegistrarProducto.Controls.Add(this.btnRegistrarProducto);
            this.pnlRegistrarProducto.Controls.Add(this.txtDescripcionProducto);
            this.pnlRegistrarProducto.Controls.Add(this.lblDescripcionProducto);
            this.pnlRegistrarProducto.Controls.Add(this.txtPrecioProducto);
            this.pnlRegistrarProducto.Controls.Add(this.lblPrecioProducto);
            this.pnlRegistrarProducto.Controls.Add(this.txtNombreProducto);
            this.pnlRegistrarProducto.Controls.Add(this.lblNombreProducto);
            this.pnlRegistrarProducto.Controls.Add(this.lblImagenProducto);
            this.pnlRegistrarProducto.Controls.Add(this.lblInformacionProducto);
            this.pnlRegistrarProducto.Controls.Add(this.lblRegistrarProducto);
            this.pnlRegistrarProducto.Controls.Add(this.picProducto);
            this.pnlRegistrarProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRegistrarProducto.Location = new System.Drawing.Point(0, 0);
            this.pnlRegistrarProducto.Name = "pnlRegistrarProducto";
            this.pnlRegistrarProducto.Size = new System.Drawing.Size(800, 450);
            this.pnlRegistrarProducto.TabIndex = 0;
            // 
            // lblSeleccionarImagen
            // 
            this.lblSeleccionarImagen.BackColor = System.Drawing.Color.Transparent;
            this.lblSeleccionarImagen.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccionarImagen.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblSeleccionarImagen.Location = new System.Drawing.Point(388, 157);
            this.lblSeleccionarImagen.Name = "lblSeleccionarImagen";
            this.lblSeleccionarImagen.Size = new System.Drawing.Size(121, 23);
            this.lblSeleccionarImagen.TabIndex = 11;
            this.lblSeleccionarImagen.Text = "Cargar imagen";
            this.lblSeleccionarImagen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSeleccionarImagen.Click += new System.EventHandler(this.lblSeleccionarImagen_Click);
            // 
            // btnRegistrarProducto
            // 
            this.btnRegistrarProducto.Location = new System.Drawing.Point(353, 405);
            this.btnRegistrarProducto.Name = "btnRegistrarProducto";
            this.btnRegistrarProducto.Size = new System.Drawing.Size(124, 23);
            this.btnRegistrarProducto.TabIndex = 10;
            this.btnRegistrarProducto.Text = "Guardar Producto";
            this.btnRegistrarProducto.UseVisualStyleBackColor = true;
            // 
            // txtDescripcionProducto
            // 
            this.txtDescripcionProducto.Location = new System.Drawing.Point(192, 339);
            this.txtDescripcionProducto.Name = "txtDescripcionProducto";
            this.txtDescripcionProducto.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcionProducto.TabIndex = 9;
            // 
            // lblDescripcionProducto
            // 
            this.lblDescripcionProducto.AutoSize = true;
            this.lblDescripcionProducto.Location = new System.Drawing.Point(192, 322);
            this.lblDescripcionProducto.Name = "lblDescripcionProducto";
            this.lblDescripcionProducto.Size = new System.Drawing.Size(70, 13);
            this.lblDescripcionProducto.TabIndex = 8;
            this.lblDescripcionProducto.Text = "Descripción *";
            // 
            // txtPrecioProducto
            // 
            this.txtPrecioProducto.Location = new System.Drawing.Point(192, 281);
            this.txtPrecioProducto.Name = "txtPrecioProducto";
            this.txtPrecioProducto.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioProducto.TabIndex = 7;
            // 
            // lblPrecioProducto
            // 
            this.lblPrecioProducto.AutoSize = true;
            this.lblPrecioProducto.Location = new System.Drawing.Point(195, 264);
            this.lblPrecioProducto.Name = "lblPrecioProducto";
            this.lblPrecioProducto.Size = new System.Drawing.Size(59, 13);
            this.lblPrecioProducto.TabIndex = 6;
            this.lblPrecioProducto.Text = "Precio ($) *";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(195, 222);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(100, 20);
            this.txtNombreProducto.TabIndex = 5;
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Location = new System.Drawing.Point(192, 205);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(113, 13);
            this.lblNombreProducto.TabIndex = 4;
            this.lblNombreProducto.Text = "Nombre del producto *";
            // 
            // lblImagenProducto
            // 
            this.lblImagenProducto.AutoSize = true;
            this.lblImagenProducto.Location = new System.Drawing.Point(184, 97);
            this.lblImagenProducto.Name = "lblImagenProducto";
            this.lblImagenProducto.Size = new System.Drawing.Size(114, 13);
            this.lblImagenProducto.TabIndex = 2;
            this.lblImagenProducto.Text = "Imagen del producto  *";
            // 
            // lblInformacionProducto
            // 
            this.lblInformacionProducto.AutoSize = true;
            this.lblInformacionProducto.Location = new System.Drawing.Point(123, 47);
            this.lblInformacionProducto.Name = "lblInformacionProducto";
            this.lblInformacionProducto.Size = new System.Drawing.Size(124, 13);
            this.lblInformacionProducto.TabIndex = 1;
            this.lblInformacionProducto.Text = "Información del producto";
            // 
            // lblRegistrarProducto
            // 
            this.lblRegistrarProducto.AutoSize = true;
            this.lblRegistrarProducto.Location = new System.Drawing.Point(350, 9);
            this.lblRegistrarProducto.Name = "lblRegistrarProducto";
            this.lblRegistrarProducto.Size = new System.Drawing.Size(95, 13);
            this.lblRegistrarProducto.TabIndex = 0;
            this.lblRegistrarProducto.Text = "Registrar Producto";
            // 
            // picProducto
            // 
            this.picProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picProducto.Location = new System.Drawing.Point(353, 124);
            this.picProducto.Name = "picProducto";
            this.picProducto.Size = new System.Drawing.Size(187, 94);
            this.picProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProducto.TabIndex = 3;
            this.picProducto.TabStop = false;
            this.picProducto.Click += new System.EventHandler(this.picProducto_Click);
            // 
            // FormRegistrarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlRegistrarProducto);
            this.Name = "FormRegistrarProducto";
            this.Text = "¿";
            this.Load += new System.EventHandler(this.FormRegistrarProducto_Load);
            this.pnlRegistrarProducto.ResumeLayout(false);
            this.pnlRegistrarProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRegistrarProducto;
        private System.Windows.Forms.Label lblRegistrarProducto;
        private System.Windows.Forms.Label lblInformacionProducto;
        private System.Windows.Forms.PictureBox picProducto;
        private System.Windows.Forms.Label lblImagenProducto;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.Label lblDescripcionProducto;
        private System.Windows.Forms.TextBox txtPrecioProducto;
        private System.Windows.Forms.Label lblPrecioProducto;
        private System.Windows.Forms.Button btnRegistrarProducto;
        private System.Windows.Forms.TextBox txtDescripcionProducto;
        private System.Windows.Forms.Label lblSeleccionarImagen;
    }
}