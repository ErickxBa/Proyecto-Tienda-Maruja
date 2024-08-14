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

        public int ObtenerNuevoNumeroFactura(SqlConnection cn, SqlTransaction transaction)
        {
            int nuevoNumeroFactura = 0;
            string query = "SELECT ISNULL(MAX(fac_gye_num), 0) + 1 FROM tb_fac_facturaGuayaquil";

            using (SqlCommand cmd = new SqlCommand(query, cn, transaction))
            {
                object resultado = cmd.ExecuteScalar();
                if (resultado != null && resultado != DBNull.Value)
                {
                    nuevoNumeroFactura = Convert.ToInt32(resultado);
                }
            }

            return nuevoNumeroFactura;
        }

        public bool RegistrarFactura(E_Factura factura)
        {
            SqlTransaction transaction = null;
            try
            {
                cn.Open();
                transaction = cn.BeginTransaction();

                // Obtener un nuevo número de factura
                int nuevoNumeroFactura = ObtenerNuevoNumeroFactura(cn, transaction);
                factura.FacturaNum = nuevoNumeroFactura;

                // Insertar directamente en la tabla de facturas de Guayaquil
                SqlCommand cmdFactura = new SqlCommand("INSERT INTO tb_fac_facturaGuayaquil (fac_gye_num, fac_gye_fecha, fac_gye_total, fac_gye_emp_cedula, fac_gye_cli_id, fac_gye_sucursal_id) " +
                                                       "VALUES (@NumFac, GETDATE(), @Total, @IdEmp, @IdCli, @IdSuc)", cn, transaction);

                cmdFactura.Parameters.AddWithValue("@NumFac", factura.FacturaNum);
                cmdFactura.Parameters.AddWithValue("@Total", factura.Total);
                cmdFactura.Parameters.AddWithValue("@IdEmp", factura.CedulaEmpleado);
                cmdFactura.Parameters.AddWithValue("@IdCli", factura.CedulaCliente);
                cmdFactura.Parameters.AddWithValue("@IdSuc", factura.SucursalID);

                cmdFactura.ExecuteNonQuery();

                // Registrar detalles de la factura
                foreach (var detalle in factura.Detalles)
                {
                    using (var cmdDetalle = new SqlCommand("INSERT INTO tb_det_detalleGuayaquil (det_gye_id, det_gye_fac_num, det_gye_prod_id, det_gye_sucursal_id, det_gye_unidades, det_gye_precio_unitario) " +
                                                           "VALUES (@DetId, @FacNum, @ProdId, @SucId, @Unidades, @PrecioUnitario)", cn, transaction))
                    {
                        int nuevoDetGyeId = ObtenerNuevoId(cn, transaction); // Obtener nuevo ID para el detalle
                        cmdDetalle.Parameters.AddWithValue("@DetId", nuevoDetGyeId);
                        cmdDetalle.Parameters.AddWithValue("@FacNum", factura.FacturaNum);
                        cmdDetalle.Parameters.AddWithValue("@ProdId", detalle.ProductoID);
                        cmdDetalle.Parameters.AddWithValue("@SucId", factura.SucursalID);
                        cmdDetalle.Parameters.AddWithValue("@Unidades", detalle.Cantidad);
                        cmdDetalle.Parameters.AddWithValue("@PrecioUnitario", detalle.PrecioUnitario);

                        cmdDetalle.ExecuteNonQuery();
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
            string query = "SELECT fac_gye_num, fac_gye_fecha, fac_gye_total, fac_gye_emp_cedula, fac_gye_cli_id FROM v_factura WHERE fac_gye_sucursal_id = 2";
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
            string query = "SELECT det_gye_prod_id, det_gye_unidades, det_gye_precio_unitario FROM v_detalle WHERE det_gye_fac_num = @FacturaNum";
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

        // Puedes agregar otros métodos para manejar la búsqueda de facturas o detalles específicos
    }
}
