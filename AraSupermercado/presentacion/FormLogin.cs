using AraSupermercado.logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AraSupermercado.presentacion
{
    public partial class FormLogin : Form
    {
        private Login login;
        private ErrorProvider errorProvider = new ErrorProvider();

        public FormLogin()
        {
            InitializeComponent();
            login = new Login();
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;

            // Configurar enmascaramiento de contraseñas por defecto
            txtContrasena.UseSystemPasswordChar = true;
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            // Limpiar errores previos
            errorProvider.Clear();

            string correo = txtCorreo.Text.Trim();
            string contrasena = txtContrasena.Text.Trim();

            // Validar campos obligatorios
            bool camposValidos = true;
            if (string.IsNullOrWhiteSpace(correo))
            {
                errorProvider.SetError(txtCorreo, "Campo obligatorio.");
                camposValidos = false;
            }
            if (string.IsNullOrWhiteSpace(contrasena))
            {
                errorProvider.SetError(txtContrasena, "Campo obligatorio.");
                camposValidos = false;
            }

            // Validación opcional: formato básico de correo
            if (!string.IsNullOrWhiteSpace(correo) && (!correo.Contains("@") || !correo.Contains(".")))
            {
                errorProvider.SetError(txtCorreo, "Formato inválido (ej. usuario@dominio.com).");
                camposValidos = false;
            }

            if (!camposValidos)
            {
                MessageBox.Show("Por favor ingrese correo y contraseña válidos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string tipoUsuario = login.ValidarUsuario(correo, contrasena);

                if (tipoUsuario == "ADMIN")
                {
                    MessageBox.Show("Bienvenido Administrador", "Login exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormMenuAdmin frmAdmin = new FormMenuAdmin();
                    frmAdmin.Show();
                    this.Hide();
                }
                else if (tipoUsuario == "CLIENTE")
                {
                    MessageBox.Show("Bienvenido", "Login exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormMenuCliente frmCliente = new FormMenuCliente();
                    frmCliente.Show();
                    this.Hide();
                }
                else
                {
                    // Resaltar campos si credenciales incorrectas
                    errorProvider.SetError(txtCorreo, "Verifique sus credenciales.");
                    errorProvider.SetError(txtContrasena, "Verifique sus credenciales.");
                    MessageBox.Show("Usuario o contraseña incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al validar usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRegistrarCliente frmRegistro = new FormRegistrarCliente();
            frmRegistro.ShowDialog();
        }

        private void btnMostrarContrasena_Click(object sender, EventArgs e)
        {
            txtContrasena.UseSystemPasswordChar = !txtContrasena.UseSystemPasswordChar;
            btnMostrarContrasena.Text = txtContrasena.UseSystemPasswordChar ? "👁" : "🙈";
        }
    }
}
