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

    }

    
   
}
