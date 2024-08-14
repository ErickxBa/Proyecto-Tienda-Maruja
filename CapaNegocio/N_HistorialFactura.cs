using System;
using System.Collections.Generic;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class N_HistorialFactura
    {
        private D_HistorialFactura historialDatos = new D_HistorialFactura();

        public List<E_Factura> ObtenerHistorialFacturas()
        {
            return historialDatos.ObtenerHistorialFacturas();
        }

        public List<E_DetalleFactura> ObtenerDetallesFactura(int facturaID)
        {
            return historialDatos.ObtenerDetallesFactura(facturaID);
        }

        public List<E_Factura> BuscarFacturas( int nroFact)
        {
            return historialDatos.BuscarFacturas( nroFact);
        }
    }
}