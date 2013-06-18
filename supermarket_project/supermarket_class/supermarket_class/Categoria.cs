using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace supermarket_class
{
    public class Categoria
    {
        public int id_categoria;
        public string nombre_categoria;

        /// <summary>
        /// Constructor de categoria
        /// </summary>
        /// <param name="_id_categoria">Atributo para el id de la categoria</param>
        /// <param name="_nombre_categoria">Atributo para el nombre de la categoria</param>
        public Categoria(int _id_categoria, string _nombre_categoria) {
            this.id_categoria = _id_categoria;
            this.nombre_categoria = _nombre_categoria; 
        }

    }
}
