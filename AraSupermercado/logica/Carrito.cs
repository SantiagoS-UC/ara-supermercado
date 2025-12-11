using AraSupermercado.accesoDatos;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace AraSupermercado.logica
{
    public static class Carrito
    {
        private static ConexionOracle conexion = new ConexionOracle();
        private static int cliIdActual;  // ID del cliente actual
        private static List<ItemCarrito> items = new List<ItemCarrito>();  

        // Establecer cliente y cargar carrito desde BD
        public static void EstablecerCliente(int cliId)
        {
            cliIdActual = cliId;
            CargarCarritoDesdeBD();
        }

        // Agregar producto (inserta/actualiza en CARRITO)
        public static void AgregarProducto(Producto producto, int cantidad = 1)
        {
            try
            {
                using (OracleConnection conn = conexion.ObtenerConexion())
                {
                    conn.Open();
                    using (OracleCommand cmd = new OracleCommand("pkg_carrito.pa_agregar_a_carrito", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("p_cli_id", OracleDbType.Int32).Value = cliIdActual;
                        cmd.Parameters.Add("p_prod_codigo", OracleDbType.Int32).Value = producto.prodCodigo;
                        cmd.Parameters.Add("p_cantidad", OracleDbType.Int32).Value = cantidad;

                        cmd.ExecuteNonQuery();
                    }
                }
                CargarCarritoDesdeBD();  // Recarga memoria
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar producto: " + ex.Message);
            }
        }

        // Quitar producto (actualiza/disminuye en CARRITO)
        public static void QuitarProducto(int prodCodigo, int cantidad = 1)
        {
            try
            {
                using (OracleConnection conn = conexion.ObtenerConexion())
                {
                    conn.Open();
                    using (OracleCommand cmd = new OracleCommand("pkg_carrito.pa_quitar_de_carrito", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("p_cli_id", OracleDbType.Int32).Value = cliIdActual;
                        cmd.Parameters.Add("p_prod_codigo", OracleDbType.Int32).Value = prodCodigo;
                        cmd.Parameters.Add("p_cantidad", OracleDbType.Int32).Value = cantidad;

                        cmd.ExecuteNonQuery();
                    }
                }
                CargarCarritoDesdeBD();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al quitar producto: " + ex.Message);
            }
        }

        // Cargar carrito desde BD a memoria
        private static void CargarCarritoDesdeBD()
        {
            items.Clear();
            try
            {
                using (OracleConnection conn = conexion.ObtenerConexion())
                {
                    conn.Open();
                    using (OracleCommand cmd = new OracleCommand("pkg_carrito.pa_obtener_carrito", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("p_cli_id", OracleDbType.Int32).Value = cliIdActual;
                        cmd.Parameters.Add("p_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Producto producto = new Producto
                                {
                                    prodCodigo = reader.GetInt32(reader.GetOrdinal("prod_codigo")),
                                    prodNombre = reader.GetString(reader.GetOrdinal("prod_nombre")),
                                    prodPrecio = reader.GetDecimal(reader.GetOrdinal("prod_precio")),
                                    prodImagenRuta = reader.GetString(reader.GetOrdinal("prod_imagen_ruta"))
                                };
                                int cantidad = reader.GetInt32(reader.GetOrdinal("car_cantidad"));
                                items.Add(new ItemCarrito { Producto = producto, Cantidad = cantidad });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar carrito: " + ex.Message);
            }
        }

        // Confirmar pedido (copia CARRITO a DETALLE_PEDIDO, crea PEDIDO/VENTA)
        public static int ConfirmarPedido(string direccionEnvio, string metodoPago)
        {
            if (items.Count == 0) return 0;

            using (OracleConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                using (OracleTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        // 1. Crear PEDIDO
                        int pedCodigo;
                        using (OracleCommand cmdPedido = new OracleCommand("pkg_pedido.pa_insertar_pedido", conn))
                        {
                            cmdPedido.CommandType = CommandType.StoredProcedure;
                            cmdPedido.Transaction = trans;

                            cmdPedido.Parameters.Add("p_cli_id", OracleDbType.Int32).Value = cliIdActual;
                            cmdPedido.Parameters.Add("p_ped_estado", OracleDbType.Varchar2).Value = "Confirmado";
                            cmdPedido.Parameters.Add("p_ped_fecha_creacion", OracleDbType.Date).Value = DateTime.Now;
                            cmdPedido.Parameters.Add("p_ped_direccion_envio", OracleDbType.Varchar2).Value = direccionEnvio;  // ✅ FALTABA
                            cmdPedido.Parameters.Add("p_ped_metodo_pago", OracleDbType.Varchar2).Value = metodoPago;         // ✅ FALTABA
                            cmdPedido.Parameters.Add("p_ped_codigo_out", OracleDbType.Int32).Direction = ParameterDirection.Output;

                            cmdPedido.ExecuteNonQuery();

                            var dec = (Oracle.ManagedDataAccess.Types.OracleDecimal)cmdPedido.Parameters["p_ped_codigo_out"].Value;
                            pedCodigo = dec.ToInt32();
                        }

                        // 2. Copiar a DETALLE_PEDIDO
                        foreach (var item in items)
                        {
                            using (OracleCommand cmdDetalle = new OracleCommand("pkg_pedido.pa_insertar_detalle_pedido", conn))
                            {
                                cmdDetalle.CommandType = CommandType.StoredProcedure;
                                cmdDetalle.Transaction = trans;
                                cmdDetalle.Parameters.Add("p_ped_codigo", OracleDbType.Int32).Value = pedCodigo;
                                cmdDetalle.Parameters.Add("p_prod_codigo", OracleDbType.Int32).Value = item.Producto.prodCodigo;
                                cmdDetalle.Parameters.Add("p_dp_cant_prod", OracleDbType.Int32).Value = item.Cantidad;
                                cmdDetalle.Parameters.Add("p_dp_precio_unitario", OracleDbType.Decimal).Value = item.Producto.prodPrecio;
                                cmdDetalle.ExecuteNonQuery();
                            }
                        }

                        // 3. Crear VENTA
                        using (OracleCommand cmdVenta = new OracleCommand("pkg_pedido.pa_insertar_venta", conn))
                        {
                            cmdVenta.CommandType = CommandType.StoredProcedure;
                            cmdVenta.Transaction = trans;
                            cmdVenta.Parameters.Add("p_ped_codigo", OracleDbType.Int32).Value = pedCodigo;
                            cmdVenta.Parameters.Add("p_vent_fecha", OracleDbType.Date).Value = DateTime.Now;
                            cmdVenta.ExecuteNonQuery();
                        }

                        // 4. Vaciar CARRITO
                        using (OracleCommand cmdVaciar = new OracleCommand("pkg_carrito.pa_vaciar_carrito", conn))
                        {
                            cmdVaciar.CommandType = CommandType.StoredProcedure;
                            cmdVaciar.Transaction = trans;
                            cmdVaciar.Parameters.Add("p_cli_id", OracleDbType.Int32).Value = cliIdActual;
                            cmdVaciar.ExecuteNonQuery();
                        }

                        trans.Commit();
                        items.Clear();
                        return pedCodigo;
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        throw new Exception("Error al confirmar pedido: " + ex.Message);
                    }
                }
            }
        }

        // Métodos de consulta (igual)
        public static List<ItemCarrito> ObtenerItems() => items;
        public static decimal ObtenerTotal() => items.Sum(i => i.Subtotal);
        public static int ObtenerCantidadTotal() => items.Sum(i => i.Cantidad);

        // Clase ItemCarrito
        public class ItemCarrito
        {
            public Producto Producto { get; set; }
            public int Cantidad { get; set; }
            public decimal Subtotal => Producto.prodPrecio * Cantidad;
        }
    }
}