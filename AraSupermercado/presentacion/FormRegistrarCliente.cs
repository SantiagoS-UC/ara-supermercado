using AraSupermercado.logica;
using System;
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

        // Modificar btnRegistrarse_Click para usar ValidarCampos()
        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            // Limpiar errores previos
            errorProvider.Clear();

            // Llamar a ValidarCampos() (nuevo)
            if (!ValidarCampos())
            {
                MessageBox.Show("Por favor, corrija los errores marcados.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Crear objeto Cliente y registrar
            Cliente cliente = new Cliente
            {
                cliId = int.Parse(txtNumDocumento.Text.Trim()),
                cliTipoId = cbxTipoDocumento.Text.Trim(),
                cliPrimerNombre = txtPrimerNombre.Text.Trim(),
                cliSegundoNombre = txtSegundoNombre.Text.Trim(),
                cliPrimerApellido = txtPrimerApellido.Text.Trim(),
                cliSegundoApellido = txtSegundoApellido.Text.Trim(),
                cliFechaNacimiento = dtpFechaNacimiento.Value,
                cliCorreo = txtCorreo.Text.Trim(),
                cliContrasena = txtContrasena.Text.Trim(),
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
                // Manejo específico de errores
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

        // Método para validar todos los campos
        private bool ValidarCampos()
        {
            bool esValido = true;

            // Validar campos obligatorios
            if (string.IsNullOrWhiteSpace(txtNumDocumento.Text))
            {
                errorProvider.SetError(txtNumDocumento, "Campo obligatorio.");
                esValido = false;
            }
            if (string.IsNullOrWhiteSpace(cbxTipoDocumento.Text))
            {
                errorProvider.SetError(cbxTipoDocumento, "Campo obligatorio.");
                esValido = false;
            }
            if (string.IsNullOrWhiteSpace(txtPrimerNombre.Text))
            {
                errorProvider.SetError(txtPrimerNombre, "Campo obligatorio.");
                esValido = false;
            }
            if (string.IsNullOrWhiteSpace(txtPrimerApellido.Text))
            {
                errorProvider.SetError(txtPrimerApellido, "Campo obligatorio.");
                esValido = false;
            }
            if (string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                errorProvider.SetError(txtTelefono, "Campo obligatorio.");
                esValido = false;
            }
            if (string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                errorProvider.SetError(txtDireccion, "Campo obligatorio.");
                esValido = false;
            }
            if (string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                errorProvider.SetError(txtCorreo, "Campo obligatorio.");
                esValido = false;
            }
            if (string.IsNullOrWhiteSpace(txtContrasena.Text))
            {
                errorProvider.SetError(txtContrasena, "Campo obligatorio.");
                esValido = false;
            }
            if (string.IsNullOrWhiteSpace(txtConfirmarContrasena.Text))
            {
                errorProvider.SetError(txtConfirmarContrasena, "Campo obligatorio.");
                esValido = false;
            }

            // Validar cliId numérico
            if (!int.TryParse(txtNumDocumento.Text.Trim(), out int cliId) || cliId <= 0)
            {
                errorProvider.SetError(txtNumDocumento, "Debe ser un número positivo.");
                esValido = false;
            }

            // Validar tipo documento
            string tipoId = cbxTipoDocumento.Text.Trim();
            if (tipoId != "CC" && tipoId != "CE" && tipoId != "PA")
            {
                errorProvider.SetError(cbxTipoDocumento, "Debe ser CC, CE o PA.");
                esValido = false;
            }

            // Validar formato de correo básico 
            string correo = txtCorreo.Text.Trim();
            if (!correo.Contains("@") || !correo.Contains("."))
            {
                errorProvider.SetError(txtCorreo, "Formato inválido (ej. usuario@dominio.com).");
                esValido = false;
            }

            // Validar longitud de contraseña
            string contrasena = txtContrasena.Text.Trim();
            if (contrasena.Length < 8 || contrasena.Length > 16)
            {
                errorProvider.SetError(txtContrasena, "Debe tener entre 8 y 16 caracteres.");
                esValido = false;
            }

            // Validar confirmación de contraseña
            string confirmarContrasena = txtConfirmarContrasena.Text.Trim();
            if (contrasena != confirmarContrasena)
            {
                errorProvider.SetError(txtConfirmarContrasena, "Las contraseñas no coinciden.");
                esValido = false;
            }

            // Validar mayor de edad
            DateTime fechaNacimiento = dtpFechaNacimiento.Value;
            int edad = DateTime.Now.Year - fechaNacimiento.Year;
            if (fechaNacimiento > DateTime.Now.AddYears(-edad)) edad--;
            if (edad < 18)
            {
                errorProvider.SetError(dtpFechaNacimiento, "Debe ser mayor de edad.");
                esValido = false;
            }

            // Validaciones avanzadas contra inyección SQL y datos raros
            string mensajeAvanzado;

            // ID
            string idStr = txtNumDocumento.Text.Trim();
            if (!Cliente.ValidarCampoAvanzado(idStr, "id", out mensajeAvanzado))
            {
                errorProvider.SetError(txtNumDocumento, mensajeAvanzado);
                esValido = false;
            }

            // Nombres
            if (!Cliente.ValidarCampoAvanzado(txtPrimerNombre.Text.Trim(), "nombre", out mensajeAvanzado))
            {
                errorProvider.SetError(txtPrimerNombre, mensajeAvanzado);
                esValido = false;
            }
            if (!string.IsNullOrWhiteSpace(txtSegundoNombre.Text.Trim()) && !Cliente.ValidarCampoAvanzado(txtSegundoNombre.Text.Trim(), "nombre", out mensajeAvanzado))
            {
                errorProvider.SetError(txtSegundoNombre, mensajeAvanzado);
                esValido = false;
            }

            // Apellidos
            if (!Cliente.ValidarCampoAvanzado(txtPrimerApellido.Text.Trim(), "apellido", out mensajeAvanzado))
            {
                errorProvider.SetError(txtPrimerApellido, mensajeAvanzado);
                esValido = false;
            }
            if (!string.IsNullOrWhiteSpace(txtSegundoApellido.Text.Trim()) && !Cliente.ValidarCampoAvanzado(txtSegundoApellido.Text.Trim(), "apellido", out mensajeAvanzado))
            {
                errorProvider.SetError(txtSegundoApellido, mensajeAvanzado);
                esValido = false;
            }

            // Correo (avanzado)
            if (!Cliente.ValidarCampoAvanzado(correo, "correo", out mensajeAvanzado))
            {
                errorProvider.SetError(txtCorreo, mensajeAvanzado);
                esValido = false;
            }

            // Teléfono
            if (!Cliente.ValidarCampoAvanzado(txtTelefono.Text.Trim(), "telefono", out mensajeAvanzado))
            {
                errorProvider.SetError(txtTelefono, mensajeAvanzado);
                esValido = false;
            }

            // Dirección
            if (!Cliente.ValidarCampoAvanzado(txtDireccion.Text.Trim(), "direccion", out mensajeAvanzado))
            {
                errorProvider.SetError(txtDireccion, mensajeAvanzado);
                esValido = false;
            }

            // Contraseña
            if (!Cliente.ValidarCampoAvanzado(contrasena, "contrasena", out mensajeAvanzado))
            {
                errorProvider.SetError(txtContrasena, mensajeAvanzado);
                esValido = false;
            }

            return esValido;
        }

    }
}

