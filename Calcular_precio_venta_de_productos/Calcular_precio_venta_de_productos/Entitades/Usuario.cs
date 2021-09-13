using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcular_precio_venta_de_productos.Entitades
{
    class Usuario
    {
        private string  nombre;
        private int contraseña;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Contraseña { get => contraseña; set => contraseña = value; }

        public Usuario(string nombre, int contraseña)
        {
            this.Nombre = nombre;
            this.Contraseña = contraseña;
        }

        public Usuario()
        {
        }

        public override string ToString()
        {
            return "el nombre del usuario es " + nombre + " la contraseña del usuario es " + contraseña;
        }
    }
}
