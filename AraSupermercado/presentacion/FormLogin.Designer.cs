namespace AraSupermercado.presentacion
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.pnlIniciarSesion = new System.Windows.Forms.Panel();
            this.btnMostrarContrasena = new System.Windows.Forms.Button();
            this.lblNoTienesCuenta = new System.Windows.Forms.Label();
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblIniciarSesion = new System.Windows.Forms.Label();
            this.Asterisco2 = new System.Windows.Forms.Label();
            this.asterisco1 = new System.Windows.Forms.Label();
            this.pnlIniciarSesion.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlIniciarSesion
            // 
            this.pnlIniciarSesion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlIniciarSesion.BackgroundImage")));
            this.pnlIniciarSesion.Controls.Add(this.asterisco1);
            this.pnlIniciarSesion.Controls.Add(this.Asterisco2);
            this.pnlIniciarSesion.Controls.Add(this.btnMostrarContrasena);
            this.pnlIniciarSesion.Controls.Add(this.lblNoTienesCuenta);
            this.pnlIniciarSesion.Controls.Add(this.btnRegistrarse);
            this.pnlIniciarSesion.Controls.Add(this.btnIniciarSesion);
            this.pnlIniciarSesion.Controls.Add(this.txtContrasena);
            this.pnlIniciarSesion.Controls.Add(this.txtCorreo);
            this.pnlIniciarSesion.Controls.Add(this.lblContrasena);
            this.pnlIniciarSesion.Controls.Add(this.lblCorreo);
            this.pnlIniciarSesion.Controls.Add(this.lblIniciarSesion);
            this.pnlIniciarSesion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlIniciarSesion.Location = new System.Drawing.Point(0, 0);
            this.pnlIniciarSesion.Margin = new System.Windows.Forms.Padding(2);
            this.pnlIniciarSesion.MaximumSize = new System.Drawing.Size(661, 508);
            this.pnlIniciarSesion.MinimumSize = new System.Drawing.Size(661, 508);
            this.pnlIniciarSesion.Name = "pnlIniciarSesion";
            this.pnlIniciarSesion.Size = new System.Drawing.Size(661, 508);
            this.pnlIniciarSesion.TabIndex = 0;
            // 
            // btnMostrarContrasena
            // 
            this.btnMostrarContrasena.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMostrarContrasena.BackgroundImage")));
            this.btnMostrarContrasena.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMostrarContrasena.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarContrasena.Location = new System.Drawing.Point(506, 300);
            this.btnMostrarContrasena.Margin = new System.Windows.Forms.Padding(2);
            this.btnMostrarContrasena.Name = "btnMostrarContrasena";
            this.btnMostrarContrasena.Size = new System.Drawing.Size(18, 16);
            this.btnMostrarContrasena.TabIndex = 8;
            this.btnMostrarContrasena.UseVisualStyleBackColor = true;
            this.btnMostrarContrasena.Click += new System.EventHandler(this.btnMostrarContrasena_Click);
            // 
            // lblNoTienesCuenta
            // 
            this.lblNoTienesCuenta.AutoSize = true;
            this.lblNoTienesCuenta.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNoTienesCuenta.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblNoTienesCuenta.Location = new System.Drawing.Point(243, 397);
            this.lblNoTienesCuenta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNoTienesCuenta.Name = "lblNoTienesCuenta";
            this.lblNoTienesCuenta.Size = new System.Drawing.Size(157, 13);
            this.lblNoTienesCuenta.TabIndex = 7;
            this.lblNoTienesCuenta.Text = "—————¿No tienes cuenta? ————";
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarse.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnRegistrarse.Location = new System.Drawing.Point(208, 419);
            this.btnRegistrarse.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(228, 38);
            this.btnRegistrarse.TabIndex = 6;
            this.btnRegistrarse.Text = "Registrarse";
            this.btnRegistrarse.UseVisualStyleBackColor = true;
            this.btnRegistrarse.Click += new System.EventHandler(this.btnRegistrarse_Click);
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnIniciarSesion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnIniciarSesion.FlatAppearance.BorderSize = 0;
            this.btnIniciarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnIniciarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesion.ForeColor = System.Drawing.Color.White;
            this.btnIniciarSesion.Location = new System.Drawing.Point(208, 351);
            this.btnIniciarSesion.Margin = new System.Windows.Forms.Padding(2);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(228, 34);
            this.btnIniciarSesion.TabIndex = 5;
            this.btnIniciarSesion.Text = "Iniciar Sesión";
            this.btnIniciarSesion.UseVisualStyleBackColor = false;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(128, 299);
            this.txtContrasena.Margin = new System.Windows.Forms.Padding(2);
            this.txtContrasena.MaximumSize = new System.Drawing.Size(400, 30);
            this.txtContrasena.MinimumSize = new System.Drawing.Size(400, 30);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(400, 30);
            this.txtContrasena.TabIndex = 4;
            this.txtContrasena.UseSystemPasswordChar = true;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(128, 227);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCorreo.MaximumSize = new System.Drawing.Size(400, 30);
            this.txtCorreo.MinimumSize = new System.Drawing.Size(400, 30);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(400, 20);
            this.txtCorreo.TabIndex = 3;
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrasena.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblContrasena.Location = new System.Drawing.Point(124, 277);
            this.lblContrasena.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(96, 20);
            this.lblContrasena.TabIndex = 2;
            this.lblContrasena.Text = "Contraseña ";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCorreo.Location = new System.Drawing.Point(124, 205);
            this.lblCorreo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(140, 20);
            this.lblCorreo.TabIndex = 1;
            this.lblCorreo.Text = "Correo Electrónico";
            // 
            // lblIniciarSesion
            // 
            this.lblIniciarSesion.AutoSize = true;
            this.lblIniciarSesion.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblIniciarSesion.Location = new System.Drawing.Point(300, 175);
            this.lblIniciarSesion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIniciarSesion.Name = "lblIniciarSesion";
            this.lblIniciarSesion.Size = new System.Drawing.Size(0, 13);
            this.lblIniciarSesion.TabIndex = 0;
            // 
            // Asterisco2
            // 
            this.Asterisco2.AutoSize = true;
            this.Asterisco2.BackColor = System.Drawing.Color.White;
            this.Asterisco2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Asterisco2.ForeColor = System.Drawing.Color.Red;
            this.Asterisco2.Location = new System.Drawing.Point(213, 277);
            this.Asterisco2.Name = "Asterisco2";
            this.Asterisco2.Size = new System.Drawing.Size(15, 20);
            this.Asterisco2.TabIndex = 9;
            this.Asterisco2.Text = "*";
            // 
            // asterisco1
            // 
            this.asterisco1.AutoSize = true;
            this.asterisco1.BackColor = System.Drawing.Color.White;
            this.asterisco1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asterisco1.ForeColor = System.Drawing.Color.Red;
            this.asterisco1.Location = new System.Drawing.Point(262, 205);
            this.asterisco1.Name = "asterisco1";
            this.asterisco1.Size = new System.Drawing.Size(15, 20);
            this.asterisco1.TabIndex = 10;
            this.asterisco1.Text = "*";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 502);
            this.Controls.Add(this.pnlIniciarSesion);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.pnlIniciarSesion.ResumeLayout(false);
            this.pnlIniciarSesion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlIniciarSesion;
        private System.Windows.Forms.Label lblIniciarSesion;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Button btnRegistrarse;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.Label lblNoTienesCuenta;
        private System.Windows.Forms.Button btnMostrarContrasena;
        private System.Windows.Forms.Label Asterisco2;
        private System.Windows.Forms.Label asterisco1;
    }
}
