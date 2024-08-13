using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                string query = "SELECT COUNT(1) FROM tb_emp_empleadoGuayaquil WHERE emp_gye_nombres = @emp_gye_nombres AND emp_gye_cedula = @emp_gye_cedula  AND emp_gye_sucursal_id = 2" ;
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@emp_gye_nombres", usuario.Nombre);
                cmd.Parameters.AddWithValue("@emp_gye_cedula", usuario.id);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count == 1;
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

