using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcular_precio_venta_de_productos.Entitades
{
    class Venta
    {
        private string identificador_deproducto;
        private string nombre_del_producto;
        private string descripcion_del_producto;
        private double precio_de_lproducto;
        private int cantidad_del_producto;

        public string Identificador_deproducto { get => identificador_deproducto; set => identificador_deproducto = value; }
        public string Nombre_del_producto { get => nombre_del_producto; set => nombre_del_producto = value; }
        public string Descripcion_del_producto { get => descripcion_del_producto; set => descripcion_del_producto = value; }
        public double Precio_de_lproducto { get => precio_de_lproducto; set => precio_de_lproducto = value; }
        public int Cantidad_del_producto { get => cantidad_del_producto; set => cantidad_del_producto = value; }


        public Venta(string identificador_deproducto, string nombre_del_producto, string descripcion_del_producto, double precio_de_lproducto, int cantidad_del_producto)
        {
            this.Identificador_deproducto = identificador_deproducto;
            this.Nombre_del_producto = nombre_del_producto;
            this.Descripcion_del_producto = descripcion_del_producto;
            this.Precio_de_lproducto = precio_de_lproducto;
            this.Cantidad_del_producto = cantidad_del_producto;
        }

        public Venta()
        {
        }

        public override string ToString()
        {
                return "el_Identificador_deproducto: " + Identificador_deproducto + " el_Nombre_del_producto " + Nombre_del_producto + " la_Descripcion_del_producto " + Descripcion_del_producto + " el_Precio_de_lproducto " + Precio_de_lproducto + " le_Cantidad_del_producto " + Cantidad_del_producto;

        }

        
    }
}
