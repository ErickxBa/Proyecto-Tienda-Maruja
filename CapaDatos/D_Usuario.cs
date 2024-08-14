using System;
using System.Configuration;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class D_Usuario
    {
        private SqlConnection cn;

        public D_Usuario()
        {
            cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConex"].ConnectionString);
        }

        public bool VerificarCredenciales(E_Usuario usuario)
        {
            try
            {
                cn.Open();

                // Llamar al procedimiento almacenado para verificar las credenciales del empleado
                string query = "sp_select_empleado";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                // Añadir parámetros al comando
                cmd.Parameters.AddWithValue("@IdEmp", usuario.id);

                // Ejecutar el comando y leer los resultados
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string nombreEmpleado = reader["Nombres"].ToString();

                    // Verificar si el nombre coincide
                    if (nombreEmpleado.Equals(usuario.Nombre, StringComparison.OrdinalIgnoreCase))
                    {
                        return true;
                    }
                }

                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al verificar credenciales: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
