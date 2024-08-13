using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class D_Empleado
    {
        private SqlConnection cn;

        public D_Empleado()
        {
            cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConex"].ConnectionString);
        }

        public bool AgregarEmpleado(E_Empleado empleado)
        {
            try
            {
                cn.Open();

                // Inserción directa en la tabla de Guayaquil ya que la vista se utiliza solo para consultas
                string query = "INSERT INTO tb_emp_empleadoGuayaquil (emp_gye_nombres, emp_gye_apellidos, emp_gye_cedula, emp_gye_sucursal_id) " +
                               "VALUES (@emp_gye_nombres, @emp_gye_apellidos, @emp_gye_cedula, @emp_gye_sucursal_id)";
                SqlCommand cmd = new SqlCommand(query, cn);

                cmd.Parameters.AddWithValue("@emp_gye_nombres", empleado.Nombres);
                cmd.Parameters.AddWithValue("@emp_gye_apellidos", empleado.Apellidos);
                cmd.Parameters.AddWithValue("@emp_gye_cedula", empleado.Cedula);
                cmd.Parameters.AddWithValue("@emp_gye_sucursal_id", empleado.SucursalId);

                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar el empleado: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        public bool EliminarEmpleado(string cedula)
        {
            try
            {
                cn.Open();

                // Eliminación directa en la tabla de Guayaquil, la vista se usa solo para consultas
                string query = "DELETE FROM tb_emp_empleadoGuayaquil WHERE emp_gye_cedula = @Cedula";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@Cedula", cedula + "%");

                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el empleado: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        public List<E_Empleado> BuscarEmpleados(string criterio)
        {
            List<E_Empleado> empleados = new List<E_Empleado>();

            try
            {
                cn.Open();

                // Uso de la vista vw_empleados para realizar la búsqueda en ambas tablas
                string query = "SELECT Cedula, Nombres, Apellidos, SucursalId " +
                               "FROM vw_empleados " +
                               "WHERE Cedula = @Cedula ";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@Cedula",  criterio );

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    E_Empleado empleado = new E_Empleado
                    {
                        Cedula = reader["Cedula"].ToString(),
                        Nombres = reader["Nombres"].ToString(),
                        Apellidos = reader["Apellidos"].ToString(),
                        SucursalId = Convert.ToInt32(reader["SucursalId"])
                    };

                    empleados.Add(empleado);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar empleados: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }

            return empleados;
        }
        public bool EditarEmpleado(E_Empleado empleado)
        {
            try
            {
                cn.Open();

                string query = "UPDATE tb_emp_empleadoGuayaquil SET emp_gye_nombres = @emp_gye_nombres, " +
                               "emp_gye_apellidos = @emp_gye_apellidos, " +
                               "emp_gye_sucursal_id = @emp_gye_sucursal_id " +
                               "WHERE emp_gye_cedula = @emp_gye_cedula";
                SqlCommand cmd = new SqlCommand(query, cn);

                cmd.Parameters.AddWithValue("@emp_gye_nombres", empleado.Nombres);
                cmd.Parameters.AddWithValue("@emp_gye_apellidos", empleado.Apellidos);
                cmd.Parameters.AddWithValue("@emp_gye_sucursal_id", empleado.SucursalId);
                cmd.Parameters.AddWithValue("@emp_gye_cedula", empleado.Cedula);

                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al editar el empleado: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
