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
                ListaClientes.Items.Add(datos[2]);
            }

            fichero_users.Close();

            StreamReader fichero_productos = new StreamReader("Ficheros\\productos.txt");
            //string linea;
            //string[] datos = null;

            while ((linea = fichero_productos.ReadLine()) != null)
            {
                datos = linea.Split(new char[] { '#' });
                ListaProductos.Items.Add(datos[2]);
            }

            fichero_productos.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            supermarket_class.Administrador.crear_user(Convert.ToInt32(T_Id.Text),T_Dni.Text, T_Nombre.Text, T_Direc.Text, T_Email.Text, T_Pass.Text,Convert.ToBoolean(T_Admin.Text));
            ListaClientes.Items.Add(T_Nombre.Text);    
        }

        private void B_GuardarProd_Click(object sender, EventArgs e)
        {
            supermarket_class.Productos.crear_productos(Convert.ToInt32(T_id_P.Text), Convert.ToInt32(T_id_cat_P.Text), T_nom_P.Text, Convert.ToInt32(T_precio_P.Text));
            ListaProductos.Items.Add(T_nom_P.Text);
        }
    }
}
