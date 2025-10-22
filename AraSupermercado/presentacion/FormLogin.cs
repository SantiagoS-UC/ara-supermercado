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
            this.Size = new Size(661,508); // tamaño más grande
            this.StartPosition = FormStartPosition.CenterScreen; // centrado
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // evita redimensionar
            this.MaximizeBox = false; // desactiva botón maximizar
        }
    }
}
