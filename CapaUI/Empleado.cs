using CapaEntidad;
using CapaNegocio;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using CapaDatos;

namespace CapaUI
{
    public partial class Empleado : Form
    {
        N_Empleado empleadoNegocio = new N_Empleado();

        public Empleado()
        {
            InitializeComponent();
            CargarTodosLosEmpleados();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu menu = new Menu();
            menu.Show();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            E_Empleado empleado = new E_Empleado
            {
                Cedula = textBoxCedula.Text,
                SucursalId = "002",
                Nombres = textBoxNombres.Text,
                Apellidos = textBoxApellidos.Text,
            };

            N_Empleado empleadoNegocio = new N_Empleado();
            bool success = empleadoNegocio.AgregarEmpleado(empleado);

            if (success)
            {
                MessageBox.Show("Empleado agregado exitosamente.");
            }
            else
            {
                MessageBox.Show("Error al agregar el empleado.");
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            string cedula = textBoxCedula.Text;


            if (string.IsNullOrWhiteSpace(cedula))
            {
                MessageBox.Show("Por favor, ingrese la cédula del empleado a eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            N_Empleado empleadoNegocio = new N_Empleado();
            bool success = empleadoNegocio.EliminarEmpleado(cedula);

            if (success)
            {
                MessageBox.Show("Empleado eliminado exitosamente.");
            }
            else
            {
                MessageBox.Show("Error al eliminar el empleado.");
            }
        }
        private void CargarTodosLosEmpleados()
        {
            List<E_Empleado> empleados = empleadoNegocio.ObtenerTodosLosEmpleados();
            dataGridViewEmpleados.DataSource = empleados;
        }
        private void buttonEditar_Click(object sender, EventArgs e)
        {
            E_Empleado empleado = new E_Empleado
            {
                Cedula = textBoxCedula.Text,
                Nombres = textBoxNombres.Text,
                Apellidos = textBoxApellidos.Text,
                SucursalId = "002" // Asignando la sucursal de Guayaquil
            };
            bool success = empleadoNegocio.EditarEmpleado(empleado);

            if (success)
            {
                MessageBox.Show("Empleado editado exitosamente.");
                CargarTodosLosEmpleados();
            }
            else
            {
                MessageBox.Show("Error al editar el empleado.");
            }
        }

        private void dataGridViewEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewEmpleados.Rows[e.RowIndex];

                textBoxCedula.Text = row.Cells["Cedula"].Value.ToString();
                textBoxNombres.Text = row.Cells["Nombres"].Value.ToString();
                textBoxApellidos.Text = row.Cells["Apellidos"].Value.ToString();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string criterio = textBoxCedula.Text;

            if (string.IsNullOrWhiteSpace(criterio))
            {
                MessageBox.Show("Por favor, ingrese la cedula correctamente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            N_Empleado empleadoNegocio = new N_Empleado();
            List<E_Empleado> empleados = empleadoNegocio.BuscarEmpleados(criterio);

            if (empleados.Count > 0)
            {
                dataGridViewEmpleados.DataSource = empleados;
            }
            else
            {
                MessageBox.Show("No se encontraron empleados que coincidan con el criterio de búsqueda.");
                dataGridViewEmpleados.DataSource = null;
            }
        }

        private void dataGridViewEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewEmpleados.Rows[e.RowIndex];

                textBoxCedula.Text = row.Cells["Cedula"].Value.ToString();
                textBoxNombres.Text = row.Cells["Nombres"].Value.ToString();
                textBoxApellidos.Text = row.Cells["Apellidos"].Value.ToString();
            }
        }
    }
}
