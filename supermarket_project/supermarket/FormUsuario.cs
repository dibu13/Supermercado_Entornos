using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace supermarket
{
    public partial class FormUsuario : Form
    {
        public FormUsuario()
        {
            InitializeComponent();
            StreamReader fichero_users = new StreamReader("Ficheros\\usuarios.txt");
            string linea;
            string[] datos = null;
            bool encontrado = false;

            while ((linea = fichero_users.ReadLine()) != null && encontrado == false) {
                datos = linea.Split(new char[] { '#' });
                
            }

            fichero_users.Close();

            T_Id.Text = datos[0];
            T_Dni.Text = datos[1];
            T_Nombre.Text = datos[2];
            T_Direc.Text = datos[3];
            T_Email.Text = datos[4];
            T_Pass.Text = datos[5];
            T_Admin.Text = datos[6];

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

        }

    
}
