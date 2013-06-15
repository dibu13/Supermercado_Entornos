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

        }

        private void button1_Click(object sender, EventArgs e)
        {

            supermarket_class.Administrador.crear_user(Convert.ToInt32(T_Id.Text),T_Dni.Text, T_Nombre.Text, T_Direc.Text, T_Email.Text, T_Pass.Text,Convert.ToBoolean(T_Admin.Text));
            ListaClientes.Items.Add(T_Nombre.Text);    
        }
    }
}
