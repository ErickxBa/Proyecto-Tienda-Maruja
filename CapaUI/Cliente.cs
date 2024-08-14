using System;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;

namespace CapaUI
{
    public partial class Cliente : Form
    {
        N_Cliente clienteNegocio = new N_Cliente();

        public Cliente()
        {
            InitializeComponent();
            CargarClientes();
        }

        private void CargarClientes()
        {
            dataGridViewClientes.DataSource = clienteNegocio.ObtenerClientes();
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(textBoxClienteID.Text) ||
                string.IsNullOrWhiteSpace(textBoxNombreCliente.Text) ||
                string.IsNullOrWhiteSpace(textBoxDireccionCliente.Text) ||
                string.IsNullOrWhiteSpace(textBoxTelefonoCliente.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                DialogResult result = MessageBox.Show("¿Está seguro de que desea agregar este cliente?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        E_Cliente cliente = new E_Cliente()
                        {
                            ClienteID = textBoxClienteID.Text,
                            Nombre = textBoxNombreCliente.Text,
                            Direccion = textBoxDireccionCliente.Text,
                            Telefono = textBoxTelefonoCliente.Text,
                            SucursalID = "002"// Asignando la sucursal de Guayaquil (asegúrate de que sea el ID correcto)
                        };
                        clienteNegocio.AgregarCliente(cliente);
                        MessageBox.Show("Cliente agregado exitosamente.");
                        CargarClientes();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al agregar el cliente: " + ex.Message);
                    }
                }
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxClienteID.Text))
            {
                MessageBox.Show("Debe ingresar el ID del cliente para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar este cliente?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    string clienteID = textBoxClienteID.Text;
                    clienteNegocio.EliminarCliente(clienteID);
                    MessageBox.Show("Cliente eliminado exitosamente.");
                    CargarClientes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el cliente: " + ex.Message);
                }
            }
        }

        private void buttonEditar_Click_1(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                DialogResult result = MessageBox.Show("¿Está seguro de que desea editar este cliente?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        E_Cliente cliente = new E_Cliente()
                        {
                            ClienteID = textBoxClienteID.Text,
                            Nombre = textBoxNombreCliente.Text,
                            Direccion = textBoxDireccionCliente.Text,
                            Telefono = textBoxTelefonoCliente.Text,
                            SucursalID = "002" // Asignando la sucursal de Guayaquil (asegúrate de que sea el ID correcto)
                        };
                        clienteNegocio.EditarCliente(cliente);
                        MessageBox.Show("Cliente editado exitosamente.");
                        CargarClientes();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al editar el cliente: " + ex.Message);
                    }
                }
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de que desea regresar al menú principal?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
                Menu menu = new Menu();
                menu.Show();
            }
        }

        private void dataGridViewClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewClientes.Rows[e.RowIndex];
                textBoxClienteID.Text = row.Cells["cli_id"].Value.ToString();
                textBoxNombreCliente.Text = row.Cells["cli_nombre"].Value.ToString();
                textBoxDireccionCliente.Text = row.Cells["cli_direccion"].Value.ToString();
                textBoxTelefonoCliente.Text = row.Cells["cli_telefono"].Value.ToString();
            }
        }

       
    }
}
