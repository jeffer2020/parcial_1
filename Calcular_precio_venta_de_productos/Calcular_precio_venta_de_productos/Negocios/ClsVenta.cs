using Calcular_precio_venta_de_productos.Entitades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcular_precio_venta_de_productos.Negocios
{
    class ClsVenta
    {
        Venta venta = new Venta();

        public string funcionCobro(double precio, int cantidad)
        {

            double total = precio * cantidad;
            if (total > 50)
            {
                double y = total * 10 / 100;
                double K = total - y;
                return "su compra tiene descueto del 10% por compras de mas de 50 dolares" +
                    "su total a canselar sin descuento es de" + total + "su producto con el descuesto es de" + K;
            }
            else
                return "su total a pagar sin descuento es de" + total; 
            

        }
    }
}
