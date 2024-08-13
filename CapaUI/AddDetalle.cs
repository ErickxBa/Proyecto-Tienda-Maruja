using CapaDatos;
using CapaEntidad;
using System.Windows.Forms;
using System;

namespace CapaUI
{
    public partial class AddDetalle : Form
    {
        public E_DetalleFactura DetalleFactura { get; private set; }

        public AddDetalle()
        {
            InitializeComponent();
        }

        private void buttonAnadir_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxProducto.Text) || string.IsNullOrWhiteSpace(textBoxUnidades.Text))
                {
                    MessageBox.Show("Todos los campos son obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int productoID = int.Parse(textBoxProducto.Text);
                int cantidad = int.Parse(textBoxUnidades.Text);

                // Crear una instancia de D_Producto para obtener el precio del producto
                D_Prod productoDatos = new D_Prod();
                decimal precioUnitario = productoDatos.ObtenerPrecioProducto(productoID);

                // Crear el objeto DetalleFactura
                DetalleFactura = new E_DetalleFactura
                { 
                    ProductoID = productoID,
                    Cantidad = cantidad,
                    PrecioUnitario = precioUnitario
                };

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al añadir el detalle: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
