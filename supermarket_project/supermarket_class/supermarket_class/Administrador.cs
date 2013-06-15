using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using supermarket_class;
using System.IO;

namespace supermarket_class
{
    public class Administrador : Usuario
    {
         
        static public void crear_user(int T_Id, string T_Dni, string T_Nombre, string T_Direc, string T_Email, string T_Pass, bool T_Admin){

            StreamWriter fichero_users = new StreamWriter("Ficheros\\usuarios.txt", true);

            fichero_users.WriteLine(T_Id + "#" + T_Dni.ToString() + "#" + T_Nombre.ToString() + "#" + T_Direc.ToString() + "#" + T_Email.ToString() + "#" + T_Pass.ToString() + "#" + T_Admin.ToString());

            fichero_users.Close();


        }

        static public void crear_productos(int T_id_P, int T_id_cat_P, string T_nom_P, double T_precio_P)
        {
            StreamWriter fichero_productos = new StreamWriter("Ficheros\\productos.txt", true);

            fichero_productos.WriteLine(T_id_P + "#" + T_id_cat_P + "#" + T_nom_P.ToString() + "#" + T_precio_P);

            fichero_productos.Close();
        }

    }

    
   
}
