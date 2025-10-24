using AraSupermercado.logica;
using AraSupermercado.presentacion;
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
    public partial class FormRegistrarCliente : Form
    {
        private ErrorProvider errorProvider = new ErrorProvider();

        public FormRegistrarCliente()
        {
            InitializeComponent();
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;

            // Configurar enmascaramiento de contraseñas por defecto
            txtContrasena.UseSystemPasswordChar = true;
            txtConfirmarContrasena.UseSystemPasswordChar = true;
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            // Limpiar errores previos
            errorProvider.Clear();

            // Validar campos obligatorios
            bool camposValidos = true;
            if (string.IsNullOrWhiteSpace(txtNumDocumento.Text))
            {
                errorProvider.SetError(txtNumDocumento, "Campo obligatorio.");
                camposValidos = false;
            }
            if (string.IsNullOrWhiteSpace(cbxTipoDocumento.Text))
            {
                errorProvider.SetError(cbxTipoDocumento, "Campo obligatorio.");
                camposValidos = false;
            }
            if (string.IsNullOrWhiteSpace(txtPrimerNombre.Text))
            {
                errorProvider.SetError(txtPrimerNombre, "Campo obligatorio.");
                camposValidos = false;
            }
            if (string.IsNullOrWhiteSpace(txtPrimerApellido.Text))
            {
                errorProvider.SetError(txtPrimerApellido, "Campo obligatorio.");
                camposValidos = false;
            }
            if (string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                errorProvider.SetError(txtCorreo, "Campo obligatorio.");
                camposValidos = false;
            }
            if (string.IsNullOrWhiteSpace(txtContrasena.Text))
            {
                errorProvider.SetError(txtContrasena, "Campo obligatorio.");
                camposValidos = false;
            }
            if (string.IsNullOrWhiteSpace(txtConfirmarContrasena.Text))
            {
                errorProvider.SetError(txtConfirmarContrasena, "Campo obligatorio.");
                camposValidos = false;
            }

            if (!camposValidos)
            {
                MessageBox.Show("Debe llenar todos los campos obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar cliId numérico
            if (!int.TryParse(txtNumDocumento.Text.Trim(), out int cliId) || cliId <= 0)
            {
                errorProvider.SetError(txtNumDocumento, "Debe ser un número positivo.");
                MessageBox.Show("El ID del cliente debe ser un número positivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar tipo documento
            string tipoId = cbxTipoDocumento.Text.Trim();
            if (tipoId != "CC" && tipoId != "CE" && tipoId != "PA")
            {
                errorProvider.SetError(cbxTipoDocumento, "Debe ser CC, CE o PA.");
                MessageBox.Show("El tipo de documento debe ser CC, CE o PA.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar formato de correo básico
            string correo = txtCorreo.Text.Trim();
            if (!correo.Contains("@") || !correo.Contains("."))
            {
                errorProvider.SetError(txtCorreo, "Formato inválido (ej. usuario@dominio.com).");
                MessageBox.Show("El correo debe tener un formato válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar longitud de contraseña
            string contrasena = txtContrasena.Text.Trim();
            if (contrasena.Length < 8 || contrasena.Length > 16)
            {
                errorProvider.SetError(txtContrasena, "Debe tener entre 8 y 16 caracteres.");
                MessageBox.Show("La contraseña debe tener entre 8 y 16 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar confirmación de contraseña
            string confirmarContrasena = txtConfirmarContrasena.Text.Trim();
            if (contrasena != confirmarContrasena)
            {
                errorProvider.SetError(txtConfirmarContrasena, "Las contraseñas no coinciden.");
                MessageBox.Show("Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar mayor de edad
            DateTime fechaNacimiento = dtpFechaNacimiento.Value;
            int edad = DateTime.Now.Year - fechaNacimiento.Year;
            if (fechaNacimiento > DateTime.Now.AddYears(-edad)) edad--;  // Ajuste si no ha cumplido años este año
            if (edad < 18)
            {
                errorProvider.SetError(dtpFechaNacimiento, "Debe ser mayor de edad.");
                MessageBox.Show("Debe ser mayor de edad (al menos 18 años).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Crear objeto Cliente
            Cliente cliente = new Cliente
            {
                cliId = cliId,
                cliTipoId = tipoId,
                cliPrimerNombre = txtPrimerNombre.Text.Trim(),
                cliSegundoNombre = txtSegundoNombre.Text.Trim(),
                cliPrimerApellido = txtPrimerApellido.Text.Trim(),
                cliSegundoApellido = txtSegundoApellido.Text.Trim(),
                cliFechaNacimiento = fechaNacimiento,
                cliCorreo = correo,
                cliContrasena = contrasena,
                cliTelefono = txtTelefono.Text.Trim(),
                cliDireccion = txtDireccion.Text.Trim()
            };

            try
            {
                if (cliente.RegistrarCliente())
                {
                    MessageBox.Show("Cliente registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Redirigir a login
                    this.Hide();
                    FormLogin formLogin = new FormLogin();
                    formLogin.Show();
                }
            }
            catch (Exception ex)
            {
                string mensajeError = ex.Message;
                // Detectar mensajes específicos de duplicados
                if (mensajeError.Contains("El ID del cliente ya está registrado"))
                {
                    errorProvider.SetError(txtNumDocumento, "El documento ya está registrado.");
                    MessageBox.Show("El documento ya está registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (mensajeError.Contains("El correo ya está registrado"))
                {
                    errorProvider.SetError(txtCorreo, "El correo ya está registrado.");
                    MessageBox.Show("El correo ya está registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Otros errores (ej. formato inválido, etc.)
                    MessageBox.Show("Error: " + mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
        }

        private void btnMostrarContrasena_Click(object sender, EventArgs e)
        {
            txtContrasena.UseSystemPasswordChar = !txtContrasena.UseSystemPasswordChar;
            btnMostrarContrasena.Text = txtContrasena.UseSystemPasswordChar ? "👁" : "🙈";
        }

        private void btnMostrarConfirmarContrasena_Click(object sender, EventArgs e)
        {
            txtConfirmarContrasena.UseSystemPasswordChar = !txtConfirmarContrasena.UseSystemPasswordChar;
            btnMostrarConfirmarContrasena.Text = txtConfirmarContrasena.UseSystemPasswordChar ? "👁" : "🙈";
        }

    }
}

