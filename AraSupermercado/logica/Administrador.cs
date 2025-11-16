using AraSupermercado.accesoDatos;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;

namespace AraSupermercado.logica
{
    public class Administrador
    {
        private ConexionOracle conexion; 

        public Administrador()
        {
            conexion = new ConexionOracle(); 
        }

        // Devuelve una lista de productos. Si no hay, la lista estará vacía 
        public List<Producto> VerProductosAdmin()
        {
            List<Producto> productos = new List<Producto>();
            try
            {
                using (OracleConnection conn = conexion.ObtenerConexion())
                {
                    conn.Open();
                    using (OracleCommand cmd = new OracleCommand("pkg_producto.pa_ver_productos_admin", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Parámetro de salida (cursor)
                        cmd.Parameters.Add("p_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

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
                                        categoria,
                                        reader.GetString(reader.GetOrdinal("prod_estado")),
                                        reader.GetDecimal(reader.GetOrdinal("prod_precio")),
                                        reader.GetInt32(reader.GetOrdinal("prod_stock")),
                                        reader.GetString(reader.GetOrdinal("prod_imagen_ruta"))
                                    );
                                    productos.Add(prod);
                                }
                                catch (Exception ex)
                                {
                                    throw new Exception($"Error procesando fila: {ex.Message}");
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error en VerProductosAdmin: {ex.Message}");
            }
            return productos;
        }

        public bool RegistrarProducto(int codigo, int nitProveedor, string nombre, string descripcion, string estado, decimal precio, int stock, string direccionImagen, string categoria)
        {
            // Validaciones básicas
            if (codigo <= 0 || precio <= 0 || stock < 0 || string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(descripcion) ||
                (estado != "Activo" && estado != "Inactivo"))
            {
                return false; 
            }

            try
            {
                using (OracleConnection conn = conexion.ObtenerConexion())
                {
                    conn.Open();
                    using (OracleCommand cmd = new OracleCommand("pkg_producto.pa_registrar_producto", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("p_codigo", OracleDbType.Int32).Value = codigo;
                        cmd.Parameters.Add("p_nombre", OracleDbType.Varchar2).Value = nombre;
                        cmd.Parameters.Add("p_descripcion", OracleDbType.Varchar2).Value = descripcion;
                        cmd.Parameters.Add("p_estado", OracleDbType.Varchar2).Value = estado;
                        cmd.Parameters.Add("p_precio", OracleDbType.Decimal).Value = precio;
                        cmd.Parameters.Add("p_imagen", OracleDbType.Varchar2).Value = direccionImagen;
                        cmd.Parameters.Add("p_categoria", OracleDbType.Varchar2).Value = categoria;

                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error en RegistrarProducto: {ex.Message}");
            }
        }

        // Buscar Productos por Nombre 
        public List<Producto> BuscarProductos(string nombreBusqueda)
        {
            List<Producto> productos = new List<Producto>();
            try
            {
                using (OracleConnection conn = conexion.ObtenerConexion())
                {
                    conn.Open();
                    using (OracleCommand cmd = new OracleCommand("pkg_producto.pa_buscar_productos", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Parámetros
                        cmd.Parameters.Add("p_nombre_busqueda", OracleDbType.Varchar2).Value = nombreBusqueda;
                        cmd.Parameters.Add("p_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

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
                                        categoria,
                                        reader.GetString(reader.GetOrdinal("prod_estado")),
                                        reader.GetDecimal(reader.GetOrdinal("prod_precio")),
                                        reader.GetInt32(reader.GetOrdinal("prod_stock")),
                                        reader.GetString(reader.GetOrdinal("prod_imagen_ruta"))
                                    );
                                    productos.Add(prod);
                                }
                                catch (Exception ex)
                                {
                                    throw new Exception($"Error procesando fila: {ex.Message}");
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error en BuscarProductos: {ex.Message}");
            }
            return productos;
        }

        public bool ActualizarProducto(Producto producto, string categoria = null)
        {
            try
            {
                using (OracleConnection conn = conexion.ObtenerConexion())
                {
                    conn.Open();
                    using (OracleCommand cmd = new OracleCommand("pkg_producto.pa_actualizar_producto", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("p_codigo", OracleDbType.Int32).Value = producto.prodCodigo;
                        cmd.Parameters.Add("p_nombre", OracleDbType.Varchar2).Value = producto.prodNombre;
                        cmd.Parameters.Add("p_descripcion", OracleDbType.Varchar2).Value = producto.prodDescripcion;
                        cmd.Parameters.Add("p_precio", OracleDbType.Decimal).Value = producto.prodPrecio;
                        cmd.Parameters.Add("p_estado", OracleDbType.Varchar2).Value = producto.prodEstado;
                        cmd.Parameters.Add("p_imagen_ruta", OracleDbType.Varchar2).Value = producto.prodImagenRuta;
                        string catFinal = categoria ?? producto.prodCategoria;
                        cmd.Parameters.Add("p_categoria", OracleDbType.Varchar2).Value = catFinal;

                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error en ActualizarProducto: {ex.Message}");
            }
        }
    }
}