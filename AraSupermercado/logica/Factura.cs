using AraSupermercado.accesoDatos;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AraSupermercado.logica
{
    public class Factura
    {
        // Propiedades
        public int ventCodigo { get; set; }
        public int pedCodigo { get; set; }
        public int cliId { get; set; }
        public string clienteNombre { get; set; }
        public string pedEstado { get; set; }
        public DateTime ventFecha { get; set; }
        public string pedDireccionEnvio { get; set; }
        public string pedMetodoPago { get; set; }
        public decimal ventTotal { get; set; }

        private ConexionOracle conexion = new ConexionOracle();

        public Factura() { }

        public Factura(int codigoVenta, int codigoPedido, int clienteId, string nombreCliente, string estado, DateTime fecha, string direccion, string metodoPago, decimal total)
        {
            ventCodigo = codigoVenta;
            pedCodigo = codigoPedido;
            cliId = clienteId;
            clienteNombre = nombreCliente;
            pedEstado = estado;
            ventFecha = fecha;
            pedDireccionEnvio = direccion;
            pedMetodoPago = metodoPago;
            ventTotal = total;
        }

        /// Obtiene todas las facturas del sistema
        public List<Factura> ObtenerTodasFacturas()
        {
            List<Factura> facturas = new List<Factura>();
            try
            {
                using (OracleConnection conn = conexion.ObtenerConexion())
                {
                    conn.Open();
                    using (OracleCommand cmd = new OracleCommand("pkg_pedido.pa_obtener_todas_facturas", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("p_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Factura factura = new Factura
                                {
                                    ventCodigo = reader.GetInt32(0),           
                                    pedCodigo = reader.GetInt32(1),            
                                    pedEstado = reader.GetString(2),           
                                    ventFecha = reader.GetDateTime(3),         
                                    pedDireccionEnvio = reader.GetString(4),   
                                    pedMetodoPago = reader.GetString(5),       
                                    clienteNombre = reader.GetString(6),       
                                    ventTotal = reader.GetDecimal(7)           
                                };
                                facturas.Add(factura);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener todas las facturas: " + ex.Message);
            }
            return facturas;
        }

        /// Obtiene información completa de una factura 
        public Factura ObtenerFacturaCompleta(int codigoVenta)
        {
            Factura factura = null;
            try
            {
                using (OracleConnection conn = conexion.ObtenerConexion())
                {
                    conn.Open();
                    using (OracleCommand cmd = new OracleCommand("pkg_pedido.pa_obtener_factura_completa", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("p_vent_codigo", OracleDbType.Int32).Value = codigoVenta;
                        cmd.Parameters.Add("p_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                factura = new Factura
                                {
                                    ventCodigo = reader.GetInt32(0),           
                                    pedCodigo = reader.GetInt32(1),            
                                    cliId = reader.GetInt32(2),                
                                    clienteNombre = reader.GetString(3),       
                                    pedEstado = reader.GetString(4),           
                                    ventFecha = reader.GetDateTime(5),         
                                    pedDireccionEnvio = reader.GetString(6),   
                                    pedMetodoPago = reader.GetString(7),       
                                    ventTotal = reader.GetDecimal(8)           
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener factura #{codigoVenta}: " + ex.Message);
            }
            return factura;
        }

        /// Obtiene los productos de una factura 
        public List<DetalleFacturaItem> ObtenerProductosFactura(int codigoVenta)
        {
            List<DetalleFacturaItem> items = new List<DetalleFacturaItem>();
            try
            {
                using (OracleConnection conn = conexion.ObtenerConexion())
                {
                    conn.Open();
                    using (OracleCommand cmd = new OracleCommand("pkg_pedido.pa_obtener_productos_factura", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("p_vent_codigo", OracleDbType.Int32).Value = codigoVenta;
                        cmd.Parameters.Add("p_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                DetalleFacturaItem item = new DetalleFacturaItem
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
                throw new Exception($"Error al obtener productos de la factura #{codigoVenta}: " + ex.Message);
            }
            return items;
        }
    }

    /// Clase auxiliar para items del detalle de factura
    public class DetalleFacturaItem
    {
        public string ProductoNombre { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Subtotal { get; set; }
    }
}