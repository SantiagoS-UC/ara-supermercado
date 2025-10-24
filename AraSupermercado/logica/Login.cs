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
    public class Login
    {
        private ConexionOracle conexion;

        // Constructor
        public Login()
        {
            conexion = new ConexionOracle();
        }

        // Método para validar credenciales
        public string ValidarUsuario(string correo, string contrasena)
        {
            string tipoUsuario;

            try
            {
                using (OracleConnection conn = conexion.ObtenerConexion())
                {
                    conn.Open();

                    using (OracleCommand cmd = new OracleCommand("pa_validar_login", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Parámetros de entrada
                        cmd.Parameters.Add("p_correo", OracleDbType.Varchar2).Value = correo;
                        cmd.Parameters.Add("p_contrasena", OracleDbType.Varchar2).Value = contrasena;

                        // Parámetro de salida
                        cmd.Parameters.Add("p_tipo_usuario", OracleDbType.Varchar2, 20).Direction = ParameterDirection.Output;

                        // Ejecutar el procedimiento
                        cmd.ExecuteNonQuery();

                        // Leer valor de salida
                        tipoUsuario = cmd.Parameters["p_tipo_usuario"].Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al validar usuario: " + ex.Message);
            }

            return tipoUsuario;
        }
    }
}