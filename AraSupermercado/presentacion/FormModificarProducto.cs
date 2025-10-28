using AraSupermercado.accesoDatos;
using AraSupermercado.logica;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace AraSupermercado.presentacion
{
    public partial class FormModificarProducto : Form
    {
        private Producto producto;  // Producto a modificar
        private ConexionOracle conexion;

        public FormModificarProducto(Producto prod)
        {
            InitializeComponent();
            producto = prod;
            conexion = new ConexionOracle();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // FormModificarProducto
            // 
            this.ClientSize = new System.Drawing.Size(851, 409);
            this.Name = "FormModificarProducto";
            this.Text = "FormModificarProducto";
            this.ResumeLayout(false);

        }
    }
}
