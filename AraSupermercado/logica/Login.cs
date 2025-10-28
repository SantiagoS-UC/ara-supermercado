using AraSupermercado.accesoDatos;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System;
using System.Data;
using System.Windows.Forms;

namespace AraSupermercado.logica
{
    public class Login
    {
        private ConexionOracle conexion;

        public Login()
        {
            conexion = new ConexionOracle();
        }

        // Método para validar credenciales y devolver tipo de usuario + id del cliente
        public (string tipoUsuario, int clienteId) ValidarUsuario(string correo, string contrasena)
        {
            string tipoUsuario = string.Empty;
            int clienteId;

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

                        // Parámetros de salida
                        cmd.Parameters.Add("p_tipo_usuario", OracleDbType.Varchar2, 20).Direction = ParameterDirection.Output;
                        cmd.Parameters.Add("p_cli_id", OracleDbType.Int32).Direction = ParameterDirection.Output;

                        cmd.ExecuteNonQuery();

                        // Leer tipo de usuario
                        object tipoVal = cmd.Parameters["p_tipo_usuario"].Value;
                        tipoUsuario = tipoVal != null ? tipoVal.ToString() : string.Empty;

                        // Leer ID del cliente
                        object idVal = cmd.Parameters["p_cli_id"].Value;
                        if (idVal == null || idVal == DBNull.Value)
                        {
                            clienteId = 0;
                        }
                        else if (idVal is OracleDecimal od)
                        {
                            clienteId = od.IsNull ? 0 : od.ToInt32();
                        }
                        else if (idVal is int i)
                        {
                            clienteId = i;
                        }
                        else if (idVal is decimal dec)
                        {
                            clienteId = Convert.ToInt32(dec);
                        }
                        else
                        {
                            int.TryParse(idVal.ToString(), out clienteId);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al validar usuario: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

            return (tipoUsuario, clienteId);
        }
    }
}
