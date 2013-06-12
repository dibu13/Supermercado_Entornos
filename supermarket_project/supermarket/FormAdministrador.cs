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
    public partial class FormAdministrador : Form
    {
        public FormAdministrador()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter fichero_clientes = new StreamWriter("Ficheros\\usuarios.txt",true);

            fichero_clientes.WriteLine(T_Dni.Text + "#" + T_Dni.Text + "#" + T_Direc.Text + "#" + T_Email.Text + "#" + T_Pass.Text + "#" + T_Admin.Text);

            fichero_clientes.Close();
        }
    }
}
