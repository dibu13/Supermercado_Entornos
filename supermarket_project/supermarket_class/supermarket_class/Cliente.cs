using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace supermarket_class
{
    public class Cliente : Usuario
    {
        public Cliente(int _id_user, string _dni_user, string _nombre_user, string _direccion_user, string _email_user, string _contraseña_user, bool _admin_user) : base(_id_user, _dni_user, _nombre_user, _direccion_user, _email_user, _contraseña_user, _admin_user) { }
        #region Metodos
        static public void modificar_direccion(Cliente cl, string n_direc)
        {
            cl.direccion_user = n_direc;

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
                if (cl.nombre_user != item.nombre_user)
                {
                    lista_aux.Add(new Usuario(item.id_user, item.dni_user, item.nombre_user, item.direccion_user, item.email_user, item.contraseña_user, item.admin_user));
                }
                else
                {
                    lista_aux.Add(new Usuario(cl.id_user, cl.dni_user, cl.nombre_user, cl.direccion_user, cl.email_user, cl.contraseña_user, cl.admin_user));
                }
            }

            StreamWriter fichero_users_r = new StreamWriter("Ficheros\\usuarios.txt");
            foreach (Usuario item in lista_aux)
            {
                fichero_users_r.WriteLine(item.id_user.ToString() + "#" + item.dni_user + "#" + item.nombre_user + "#" + item.direccion_user + "#" + item.email_user + "#" + item.contraseña_user + "#" + item.admin_user);
            }
            fichero_users_r.Close();
        }

        static public void finalizar_carro(Cliente cl, List<Producto> lista_productos_carro)
        {
            StreamReader fichero_pedidos_w = new StreamReader("Ficheros\\pedidos.txt");
            string linea = "";
            int id = 0;
            while ((linea = fichero_pedidos_w.ReadLine()) != null)
            {
                string[] datos = linea.Split(new char[] { '#' });

                int id_pedido = Convert.ToInt32(datos[0]);

                if (id_pedido > id) {
                    id = id_pedido;
                }

            }

            id++;

            fichero_pedidos_w.Close();

            StreamWriter fichero_pedidos = new StreamWriter("Ficheros\\pedidos.txt", true);

            fichero_pedidos.WriteLine(id + "#" + cl.id_user + "#" + DateTime.Now.ToShortDateString());

            fichero_pedidos.Close();

            StreamWriter fichero_compra = new StreamWriter("Ficheros\\compra.txt",true);
            foreach (Producto item in lista_productos_carro)
            {
                fichero_compra.WriteLine(id + "#" + item.id_prod + "#" + item.cantidad);
            }
            fichero_compra.Close();
        }

        #endregion
    }
}
