using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class N_Usuario
    {
        private D_Usuario datos = new D_Usuario();

        public bool IniciarSesion(string nombreUsuario, string contraseña)
        {
            E_Usuario usuario = new E_Usuario
            {
                Nombre = nombreUsuario,
                id = contraseña
            };

            return datos.VerificarCredenciales(usuario);
        }
    }
}
