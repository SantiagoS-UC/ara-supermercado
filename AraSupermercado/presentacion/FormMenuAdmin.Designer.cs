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
            this.menuStripAdmin = new System.Windows.Forms.MenuStrip();
            this.subMenuProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuRegistrarProducto = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuPedidos = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuFacturas = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuCerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.menuStripAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripAdmin
            // 
            this.menuStripAdmin.AutoSize = false;
            this.menuStripAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(111)))), ((int)(((byte)(33)))));
            this.menuStripAdmin.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuProductos,
            this.subMenuRegistrarProducto,
            this.subMenuPedidos,
            this.subMenuFacturas,
            this.subMenuCerrarSesion});
            this.menuStripAdmin.Location = new System.Drawing.Point(0, 0);
            this.menuStripAdmin.Name = "menuStripAdmin";
            this.menuStripAdmin.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStripAdmin.Size = new System.Drawing.Size(1182, 59);
            this.menuStripAdmin.TabIndex = 0;
            this.menuStripAdmin.Text = "menuAdmin";
            // 
            // subMenuProductos
            // 
            this.subMenuProductos.AutoSize = false;
            this.subMenuProductos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subMenuProductos.Name = "subMenuProductos";
            this.subMenuProductos.Size = new System.Drawing.Size(250, 57);
            this.subMenuProductos.Text = "Productos";
            this.subMenuProductos.Click += new System.EventHandler(this.subMenuProductos_Click);
            // 
            // subMenuRegistrarProducto
            // 
            this.subMenuRegistrarProducto.AutoSize = false;
            this.subMenuRegistrarProducto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subMenuRegistrarProducto.Name = "subMenuRegistrarProducto";
            this.subMenuRegistrarProducto.Size = new System.Drawing.Size(250, 57);
            this.subMenuRegistrarProducto.Text = "Resgistrar Producto";
            this.subMenuRegistrarProducto.Click += new System.EventHandler(this.subMenuRegistrarProducto_Click);
            // 
            // subMenuPedidos
            // 
            this.subMenuPedidos.AutoSize = false;
            this.subMenuPedidos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subMenuPedidos.Name = "subMenuPedidos";
            this.subMenuPedidos.Size = new System.Drawing.Size(250, 57);
            this.subMenuPedidos.Text = "Pedidos";
            this.subMenuPedidos.Click += new System.EventHandler(this.subMenuPedidos_Click);
            //
            //subMenuFacturas
            //
            this.subMenuFacturas.AutoSize = false;
            this.subMenuFacturas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.subMenuFacturas.Name = "subMenuFacturas";
            this.subMenuFacturas.Size = new System.Drawing.Size(250, 57);
            this.subMenuFacturas.Text = "Facturas";
            this.subMenuFacturas.Click += new System.EventHandler(this.subMenuFacturas_Click);

            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(0, 59);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(1182, 594);
            this.pnlContenedor.TabIndex = 1;
            // 
            // subMenuCerrarSesion
            // 
            this.subMenuCerrarSesion.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.subMenuCerrarSesion.AutoSize = false;
            this.subMenuCerrarSesion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subMenuCerrarSesion.Name = "subMenuCerrarSesion";
            this.subMenuCerrarSesion.Size = new System.Drawing.Size(130, 57);
            this.subMenuCerrarSesion.Text = "Cerrar Sesión";
            this.subMenuCerrarSesion.Click += new System.EventHandler(this.subMenuCerrarSesion_Click);
            // 
            // FormMenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.menuStripAdmin);
            this.MainMenuStrip = this.menuStripAdmin;
            this.Name = "FormMenuAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMenuAdmin";
            this.Load += new System.EventHandler(this.FormMenuAdmin_Load);
            this.menuStripAdmin.ResumeLayout(false);
            this.menuStripAdmin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripAdmin;
        private System.Windows.Forms.ToolStripMenuItem subMenuProductos;
        private System.Windows.Forms.ToolStripMenuItem subMenuRegistrarProducto;
        private System.Windows.Forms.ToolStripMenuItem subMenuPedidos;
        private System.Windows.Forms.ToolStripMenuItem subMenuFacturas;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.ToolStripMenuItem subMenuCerrarSesion;
    }
}