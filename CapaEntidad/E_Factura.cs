using System.Collections.Generic;
using System;

namespace CapaEntidad
{
    public class E_Factura
    {
        public int FacturaNum { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }
        public string CedulaEmpleado { get; set; }
        public string CedulaCliente { get; set; }

        // Nueva propiedad para la sucursal ID
        public string SucursalID { get; set; }

        // Detalles de la factura
        public List<E_DetalleFactura> Detalles { get; set; }
    }
}
