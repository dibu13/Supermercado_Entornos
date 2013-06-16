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
        }

    }
}
