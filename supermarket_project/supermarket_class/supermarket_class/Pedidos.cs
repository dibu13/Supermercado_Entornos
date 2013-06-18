using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace supermarket_class
{
    public class Pedidos
    {
        int id_pedido;
        int id_user;
        string fecha;

        /// <summary>
        /// Contructor de pedidos
        /// </summary>
        /// <param name="_id_pedido">Atributo para el id del pedido</param>
        /// <param name="_id_user">Atributo para el id del usuario</param>
        /// <param name="_fecha">Atributo para la fecha en la que se realiza el pedido</param>
        public Pedidos(int _id_pedido, int _id_user, string _fecha) 
        {
            this.id_pedido = _id_pedido;
            this.id_user = _id_user;
            this.fecha = _fecha;
        }
    }
}
