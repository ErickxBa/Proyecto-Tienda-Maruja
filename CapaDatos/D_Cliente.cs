using System;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class D_cliente
    {
        // Cadena de conexión a QuitoMaruja
        private string connectionStringQuito = "Data Source=DESKTOP-CQGTJ6R;Initial Catalog=QuitoMaruja;User ID=sa;Password=password;";

        // Cadena de conexión a GuayaquilMaruja
        private string connectionStringGuayaquil = "Data Source=Johan;Initial Catalog=GuayaquilMaruja;User ID=sa;Password=password;";

        // Método para obtener clientes desde ambas bases de datos
        public DataTable ObtenerClientes()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connectionQuito = new SqlConnection(connectionStringQuito))
            {
                string queryQuito = "SELECT * FROM tb_cli_cliente";
                SqlDataAdapter adapterQuito = new SqlDataAdapter(queryQuito, connectionQuito);
                adapterQuito.Fill(dataTable);
            }

            using (SqlConnection connectionGuayaquil = new SqlConnection(connectionStringGuayaquil))
            {
                string queryGuayaquil = "SELECT * FROM tb_cli_cliente";
                SqlDataAdapter adapterGuayaquil = new SqlDataAdapter(queryGuayaquil, connectionGuayaquil);
                adapterGuayaquil.Fill(dataTable);
            }

            return dataTable;
        }

        // Métodos para Agregar, Editar y Eliminar solo en GuayaquilMaruja
        public void AgregarCliente(E_Cliente cliente)
        {
            using (SqlConnection connection = new SqlConnection(connectionStringGuayaquil))
            {
                string query = "INSERT INTO tb_cli_cliente (cli_id, cli_nombre, cli_direccion, cli_telefono, cli_sucursal_id) VALUES (@cli_id, @cli_nombre, @cli_direccion, @cli_telefono, @cli_sucursal_id)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@cli_id", cliente.ClienteID);
                command.Parameters.AddWithValue("@cli_nombre", cliente.Nombre);
                command.Parameters.AddWithValue("@cli_direccion", cliente.Direccion);
                command.Parameters.AddWithValue("@cli_telefono", cliente.Telefono);
                command.Parameters.AddWithValue("@cli_sucursal_id", cliente.SucursalID);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void EditarCliente(E_Cliente cliente)
        {
            using (SqlConnection connection = new SqlConnection(connectionStringGuayaquil))
            {
                string query = "UPDATE tb_cli_cliente SET cli_nombre = @cli_nombre, cli_direccion = @cli_direccion, cli_telefono = @cli_telefono WHERE cli_id = @cli_id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@cli_id", cliente.ClienteID);
                command.Parameters.AddWithValue("@cli_nombre", cliente.Nombre);
                command.Parameters.AddWithValue("@cli_direccion", cliente.Direccion);
                command.Parameters.AddWithValue("@cli_telefono", cliente.Telefono);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void EliminarCliente(string clienteID)
        {
            using (SqlConnection connection = new SqlConnection(connectionStringGuayaquil))
            {
                string query = "DELETE FROM tb_cli_cliente WHERE cli_id = @cli_id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@cli_id", clienteID);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}