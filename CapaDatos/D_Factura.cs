using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class D_Factura
    {
        private SqlConnection cn;

        public D_Factura()
        {
            cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConex"].ConnectionString);
        }

        public int ObtenerNuevoId(SqlConnection cn, SqlTransaction transaction)
        {
            // Variable para almacenar el nuevo ID
            int nuevoId = 0;

            // Consulta SQL para obtener el máximo ID actual
            string query = "SELECT ISNULL(MAX(det_gye_id), -1) FROM tb_det_detalleGuayaquil";

            using (SqlCommand cmd = new SqlCommand(query, cn, transaction))
            {
                // Ejecutar la consulta y obtener el valor
                object resultado = cmd.ExecuteScalar();

                // Si existe un resultado, sumamos 1, si no, el ID será 0
                if (resultado != null && resultado != DBNull.Value)
                {
                    nuevoId = Convert.ToInt32(resultado) + 1;
                }
            }

            return nuevoId;
        }

        public bool RegistrarFactura(E_Factura factura)
        {
            SqlTransaction transaction = null;
            try
            {
                cn.Open();
                transaction = cn.BeginTransaction();
                int nuevoDetGyeId = ObtenerNuevoId(cn, transaction);

                // Llamar al procedimiento almacenado para insertar la factura y obtener el nuevo número de factura
                SqlCommand cmdFactura = new SqlCommand("sp_insert_vw_facturas", cn, transaction);
                cmdFactura.CommandType = CommandType.StoredProcedure;
                cmdFactura.Parameters.AddWithValue("@fac_total", factura.Total);
                cmdFactura.Parameters.AddWithValue("@fac_sucursal_id", 2); // Sucursal Guayaquil
                cmdFactura.Parameters.AddWithValue("@fac_emp_cedula", factura.CedulaEmpleado);
                cmdFactura.Parameters.AddWithValue("@fac_cli_id", factura.CedulaCliente);

                SqlParameter outputParam = new SqlParameter("@new_fac_num", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                cmdFactura.Parameters.Add(outputParam);

                cmdFactura.ExecuteNonQuery();

                // Obtener el número de factura generado
                factura.FacturaNum = (int)outputParam.Value;

                foreach (var detalle in factura.Detalles)
                {
                    using (var cmdDetalle = new SqlCommand("sp_insert_vw_det_facturas", cn, transaction))
                    {
                        cmdDetalle.CommandType = CommandType.StoredProcedure;

                        // Parámetros del procedimiento almacenado
                        cmdDetalle.Parameters.AddWithValue("@det_fac_num", factura.FacturaNum);
                        cmdDetalle.Parameters.AddWithValue("@det_prod_id", detalle.ProductoID);
                        cmdDetalle.Parameters.AddWithValue("@det_sucursal_id", 2); // Sucursal Guayaquil
                        cmdDetalle.Parameters.AddWithValue("@det_unidades", detalle.Cantidad);
                        cmdDetalle.Parameters.AddWithValue("@det_precio_unitario", detalle.PrecioUnitario);

                        // Parámetro de salida para el nuevo ID
                        var newDetIdParam = new SqlParameter("@new_det_id", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        cmdDetalle.Parameters.Add(newDetIdParam);

                        // Ejecutar el procedimiento almacenado
                        cmdDetalle.ExecuteNonQuery();

                        // Obtener el nuevo ID generado
                        int finDetGyeId = (int)newDetIdParam.Value;
                    }
                }

                transaction.Commit();
                return true;
            }
            catch (Exception ex)
            {
                transaction?.Rollback();
                throw new Exception("Error al registrar la factura: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }





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

        //public List<E_Factura> BuscarFacturas(string criterio, string textoBusqueda)
        //{
        //    List<E_Factura> facturas = new List<E_Factura>();
        //    string query = "";

        //    switch (criterio)
        //    {
        //        case "Número de Factura":
        //            query = "SELECT fac_num, fac_fecha, fac_total, fac_emp_cedula, fac_cli_id FROM vw_facturas WHERE fac_num LIKE @TextoBusqueda AND fac_sucursal_id = 2";
        //            break;
        //        case "ID del Cliente":
        //            query = "SELECT fac_num, fac_fecha, fac_total, fac_emp_cedula, fac_cli_id FROM vw_facturas WHERE fac_cli_id LIKE @TextoBusqueda AND fac_sucursal_id = 2";
        //            break;
        //        case "Cédula del Empleado":
        //            query = "SELECT fac_num, fac_fecha, fac_total, fac_emp_cedula, fac_cli_id FROM vw_facturas WHERE fac_emp_cedula LIKE @TextoBusqueda AND fac_sucursal_id = 2";
        //            break;
        //        case "Fecha de Factura":
        //            query = "SELECT fac_num, fac_fecha, fac_total, fac_emp_cedula, fac_cli_id FROM vw_facturas WHERE CONVERT(VARCHAR, fac_fecha, 103) LIKE @TextoBusqueda AND fac_sucursal_id = 2";
        //            break;
        //        case "Total de Factura":
        //            query = "SELECT fac_num, fac_fecha, fac_total, fac_emp_cedula, fac_cli_id FROM vw_facturas WHERE fac_total LIKE @TextoBusqueda AND fac_sucursal_id = 2";
        //            break;
        //        default:
        //            throw new ArgumentException("Criterio de búsqueda no válido.");
        //    }

        //    using (SqlCommand cmd = new SqlCommand(query, cn))
        //    {
        //        cmd.Parameters.AddWithValue("@TextoBusqueda", "%" + textoBusqueda + "%");

        //        try
        //        {
        //            cn.Open();
        //            using (SqlDataReader reader = cmd.ExecuteReader())
        //            {
        //                while (reader.Read())
        //                {
        //                    E_Factura factura = new E_Factura
        //                    {
        //                        FacturaNum = reader.GetInt32(0),
        //                        Fecha = reader.GetDateTime(1),
        //                        Total = reader.GetDecimal(2),
        //                        CedulaEmpleado = reader.GetString(3),
        //                        CedulaCliente = reader.GetString(4)
        //                    };
        //                    facturas.Add(factura);
        //                }
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            // Manejar excepción adecuadamente
        //            throw new Exception("Error al buscar facturas: " + ex.Message);
        //        }
        //        finally
        //        {
        //            cn.Close();
        //        }
        //    }

        //}
    }
}
