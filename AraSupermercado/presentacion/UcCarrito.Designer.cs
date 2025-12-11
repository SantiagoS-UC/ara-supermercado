namespace AraSupermercado.presentacion
{
    partial class UcCarrito
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
            this.pnlUcCarrito = new System.Windows.Forms.Panel();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.flpCarrito = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlUcCarrito.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUcCarrito
            // 
            this.pnlUcCarrito.Controls.Add(this.btnVolver);
            this.pnlUcCarrito.Controls.Add(this.btnConfirmar);
            this.pnlUcCarrito.Controls.Add(this.lblTotal);
            this.pnlUcCarrito.Controls.Add(this.flpCarrito);
            this.pnlUcCarrito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUcCarrito.Location = new System.Drawing.Point(0, 0);
            this.pnlUcCarrito.Name = "pnlUcCarrito";
            this.pnlUcCarrito.Size = new System.Drawing.Size(1180, 650);
            this.pnlUcCarrito.TabIndex = 0;
            // 
            // btnVolver
            // 
            this.btnVolver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(119)))), ((int)(((byte)(26)))));
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(869, 592);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(127, 39);
            this.btnVolver.TabIndex = 2;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(119)))), ((int)(((byte)(26)))));
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Location = new System.Drawing.Point(1002, 592);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(175, 39);
            this.btnConfirmar.TabIndex = 1;
            this.btnConfirmar.Text = "Confirmar Pedido";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(3, 607);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(74, 24);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Total: $0";
            // 
            // flpCarrito
            // 
            this.flpCarrito.AutoScroll = true;
            this.flpCarrito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpCarrito.Location = new System.Drawing.Point(0, 0);
            this.flpCarrito.Name = "flpCarrito";
            this.flpCarrito.Size = new System.Drawing.Size(1180, 650);
            this.flpCarrito.TabIndex = 0;
            // 
            // UcCarrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlUcCarrito);
            this.Name = "UcCarrito";
            this.Size = new System.Drawing.Size(1180, 650);
            this.pnlUcCarrito.ResumeLayout(false);
            this.pnlUcCarrito.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUcCarrito;
        private System.Windows.Forms.FlowLayoutPanel flpCarrito;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnVolver;
    }
}
