using Calcular_precio_venta_de_productos.Entitades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcular_precio_venta_de_productos.Negocios
{
    class ClsUsuario
    {
        Usuario usuario = new Usuario();
        public string acceso(string nombre, int contraseña)
        {if ((nombre == "Jefferson Romero") && (contraseña == 123))
            {
                return " a iniciado secion correctamente";
            }
            else
                return "sus datos son incorrectos no es pocible iniciar sesion";
        }

    }
}
