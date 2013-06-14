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
        }

        private void button1_Click(object sender, EventArgs e)
        {

            supermarket_class.Administrador.crear_user(Convert.ToInt32(T_Id.Text),T_Dni.Text, T_Direc.Text, T_Email.Text, T_Pass.Text,Convert.ToBoolean(T_Admin.Text));                
        }
    }
}
