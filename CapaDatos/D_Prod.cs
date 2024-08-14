using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class D_Prod
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConex"].ConnectionString);

        public DataTable D_listado()
        {
            SqlCommand cmd = new SqlCommand("sp_select_productos", cn); // Reemplazamos por un procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void D_Insertar(E_Prod producto)
        {
            SqlCommand cmd = new SqlCommand("sp_insert_producto", cn); // Procedimiento almacenado para insertar producto
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@IdProd", producto.id);
            cmd.Parameters.AddWithValue("@NomProd", producto.Nombre);
            cmd.Parameters.AddWithValue("@PrecioProd", producto.precio);
            cmd.Parameters.AddWithValue("@Stock", producto.stock);
       

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public decimal ObtenerPrecioProducto(int productoID)
        {
            try
            {
                cn.Open();
                string query = "SELECT prod_precio FROM tb_prod_producto WHERE prod_id = @ProductoID"; // Este código permanece igual
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@ProductoID", productoID);

                object resultado = cmd.ExecuteScalar();

                if (resultado != null && resultado != DBNull.Value)
                {
                    return Convert.ToDecimal(resultado);
                }
                else
                {
                    throw new Exception("El producto no existe.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el precio del producto: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        public void D_Eliminar(int prodID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_delete_producto", cn); // Procedimiento almacenado para eliminar producto
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdProd", prodID);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el producto: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        public void D_Editar(E_Prod producto)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_update_producto", cn); // Procedimiento almacenado para actualizar producto
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdProd", producto.id);
                cmd.Parameters.AddWithValue("@NomProd", producto.Nombre);
                cmd.Parameters.AddWithValue("@PrecioProd", producto.precio);
                cmd.Parameters.AddWithValue("@Stock", producto.stock);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al editar el producto: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
