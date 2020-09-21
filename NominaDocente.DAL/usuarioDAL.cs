using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data.Common;
using System.Collections;
using Entidades;

namespace NominaDocente.DAL 
{
     public class usuarioDAL : AbstractMapper
    {
         public Usuario ConsultarUsuarios(string nombreUsuario, string clave)
        {
            commandText = string.Format("SELECT nombre,password, id, dni FROM usuario where nombre='{0}' and password='{1}'",nombreUsuario,clave);
            Usuario usuario = (Usuario)AbstractFind();
            return usuario;
        }






        public override object DoLoad(System.Data.IDataReader registers)
        {
            Usuario person = new Usuario();

            person.Nombre = registers["nombre"].ToString();
            person.Password = registers["password"].ToString();
            person.Id = registers["id"].ToString();
            //person.Dni = registers["dni"].ToString();
            return person;


        }
    }
}