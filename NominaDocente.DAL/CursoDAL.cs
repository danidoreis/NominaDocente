using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data.Common;
using System.Collections;
using NominaDocente.Entidades;

namespace NominaDocente.DAL
{
    public class CursoDAL:AbstractMapper
    {
        public ArrayList ConsultaCurso(string especialidad)
        {
            ArrayList cursos = new ArrayList();
            commandText = string.Format("SELECT id,concat_ws(' ',año,division)as curso FROM cursos where especialidad='{0}'",especialidad);
            cursos=AbstractFindAll();

            return cursos;
        }

        public ArrayList ConsultaAño()
        {
            ArrayList años = new ArrayList();
            commandText = "select distinct año as id,año as curso from cursos;";
            años = AbstractFindAll();

            return años;
        }
        public override object DoLoad(System.Data.IDataReader registers)
        {
            Curso curso = new Curso();
            
            curso.Id = registers["id"].ToString();
            curso.NomCurso = registers["curso"].ToString();

            return curso;
        }
    }
}
