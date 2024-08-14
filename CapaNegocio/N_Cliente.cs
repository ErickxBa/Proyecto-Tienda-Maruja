using System;
using System.Data;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class N_Cliente
    {
        D_cliente clienteDatos = new D_cliente();

        public DataTable ObtenerClientes()
        {
            return clienteDatos.D_Listado();
        }

        public void AgregarCliente(E_Cliente cliente)
        {
            clienteDatos.D_Insertar(cliente);
        }

        public void EditarCliente(E_Cliente cliente)
        {
            clienteDatos.D_Editar(cliente);
        }

        public void EliminarCliente(string clienteID)
        {
            clienteDatos.D_Eliminar(clienteID);
        }
    }
}
