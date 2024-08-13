using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;

namespace CapaUI
{
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
            ListarProducto();
        }

        E_Prod objEntidad = new E_Prod();
        N_Prod objNego = new N_Prod();

        void ListarProducto()
        {
            DataTable dt = objNego.N_listado();
            dataGridViewInventario.DataSource = dt;
        }


    
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu menu = new Menu();
            menu.Show();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
               try
            {
                E_Prod producto = new E_Prod
                {
                    Nombre = textBoxNombreProducto.Text,
                    precio = float.Parse(textBoxPrecioProducto.Text),
                    stock = int.Parse(textBoxStockProducto.Text),
                    id = int.Parse(textBoxProductoID.Text)
                };

                objNego.N_Insertar(producto);

                MessageBox.Show("Producto agregado exitosamente.");
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el producto: " + ex.Message);
            } 
            ListarProducto();
        }
      
        private void LimpiarCampos()
        {
            textBoxProductoID.Clear();
            textBoxNombreProducto.Clear();
            textBoxPrecioProducto.Clear();
            textBoxStockProducto.Clear();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBoxProductoID.Text))
                {
                    MessageBox.Show("Debe ingresar el ID del producto para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                E_Prod producto = new E_Prod
                {
                    id = int.Parse(textBoxProductoID.Text),
                    Nombre = textBoxNombreProducto.Text,
                    precio = float.Parse(textBoxPrecioProducto.Text),
                    stock = int.Parse(textBoxStockProducto.Text)
                };

                DialogResult result = MessageBox.Show("¿Está seguro de que desea editar este producto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    objNego.N_Editar(producto);
                    MessageBox.Show("Producto editado exitosamente.");
                    ListarProducto();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar el producto: " + ex.Message);
            }
            ListarProducto();
        }


        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBoxProductoID.Text))
                {
                    int prodID = int.Parse(textBoxProductoID.Text);

                    DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar este producto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        objNego.N_Eliminar(prodID);
                        MessageBox.Show("Producto eliminado exitosamente.");
                        ListarProducto();
                    }
                }
                else
                {
                    MessageBox.Show("Debe ingresar el ID del producto para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el producto: " + ex.Message);
            }

            ListarProducto();
        }

    }
}
