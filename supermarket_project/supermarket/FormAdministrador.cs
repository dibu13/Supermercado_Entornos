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
    public partial class FormAdministrador : Form
    {
        public FormAdministrador()
        {
            InitializeComponent();

            StreamReader fichero_users = new StreamReader("Ficheros\\usuarios.txt");
            string linea;
            string[] datos = null;

            while ((linea = fichero_users.ReadLine()) != null)
            {
                datos = linea.Split(new char[] { '#' });
                ListaUsuarios.Items.Add(datos[2]);
            }

            fichero_users.Close();

            StreamReader fichero_productos = new StreamReader("Ficheros\\productos.txt");

            while ((linea = fichero_productos.ReadLine()) != null)
            {
                datos = linea.Split(new char[] { '#' });
                ListaProductos.Items.Add(datos[2]);
            }

            fichero_productos.Close();

            StreamReader fichero_categorias = new StreamReader("Ficheros\\categorias.txt");
      

            while ((linea = fichero_categorias.ReadLine()) != null)
            {
                datos = linea.Split(new char[] { '#' });
                ListaCategorias.Items.Add(datos[1]);
            }

            fichero_categorias.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            supermarket_class.Administrador.crear_user(Convert.ToInt32(T_Id.Text),T_Dni.Text, T_Nombre.Text, T_Direc.Text, T_Email.Text, T_Pass.Text,Convert.ToBoolean(T_Admin.Text));
            ListaUsuarios.Items.Add(T_Nombre.Text);
            T_Id.Text = null;
            T_Dni.Text = null;
            T_Nombre.Text = null;
            T_Direc.Text = null;
            T_Email.Text = null;
            T_Pass.Text = null;
            T_Admin.Text = null;
        }

        private void B_GuardarProd_Click(object sender, EventArgs e)
        {
            supermarket_class.Administrador.crear_productos(Convert.ToInt32(T_id_P.Text), Convert.ToInt32(T_id_cat_P.Text), T_nom_P.Text, Convert.ToDouble(T_precio_P.Text));
            ListaProductos.Items.Add(T_nom_P.Text);

            T_id_cat_P.Text = null;
            T_id_P.Text = null;
            T_nom_P.Text = null;
            T_precio_P.Text = null;
        }

        private void B_VerProductos_Click(object sender, EventArgs e)
        {
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

            T_id_cat_P.Text = datos[1];
            T_id_P.Text = datos[0];
            T_nom_P.Text = datos[2];
            T_precio_P.Text = datos[3];
        }

        private void B_VerClientes_Click(object sender, EventArgs e)
        {
            StreamReader fichero_users = new StreamReader("Ficheros\\usuarios.txt");
            string linea;
            string[] datos = null;
            bool encontrado = false;

            while ((linea = fichero_users.ReadLine()) != null && encontrado == false)
            {
                datos = linea.Split(new char[] { '#' });
                if (datos[2] == (string)ListaUsuarios.SelectedItem)
                {
                    encontrado = true;
                }
            }

            fichero_users.Close();

            T_Id.Text = datos[0];
            T_Dni.Text = datos[1];
            T_Nombre.Text = datos[2];
            T_Direc.Text = datos[3];
            T_Email.Text = datos[4];
            T_Pass.Text = datos[5];
            T_Admin.Text = datos[6];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            supermarket_class.Administrador.crear_categorias(Convert.ToInt32(T_IdCat.Text),T_NombreCat.Text);
            ListaCategorias.Items.Add(T_NombreCat.Text);
            T_IdCat.Text = null;
            T_NombreCat.Text = null;
        }

        private void B_VerDetCat_Click(object sender, EventArgs e)
        {
            StreamReader fichero_categorias = new StreamReader("Ficheros\\categorias.txt");
            string linea;
            string[] datos = null;
            bool encontrado = false;

            while ((linea = fichero_categorias.ReadLine()) != null && encontrado == false)
            {
                datos = linea.Split(new char[] { '#' });
                if (datos[1] == (string)ListaCategorias.SelectedItem)
                {
                    encontrado = true;
                }
            }

            fichero_categorias.Close();

            T_NombreCat.Text = datos[1];
            T_IdCat.Text= datos[0];
            
        }

        private void B_BorrarCat_Click(object sender, EventArgs e)
        {
            supermarket_class.Administrador.borrar_categoria((string)ListaCategorias.SelectedItem);
            ListaCategorias.Items.Remove(ListaCategorias.SelectedItem);
        }

        private void B_BorrarCliente_Click(object sender, EventArgs e)
        {
            supermarket_class.Administrador.borrar_user((string)ListaUsuarios.SelectedItem);
            ListaUsuarios.Items.Remove(ListaUsuarios.SelectedItem);
        }

        private void B_EliminarCat_Click(object sender, EventArgs e)
        {
            supermarket_class.Administrador.borrar_prod((string)ListaProductos.SelectedItem);
            ListaProductos.Items.Remove(ListaProductos.SelectedItem);
        }

        private void B_ModUsuarios_Click(object sender, EventArgs e)
        {
            supermarket_class.Administrador.modificar_user((string)ListaUsuarios.SelectedItem, Convert.ToInt32(T_Id.Text), T_Dni.Text, T_Nombre.Text, T_Direc.Text, T_Email.Text, T_Pass.Text, Convert.ToBoolean(T_Admin.Text));
            ListaUsuarios.Items.Remove(ListaUsuarios.SelectedItem);
            ListaUsuarios.Items.Add(T_Nombre.Text);
        }

        private void B_NuevaCat_Click(object sender, EventArgs e)
        {
            supermarket_class.Administrador.modificar_prod((string)ListaProductos.SelectedItem, Convert.ToInt32(T_id_P.Text), Convert.ToInt32(T_id_cat_P.Text), T_nom_P.Text, Convert.ToDouble(T_precio_P.Text));
            ListaProductos.Items.Remove(ListaProductos.SelectedItem);
            ListaProductos.Items.Add(T_nom_P.Text);
        }

        private void B_GuardarCat_Click(object sender, EventArgs e)
        {
            supermarket_class.Administrador.modificar_categoria((string)ListaCategorias.SelectedItem, Convert.ToInt32(T_IdCat.Text), T_NombreCat.Text);
            ListaCategorias.Items.Remove(ListaCategorias.SelectedItem);
            ListaCategorias.Items.Add(T_NombreCat.Text);
        }

        private void B_CerrarSesion_Click(object sender, EventArgs e) {
            this.Close();
        }

    }
}
