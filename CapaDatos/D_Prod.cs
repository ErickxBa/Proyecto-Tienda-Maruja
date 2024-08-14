using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using CapaEntidad;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class D_Prod
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConex"].ConnectionString);

        public DataTable D_listado()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM vw_productos_unificados", cn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


        public void D_Insertar(E_Prod producto)
        {
            SqlCommand cmd = new SqlCommand("sp_insertar_actualizar_producto_Guayaquil", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@prod_id", producto.id);
            cmd.Parameters.AddWithValue("@prod_precio", producto.precio);
            cmd.Parameters.AddWithValue("@prod_nombre", producto.Nombre);
            cmd.Parameters.AddWithValue("@prod_stock", producto.stock);
            cmd.Parameters.AddWithValue("@sucursal_id", 2); // Sucursal Guayaquil
     
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public decimal ObtenerPrecioProducto(int productoID)
        {
            try
            {
                cn.Open();
                string query = "SELECT prod_precio FROM tb_prod_producto WHERE prod_id = @ProductoID";
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
                string query = "DELETE FROM tb_prod_producto WHERE prod_id = @prod_id";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@prod_id", prodID);

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
                string query = "UPDATE tb_prod_producto SET prod_precio = @precio, prod_nombre = @nombre, prod_stock = @stock WHERE prod_id = @prod_id";
                SqlCommand cmd = new SqlCommand(query, cn);

                cmd.Parameters.AddWithValue("@prod_id", producto.id);
                cmd.Parameters.AddWithValue("@precio", producto.precio);
                cmd.Parameters.AddWithValue("@nombre", producto.Nombre);
                cmd.Parameters.AddWithValue("@stock", producto.stock);

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