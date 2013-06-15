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

        static public void crear_categorias(int T_IdCat, string T_NombreCat)
        {
            StreamWriter fichero_categorias = new StreamWriter("Ficheros\\categorias.txt", true);

            fichero_categorias.WriteLine(T_IdCat + "#" + T_NombreCat.ToString());

            fichero_categorias.Close();
        }

        static public void borrar_categoria(string seleccionado)
        {
            List<Categoria> lista_cat = new List<Categoria>();
            StreamReader fichero_categorias_w = new StreamReader("Ficheros\\categorias.txt");
            string linea = "";
            while ((linea = fichero_categorias_w.ReadLine()) != null)
            {
                string[] datos = linea.Split(new char[] { '#' });
                int id_categoria = Convert.ToInt32(datos[0]);
                string nombre_categoria = datos[1];
                lista_cat.Add(new Categoria(id_categoria, nombre_categoria));
            }
            fichero_categorias_w.Close();
            List<Categoria> lista_aux = new List<Categoria>();
            foreach (Categoria item in lista_cat)
            {
                if (seleccionado != item.nombre_categoria)
                {
                    lista_aux.Add(new Categoria(item.id_categoria, item.nombre_categoria));
                }
            }

            StreamWriter fichero_categorias_r = new StreamWriter("Ficheros\\categorias.txt");
            foreach (Categoria item in lista_aux)
            {
                fichero_categorias_r.WriteLine(item.id_categoria.ToString() + "#" + item.nombre_categoria);
            }
            fichero_categorias_r.Close();
        }
    }

    
   
}
