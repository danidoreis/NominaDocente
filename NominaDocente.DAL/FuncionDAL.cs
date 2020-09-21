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
    public class FuncionDAL : AbstractMapper



    {
        public ArrayList ConsultarFunciones(int idPerfil)
        {
            commandText = string.Format("SELECT f.nombre as nombre, f.url as url, f.id as id FROM funcion f, perfilfuncion pf where pf.Id_Perfil ={0} AND pf.id_Funcion=f.id", idPerfil.ToString());
            ArrayList funciones = AbstractFindAll();
            return funciones;
        }
        //public int grabaPerfil(Perfil perfil)
        //{
        //    //Realiza la grabacion en la tabla Perfil, y recupera el ID del perfil grabado para retornarlo

        //    int ID = 0;
        //    return ID;
        //}

        //public void grabaFuncionPerfil(int idFuncion, int idPerfil)
        //{
        //    // realiza la grabacion en la relacion FuncionPerfil.
        //}
        public override object DoLoad(System.Data.IDataReader registers)
        {

            Funcion funcion = new Funcion();

   
            funcion.Nombre = registers["nombre"].ToString();
            funcion.Url = registers["url"].ToString();
            funcion.Codigo= registers["id"].ToString();
            return funcion;
        }
    }
}

