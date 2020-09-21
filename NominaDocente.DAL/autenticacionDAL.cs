using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data.Common;
using System.Collections;
using NominaDocente.Entidades;
using Entidades;

namespace NominaDocente.DAL
{
   public class autenticacionDAL:AbstractMapper
    {
       public ArrayList ConsultaUsuario(string nombre, string contraseña)
        {
            ArrayList usuario = new ArrayList();
            commandText = string.Format("SELECT FROM Nomina where id,usuario");
            usuario = AbstractFindAll();

            return usuario;
        }

        public ArrayList ConsultaContraseña()
        {
            ArrayList contraseña = new ArrayList();
            commandText = ("SELECT Nomina where id,contraseña");
            contraseña = AbstractFindAll();

            return contraseña;
        }
        public override object DoLoad(System.Data.IDataReader registers)
        {
          Usuario usuario = new Usuario();
            
            usuario.Id = registers["id"].ToString();
            usuario.Nombre = registers["usuario"].ToString();

            return usuario;
        }
    }
}