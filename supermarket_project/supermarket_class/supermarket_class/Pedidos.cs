using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace supermarket_class
{
    class Pedidos
    {
        int id_pedido;
        int id_user;
        string fecha;

        public Pedidos(int _id_pedido, int _id_user, string _fecha) 
        {
            this.id_pedido = _id_pedido;
            this.id_user = _id_user;
            this.fecha = _fecha;
        }
    }
}
