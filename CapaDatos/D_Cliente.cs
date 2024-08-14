using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class D_cliente
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConex"].ConnectionString);

        public DataTable D_Listado()
        {
            SqlCommand cmd = new SqlCommand("sp_select_cliente", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void D_Insertar(E_Cliente cliente)
        {
            SqlCommand cmd = new SqlCommand("sp_insert_cliente", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@cli_id", cliente.ClienteID);
            cmd.Parameters.AddWithValue("@cli_nombre", cliente.Nombre);
            cmd.Parameters.AddWithValue("@cli_direccion", cliente.Direccion);
            cmd.Parameters.AddWithValue("@cli_telefono", cliente.Telefono);
            cmd.Parameters.AddWithValue("@cli_sucursal_id", cliente.SucursalID);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public void D_Editar(E_Cliente cliente)
        {
            SqlCommand cmd = new SqlCommand("sp_update_cliente", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@cli_id", cliente.ClienteID);
            cmd.Parameters.AddWithValue("@cli_nombre", cliente.Nombre);
            cmd.Parameters.AddWithValue("@cli_direccion", cliente.Direccion);
            cmd.Parameters.AddWithValue("@cli_telefono", cliente.Telefono);
            cmd.Parameters.AddWithValue("@cli_sucursal_id", cliente.SucursalID);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public void D_Eliminar(string clienteID)
        {
            SqlCommand cmd = new SqlCommand("sp_delete_cliente", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cli_id", clienteID);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}
