using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;
using System.Data;


namespace CapaNegocio
{
    public class N_Prod
    {
        D_Prod objdato = new D_Prod();

        public DataTable N_listado()
        {
            return objdato.D_listado();
        }

        public void N_Insertar(E_Prod producto)
        {
            // Puedes realizar validaciones adicionales aquí si es necesario
            if (!string.IsNullOrEmpty(producto.Nombre) && producto.precio > 0 && producto.stock >= 0)
            {
                objdato.D_Insertar(producto);
            }
            else
            {
                throw new Exception("Datos de producto no válidos.");
            }
        }

        public void N_Eliminar(int prodID)
        {
            // Se pueden añadir validaciones adicionales aquí si es necesario
            if (prodID > 0)
            {
                objdato.D_Eliminar(prodID);
            }
            else
            {
                throw new Exception("ID de producto no válido.");
            }
        }

        public void N_Editar(E_Prod producto)
        {
            // Se pueden añadir validaciones adicionales aquí si es necesario
            if (!string.IsNullOrEmpty(producto.Nombre) && producto.precio > 0 && producto.stock >= 0 && producto.id > 0)
            {
                objdato.D_Editar(producto);
            }
            else
            {
                throw new Exception("Datos de producto no válidos.");
            }
        }



    }

        

}
