using AraSupermercado.logica;
using System;
using System.ComponentModel; 
using System.Windows.Forms;

namespace AraSupermercado.presentacion
{
    public partial class FormPanelUsuario : Form
    {
        private Cliente cliente;
        private string opcionActual;
        private ErrorProvider errorProvider = new ErrorProvider();

        public FormPanelUsuario(string opcion, Cliente cliente)
        {
            InitializeComponent();
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            this.opcionActual = opcion;
            this.cliente = cliente ?? throw new ArgumentNullException(nameof(cliente));

            // Configurar enmascaramiento de contraseñas por defecto
            txtEditContrasena.UseSystemPasswordChar = true;
            txtEditConfirmarContrasena.UseSystemPasswordChar = true;

            // Configurar ComboBox para tipo de documento
            cbxEditTipoDoc.DropDownStyle = ComboBoxStyle.DropDownList;

            CargarVista();
        }

        public void cargarInformacionCliente()
        {
            try
            {
                cliente.ConsultarCliente(cliente.cliId);
                // Carga datos en los controles
                cbxEditTipoDoc.Text = cliente.cliTipoId ?? string.Empty;
                txtEditNumDoc.Text = cliente.cliId.ToString();
                txtEditNumDoc.ReadOnly = true;  // ID no editable
                txtEditPrimerNombre.Text = cliente.cliPrimerNombre ?? string.Empty;
                txtEditSegundoNombre.Text = (cliente.cliSegundoNombre == null || cliente.cliSegundoNombre == "null") ? string.Empty : cliente.cliSegundoNombre;
                txtEditPrimerApellido.Text = cliente.cliPrimerApellido ?? string.Empty;
                txtEditSegundoApellido.Text = (cliente.cliSegundoApellido == null || cliente.cliSegundoApellido == "null") ? string.Empty : cliente.cliSegundoApellido; 
                dtpEditFechaNac.Value = cliente.cliFechaNacimiento;
                txtEditCorreo.Text = cliente.cliCorreo ?? string.Empty;
                txtEditTelefono.Text = cliente.cliTelefono ?? string.Empty;
                txtEditDireccion.Text = cliente.cliDireccion ?? string.Empty;
                txtEditContrasena.Text = cliente.cliContrasena ?? string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la información del usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarVista()
        {
            // Oculta todos los paneles
            pnlAdminCuenta.Visible = false;
            pnlVerPedidos.Visible = false;

            // Muestra el panel correspondiente y carga datos
            switch (opcionActual)
            {
                case "AdministrarCuenta":
                    pnlAdminCuenta.Visible = true;
                    cargarInformacionCliente();
                    break;
                case "VerPedidos":
                    pnlVerPedidos.Visible = true;
                    // Carga pedidos: dataGridViewPedidos.DataSource = logica.ObtenerPedidos();
                    break;
            }
        }

        public void ActualizarVista(string nuevaOpcion)
        {
            this.opcionActual = nuevaOpcion;
            CargarVista();
        }

        // Método para validar todos los campos
        private bool ValidarCampos()
        {
            bool esValido = true;

            // Tipo de documento (obligatorio, ComboBox)
            if (string.IsNullOrWhiteSpace(cbxEditTipoDoc.Text))
            {
                errorProvider.SetError(cbxEditTipoDoc, "Campo obligatorio.");
                esValido = false;
            }
            else if (cbxEditTipoDoc.Text != "CC" && cbxEditTipoDoc.Text != "CE" && cbxEditTipoDoc.Text != "PA")
            {
                errorProvider.SetError(cbxEditTipoDoc, "Debe ser CC, CE o PA.");
                esValido = false;
            }

            // Nombres y apellidos (obligatorios)
            if (string.IsNullOrWhiteSpace(txtEditPrimerNombre.Text))
            {
                errorProvider.SetError(txtEditPrimerNombre, "Campo obligatorio.");
                esValido = false;
            }
            if (string.IsNullOrWhiteSpace(txtEditPrimerApellido.Text))
            {
                errorProvider.SetError(txtEditPrimerApellido, "Campo obligatorio.");
                esValido = false;
            }

            // Fecha de nacimiento (obligatoria y con reglas, igual que registro)
            string mensajeFecha;
            if (!Cliente.ValidarFechaNacimiento(dtpEditFechaNac.Value, out mensajeFecha))
            {
                errorProvider.SetError(dtpEditFechaNac, mensajeFecha);
                esValido = false;
            }

            // Correo (obligatorio y formato básico, con mensaje intuitivo)
            string correo = txtEditCorreo.Text.Trim();
            if (string.IsNullOrWhiteSpace(correo))
            {
                errorProvider.SetError(txtEditCorreo, "Campo obligatorio.");
                esValido = false;
            }
            else if (!correo.Contains("@") || !correo.Contains("."))
            {
                errorProvider.SetError(txtEditCorreo, "Formato inválido (ej. usuario@dominio.com).");
                esValido = false;
            }

            // Teléfono (obligatorio)
            if (string.IsNullOrWhiteSpace(txtEditTelefono.Text))
            {
                errorProvider.SetError(txtEditTelefono, "Campo obligatorio.");
                esValido = false;
            }

            // Dirección (obligatoria)
            if (string.IsNullOrWhiteSpace(txtEditDireccion.Text))
            {
                errorProvider.SetError(txtEditDireccion, "Campo obligatorio.");
                esValido = false;
            }

            // Contraseña (obligatoria, con longitud igual que registro)
            string contrasena = txtEditContrasena.Text.Trim();
            if (string.IsNullOrWhiteSpace(contrasena))
            {
                errorProvider.SetError(txtEditContrasena, "Campo obligatorio.");
                esValido = false;
            }
            else if (contrasena.Length < 8 || contrasena.Length > 16)
            {
                errorProvider.SetError(txtEditContrasena, "Debe tener entre 8 y 16 caracteres.");
                esValido = false;
            }

            // Confirmar contraseña (obligatoria y debe coincidir)
            string confirmarContrasena = txtEditConfirmarContrasena.Text.Trim();
            if (string.IsNullOrWhiteSpace(confirmarContrasena))
            {
                errorProvider.SetError(txtEditConfirmarContrasena, "Campo obligatorio.");
                esValido = false;
            }
            else if (confirmarContrasena != contrasena)
            {
                errorProvider.SetError(txtEditConfirmarContrasena, "Las contraseñas no coinciden.");
                esValido = false;
            }
            // Validaciones avanzadas contra inyección SQL y datos raros
            string mensajeAvanzado;

            // ID
            string idStr = txtEditNumDoc.Text.Trim();
            if (!Cliente.ValidarCampoAvanzado(idStr, "id", out mensajeAvanzado))
            {
                errorProvider.SetError(txtEditNumDoc, mensajeAvanzado);
                esValido = false;
            }

            // Nombres
            if (!Cliente.ValidarCampoAvanzado(txtEditPrimerNombre.Text.Trim(), "nombre", out mensajeAvanzado))
            {
                errorProvider.SetError(txtEditPrimerNombre, mensajeAvanzado);
                esValido = false;
            }
            if (!string.IsNullOrWhiteSpace(txtEditSegundoNombre.Text.Trim()) && !Cliente.ValidarCampoAvanzado(txtEditSegundoNombre.Text.Trim(), "nombre", out mensajeAvanzado))
            {
                errorProvider.SetError(txtEditSegundoNombre, mensajeAvanzado);
                esValido = false;
            }

            // Apellidos
            if (!Cliente.ValidarCampoAvanzado(txtEditPrimerApellido.Text.Trim(), "apellido", out mensajeAvanzado))
            {
                errorProvider.SetError(txtEditPrimerApellido, mensajeAvanzado);
                esValido = false;
            }
            if (!string.IsNullOrWhiteSpace(txtEditSegundoApellido.Text.Trim()) && !Cliente.ValidarCampoAvanzado(txtEditSegundoApellido.Text.Trim(), "apellido", out mensajeAvanzado))
            {
                errorProvider.SetError(txtEditSegundoApellido, mensajeAvanzado);
                esValido = false;
            }

            // Correo
            correo = txtEditCorreo.Text.Trim();
            if (!Cliente.ValidarCampoAvanzado(correo, "correo", out mensajeAvanzado))
            {
                errorProvider.SetError(txtEditCorreo, mensajeAvanzado);
                esValido = false;
            }

            // Teléfono
            if (!Cliente.ValidarCampoAvanzado(txtEditTelefono.Text.Trim(), "telefono", out mensajeAvanzado))
            {
                errorProvider.SetError(txtEditTelefono, mensajeAvanzado);
                esValido = false;
            }

            // Dirección
            if (!Cliente.ValidarCampoAvanzado(txtEditDireccion.Text.Trim(), "direccion", out mensajeAvanzado))
            {
                errorProvider.SetError(txtEditDireccion, mensajeAvanzado);
                esValido = false;
            }

            // Contraseña
            contrasena = txtEditContrasena.Text.Trim();
            if (!Cliente.ValidarCampoAvanzado(contrasena, "contrasena", out mensajeAvanzado))
            {
                errorProvider.SetError(txtEditContrasena, mensajeAvanzado);
                esValido = false;
            }

            return esValido;
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            // Limpiar errores previos
            errorProvider.Clear();

            // Validar ID numérico
            if (!int.TryParse(txtEditNumDoc.Text.Trim(), out int cliId) || cliId <= 0)
            {
                errorProvider.SetError(txtEditNumDoc, "Debe ser un número positivo.");
                MessageBox.Show("Por favor, corrija los errores marcados.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar todos los campos 
            if (!ValidarCampos())
            {
                MessageBox.Show("Por favor, corrija los errores marcados.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Asignar valores al objeto cliente 
            cliente.cliTipoId = cbxEditTipoDoc.Text.Trim(); 
            cliente.cliPrimerNombre = txtEditPrimerNombre.Text.Trim();
            cliente.cliSegundoNombre = string.IsNullOrWhiteSpace(txtEditSegundoNombre.Text) ? null : txtEditSegundoNombre.Text.Trim();
            cliente.cliPrimerApellido = txtEditPrimerApellido.Text.Trim();
            cliente.cliSegundoApellido = string.IsNullOrWhiteSpace(txtEditSegundoApellido.Text) ? null : txtEditSegundoApellido.Text.Trim();
            cliente.cliFechaNacimiento = dtpEditFechaNac.Value;
            cliente.cliCorreo = txtEditCorreo.Text.Trim();
            cliente.cliContrasena = txtEditContrasena.Text.Trim();
            cliente.cliTelefono = string.IsNullOrWhiteSpace(txtEditTelefono.Text) ? null : txtEditTelefono.Text.Trim();
            cliente.cliDireccion = string.IsNullOrWhiteSpace(txtEditDireccion.Text) ? null : txtEditDireccion.Text.Trim();

            try
            {
                // Llamar al método de actualización
                if (cliente.ActualizarCliente())
                {
                    MessageBox.Show("Información actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Recargar vista para reflejar cambios
                    cargarInformacionCliente();
                }
            }
            catch (Exception ex)
            {
                string mensajeError = ex.Message;
                // Manejo específico de errores 
                if (mensajeError.Contains("El correo ya está registrado"))
                {
                    errorProvider.SetError(txtEditCorreo, "El correo ya está registrado.");
                    MessageBox.Show("El correo ya está registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Error al actualizar: " + mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Botón para mostrar/ocultar contraseña 
        private void btnVerContrasena_Click(object sender, EventArgs e)
        {
            txtEditContrasena.UseSystemPasswordChar = !txtEditContrasena.UseSystemPasswordChar;
            btnVerContrasena.Text = txtEditContrasena.UseSystemPasswordChar ? "👁" : "🙈";
        }

        // Botón para mostrar/ocultar confirmación de contraseña 
        private void btnVerConfirmarContrasena_Click(object sender, EventArgs e)
        {
            txtEditConfirmarContrasena.UseSystemPasswordChar = !txtEditConfirmarContrasena.UseSystemPasswordChar;
            btnVerConfirmarContrasena.Text = txtEditConfirmarContrasena.UseSystemPasswordChar ? "👁" : "🙈";
        }

        // Eventos de validación individual
        private void cbxEditTipoDoc_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbxEditTipoDoc.Text))
            {
                errorProvider.SetError(cbxEditTipoDoc, "Campo obligatorio.");
            }
            else if (cbxEditTipoDoc.Text != "CC" && cbxEditTipoDoc.Text != "CE" && cbxEditTipoDoc.Text != "PA")
            {
                errorProvider.SetError(cbxEditTipoDoc, "Debe ser CC, CE o PA.");
            }
            else
            {
                errorProvider.SetError(cbxEditTipoDoc, "");
            }
        }


    }
}
