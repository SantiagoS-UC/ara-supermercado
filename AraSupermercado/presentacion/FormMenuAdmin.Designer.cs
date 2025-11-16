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
            this.subMenuFacturas = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuPedidos = new System.Windows.Forms.ToolStripMenuItem();
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
            this.subMenuFacturas,
            this.subMenuPedidos});
            this.menuStripAdmin.Location = new System.Drawing.Point(0, 0);
            this.menuStripAdmin.Name = "menuStripAdmin";
            this.menuStripAdmin.Size = new System.Drawing.Size(1181, 52);
            this.menuStripAdmin.TabIndex = 0;
            this.menuStripAdmin.Text = "menuAdmin";
            // 
            // subMenuProductos
            // 
            this.subMenuProductos.Name = "subMenuProductos";
            this.subMenuProductos.Size = new System.Drawing.Size(89, 48);
            this.subMenuProductos.Text = "Productos";
            this.subMenuProductos.Click += new System.EventHandler(this.subMenuProductos_Click);
            // 
            // subMenuRegistrarProducto
            // 
            this.subMenuRegistrarProducto.Name = "subMenuRegistrarProducto";
            this.subMenuRegistrarProducto.Size = new System.Drawing.Size(152, 48);
            this.subMenuRegistrarProducto.Text = "Resgistrar Producto";
            this.subMenuRegistrarProducto.Click += new System.EventHandler(this.subMenuRegistrarProducto_Click);
            // 
            // subMenuFacturas
            // 
            this.subMenuFacturas.Name = "subMenuFacturas";
            this.subMenuFacturas.Size = new System.Drawing.Size(76, 48);
            this.subMenuFacturas.Text = "Facturas";
            // 
            // subMenuPedidos
            // 
            this.subMenuPedidos.Name = "subMenuPedidos";
            this.subMenuPedidos.Size = new System.Drawing.Size(75, 48);
            this.subMenuPedidos.Text = "Pedidos";
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(0, 52);
            this.pnlContenedor.Margin = new System.Windows.Forms.Padding(4);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(1181, 602);
            this.pnlContenedor.TabIndex = 1;
            // 
            // FormMenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 654);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.menuStripAdmin);
            this.MainMenuStrip = this.menuStripAdmin;
            this.Margin = new System.Windows.Forms.Padding(4);
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
    }
}