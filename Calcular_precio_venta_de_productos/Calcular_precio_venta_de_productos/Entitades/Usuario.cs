using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcular_precio_venta_de_productos.Entitades
{
    class Usuario
    {
        private string Nombre;
        private int Contraseña;

        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public int Contraseña1 { get => Contraseña; set => Contraseña = value; }


        public Usuario(string nombre, int contraseña)
        {
            Nombre1 = nombre;
            Contraseña1 = contraseña;
        }

        public Usuario()
        {
        }

        public override string ToString()
        {
            return "el Nombre del usuario es " + Nombre + " la Contraseña del usuario es " + Contraseña;
        }
    }
}
