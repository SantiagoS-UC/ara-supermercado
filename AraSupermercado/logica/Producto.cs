using AraSupermercado.accesoDatos;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;

namespace AraSupermercado.logica
{
    public class Producto
    {
        // Propiedades existentes (tu código)
        public int prodCodigo { get; set; }
        public int provNit { get; set; }
        public string prodNombre { get; set; }
        public string prodDescripcion { get; set; }
        public string prodCategoria { get; set; }
        public string prodEstado { get; set; }
        public decimal prodPrecio { get; set; }
        public int prodStock { get; set; }
        public string prodImagenRuta { get; set; }

        private ConexionOracle conexion = new ConexionOracle();

        // Constructor vacío (tu código)
        public Producto() { }

        // Constructor con parámetros (tu código)
        public Producto(int codigo, int nit, string nombre, string descripcion, string estado, decimal precio, int stock, string imagenRuta)
        {
            prodCodigo = codigo;
            provNit = nit;
            prodNombre = nombre;
            prodDescripcion = descripcion;
            prodEstado = estado;
            prodPrecio = precio;
            prodStock = stock;
            prodImagenRuta = imagenRuta;
        }

        // Método para obtener todos los productos activos
        public List<Producto> ObtenerTodosProductos()
        {
            List<Producto> productos = new List<Producto>();
            try
            {
                using (OracleConnection conn = conexion.ObtenerConexion())
                {
                    conn.Open();
                    using (OracleCommand cmd = new OracleCommand("pa_obtener_productos", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Parámetro de entrada (estado, ej. "ACTIVO")
                        cmd.Parameters.Add("p_estado", OracleDbType.Varchar2).Value = "ACTIVO";

                        // Parámetro de salida (cursor)
                        cmd.Parameters.Add("p_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Producto producto = new Producto
                                {
                                    prodCodigo = reader.GetInt32(reader.GetOrdinal("prod_codigo")),
                                    provNit = reader.GetInt32(reader.GetOrdinal("prov_nit")),
                                    prodNombre = reader.GetString(reader.GetOrdinal("prod_nombre")),
                                    prodDescripcion = reader.GetString(reader.GetOrdinal("prod_descripcion")),
                                    prodEstado = reader.GetString(reader.GetOrdinal("prod_estado")),
                                    prodPrecio = reader.GetDecimal(reader.GetOrdinal("prod_precio")),
                                    prodStock = reader.GetInt32(reader.GetOrdinal("prod_stock")),
                                    prodImagenRuta = reader.GetString(reader.GetOrdinal("prod_imagen_ruta"))
                                };
                                productos.Add(producto);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener productos: " + ex.Message);
            }
            return productos;
        }

        // Obtener productos por categoría
        public List<Producto> ObtenerProductosPorCategoria(string categoria)
        {
            List<Producto> productos = new List<Producto>();
            try
            {
                using (OracleConnection conn = conexion.ObtenerConexion())
                {
                    conn.Open();
                    using (OracleCommand cmd = new OracleCommand("pa_obtener_productos_por_categoria", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("p_categoria", OracleDbType.Varchar2).Value = categoria;
                        cmd.Parameters.Add("p_estado", OracleDbType.Varchar2).Value = "ACTIVO";
                        cmd.Parameters.Add("p_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Producto producto = new Producto
                                {
                                    prodCodigo = reader.GetInt32(reader.GetOrdinal("prod_codigo")),
                                    provNit = reader.GetInt32(reader.GetOrdinal("prov_nit")),
                                    prodNombre = reader.GetString(reader.GetOrdinal("prod_nombre")),
                                    prodDescripcion = reader.GetString(reader.GetOrdinal("prod_descripcion")),
                                    prodEstado = reader.GetString(reader.GetOrdinal("prod_estado")),
                                    prodPrecio = reader.GetDecimal(reader.GetOrdinal("prod_precio")),
                                    prodStock = reader.GetInt32(reader.GetOrdinal("prod_stock")),
                                    prodImagenRuta = reader.GetString(reader.GetOrdinal("prod_imagen_ruta"))
                                };
                                productos.Add(producto);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener productos por categoría: " + ex.Message);
            }
            return productos;
        }

        // Método opcional: Consultar un producto específico por ID
        public void ConsultarProducto(int prodCodigo)
        {
            try
            {
                using (OracleConnection conn = conexion.ObtenerConexion())
                {
                    conn.Open();
                    using (OracleCommand cmd = new OracleCommand("pa_consultar_producto", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("p_prod_codigo", OracleDbType.Int32).Value = prodCodigo;

                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                this.prodCodigo = reader.GetInt32(reader.GetOrdinal("PRO_CODIGO"));
                                // Mapea el resto de propiedades
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar producto: " + ex.Message);
            }
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