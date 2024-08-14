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

        // Método para obtener el historial de facturas
        public List<E_Factura> ObtenerHistorialFacturas()
        {
            List<E_Factura> facturas = new List<E_Factura>();

            using (SqlCommand cmd = new SqlCommand("sp_select_facturas", cn)) // Cambiado a sp_select_facturas
            {
                cmd.CommandType = CommandType.StoredProcedure;

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
                            CedulaCliente = reader.GetString(4),
                            SucursalID = reader.GetString(5) // Asegúrate de que la posición 5 corresponde a SucursalID en la consulta
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

        // Método para obtener los detalles de una factura específica
       public List<E_DetalleFactura> ObtenerDetallesFactura(int facturaID)
{
    List<E_DetalleFactura> detalles = new List<E_DetalleFactura>();

    using (SqlCommand cmd = new SqlCommand("sp_consultar_detalle", cn))
    {
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@NroFactura", facturaID);

        try
        {
            cn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                E_DetalleFactura detalle = new E_DetalleFactura
                {
                    ProductoID = reader.GetInt32(reader.GetOrdinal("Id Producto")), // Alias de la columna en el SP
                    Cantidad = reader.GetInt32(reader.GetOrdinal("Unidades")), // Alias de la columna en el SP
                    PrecioUnitario = reader.GetDecimal(reader.GetOrdinal("Precio de Venta")) // Alias de la columna en el SP
                };
                detalles.Add(detalle);
            }
            reader.Close();
        }
        catch (Exception ex)
        {
            throw new Exception("Error al obtener los detalles de la factura: " + ex.Message);
        }
        finally
        {
            cn.Close();
        }
    }

    return detalles;
}


        // Método para buscar facturas según un criterio
        public List<E_Factura> BuscarFacturas( string textoBusqueda)
        {
            List<E_Factura> facturas = new List<E_Factura>();

            using (SqlCommand cmd = new SqlCommand("sp_select_factura", cn)) // Debes crear o adaptar este SP
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nro", textoBusqueda);
                

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
