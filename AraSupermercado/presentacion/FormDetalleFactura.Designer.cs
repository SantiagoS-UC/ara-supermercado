namespace AraSupermercado.presentacion
{
    partial class FormDetalleFactura
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblTotalValor = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.lblMetodoPagoValor = new System.Windows.Forms.Label();
            this.lblMetodoPago = new System.Windows.Forms.Label();
            this.lblEstadoValor = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblFechaValor = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblIdPedidoValor = new System.Windows.Forms.Label();
            this.lblIdPedido = new System.Windows.Forms.Label();
            this.lblDireccionValor = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblClienteValor = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblCodigoValor = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.pnlInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.BackColor = System.Drawing.Color.White;
            this.pnlPrincipal.Controls.Add(this.btnVolver);
            this.pnlPrincipal.Controls.Add(this.lblTotalValor);
            this.pnlPrincipal.Controls.Add(this.lblTotal);
            this.pnlPrincipal.Controls.Add(this.dgvProductos);
            this.pnlPrincipal.Controls.Add(this.pnlInfo);
            this.pnlPrincipal.Controls.Add(this.lblCodigoValor);
            this.pnlPrincipal.Controls.Add(this.lblTitulo);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Padding = new System.Windows.Forms.Padding(20);
            this.pnlPrincipal.Size = new System.Drawing.Size(1182, 653);
            this.pnlPrincipal.TabIndex = 0;
            // 
            // btnVolver
            // 
            this.btnVolver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(111)))), ((int)(((byte)(33)))));
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(23, 585);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(120, 45);
            this.btnVolver.TabIndex = 6;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblTotalValor
            // 
            this.lblTotalValor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalValor.AutoSize = true;
            this.lblTotalValor.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTotalValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(111)))), ((int)(((byte)(33)))));
            this.lblTotalValor.Location = new System.Drawing.Point(110, 535);
            this.lblTotalValor.Name = "lblTotalValor";
            this.lblTotalValor.Size = new System.Drawing.Size(106, 30);
            this.lblTotalValor.TabIndex = 5;
            this.lblTotalValor.Text = "$ 0.00";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(23, 535);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(71, 30);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total:";
            // 
            // dgvProductos
            // 
            this.dgvProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(23, 300);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.Size = new System.Drawing.Size(1136, 220);
            this.dgvProductos.TabIndex = 3;
            // 
            // pnlInfo
            // 
            this.pnlInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.pnlInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInfo.Controls.Add(this.lblMetodoPagoValor);
            this.pnlInfo.Controls.Add(this.lblMetodoPago);
            this.pnlInfo.Controls.Add(this.lblEstadoValor);
            this.pnlInfo.Controls.Add(this.lblEstado);
            this.pnlInfo.Controls.Add(this.lblFechaValor);
            this.pnlInfo.Controls.Add(this.lblFecha);
            this.pnlInfo.Controls.Add(this.lblIdPedidoValor);
            this.pnlInfo.Controls.Add(this.lblIdPedido);
            this.pnlInfo.Controls.Add(this.lblDireccionValor);
            this.pnlInfo.Controls.Add(this.lblDireccion);
            this.pnlInfo.Controls.Add(this.lblClienteValor);
            this.pnlInfo.Controls.Add(this.lblCliente);
            this.pnlInfo.Location = new System.Drawing.Point(23, 75);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Padding = new System.Windows.Forms.Padding(20);
            this.pnlInfo.Size = new System.Drawing.Size(1136, 205);
            this.pnlInfo.TabIndex = 2;
            // 
            // lblMetodoPagoValor
            // 
            this.lblMetodoPagoValor.AutoSize = true;
            this.lblMetodoPagoValor.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblMetodoPagoValor.Location = new System.Drawing.Point(637, 159);
            this.lblMetodoPagoValor.Name = "lblMetodoPagoValor";
            this.lblMetodoPagoValor.Size = new System.Drawing.Size(148, 20);
            this.lblMetodoPagoValor.TabIndex = 11;
            this.lblMetodoPagoValor.Text = "Tarjeta de crédito";
            // 
            // lblMetodoPago
            // 
            this.lblMetodoPago.AutoSize = true;
            this.lblMetodoPago.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblMetodoPago.Location = new System.Drawing.Point(637, 135);
            this.lblMetodoPago.Name = "lblMetodoPago";
            this.lblMetodoPago.Size = new System.Drawing.Size(119, 19);
            this.lblMetodoPago.TabIndex = 10;
            this.lblMetodoPago.Text = "Método de Pago:";
            // 
            // lblEstadoValor
            // 
            this.lblEstadoValor.AutoSize = true;
            this.lblEstadoValor.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblEstadoValor.Location = new System.Drawing.Point(637, 99);
            this.lblEstadoValor.Name = "lblEstadoValor";
            this.lblEstadoValor.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.lblEstadoValor.Size = new System.Drawing.Size(105, 30);
            this.lblEstadoValor.TabIndex = 9;
            this.lblEstadoValor.Text = "Procesando";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblEstado.Location = new System.Drawing.Point(637, 75);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(105, 19);
            this.lblEstado.TabIndex = 8;
            this.lblEstado.Text = "Estado Actual:";
            // 
            // lblFechaValor
            // 
            this.lblFechaValor.AutoSize = true;
            this.lblFechaValor.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblFechaValor.Location = new System.Drawing.Point(637, 44);
            this.lblFechaValor.Name = "lblFechaValor";
            this.lblFechaValor.Size = new System.Drawing.Size(139, 20);
            this.lblFechaValor.TabIndex = 7;
            this.lblFechaValor.Text = "2025-01-15 14:30";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFecha.Location = new System.Drawing.Point(637, 20);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(139, 19);
            this.lblFecha.TabIndex = 6;
            this.lblFecha.Text = "Fecha de Creación:";
            // 
            // lblIdPedidoValor
            // 
            this.lblIdPedidoValor.AutoSize = true;
            this.lblIdPedidoValor.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblIdPedidoValor.Location = new System.Drawing.Point(23, 159);
            this.lblIdPedidoValor.Name = "lblIdPedidoValor";
            this.lblIdPedidoValor.Size = new System.Drawing.Size(58, 20);
            this.lblIdPedidoValor.TabIndex = 5;
            this.lblIdPedidoValor.Text = "# 1234";
            // 
            // lblIdPedido
            // 
            this.lblIdPedido.AutoSize = true;
            this.lblIdPedido.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblIdPedido.Location = new System.Drawing.Point(19, 135);
            this.lblIdPedido.Name = "lblIdPedido";
            this.lblIdPedido.Size = new System.Drawing.Size(101, 19);
            this.lblIdPedido.TabIndex = 4;
            this.lblIdPedido.Text = "ID del Pedido:";
            // 
            // lblDireccionValor
            // 
            this.lblDireccionValor.AutoSize = true;
            this.lblDireccionValor.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblDireccionValor.Location = new System.Drawing.Point(23, 99);
            this.lblDireccionValor.Name = "lblDireccionValor";
            this.lblDireccionValor.Size = new System.Drawing.Size(62, 20);
            this.lblDireccionValor.TabIndex = 3;
            this.lblDireccionValor.Text = "Calle 123";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDireccion.Location = new System.Drawing.Point(19, 75);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(138, 19);
            this.lblDireccion.TabIndex = 2;
            this.lblDireccion.Text = "Dirección de Envío:";
            // 
            // lblClienteValor
            // 
            this.lblClienteValor.AutoSize = true;
            this.lblClienteValor.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblClienteValor.Location = new System.Drawing.Point(23, 44);
            this.lblClienteValor.Name = "lblClienteValor";
            this.lblClienteValor.Size = new System.Drawing.Size(84, 20);
            this.lblClienteValor.TabIndex = 1;
            this.lblClienteValor.Text = "Juan Pérez";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCliente.Location = new System.Drawing.Point(19, 20);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(60, 19);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente:";
            // 
            // lblCodigoValor
            // 
            this.lblCodigoValor.AutoSize = true;
            this.lblCodigoValor.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblCodigoValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(111)))), ((int)(((byte)(33)))));
            this.lblCodigoValor.Location = new System.Drawing.Point(380, 20);
            this.lblCodigoValor.Name = "lblCodigoValor";
            this.lblCodigoValor.Size = new System.Drawing.Size(86, 32);
            this.lblCodigoValor.TabIndex = 1;
            this.lblCodigoValor.Text = "  1234";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(111)))), ((int)(((byte)(33)))));
            this.lblTitulo.Location = new System.Drawing.Point(17, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(277, 32);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Detalles del Pedido #";
            // 
            // FormDetalleFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.pnlPrincipal);
            this.Name = "FormDetalleFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle de Factura";
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCodigoValor;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblClienteValor;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblDireccionValor;
        private System.Windows.Forms.Label lblIdPedido;
        private System.Windows.Forms.Label lblIdPedidoValor;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblFechaValor;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblEstadoValor;
        private System.Windows.Forms.Label lblMetodoPago;
        private System.Windows.Forms.Label lblMetodoPagoValor;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalValor;
        private System.Windows.Forms.Button btnVolver;
    }
}