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
            List<E_Factura> facturas = negocioHistorial.ObtenerHistorialFacturas();
            dataGridViewFacturas.DataSource = facturas;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu menu = new Menu();
            menu.Show();
        }

        private void buttonVerDetalles_Click(object sender, EventArgs e)
        {
            if (dataGridViewFacturas.SelectedRows.Count > 0)
            {
                int facturaID = Convert.ToInt32(dataGridViewFacturas.SelectedRows[0].Cells["FacturaNum"].Value);
                List<E_DetalleFactura> detalles = negocioHistorial.ObtenerDetallesFactura(facturaID);
                dataGridViewDetalles.DataSource = detalles;
            }
            else
            {
                MessageBox.Show("Seleccione una factura para ver los detalles.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            string criterioBusqueda = comboBoxBuscarPor.SelectedItem?.ToString();
            string textoBusqueda = textBoxBuscar.Text;

            if (string.IsNullOrWhiteSpace(criterioBusqueda) || string.IsNullOrWhiteSpace(textoBusqueda))
            {
                MessageBox.Show("Por favor, seleccione un criterio de búsqueda y proporcione un texto de búsqueda.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<E_Factura> facturasFiltradas = negocioHistorial.BuscarFacturas(criterioBusqueda, textoBusqueda);

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
    }
}