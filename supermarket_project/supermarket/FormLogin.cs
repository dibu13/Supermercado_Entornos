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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader fichero_users = new StreamReader("Ficheros\\usuarios.txt");
            string linea;
            string[] datos=null;
            bool encontrado = false;

            while ((linea=fichero_users.ReadLine())!=null && encontrado==false)
            {
                datos = linea.Split(new char[] {'#'});
                if (datos[2]==Textbox_Usuario.Text)
                {
                    encontrado = true;
                }
            }

            if (datos[5]==Textbox_Password.Text)
            {
                if (Convert.ToBoolean(datos[6])==true)
                {
                    FormAdministrador ventana_admin = new FormAdministrador();
                    ventana_admin.ShowDialog();
                }
                else
                {
                    FormUsuario ventana_user = new FormUsuario();
                    ventana_user.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }


            /*FormAdministrador ventana = new FormAdministrador();
            ventana.ShowDialog();*/
        }

    }
}
