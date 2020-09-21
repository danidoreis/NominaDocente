using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Entidades
{
    public class Perfil
    {
        public Perfil(/*string nombre,*/ string id/*, string descripcion*/)
        {
           // this.nombre = nombre;
            this.id = id;
        }
        public Perfil()
        {
         
        }


        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }



        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        private List<Funcion> funciones;

        public List<Funcion> Funciones
        {
            get { return funciones; }
            set { funciones = value; }
        }
    }
}
