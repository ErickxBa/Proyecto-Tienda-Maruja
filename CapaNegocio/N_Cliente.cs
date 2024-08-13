using System.Data;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class N_Cliente
    {
        D_cliente datosCliente = new D_cliente();

        public DataTable ObtenerClientes()
        {
            return datosCliente.ObtenerClientes();
        }

        public void AgregarCliente(E_Cliente cliente)
        {
            datosCliente.AgregarCliente(cliente);
        }

        public void EditarCliente(E_Cliente cliente)
        {
            datosCliente.EditarCliente(cliente);
        }

        public void EliminarCliente(string clienteID)
        {
            datosCliente.EliminarCliente(clienteID);
        }
    }
}