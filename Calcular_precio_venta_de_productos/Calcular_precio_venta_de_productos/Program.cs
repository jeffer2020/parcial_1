using Calcular_precio_venta_de_productos.Entitades;
using Calcular_precio_venta_de_productos.Negocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcular_precio_venta_de_productos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("escriba su usuario");
            string nombre = Convert.ToString(Console.ReadLine());

            Console.WriteLine("escriba su contraseña");
            int contraseña = Convert.ToInt32 (Console.ReadLine());

            Usuario usuario = new Usuario();
            ClsUsuario clsusuario = new ClsUsuario();
            Console.WriteLine(clsusuario.acceso( nombre, contraseña));
            Console.ReadLine();
        }
    }
}
