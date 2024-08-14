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

            using (SqlCommand cmd = new SqlCommand("sp_select_facturas", cn)) // Usando el SP sp_select_facturas
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
                            FacturaNum = reader.GetInt32(reader.GetOrdinal("Nro")),
                            CedulaCliente = reader.GetString(reader.GetOrdinal("Cédula Cliente")),
                            CedulaEmpleado = reader.GetString(reader.GetOrdinal("Cédula Empleado")),
                            Fecha = reader.GetDateTime(reader.GetOrdinal("Fecha")),
                            Total = reader.GetDecimal(reader.GetOrdinal("Total"))
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

            using (SqlCommand cmd = new SqlCommand("sp_consultar_detalle", cn)) // Usando el SP sp_consultar_detalle
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NroFactura", facturaID);

                try
                {
                    cn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        try
                        {
                            // Verificamos si el valor es nulo antes de intentar castearlo
                            int productoID = reader.IsDBNull(reader.GetOrdinal("Id Producto")) ? 0 : Convert.ToInt32(reader["Id Producto"]);

                            E_DetalleFactura detalle = new E_DetalleFactura
                            {
                                ProductoID = productoID,
                                Cantidad = reader.GetInt32(reader.GetOrdinal("Unidades")),
                                PrecioUnitario = reader.GetDecimal(reader.GetOrdinal("Precio de Venta"))
                            };
                            detalles.Add(detalle);
                        }
                        catch (InvalidCastException ex)
                        {
                            string errorMessage = $"Error de casteo en los detalles de la factura. " +
                                                  $"Factura ID: {facturaID}, " +
                                                  $"Columna: {reader.GetName(reader.GetOrdinal("Id Producto"))}, " +
                                                  $"Mensaje: {ex.Message}";
                            throw new Exception(errorMessage, ex);
                        }
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




        // Método para buscar una factura específica según el número de factura
        public List<E_Factura> BuscarFacturas(int nroFac)
        {
            List<E_Factura> facturas = new List<E_Factura>();

            using (SqlCommand cmd = new SqlCommand("sp_select_factura", cn)) // Usando el SP sp_select_factura
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NroFac", nroFac); // Asegúrate de que el parámetro coincida con el SP

                try
                {
                    cn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        E_Factura factura = new E_Factura
                        {
                            FacturaNum = reader.GetInt32(reader.GetOrdinal("Nro")),
                            CedulaCliente = reader.GetString(reader.GetOrdinal("Cédula Cliente")),
                            CedulaEmpleado = reader.GetString(reader.GetOrdinal("Cédula Empleado")),
                            Fecha = reader.GetDateTime(reader.GetOrdinal("Fecha")),
                            Total = reader.GetDecimal(reader.GetOrdinal("Total"))
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
