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
    public class PerfilDAL : AbstractMapper
    {
        public Perfil ConsultarPerfil(int idUsuario)
        {

            commandText = string.Format("SELECT p.nombre as perfilNombre, p.descripcion AS perfilDescripcion, p.id as Perfilid FROM  usuarioperfil up,perfil p where up.id_usuario ={0} AND up.id_Perfil= p.id", idUsuario);
            Perfil perfil = (Perfil)AbstractFind();
            return perfil;


        }

        public ArrayList ConsultarPerfiles() {
            commandText = string.Format("SELECT nombre from Perfil");
            ArrayList perfiles = AbstractFindAll();
            return perfiles;
        }




        public int grabaPerfil(Perfil perfil)
        {
            //Realiza la grabacion en la tabla Perfil, y recupera el ID del perfil grabado para retornarlo

            int ID = 0;
            return ID;
        }

        public void grabaFuncionPerfil(string idFuncion, string idPerfil)
        {

            // realiza la grabacion en la relacion FuncionPerfil.
        }

        public override object DoLoad(System.Data.IDataReader registers)
        {

            Perfil perf = new Perfil();

            perf.Id = registers["Perfilid"].ToString();
            perf.Nombre = registers["perfilNombre"].ToString();
            perf.Descripcion = registers["perfilDescripcion"].ToString();
     
            return perf;


        }
    }
}

