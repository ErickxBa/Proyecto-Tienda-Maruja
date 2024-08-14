using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class N_Empleado
    {
        D_Empleado empleadoDatos = new D_Empleado();

        public bool AgregarEmpleado(E_Empleado empleado)
        {
            // Validaciones de negocio
            if (string.IsNullOrEmpty(empleado.Nombres) || string.IsNullOrEmpty(empleado.Apellidos))
            {
                return false; // Validación fallida
            }

            // Llamada a la capa de datos
            return empleadoDatos.AgregarEmpleado(empleado);
        }

        public bool EliminarEmpleado(string cedula)
        {
            if (string.IsNullOrEmpty(cedula))
            {
                return false;
            }

            return empleadoDatos.EliminarEmpleado(cedula);
        }

        public List<E_Empleado> ObtenerTodosLosEmpleados()
        {
            return empleadoDatos.ObtenerTodosLosEmpleados();
        }
        public List<E_Empleado> BuscarEmpleados(string criterio)
        {
            return empleadoDatos.BuscarEmpleados(criterio);
        }

        public bool EditarEmpleado(E_Empleado empleado)
        {
            if (string.IsNullOrEmpty(empleado.Nombres) || string.IsNullOrEmpty(empleado.Apellidos))
            {
                return false;
            }

            return empleadoDatos.EditarEmpleado(empleado);
        }
    }
}
