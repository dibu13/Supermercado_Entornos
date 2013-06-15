using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace supermarket_class
{
    public class Usuario
    {
        public int id_user;
        public string dni_user;
        public string nombre_user;
        public string direccion_user;
        public string email_user;
        public string contraseña_user;
        public bool admin_user;

        public Usuario(int _id_user, string _dni_user, string _nombre_user, string _direccion_user, string _email_user, string _contraseña_user, bool _admin_user)
        {
            this.id_user = _id_user;
            this.dni_user = _dni_user;
            this.nombre_user = _nombre_user;
            this.direccion_user = _direccion_user;
            this.email_user = _email_user;
            this.contraseña_user = _contraseña_user;
            this.admin_user = _admin_user;
        }
    }
}
