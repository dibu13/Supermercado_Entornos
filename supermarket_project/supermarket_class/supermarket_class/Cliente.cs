using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace supermarket_class
{
    public class Cliente : Usuario
    {
        public Cliente(int _id_user, string _dni_user, string _nombre_user, string _direccion_user, string _email_user, string _contraseña_user, bool _admin_user) : base(_id_user, _dni_user, _nombre_user, _direccion_user, _email_user, _contraseña_user, _admin_user) { }

    }
}
