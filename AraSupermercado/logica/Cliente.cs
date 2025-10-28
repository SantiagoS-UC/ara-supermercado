using AraSupermercado.accesoDatos;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Text.RegularExpressions;

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

        // Método para consultar información del cliente
        public void ConsultarCliente(int cliId)
        {
            try
            {
                using (OracleConnection conn = conexion.ObtenerConexion())
                {
                    conn.Open();

                    using (OracleCommand cmd = new OracleCommand("pa_consultar_cliente", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Parámetro de entrada
                        cmd.Parameters.Add("p_cli_id", OracleDbType.Int32).Value = cliId;

                        // Parámetros de salida 
                        cmd.Parameters.Add("p_cli_tipo_id", OracleDbType.Varchar2, 30).Direction = ParameterDirection.Output;
                        cmd.Parameters.Add("p_cli_primer_nombre", OracleDbType.Varchar2, 50).Direction = ParameterDirection.Output;
                        cmd.Parameters.Add("p_cli_segundo_nombre", OracleDbType.Varchar2, 50).Direction = ParameterDirection.Output;
                        cmd.Parameters.Add("p_cli_primer_apellido", OracleDbType.Varchar2, 50).Direction = ParameterDirection.Output;
                        cmd.Parameters.Add("p_cli_segundo_apellido", OracleDbType.Varchar2, 50).Direction = ParameterDirection.Output;
                        cmd.Parameters.Add("p_cli_fecha_nacimiento", OracleDbType.Date).Direction = ParameterDirection.Output;
                        cmd.Parameters.Add("p_cli_correo", OracleDbType.Varchar2, 100).Direction = ParameterDirection.Output;
                        cmd.Parameters.Add("p_cli_contrasena", OracleDbType.Varchar2, 100).Direction = ParameterDirection.Output;
                        cmd.Parameters.Add("p_tel_numero", OracleDbType.Varchar2, 15).Direction = ParameterDirection.Output;
                        cmd.Parameters.Add("p_dir_cliente", OracleDbType.Varchar2, 200).Direction = ParameterDirection.Output;
                        cmd.ExecuteNonQuery();

                        // Asignación segura de valores
                        cliTipoId = cmd.Parameters["p_cli_tipo_id"].Value?.ToString();
                        cliPrimerNombre = cmd.Parameters["p_cli_primer_nombre"].Value?.ToString();
                        cliSegundoNombre = cmd.Parameters["p_cli_segundo_nombre"].Value?.ToString();
                        cliPrimerApellido = cmd.Parameters["p_cli_primer_apellido"].Value?.ToString();
                        cliSegundoApellido = cmd.Parameters["p_cli_segundo_apellido"].Value?.ToString();
                        cliCorreo = cmd.Parameters["p_cli_correo"].Value?.ToString();
                        cliContrasena = cmd.Parameters["p_cli_contrasena"].Value?.ToString();
                        cliTelefono = cmd.Parameters["p_tel_numero"].Value?.ToString();
                        cliDireccion = cmd.Parameters["p_dir_cliente"].Value?.ToString();

                        // Fecha de nacimiento 
                        object fechaVal = cmd.Parameters["p_cli_fecha_nacimiento"].Value;
                        if (fechaVal != null && fechaVal != DBNull.Value)
                        {
                            if (fechaVal is Oracle.ManagedDataAccess.Types.OracleDate oracleDate)
                            {
                                cliFechaNacimiento = oracleDate.Value;
                            }
                            else
                            {
                                cliFechaNacimiento = Convert.ToDateTime(fechaVal);
                            }
                        }
                        else
                        {
                            cliFechaNacimiento = DateTime.MinValue;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar cliente: " + ex.Message, ex);
            }
        }

        // Método para actualizar información del cliente
        public bool ActualizarCliente()
        {
            try
            {
                using (var conn = conexion.ObtenerConexion())
                {
                    conn.Open();
                    using (var cmd = new OracleCommand("pa_actualizar_cliente", conn))
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
                        cmd.Parameters.Add("p_cli_contrasena", OracleDbType.Varchar2).Value = this.cliContrasena;
                        cmd.Parameters.Add("p_tel_numero", OracleDbType.Varchar2).Value = string.IsNullOrEmpty(this.cliTelefono) ? (object)DBNull.Value : this.cliTelefono;
                        cmd.Parameters.Add("p_dir_cliente", OracleDbType.Varchar2).Value = string.IsNullOrEmpty(this.cliDireccion) ? (object)DBNull.Value : this.cliDireccion;
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

        // Método auxiliar para validar fecha de nacimiento
        public static bool ValidarFechaNacimiento(DateTime fecha, out string mensajeError)
        {
            mensajeError = string.Empty;
            if (fecha > DateTime.Now)
            {
                mensajeError = "La fecha de nacimiento no puede ser mayor al día actual.";
                return false;
            }
            int edad = DateTime.Now.Year - fecha.Year;
            if (fecha > DateTime.Now.AddYears(-edad)) edad--;  // Ajuste si no ha cumplido años este año
            if (edad < 18)
            {
                mensajeError = "Debe ser mayor de 18 años.";
                return false;
            }
            // Validar edad máxima (no mayor a 100 años)
            if (edad > 100)
            {
                mensajeError = "La edad no puede ser mayor a 100 años.";
                return false;
            }
            return true;
        }

        // Método auxiliar para validar patrones y prevenir inyección SQL/datos raros
        public static bool ValidarCampoAvanzado(string valor, string tipoCampo, out string mensajeError)
        {
            mensajeError = string.Empty;
            if (string.IsNullOrWhiteSpace(valor)) return true;

            // Lista de palabras clave SQL comunes a bloquear
            string[] palabrasSql = { "SELECT", "INSERT", "UPDATE", "DELETE", "DROP", "CREATE", "ALTER", "EXEC", "UNION", "SCRIPT" };
            foreach (string palabra in palabrasSql)
            {
                if (valor.ToUpper().Contains(palabra))
                {
                    mensajeError = $"No se permiten palabras reservadas como '{palabra}'.";
                    return false;
                }
            }

            // Validaciones por tipo de campo usando Regex
            switch (tipoCampo.ToLower())
            {
                case "id":
                    if (!Regex.IsMatch(valor, @"^\d{5,10}$"))
                    {
                        mensajeError = "Debe contener solo números, entre 5 y 15 dígitos.";
                        return false;
                    }
                    break;
                case "nombre":
                case "apellido":
                    if (!Regex.IsMatch(valor, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ]+$"))
                    {
                        mensajeError = "Solo letras y acentos (ej. José).";
                        return false;
                    }
                    break;
                case "correo":
                    if (!Regex.IsMatch(valor, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
                    {
                        mensajeError = "Formato inválido (ej. usuario@dominio.com).";
                        return false;
                    }
                    break;
                case "telefono":
                    if (!Regex.IsMatch(valor, @"^\d{10}$"))
                    {
                        mensajeError = "El número debe contener exactamente 10 dígitos y solo números (sin guiones ni espacios).\"";
                        return false;
                    }
                    break;
                case "direccion":
                case "contrasena":
                    if (!Regex.IsMatch(valor, @"^[a-zA-Z0-9\s.,#-]+$"))
                    {
                        mensajeError = "Solo letras, números, espacios y caracteres básicos (., #, -).";
                        return false;
                    }
                    break;
            }
            return true;
        }
    }
}