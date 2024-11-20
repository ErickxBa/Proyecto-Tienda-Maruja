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
            //La base de datos va a ser sql server, la conexion a la bdd está en el archivo app.config para ser mas eficientes.
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
