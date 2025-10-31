using AraSupermercado.accesoDatos;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
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
    public List<Producto> VerProductosAdmin()
    {
        List<Producto> productos = new List<Producto>();
        try
        {
            using (OracleConnection conn = new OracleConnection(conexion.ObtenerConexion().ConnectionString))
            using (OracleCommand cmd = new OracleCommand("pa_ver_productos_admin", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                // Parámetro OUT
                cmd.Parameters.Add(new OracleParameter("p_cursor", OracleDbType.RefCursor, ParameterDirection.Output));

                conn.Open();
                using (OracleDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        try
                        {
                                string categoria = reader.IsDBNull(reader.GetOrdinal("prod_categoria")) ? null : reader.GetString(reader.GetOrdinal("prod_categoria"));
                                Producto prod = new Producto(
                                    reader.GetInt32(reader.GetOrdinal("prod_codigo")),
                                    reader.GetInt32(reader.GetOrdinal("prov_nit")),
                                    reader.GetString(reader.GetOrdinal("prod_nombre")),
                                    reader.GetString(reader.GetOrdinal("prod_descripcion")),
                                    categoria,  // Usa la variable
                                    reader.GetString(reader.GetOrdinal("prod_estado")),
                                    reader.GetDecimal(reader.GetOrdinal("prod_precio")),
                                    reader.GetInt32(reader.GetOrdinal("prod_stock")),
                                    reader.GetString(reader.GetOrdinal("prod_imagen_ruta"))
                                );
                            productos.Add(prod);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error procesando fila: {ex.Message}");
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error en VerProductosAdmin: {ex.Message}");
        }
        return productos;
    }


    // Método 2: Registrar Producto (usando Procedimiento Almacenado)
    // Parámetros: mismos que antes.
    // Devuelve true si se registra exitosamente, false si falla (e.g., por errores del SP).
    public bool RegistrarProducto(int codigo, int nitProveedor, string nombre, string descripcion, string estado, decimal precio, int stock, string direccionImagen, string categoria)
    {
        // Validaciones básicas
        if (codigo <= 0 || precio <= 0 || stock < 0 || string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(descripcion) ||
            (estado != "Activo" && estado != "Inactivo"))
        {
            return false; // Datos inválidos
        }

        // Llamada al procedimiento almacenado
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

        // Método 3: Buscar Productos por Nombre (usando Procedimiento Almacenado)
        public List<Producto> BuscarProductos(string nombreBusqueda)
        {
            List<Producto> productos = new List<Producto>();
            try
            {
                using (OracleConnection conn = new OracleConnection(conexion.ObtenerConexion().ConnectionString))
                using (OracleCommand cmd = new OracleCommand("pa_buscar_productos", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Parámetros
                    cmd.Parameters.Add(new OracleParameter("p_nombre_busqueda", OracleDbType.Varchar2, nombreBusqueda, ParameterDirection.Input));
                    cmd.Parameters.Add(new OracleParameter("p_cursor", OracleDbType.RefCursor, ParameterDirection.Output));

                    conn.Open();
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            try
                            {
                                // Maneja null en categoría
                                string categoria = reader.IsDBNull(reader.GetOrdinal("prod_categoria")) ? null : reader.GetString(reader.GetOrdinal("prod_categoria"));

                                Producto prod = new Producto(
                                    reader.GetInt32(reader.GetOrdinal("prod_codigo")),
                                    reader.GetInt32(reader.GetOrdinal("prov_nit")),
                                    reader.GetString(reader.GetOrdinal("prod_nombre")),
                                    reader.GetString(reader.GetOrdinal("prod_descripcion")),
                                    categoria,  // Asigna la categoría (puede ser null)
                                    reader.GetString(reader.GetOrdinal("prod_estado")),
                                    reader.GetDecimal(reader.GetOrdinal("prod_precio")),
                                    reader.GetInt32(reader.GetOrdinal("prod_stock")),
                                    reader.GetString(reader.GetOrdinal("prod_imagen_ruta"))
                                );
                                productos.Add(prod);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"Error procesando fila: {ex.Message}");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en BuscarProductos: {ex.Message}");
            }
            return productos;
        }

        // Método 4: Actualizar Producto
        public bool ActualizarProducto(Producto producto, string categoria = null)
        {
            Debug.WriteLine("Iniciando ActualizarProducto");  // Debug inicio
            try
            {
                Debug.WriteLine("Obteniendo conexión");  // Debug conexión
                using (var conn = conexion.ObtenerConexion())
                {
                    conn.Open();
                    Debug.WriteLine("Conexión abierta");  // Debug conexión abierta
                    using (var cmd = new OracleCommand("pa_actualizar_producto", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        // Agregar parámetros con debug
                        cmd.Parameters.Add("p_codigo", OracleDbType.Int32).Value = producto.prodCodigo;
                        Debug.WriteLine($"Parámetro p_codigo: {producto.prodCodigo}");

                        cmd.Parameters.Add("p_nombre", OracleDbType.Varchar2).Value = producto.prodNombre;
                        Debug.WriteLine($"Parámetro p_nombre: '{producto.prodNombre}'");

                        cmd.Parameters.Add("p_descripcion", OracleDbType.Varchar2).Value = producto.prodDescripcion;
                        Debug.WriteLine($"Parámetro p_descripcion: '{producto.prodDescripcion}'");

                        cmd.Parameters.Add("p_precio", OracleDbType.Decimal).Value = producto.prodPrecio;
                        Debug.WriteLine($"Parámetro p_precio: {producto.prodPrecio}");

                        cmd.Parameters.Add("p_estado", OracleDbType.Varchar2).Value = producto.prodEstado;
                        Debug.WriteLine($"Parámetro p_estado: '{producto.prodEstado}'");

                        cmd.Parameters.Add("p_imagen_ruta", OracleDbType.Varchar2).Value = producto.prodImagenRuta;
                        Debug.WriteLine($"Parámetro p_imagen_ruta: '{producto.prodImagenRuta}'");

                        string catFinal = categoria ?? producto.prodCategoria;
                        cmd.Parameters.Add("p_categoria", OracleDbType.Varchar2).Value = catFinal;
                        Debug.WriteLine($"Parámetro p_categoria: '{catFinal}'");

                        Debug.WriteLine("Ejecutando ExecuteNonQuery");  // Debug ejecución
                        cmd.ExecuteNonQuery();
                        Debug.WriteLine("ExecuteNonQuery completado");  // Debug completado
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error en ActualizarProducto: {ex.Message}");  // Debug error
                                                                                // Lanza la excepción para que sea capturada en el botón
                throw new Exception(ex.Message);
            }
        }


    }
}