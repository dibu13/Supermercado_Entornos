using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using supermarket_class;

namespace supermarket_class
{
    public class Productos
    {
        int id_cat;
        int id_prod;
        string nombre_prod;
        int precio_prod;


        static public void crear_productos(int T_id_P, int T_id_cat_P, string T_nom_P, int T_precio_P)
        {

            StreamWriter fichero_productos = new StreamWriter("Ficheros\\productos.txt", true);

            fichero_productos.WriteLine(T_id_P + "#" + T_id_cat_P + "#" + T_nom_P.ToString() + "#" + T_precio_P);

            fichero_productos.Close();
        }



        
    }
}
