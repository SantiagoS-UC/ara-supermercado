using AraSupermercado.accesoDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AraSupermercado.logica
{
    public class Administrador
    {
        private ConexionOracle conexion; // Instancia de conexión

        // Constructor
        public Administrador()
        {
            conexion = new ConexionOracle(); // Inicializa la conexión
        }

        // Método 1: Ver Productos
        // Devuelve una lista de productos. Si no hay, la lista estará vacía (maneja mensaje en UI).
        public List<Producto> VerProductos()
        {
            List<Producto> productos = new List<Producto>();
            string consulta = "SELECT prod_codigo, prov_nit, prod_nombre, prod_descripcion, prod_estado, prod_precio, prod_stock, prod_imagen_ruta FROM Producto";

            DataSet ds = conexion.EjecutarDQL(consulta);
            if (ds != null && ds.Tables["ResultadoDatos"].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables["ResultadoDatos"].Rows)
                {
                    Producto prod = new Producto(
                        Convert.ToInt32(row["prod_codigo"]),
                        Convert.ToInt32(row["prov_nit"]),
                        row["prod_nombre"].ToString(),
                        row["prod_descripcion"].ToString(),
                        row["prod_estado"].ToString(),
                        Convert.ToDecimal(row["prod_precio"]),
                        Convert.ToInt32(row["prod_stock"]),
                        row["prod_imagen_ruta"].ToString()
                    );
                    productos.Add(prod);
                }
            }
            return productos; // Si vacía, muestra mensaje en formulario
        }

        // Método 2: Registrar Producto (usando Procedimiento Almacenado)
        // Parámetros: mismos que antes.
        // Devuelve true si se registra exitosamente, false si falla (e.g., por errores del SP).
        public bool RegistrarProducto(int codigo, int nitProveedor, string nombre, string descripcion, string estado, decimal precio, int stock, string direccionImagen, string categoria)
        {
            // Validaciones básicas en C# (opcionales, ya que el SP las maneja)
            if (codigo <= 0 || precio <= 0 || stock < 0 || string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(descripcion) ||
                (estado != "Activo" && estado != "Inactivo"))
            {
                return false; // Datos inválidos
            }

            // Llamada al SP
            string consulta = "BEGIN pa_registrar_producto(:codigo, :nit, :nombre, :descripcion, :estado, :precio, :stock, :imagen, :categoria); END;";

            var parametros = new Dictionary<string, object>
    {
        { ":codigo", codigo },
        { ":nit", nitProveedor },
        { ":nombre", nombre },
        { ":descripcion", descripcion },
        { ":estado", estado },
        { ":precio", precio },
        { ":stock", stock },
        { ":imagen", direccionImagen },
        { ":categoria", categoria },
    };
            int filasAfectadas = conexion.EjecutarDML(consulta, parametros);
            return filasAfectadas >= 0;
        }
    }
}