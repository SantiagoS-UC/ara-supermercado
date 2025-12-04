using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AraSupermercado.accesoDatos;
using Oracle.ManagedDataAccess.Client;
using System.Data;


namespace AraSupermercado.logica
{
    public class Pedido
    {
        public int pedCodigo { get; set; }
        public int cliId { get; set; }
        public string cliNombreCompleto { get; set; }
        public string pedEstado { get; set; }
        public DateTime pedFechaCreacion { get; set; }
        public string pedDireccionEnvio { get; set; }
        public string pedMetodoPago { get; set; }
        public decimal pedTotal { get; set; }

        private ConexionOracle conexion = new ConexionOracle();

        public Pedido() { }

        public Pedido(int codigo, int clienteId, string nombreCliente, string estado, DateTime fecha, string direccion, string metodoPago, decimal total)
        {
            pedCodigo = codigo;
            cliId = clienteId;
            cliNombreCompleto = nombreCliente;
            pedEstado = estado;
            pedFechaCreacion = fecha;
            pedDireccionEnvio = direccion;
            pedMetodoPago = metodoPago;
            pedTotal = total;
        }

        //Obtiene todos los pedidos
        public List<Pedido> ObtenerTodosPedidos()
        {
            List<Pedido> pedidos = new List<Pedido>();
            try
            {
                using (OracleConnection conn = conexion.ObtenerConexion())
                {
                    conn.Open();
                    using (OracleCommand cmd = new OracleCommand("pkg_pedido.pa_obtener_todos_pedidos", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("p_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Pedido pedido = new Pedido
                                {
                                    pedCodigo = reader.GetInt32(0),
                                    cliId = reader.GetInt32(1),
                                    cliNombreCompleto = reader.GetString(2),
                                    pedEstado = reader.GetString(3),
                                    pedFechaCreacion = reader.GetDateTime(4),
                                    pedTotal = reader.GetDecimal(5)
                                };
                                pedidos.Add(pedido);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener todos los pedidos: " + ex.Message);
            }
            return pedidos;
        }

        /// <summary>
        /// Filtra pedidos por estado
        /// </summary>
        public List<Pedido> ObtenerPedidosPorEstado(string estado)
        {
            List<Pedido> pedidos = new List<Pedido>();
            try
            {
                using (OracleConnection conn = conexion.ObtenerConexion())
                {
                    conn.Open();
                    using (OracleCommand cmd = new OracleCommand("pkg_pedido.pa_obtener_pedidos_por_estado", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("p_estado", OracleDbType.Varchar2).Value = estado;
                        cmd.Parameters.Add("p_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Pedido pedido = new Pedido
                                {
                                    pedCodigo = reader.GetInt32(0),
                                    cliId = reader.GetInt32(1),
                                    cliNombreCompleto = reader.GetString(2),
                                    pedEstado = reader.GetString(3),
                                    pedFechaCreacion = reader.GetDateTime(4),
                                    pedTotal = reader.GetDecimal(5)
                                };
                                pedidos.Add(pedido);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al filtrar pedidos por estado '{estado}': " + ex.Message);
            }
            return pedidos;
        }

        /// <summary>
        /// Obtiene los detalles completos de un pedido específico
        /// </summary>
        public Pedido ObtenerDetallePedido(int pedidoCodigo)
        {
            Pedido pedido = null;
            try
            {
                using (OracleConnection conn = conexion.ObtenerConexion())
                {
                    conn.Open();
                    using (OracleCommand cmd = new OracleCommand("pkg_pedido.pa_obtener_pedido_completo", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("p_ped_codigo", OracleDbType.Int32).Value = pedidoCodigo;
                        cmd.Parameters.Add("p_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                pedido = new Pedido
                                {
                                    pedCodigo = reader.GetInt32(0),
                                    cliId = reader.GetInt32(1),
                                    cliNombreCompleto = reader.GetString(2),
                                    pedEstado = reader.GetString(3),
                                    pedFechaCreacion = reader.GetDateTime(4),
                                    pedDireccionEnvio = reader.GetString(5),
                                    pedMetodoPago = reader.GetString(6),
                                    pedTotal = reader.GetDecimal(7)
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener detalle del pedido #{pedidoCodigo}: " + ex.Message);
            }
            return pedido;
        }

        /// <summary>
        /// Obtiene los productos de un pedido (para el DataGridView de detalles)
        /// </summary>
        public List<DetallePedidoItem> ObtenerProductosPedido(int pedidoCodigo)
        {
            List<DetallePedidoItem> items = new List<DetallePedidoItem>();
            try
            {
                using (OracleConnection conn = conexion.ObtenerConexion())
                {
                    conn.Open();
                    using (OracleCommand cmd = new OracleCommand("pkg_pedido.pa_obtener_detalle_pedido", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("p_ped_codigo", OracleDbType.Int32).Value = pedidoCodigo;
                        cmd.Parameters.Add("p_result", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                DetallePedidoItem item = new DetallePedidoItem
                                {
                                    ProductoNombre = reader.GetString(1),
                                    Cantidad = reader.GetInt32(2),
                                    PrecioUnitario = reader.GetDecimal(3),
                                    Subtotal = reader.GetDecimal(4)
                                };
                                items.Add(item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener productos del pedido #{pedidoCodigo}: " + ex.Message);
            }
            return items;
        }

        /// <summary>
        /// Actualiza el estado de un pedido
        /// </summary>
        public bool ActualizarEstadoPedido(int pedidoCodigo, string nuevoEstado)
        {
            // Validar estados permitidos según tu BD
            string[] estadosValidos = { "Pendiente", "Confirmado", "Enviado", "Entregado", "Cancelado" };
            bool esValido = false;
            foreach (string estado in estadosValidos)
            {
                if (nuevoEstado == estado)
                {
                    esValido = true;
                    break;
                }
            }

            if (!esValido)
            {
                throw new Exception($"Estado '{nuevoEstado}' no es válido. Estados permitidos: Pendiente, Confirmado, Procesando, Enviado, Entregado, Cancelado.");
            }

            try
            {
                using (OracleConnection conn = conexion.ObtenerConexion())
                {
                    conn.Open();
                    using (OracleCommand cmd = new OracleCommand("pkg_pedido.pa_actualizar_estado_pedido", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("p_ped_codigo", OracleDbType.Int32).Value = pedidoCodigo;
                        cmd.Parameters.Add("p_nuevo_estado", OracleDbType.Varchar2).Value = nuevoEstado;

                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al actualizar estado del pedido #{pedidoCodigo}: " + ex.Message);
            }
        }
    }

    /// <summary>
    /// Clase auxiliar para items del detalle
    /// </summary>
    public class DetallePedidoItem
    {
        public string ProductoNombre { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Subtotal { get; set; }
    }
}
