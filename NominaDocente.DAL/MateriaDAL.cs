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
    public class MateriaDAL : AbstractMapper
    {
        public ArrayList ConsultaMateria(int curso)
        {
            ArrayList materias = new ArrayList();
            commandText = string.Format("SELECT distinct id,nombre_materia FROM materia_curso_horario inner join materia on materia.id=materia_curso_horario.id_materia where id_curso={0}", curso);
            materias=AbstractFindAll();
            
            return materias;
        }
        public ArrayList ConsultaMateriaAño(string año)
        {
            ArrayList materias = new ArrayList();
            commandText = string.Format("select distinct materia.id,nombre_materia from materia inner join materia_curso_horario on materia_curso_horario.id_materia=materia.id inner join cursos on cursos.id=materia_curso_horario.id_curso where año='{0}'", año);
            materias = AbstractFindAll();

            return materias;
        }
        public override object DoLoad(System.Data.IDataReader registers)
        {
            Materia materias = new Materia();

            materias.Id = registers["id"].ToString();
            materias.NombreMateria = registers["nombre_materia"].ToString();

            return materias;
        }
    }
}
