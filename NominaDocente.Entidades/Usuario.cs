using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Usuario
    {
        public Usuario(int id,string nombre, string password)
        {
            
        }

        public Usuario()
        {
        
        }
        private string id;
        private string nombre;
        string password;
        string dni;
        private Perfil perfil;




        public string Id
        {
            get { return id; }
            set { id = value; }
        }


        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }


            public  Perfil Perfil
        {
            get { return perfil; }
            set { perfil = value; }
        }
    }
}
