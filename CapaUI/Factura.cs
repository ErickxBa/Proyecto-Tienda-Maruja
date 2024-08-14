using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaUI
{
    public partial class Factura : Form
    {
        private List<E_DetalleFactura> detallesFactura = new List<E_DetalleFactura>();
        public Factura()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu menu = new Menu();
            menu.Show();
        }
        private void CalcularTotalFactura()
        {
            decimal total = detallesFactura.Sum(d => d.Subtotal);
            textBoxTotalFactura.Text = total.ToString("C2");
        }


        private void buttonAñadirDetalle_Click(object sender, EventArgs e)
        {
            using (AddDetalle addDetalleForm = new AddDetalle())
            {
                if (addDetalleForm.ShowDialog() == DialogResult.OK)
                {
                    detallesFactura.Add(addDetalleForm.DetalleFactura);
                    CargarDetallesFactura();
                    CalcularTotalFactura(); // Recalcular total después de añadir el detalle
                }
            }
        }


        private void buttonEliminarDetalle_Click(object sender, EventArgs e)
        {
            if (dataGridViewDetallesFactura.SelectedRows.Count > 0)
            {
                int index = dataGridViewDetallesFactura.SelectedRows[0].Index;
                detallesFactura.RemoveAt(index);
                CargarDetallesFactura();
                CalcularTotalFactura();
            }
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            var factura = new E_Factura
            {
                CedulaCliente = textBoxCedulaCliente.Text,
                CedulaEmpleado = textBoxCedulaEmpleado.Text,
                Fecha = DateTime.Now,
                Detalles = detallesFactura,
                Total = detallesFactura.Sum(d => d.Subtotal),
                SucursalID = "002" // Asignando la sucursal de Guayaquil (asegúrate de que sea el ID correcto)
            };

            N_Factura facturaNegocio = new N_Factura();
            try
            {
                if (facturaNegocio.RegistrarFactura(factura))
                {
                    MessageBox.Show("Factura registrada exitosamente.");
                    LimpiarFormulario();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la factura: " + ex.Message);
            }
        }
        private void CargarDetallesFactura()
        {
            dataGridViewDetallesFactura.DataSource = null;
            dataGridViewDetallesFactura.DataSource = detallesFactura;
        }

      
        private void LimpiarFormulario()
        {
            textBoxCedulaCliente.Clear();
            textBoxCedulaEmpleado.Clear();
            textBoxTotalFactura.Clear();
            detallesFactura.Clear();
            CargarDetallesFactura();
        }
    }
}
