using CapaNegocio;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CapaUI
{
    public partial class HistorialFactura : Form
    {
        private N_HistorialFactura negocioHistorial = new N_HistorialFactura();

        public HistorialFactura()
        {
            InitializeComponent();
            CargarHistorialFacturas();
        }

        private void CargarHistorialFacturas()
        {
            try
            {
                List<E_Factura> facturas = negocioHistorial.ObtenerHistorialFacturas();
                dataGridViewFacturas.DataSource = facturas;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el historial de facturas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu menu = new Menu();
            menu.Show();
        }

        private void buttonVerDetalles_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            
            string textoBusqueda = textBoxBuscar.Text;

            if ( string.IsNullOrWhiteSpace(textoBusqueda))
            {
                MessageBox.Show("Por favor, seleccione un criterio de búsqueda y proporcione un texto de búsqueda.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                List<E_Factura> facturasFiltradas = negocioHistorial.BuscarFacturas( textoBusqueda);

                if (facturasFiltradas.Count > 0)
                {
                    dataGridViewFacturas.DataSource = facturasFiltradas;
                }
                else
                {
                    MessageBox.Show("No se encontraron facturas que coincidan con los criterios de búsqueda.", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridViewFacturas.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar facturas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonVerDetalles_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewFacturas.SelectedRows.Count > 0)
            {
                try
                {
                    int facturaID = Convert.ToInt32(dataGridViewFacturas.SelectedRows[0].Cells["FacturaNum"].Value);
                    List<E_DetalleFactura> detalles = negocioHistorial.ObtenerDetallesFactura(facturaID);
                    dataGridViewDetalles.DataSource = detalles;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener los detalles de la factura: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Seleccione una factura para ver los detalles.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void labelBuscarPor_Click(object sender, EventArgs e)
        {

        }
    }
}