using System;
using System.Data;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaUI
{
    public partial class Menu : Form
    {
        private N_Cliente negocioCliente = new N_Cliente();

        public Menu()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            DataTable dt = negocioCliente.ObtenerClientes();
            dgvClientes.DataSource = dt; // dgvClientes es el DataGridView en tu formulario
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string telefono = txtTelefono.Text;
            string email = txtEmail.Text;

            negocioCliente.AgregarCliente(nombre, telefono, email);
            MessageBox.Show("Cliente agregado correctamente");
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int idCliente = int.Parse(txtIdCliente.Text);
            string nombre = txtNombre.Text;
            string telefono = txtTelefono.Text;
            string email = txtEmail.Text;

            negocioCliente.EditarCliente(idCliente, nombre, telefono, email);
            MessageBox.Show("Cliente actualizado correctamente");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idCliente = int.Parse(txtIdCliente.Text);
            negocioCliente.BorrarCliente(idCliente);
            MessageBox.Show("Cliente eliminado correctamente");
        }
    }
}
