using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using supermarket_class;

namespace supermarket_class
{
    public class Producto
    {
        public int id_prod;
        public int id_cat;
        public string nombre_prod;
        public double precio_prod;
        public int cantidad;

        public Producto(int _id_prod, int _id_cat, string _nombre_prod, double _precio_prod) 
        {
            this.id_prod = _id_prod;
            this.id_cat = _id_cat;
            this.nombre_prod = _nombre_prod;
            this.precio_prod = _precio_prod;
        }
        public Producto(int _id_prod, string _nombre_prod, int _cantidad)
        {
            this.id_prod = _id_prod;
            this.nombre_prod = _nombre_prod;
            this.cantidad = _cantidad;
        }
    }
}
