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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonInventario_Click(object sender, EventArgs e)
        {
            this.Close();
            Inventario inventario = new Inventario();
            inventario.Show();
        }

        private void buttonClientes_Click(object sender, EventArgs e)
        {
            this.Close();
            Cliente cliente = new Cliente();
            cliente.Show();
        }

        private void buttonEmpleados_Click(object sender, EventArgs e)
        {
            this.Close();
            Empleado empleado = new Empleado();
            empleado.Show();
        }

        private void buttonNuevaFactura_Click(object sender, EventArgs e)
        {
            this.Close();
            Factura factura = new Factura();
            factura.Show();
        }

        private void buttonHistorialFacturas_Click(object sender, EventArgs e)
        {
            this.Close();
            HistorialFactura historialFacturas = new HistorialFactura();
            historialFacturas.Show();
        }
    }
}
