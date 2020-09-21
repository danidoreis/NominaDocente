using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Funcion
    {
        public Funcion( string id, string nombre, string url, string etiqueta, int funcionPadre)
        {
        }

        public Funcion()
        {

        }

        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Codigo
        {
            get { return id; }
            set { id = value; }
        }


        private string url;

        public string Url
        {
            get { return url; }
            set { url = value; }
        }
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string etiqueta;

        public string Etiqueta
        {
            get { return etiqueta; }
            set { etiqueta = value; }
        }

        private string funcionPadre;

        public string FuncionPadre
        {
            get { return funcionPadre; }
            set { funcionPadre = value; }
        }
    }
}
