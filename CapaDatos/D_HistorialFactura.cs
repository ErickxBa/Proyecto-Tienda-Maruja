using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;


namespace CapaDatos
{
    public class D_HistorialFactura
    {
        private SqlConnection cn;

        public D_HistorialFactura()
        {
            cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConex"].ConnectionString);
        }

        public List<E_Factura> ObtenerHistorialFacturas()
        {
            List<E_Factura> facturas = new List<E_Factura>();
            string query = "SELECT fac_num, fac_fecha, fac_total, fac_emp_cedula, fac_cli_id FROM vw_facturas WHERE fac_sucursal_id = 2";
            SqlCommand cmd = new SqlCommand(query, cn);

            try
            {
                cn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    E_Factura factura = new E_Factura
                    {
                        FacturaNum = reader.GetInt32(0),
                        Fecha = reader.GetDateTime(1),
                        Total = reader.GetDecimal(2),
                        CedulaEmpleado = reader.GetString(3),
                        CedulaCliente = reader.GetString(4)
                    };
                    facturas.Add(factura);
                }
                reader.Close();
            }
            finally
            {
                cn.Close();
            }

            return facturas;
        }

        public List<E_DetalleFactura> ObtenerDetallesFactura(int facturaID)
        {
            List<E_DetalleFactura> detalles = new List<E_DetalleFactura>();
            string query = "SELECT det_gye_prod_id, det_gye_unidades, det_gye_precio_unitario FROM tb_det_detalleGuayaquil WHERE det_gye_fac_num = @FacturaNum";
            SqlCommand cmd = new SqlCommand(query, cn);
            cmd.Parameters.AddWithValue("@FacturaNum", facturaID);

            try
            {
                cn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    E_DetalleFactura detalle = new E_DetalleFactura
                    {
                        ProductoID = reader.GetInt32(0),
                        Cantidad = reader.GetInt32(1),
                        PrecioUnitario = reader.GetDecimal(2)
                    };
                    detalles.Add(detalle);
                }
                reader.Close();
            }
            finally
            {
                cn.Close();
            }

            return detalles;
        }

        public List<E_Factura> BuscarFacturas(string criterio, string textoBusqueda)
        {
            List<E_Factura> facturas = new List<E_Factura>();
            string query = "";

            switch (criterio)
            {
                case "Número de Factura":
                    query = "SELECT fac_num, fac_fecha, fac_total, fac_emp_cedula, fac_cli_id FROM vw_facturas WHERE fac_num LIKE @TextoBusqueda AND fac_sucursal_id = 2";
                    break;
                case "ID del Cliente":
                    query = "SELECT fac_num, fac_fecha, fac_total, fac_emp_cedula, fac_cli_id FROM vw_facturas WHERE fac_cli_id LIKE @TextoBusqueda AND fac_sucursal_id = 2";
                    break;
                case "Cédula del Empleado":
                    query = "SELECT fac_num, fac_fecha, fac_total, fac_emp_cedula, fac_cli_id FROM vw_facturas WHERE fac_emp_cedula LIKE @TextoBusqueda AND fac_sucursal_id = 2";
                    break;
                case "Fecha de Factura":
                    query = "SELECT fac_num, fac_fecha, fac_total, fac_emp_cedula, fac_cli_id FROM vw_facturas WHERE CONVERT(VARCHAR, fac_fecha, 103) LIKE @TextoBusqueda AND fac_sucursal_id = 2";
                    break;
                case "Total de Factura":
                    query = "SELECT fac_num, fac_fecha, fac_total, fac_emp_cedula, fac_cli_id FROM vw_facturas WHERE fac_total LIKE @TextoBusqueda AND fac_sucursal_id = 2";
                    break;
            }

            if (!string.IsNullOrEmpty(query))
            {
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@TextoBusqueda", "%" + textoBusqueda + "%");

                try
                {
                    cn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        E_Factura factura = new E_Factura
                        {
                            FacturaNum = reader.GetInt32(0),
                            Fecha = reader.GetDateTime(1),
                            Total = reader.GetDecimal(2),
                            CedulaEmpleado = reader.GetString(3),
                            CedulaCliente = reader.GetString(4)
                        };
                        facturas.Add(factura);
                    }
                    reader.Close();
                }
                finally
                {
                    cn.Close();
                }
            }

            return facturas;
        }
    }
}