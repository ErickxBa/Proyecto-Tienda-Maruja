using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;


namespace CapaNegocio
{
    public class N_Factura
    {
        D_Factura facturaDatos = new D_Factura();

        public bool RegistrarFactura(E_Factura factura)
        {
            if (factura == null || factura.Detalles.Count == 0)
            {
                throw new ArgumentException("La factura no puede estar vacía y debe tener al menos un detalle.");
            }

            return facturaDatos.RegistrarFactura(factura);
        }

        public List<E_Factura> ObtenerHistorialFacturas()
        {
            return facturaDatos.ObtenerHistorialFacturas();
        }

        public List<E_DetalleFactura> ObtenerDetallesFactura(int facturaID)
        {
            return facturaDatos.ObtenerDetallesFactura(facturaID);
        }

        //public List<E_Factura> BuscarFacturas(string criterio, string textoBusqueda)
        //{
        //    return facturaDatos.BuscarFacturas(criterio, textoBusqueda);
        //}
    }
}
