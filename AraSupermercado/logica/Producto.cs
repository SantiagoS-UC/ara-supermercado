using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AraSupermercado.logica
{
    public class Producto
    {
        public int prod_Codigo { get; set; }
        public int prov_Nit { get; set; }
        public string prod_Nombre { get; set; }
        public string prod_Descripcion { get; set; }
        public string prod_Estado { get; set; }
        public decimal prod_Precio { get; set; }
        public int prod_Stock { get; set; }
        public string prod_Imagen_Ruta { get; set; }
        // Constructor vacío
        public Producto() { }
        // Constructor con parámetros
        public Producto(int codigo, int nit, string nombre, string descripcion, string estado, decimal precio, int stock, string imagen_Ruta)
        {
            prod_Codigo = codigo;
            prov_Nit = nit;
            prod_Nombre = nombre;
            prod_Descripcion = descripcion;
            prod_Estado = estado;
            prod_Precio = precio;
            prod_Stock = stock;
            prod_Imagen_Ruta = imagen_Ruta;
        }
    }
}
