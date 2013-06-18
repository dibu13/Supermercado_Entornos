using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using supermarket_class;

namespace supermarket
{
    public partial class FormUsuario : Form
    {
        Cliente cl;
        List<Producto> lista_prod_carro = new List<Producto>();
        public FormUsuario(string user)
        {
            InitializeComponent();

            StreamReader fichero_users = new StreamReader("Ficheros\\usuarios.txt");
            string linea;
            string[] datos = null;
            bool encontrado = false;

            while ((linea = fichero_users.ReadLine()) != null && encontrado == false)
            {
                datos = linea.Split(new char[] { '#' });
                if (datos[2] == user)
                {
                    encontrado = true;
                }
            }

            fichero_users.Close();

            cl = new Cliente(Convert.ToInt32(datos[0]), datos[1], datos[2], datos[3], datos[4], datos[5], Convert.ToBoolean(datos[6]));
            T_Id.Text = Convert.ToString(cl.id_user);
            T_Dni.Text = cl.dni_user;
            T_Nombre.Text = cl.nombre_user;
            T_Direc.Text = cl.direccion_user;
            T_Email.Text = cl.email_user;

            label6.Text = cl.nombre_user;

            StreamReader fichero_productos = new StreamReader("Ficheros\\productos.txt");

            while ((linea = fichero_productos.ReadLine()) != null) {
                datos = linea.Split(new char[] { '#' });
                ListaProductos.Items.Add(datos[2]);
            }

            fichero_productos.Close();

        }

        private void B_VerProductos_Click(object sender, EventArgs e) {
           
            StreamReader fichero_productos = new StreamReader("Ficheros\\productos.txt");
            string linea;
            string[] datos = null;
            bool encontrado = false;

            while ((linea = fichero_productos.ReadLine()) != null && encontrado == false)
            {
                datos = linea.Split(new char[] { '#' });
                if (datos[2] == (string)ListaProductos.SelectedItem)
                {
                    encontrado = true;
                }
            }

            fichero_productos.Close();
            T_NombreProducto.Text = datos[2];
            T_IdProd.Text = datos[0];
            T_IdCategoria.Text = datos[1];
            T_Precio.Text = datos[3];

        
        }

        private void B_Enviaralcarro_Click(object sender, EventArgs e) {
            if ((string)ListaProductos.SelectedItem != null) {
                ListaCarro.Items.Add((string)ListaProductos.SelectedItem);

                StreamReader fichero_productos = new StreamReader("Ficheros\\productos.txt");
                string linea;
                string[] datos = null;
                bool encontrado = false;

                while ((linea = fichero_productos.ReadLine()) != null && encontrado == false)
                {
                    datos = linea.Split(new char[] { '#' });
                    if (datos[2] == (string)ListaProductos.SelectedItem)
                    {
                        encontrado = true;
                    }
                }
                
                lista_prod_carro.Add(new Producto(Convert.ToInt32(datos[0]),datos[2],Convert.ToInt32(T_cantidad.Text)));
                T_cantidad.Text = "1";
            }
            else {
                MessageBox.Show("No has seleccionado ningun elemento");
            }
            
        }
        private void button2_Click(object sender, EventArgs e) {
            Cliente.finalizar_carro(cl,lista_prod_carro);
        }

        private void B_CerrarSesion_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cliente.modificar_direccion(cl,T_Direc.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<Producto> aux = new List<Producto>();
            foreach (Producto item in lista_prod_carro)
            {
                if(item.nombre_prod!=(string)ListaCarro.SelectedItem)
                {
                    aux.Add(new Producto(item.id_prod,item.nombre_prod,item.cantidad));
                }
            }

            lista_prod_carro = aux;

            ListaCarro.Items.Remove(ListaCarro.SelectedItem);
        }

        }

    
}
