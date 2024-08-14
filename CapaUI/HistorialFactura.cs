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

            // Asocia el evento de selección de la factura
            dataGridViewFacturas.SelectionChanged += DataGridViewFacturas_SelectionChanged;
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

        // Evento para cargar los detalles de la factura seleccionada
        private void DataGridViewFacturas_SelectionChanged(object sender, EventArgs e)
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
                // Limpiar los detalles si no hay ninguna factura seleccionada
                dataGridViewDetalles.DataSource = null;
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu menu = new Menu();
            menu.Show();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            string textoBusqueda = textBoxBuscar.Text;

            if (string.IsNullOrWhiteSpace(textoBusqueda))
            {
                MessageBox.Show("Por favor, ingrese un número de factura para la búsqueda.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Intentar convertir el texto del TextBox a un entero
            if (!int.TryParse(textoBusqueda, out int numeroFactura))
            {
                MessageBox.Show("El número de factura ingresado no es válido. Por favor, ingrese un número entero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                List<E_Factura> facturasFiltradas = negocioHistorial.BuscarFacturas(numeroFactura);

                if (facturasFiltradas.Count > 0)
                {
                    dataGridViewFacturas.DataSource = facturasFiltradas;
                }
                else
                {
                    MessageBox.Show("No se encontraron facturas que coincidan con los criterios de búsqueda.", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridViewFacturas.DataSource = null;
                    dataGridViewDetalles.DataSource = null; // Limpia detalles si no hay facturas
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar facturas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
