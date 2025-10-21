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
            this.SuspendLayout();
            // 
            // pnlRegistrarProducto
            // 
            this.pnlRegistrarProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRegistrarProducto.Location = new System.Drawing.Point(0, 0);
            this.pnlRegistrarProducto.Name = "pnlRegistrarProducto";
            this.pnlRegistrarProducto.Size = new System.Drawing.Size(800, 450);
            this.pnlRegistrarProducto.TabIndex = 0;
            // 
            // FormRegistrarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlRegistrarProducto);
            this.Name = "FormRegistrarProducto";
            this.Text = "FormRegistrarProducto";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRegistrarProducto;
    }
}