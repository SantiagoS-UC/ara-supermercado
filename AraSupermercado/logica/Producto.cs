using AraSupermercado.accesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AraSupermercado.logica
{
    public class Producto
    {
        public int prodCodigo { get; set; }
        public int provNit { get; set; }
        public string prodNombre { get; set; }
        public string prodDescripcion { get; set; }
        public string prodCategoria { get; set; }
        public string prodEstado { get; set; }
        public decimal prodPrecio { get; set; }
        public int prodStock { get; set; }
        public string prodImagenRuta { get; set; }
        // Constructor vacío
        public Producto() { }
        // Constructor con parámetros
        public Producto(int codigo, int nit, string nombre, string descripcion, string categoria, string estado, decimal precio, int stock, string imagen_Ruta)
        {
            prodCodigo = codigo;
            provNit = nit;
            prodNombre = nombre;
            prodDescripcion = descripcion;
            prodCategoria = categoria;
            prodEstado = estado;
            prodPrecio = precio;
            prodStock = stock;
            prodImagenRuta = imagen_Ruta;
        }

        // Método para actualizar el producto
        public bool ActualizarProducto(ConexionOracle conexion, string categoria = null)
        {
            try
            {
                string consulta = "BEGIN pa_actualizar_producto(:codigo, :nombre, :descripcion, :precio, :estado, :imagen, :categoria); END;";
                var parametros = new Dictionary<string, object>
            {
                { ":codigo", prodCodigo },
                { ":nombre", prodNombre },
                { ":descripcion", prodDescripcion },
                { ":precio", prodPrecio },
                { ":estado", prodEstado },
                { ":imagen", prodImagenRuta },
                { ":categoria", prodCategoria}
            };
                int filasAfectadas = conexion.EjecutarDML(consulta, parametros);
                return filasAfectadas >= 0;  // True si se ejecutó sin error
            }
            catch
            {
                return false;  // False si hay error
            }
        }

    }
}
