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
    public class DocenteConCHDAL : AbstractMapper
    {
        public void InsertCargaHoraria(string dni, string id_curso, string id_materia)
        {
            commandText = string.Format("insert into carga_horaria(dni,id_materia,id_curso)values('{0}',{1},{2})", dni, id_materia, id_curso);
            AbstractSave();
        }
        public ArrayList ConsultaDocenteConCH(string nombre,string apellido,string especialidad,string curso,string materia)
        {
            ArrayList docentes = new ArrayList();
            commandText = string.Format("select distinct nombre,apellido,docentes.dni,nro_legajo,especialidad,concat_ws(' ',año,division)as curso,nombre_materia as materia,dia,horario,cant_modulos from docentes inner join carga_horaria on carga_horaria.dni=docentes.dni inner join cursos on cursos.id=carga_horaria.id_curso inner join materia on materia.id=carga_horaria.id_materia inner join materia_curso_horario on materia_curso_horario.id_materia=materia.id where nombre like concat('%',{0},'%') or apellido like concat('%',{1},'%') or especialidad={2} and carga_horaria.id_curso={3} and carga_horaria.id_materia={4} ", nombre, apellido, especialidad, curso,materia);
            docentes = AbstractFindAll();

            return docentes;
        }
        public ArrayList VerfCargaHoraria(int curso, int materia)
        {
            ArrayList doc = new ArrayList();
            commandText = string.Format("select  nombre,apellido,docentes.dni,nro_legajo,especialidad,concat_ws(' ',año,division)as curso,nombre_materia as materia,dia,horario,cant_modulos from docentes inner join carga_horaria on carga_horaria.dni=docentes.dni inner join cursos on cursos.id=carga_horaria.id_curso inner join materia on materia.id=carga_horaria.id_materia inner join materia_curso_horario on materia_curso_horario.id_materia=materia.id where carga_horaria.id_curso={0} and carga_horaria.id_materia={1}", curso,materia);
            doc = AbstractFindAll();

            return doc;
        }
        public override object DoLoad(System.Data.IDataReader registers)
        {
            DocenteConCH docentes = new DocenteConCH();

            docentes.Nombre = registers["nombre"].ToString();
            docentes.Apellido = registers["apellido"].ToString();
            docentes.Dni = registers["dni"].ToString();
            docentes.NroLegajo = registers["nro_legajo"].ToString();
            docentes.Especialidad = registers["especialidad"].ToString();
            docentes.Curso = registers["curso"].ToString();
            docentes.Materia = registers["materia"].ToString();
            docentes.Dia = registers["dia"].ToString();
            docentes.Horario = registers["horario"].ToString();
            docentes.Cant_modulos = registers["cant_modulos"].ToString();
            

            return docentes;
        }
    }
}
