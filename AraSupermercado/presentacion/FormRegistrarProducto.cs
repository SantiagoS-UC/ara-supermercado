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
    public partial class FormRegistrarProducto : Form
    {
        public FormRegistrarProducto()
        {
            InitializeComponent();
        }

        private void picProducto_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Title = "Seleccionar imagen del producto";
            abrir.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp";

            if (abrir.ShowDialog() == DialogResult.OK)
            {
                picProducto.Image = Image.FromFile(abrir.FileName);
                lblSeleccionarImagen.Visible = false; //Oculta el texto después de cargar la imagen
            }
        }

        private void FormRegistrarProducto_Load(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.SetToolTip(picProducto, "Haz clic aquí para subir una imagen");

            picProducto.Cursor = Cursors.Hand;
            lblSeleccionarImagen.Cursor = Cursors.Hand;//Cursor de mano
        }

        private void lblSeleccionarImagen_Click(object sender, EventArgs e)
        {
            picProducto_Click(sender, e);
        }
    }
}
