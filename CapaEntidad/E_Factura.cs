using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaEntidad
{

    public class E_Factura
    {
        public int FacturaNum { get; set; }
        public string CedulaCliente { get; set; }
        public string CedulaEmpleado { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }
        public List<E_DetalleFactura> Detalles { get; set; } = new List<E_DetalleFactura>();
    }


}
