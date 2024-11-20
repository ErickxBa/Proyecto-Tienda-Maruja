using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class N_Cliente
    {
        private D_cliente datosCliente = new D_cliente();

        public DataTable ObtenerClientes()
        {
            return datosCliente.ListarClientes();
        }

        public void AgregarCliente(string nombre, string telefono, string email)
        {
            datosCliente.InsertarCliente(nombre, telefono, email);
        }

        public void EditarCliente(int idCliente, string nombre, string telefono, string email)
        {
            datosCliente.ActualizarCliente(idCliente, nombre, telefono, email);
        }

        public void BorrarCliente(int idCliente)
        {
            datosCliente.EliminarCliente(idCliente);
        }
    }
}
