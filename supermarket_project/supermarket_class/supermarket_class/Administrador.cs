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
        Administrador(int _id_user, string _dni_user, string _nombre_user, string _direccion_user, string _email_user, string _contraseña_user, bool _admin_user) : base(_id_user, _dni_user, _nombre_user, _direccion_user, _email_user, _contraseña_user, _admin_user){ }
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

        static public void borrar_user(string seleccionado)
        {
            List<Usuario> lista_user = new List<Usuario>();
            StreamReader fichero_users_w = new StreamReader("Ficheros\\usuarios.txt");
            string linea = "";
            while ((linea = fichero_users_w.ReadLine()) != null)
            {
                string[] datos = linea.Split(new char[] { '#' });
                
                int id_user = Convert.ToInt32(datos[0]);
                string dni_user = datos[1];
                string nombre_user = datos[2];
                string direccion_user = datos[3];
                string email_user = datos[4];
                string contraseña_user = datos[5];
                bool admin_user = Convert.ToBoolean(datos[6]);

                lista_user.Add(new Usuario(id_user, dni_user, nombre_user, direccion_user, email_user, contraseña_user, admin_user));
            }
            fichero_users_w.Close();

            List<Usuario> lista_aux = new List<Usuario>();
            foreach (Usuario item in lista_user)
            {
                if (seleccionado != item.nombre_user)
                {
                    lista_aux.Add(new Usuario(item.id_user, item.dni_user, item.nombre_user, item.direccion_user, item.email_user, item.contraseña_user, item.admin_user));
                }
            }

            StreamWriter fichero_users_r = new StreamWriter("Ficheros\\usuarios.txt");
            foreach (Usuario item in lista_aux)
            {
                fichero_users_r.WriteLine(item.id_user.ToString() + "#" + item.dni_user + "#" + item.nombre_user + "#" + item.direccion_user + "#" + item.email_user + "#" + item.contraseña_user + "#" + item.admin_user);
            }
            fichero_users_r.Close();
        }

        static public void modificar_user(string seleccionado, int T_Id, string T_Dni, string T_Nombre, string T_Direc, string T_Email, string T_Pass, bool T_Admin)
        {
            List<Usuario> lista_user = new List<Usuario>();
            StreamReader fichero_users_w = new StreamReader("Ficheros\\usuarios.txt");
            string linea = "";
            while ((linea = fichero_users_w.ReadLine()) != null)
            {
                string[] datos = linea.Split(new char[] { '#' });

                int id_user = Convert.ToInt32(datos[0]);
                string dni_user = datos[1];
                string nombre_user = datos[2];
                string direccion_user = datos[3];
                string email_user = datos[4];
                string contraseña_user = datos[5];
                bool admin_user = Convert.ToBoolean(datos[6]);

                lista_user.Add(new Usuario(id_user, dni_user, nombre_user, direccion_user, email_user, contraseña_user, admin_user));
            }
            fichero_users_w.Close();

            List<Usuario> lista_aux = new List<Usuario>();
            foreach (Usuario item in lista_user)
            {
                if (seleccionado != item.nombre_user)
                {
                    lista_aux.Add(new Usuario(item.id_user, item.dni_user, item.nombre_user, item.direccion_user, item.email_user, item.contraseña_user, item.admin_user));
                }
                else{
                    lista_aux.Add(new Usuario(T_Id, T_Dni, T_Nombre, T_Direc, T_Email, T_Pass, T_Admin));
                }
            }

            StreamWriter fichero_users_r = new StreamWriter("Ficheros\\usuarios.txt");
            foreach (Usuario item in lista_aux)
            {
                fichero_users_r.WriteLine(item.id_user.ToString() + "#" + item.dni_user + "#" + item.nombre_user + "#" + item.direccion_user + "#" + item.email_user + "#" + item.contraseña_user + "#" + item.admin_user);
            }
            fichero_users_r.Close();
        }
        static public void borrar_prod(string seleccionado)
        {
            List<Producto> lista_productos = new List<Producto>();
            StreamReader fichero_productos_w = new StreamReader("Ficheros\\productos.txt");
            string linea = "";
            while ((linea = fichero_productos_w.ReadLine()) != null)
            {
                string[] datos = linea.Split(new char[] { '#' });

                int id_prod = Convert.ToInt32(datos[0]);
                int id_cat = Convert.ToInt32(datos[1]);
                string nombre_prod = datos[2];
                double precio_prod = Convert.ToDouble(datos[3]);

                lista_productos.Add(new Producto(id_prod, id_cat, nombre_prod, precio_prod));
            }
            fichero_productos_w.Close();

            List<Producto> lista_aux = new List<Producto>();
            foreach (Producto item in lista_productos)
            {
                if (seleccionado != item.nombre_prod)
                {
                    lista_aux.Add(new Producto(item.id_prod, item.id_cat, item.nombre_prod, item.precio_prod));
                }
            }

            StreamWriter fichero_productos_r = new StreamWriter("Ficheros\\productos.txt");
            foreach (Producto item in lista_aux)
            {
                fichero_productos_r.WriteLine(item.id_prod + "#" + item.id_prod + "#" + item.nombre_prod + "#" +  item.precio_prod);
            }
            fichero_productos_r.Close();
        }
    }

    
   
}
