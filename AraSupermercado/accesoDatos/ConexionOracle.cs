using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace AraSupermercado.accesoDatos
{
    public class ConexionOracle
    {

        //  Paso 1: obtener la cadena de conexión
        private readonly string cadenaConexion;

        public ConexionOracle()
        {
            // La cadena se lee desde App.config
            cadenaConexion = ConfigurationManager.ConnectionStrings["ConexionOracle"].ConnectionString;
        }

        //  Paso 2: ejecutar operaciones DML (INSERT, UPDATE, DELETE)
        public int EjecutarDML(string consulta, Dictionary<string, object> parametros = null)
        {
            try
            {
                using (OracleConnection conexion = new OracleConnection(cadenaConexion))
                using (OracleCommand comando = new OracleCommand(consulta, conexion))
                {
                    // Agregar parámetros si existen
                    if (parametros != null)
                    {
                        foreach (var p in parametros)
                            comando.Parameters.Add(new OracleParameter(p.Key, p.Value));
                    }

                    conexion.Open();
                    int filasAfectadas = comando.ExecuteNonQuery();
                    return filasAfectadas;
                }
            }
            catch (OracleException ex)
            {
                Console.WriteLine("Error de Oracle al ejecutar DML: " + ex.Message);
                return -1;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general al ejecutar DML: " + ex.Message);
                return -1;
            }
        }

        //  Paso 3: ejecutar consultas DQL (SELECT)
        public DataSet EjecutarDQL(string consulta, Dictionary<string, object> parametros = null)
        {
            DataSet dataSet = new DataSet();

            try
            {
                using (OracleConnection conexion = new OracleConnection(cadenaConexion))
                using (OracleCommand comando = new OracleCommand(consulta, conexion))
                {
                    // Agregar parámetros si existen
                    if (parametros != null)
                    {
                        foreach (var p in parametros)
                            comando.Parameters.Add(new OracleParameter(p.Key, p.Value));
                    }

                    using (OracleDataAdapter adaptador = new OracleDataAdapter(comando))
                    {
                        adaptador.Fill(dataSet, "ResultadoDatos");
                    }
                }
            }
            catch (OracleException ex)
            {
                Console.WriteLine("Error de Oracle al ejecutar DQL: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general al ejecutar DQL: " + ex.Message);
            }

            return dataSet;
        }

        //  Paso 4: obtener la conexión (opcional)
        public OracleConnection ObtenerConexion()
        {
            return new OracleConnection(cadenaConexion);
        }
    }
}

