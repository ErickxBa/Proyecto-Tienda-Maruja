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
    public partial class Login : Form
    {

        private N_Usuario negocio = new N_Usuario();

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Obtener los valores ingresados por el usuario
            string nombreUsuario = txtNombreEmpleado.Text;
            string contraseña = txtIdEmpleado.Text;

            // Validar las credenciales
            bool esValido = negocio.IniciarSesion(nombreUsuario, contraseña);

            if (esValido)
            {
                // Si las credenciales son válidas, mostrar el siguiente formulario
                MessageBox.Show("Inicio de sesión exitoso", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Menu menu = new Menu();
                menu.Show();
            }
            else
            {
                // Si las credenciales son incorrectas, mostrar un mensaje de error
                MessageBox.Show("Nombre de usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
            
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
