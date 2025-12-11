using AraSupermercado.accesoDatos;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;

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

        private ConexionOracle conexion = new ConexionOracle();

        public Producto() { }

        public Producto(int codigo, int nit, string nombre, string descripcion, string categoria, string estado, decimal precio, int stock, string imagenRuta)
        {
            prodCodigo = codigo;
            provNit = nit;
            prodNombre = nombre;
            prodDescripcion = descripcion;
            prodCategoria = categoria;
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
                    using (OracleCommand cmd = new OracleCommand("pkg_producto.pa_obtener_productos", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Parámetro de entrada 
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
                    using (OracleCommand cmd = new OracleCommand("pkg_producto.pa_obtener_productos_por_categoria", conn))
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
    }
}
