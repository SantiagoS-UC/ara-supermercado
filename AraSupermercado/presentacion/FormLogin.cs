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

        public FormLogin()
        {
            InitializeComponent();
            login = new Login();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string correo = txtCorreo.Text.Trim();
            string contrasena = txtContrasena.Text.Trim();

            if (string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(contrasena))
            {
                MessageBox.Show("Por favor ingrese correo y contraseña.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    MessageBox.Show("Usuario o contraseña incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al validar usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
