using AraSupermercado.accesoDatos;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AraSupermercado.logica
{
    public class Cliente
    {
        public int cliId { get; set; }
        public string cliTipoId { get; set; }
        public string cliPrimerNombre { get; set; }
        public string cliSegundoNombre { get; set; }
        public string cliPrimerApellido { get; set; }
        public string cliSegundoApellido { get; set; }
        public DateTime cliFechaNacimiento { get; set; }
        public string cliCorreo { get; set; }
        public string cliContrasena { get; set; }
        public string cliTelefono { get; set; }
        public string cliDireccion { get; set; }

        private ConexionOracle conexion = new ConexionOracle();

        public bool RegistrarCliente()
        {
            try
            {
                using (var conn = conexion.ObtenerConexion())
                {
                    conn.Open();
                    using (var cmd = new OracleCommand("pa_registrar_cliente", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        cmd.Parameters.Add("p_cli_id", OracleDbType.Int32).Value = this.cliId;
                        cmd.Parameters.Add("p_cli_tipo_id", OracleDbType.Varchar2).Value = this.cliTipoId;
                        cmd.Parameters.Add("p_cli_primer_nombre", OracleDbType.Varchar2).Value = this.cliPrimerNombre;
                        cmd.Parameters.Add("p_cli_segundo_nombre", OracleDbType.Varchar2).Value = string.IsNullOrEmpty(this.cliSegundoNombre) ? (object)DBNull.Value : this.cliSegundoNombre;
                        cmd.Parameters.Add("p_cli_primer_apellido", OracleDbType.Varchar2).Value = this.cliPrimerApellido;
                        cmd.Parameters.Add("p_cli_segundo_apellido", OracleDbType.Varchar2).Value = string.IsNullOrEmpty(this.cliSegundoApellido) ? (object)DBNull.Value : this.cliSegundoApellido;
                        cmd.Parameters.Add("p_cli_fecha_nacimiento", OracleDbType.Date).Value = this.cliFechaNacimiento;
                        cmd.Parameters.Add("p_cli_correo", OracleDbType.Varchar2).Value = this.cliCorreo;
                        cmd.Parameters.Add("p_cli_contraseña", OracleDbType.Varchar2).Value = this.cliContrasena;

                        cmd.Parameters.Add("p_tel_numero", OracleDbType.Varchar2).Value = string.IsNullOrEmpty(this.cliTelefono) ? (object)DBNull.Value : this.cliTelefono;
                        cmd.Parameters.Add("p_dir_cliente", OracleDbType.Varchar2).Value = string.IsNullOrEmpty(this.cliDireccion) ? (object)DBNull.Value : this.cliDireccion;
                        cmd.Parameters.Add("p_dir_descripcion", OracleDbType.Varchar2).Value = (object)DBNull.Value;

                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                // Lanza la excepción para que sea capturada en el botón
                throw new Exception(ex.Message);
            }
        }
    }
}