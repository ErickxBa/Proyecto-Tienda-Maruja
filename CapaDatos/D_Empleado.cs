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

                // Usar el procedimiento almacenado para insertar un empleado
                SqlCommand cmd = new SqlCommand("sp_insert_empleado", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdEmp", empleado.Cedula);
                cmd.Parameters.AddWithValue("@NomEmp", empleado.Nombres);
                cmd.Parameters.AddWithValue("@ApeEmp", empleado.Apellidos);
                cmd.Parameters.AddWithValue("@IdSuc", empleado.SucursalId);  // Cambiado para utilizar el SucursalId del empleado

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

                // Usar el procedimiento almacenado para eliminar un empleado
                SqlCommand cmd = new SqlCommand("sp_delete_empleado", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdEmp", cedula);

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

                // Consulta para buscar empleados utilizando la vista
                string query = "SELECT emp_gye_cedula AS Cedula, emp_gye_nombres AS Nombres, emp_gye_apellidos AS Apellidos, emp_gye_sucursal_id AS SucursalId " +
                               "FROM v_empleado " +
                               "WHERE emp_gye_cedula LIKE @Cedula + '%'";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@Cedula", criterio);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    E_Empleado empleado = new E_Empleado
                    {
                        Cedula = reader["Cedula"].ToString(),
                        Nombres = reader["Nombres"].ToString(),
                        Apellidos = reader["Apellidos"].ToString(),
                        SucursalId = reader["SucursalId"].ToString()
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

        public List<E_Empleado> ObtenerTodosLosEmpleados()
        {
            List<E_Empleado> empleados = new List<E_Empleado>();

            try
            {
                cn.Open();

                // Consulta para obtener todos los empleados desde la vista
                string query = "SELECT emp_gye_cedula AS Cedula, emp_gye_nombres AS Nombres, emp_gye_apellidos AS Apellidos, emp_gye_sucursal_id AS SucursalId " +
                               "FROM v_empleado";
                SqlCommand cmd = new SqlCommand(query, cn);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    E_Empleado empleado = new E_Empleado
                    {
                        Cedula = reader["Cedula"].ToString(),
                        Nombres = reader["Nombres"].ToString(),
                        Apellidos = reader["Apellidos"].ToString(),
                        SucursalId = reader["SucursalId"].ToString()
                    };

                    empleados.Add(empleado);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los empleados: " + ex.Message);
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

                // Usar el procedimiento almacenado para editar un empleado
                SqlCommand cmd = new SqlCommand("sp_update_empleado", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdEmp", empleado.Cedula);
                cmd.Parameters.AddWithValue("@NomEmp", empleado.Nombres);
                cmd.Parameters.AddWithValue("@ApeEmp", empleado.Apellidos);
                cmd.Parameters.AddWithValue("@IdSuc", empleado.SucursalId);

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
