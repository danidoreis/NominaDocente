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
    public class HorarioCursoDAL : AbstractMapper
    {
        private int num=0;
        public ArrayList ConsultaHorarioCurso()
        {

            ArrayList cursos = new ArrayList();
            ArrayList lunes = new ArrayList();
            ArrayList martes = new ArrayList();
            ArrayList miercoles = new ArrayList();
            ArrayList jueves = new ArrayList();
            ArrayList viernes = new ArrayList();
            


            

            return cursos;
        }
        public ArrayList Lunes()
        {
            num = 1;
            ArrayList lunes = new ArrayList();
            commandText = "select concat_ws('  -  ',horario,nombre_materia)as materia  from materia_curso_horario inner join materia on materia.id=materia_curso_horario.id_materia inner join cursos on cursos.id=materia_curso_horario.id_curso where materia_curso_horario.id_curso=1 and dia='Lunes'";
            lunes = AbstractFindAll();

            return lunes;
        }

        public ArrayList Martes()
        {
            num = 2;
            ArrayList martes = new ArrayList();
            commandText = "select concat_ws('  -  ',horario,nombre_materia)as materia  from materia_curso_horario inner join materia on materia.id=materia_curso_horario.id_materia inner join cursos on cursos.id=materia_curso_horario.id_curso where materia_curso_horario.id_curso=1 and dia='Martes'";
            martes = AbstractFindAll();

            return martes;
        }

        public ArrayList Miercoles()
        {
            num = 3;
            ArrayList miercoles = new ArrayList();
            commandText = "select concat_ws('  -  ',horario,nombre_materia)as materia  from materia_curso_horario inner join materia on materia.id=materia_curso_horario.id_materia inner join cursos on cursos.id=materia_curso_horario.id_curso where materia_curso_horario.id_curso=1 and dia='Miercoles'";
            miercoles = AbstractFindAll();

            return miercoles;
        }

        public ArrayList Jueves()
        {
            num = 4;
            ArrayList jueves = new ArrayList();
            commandText = "select concat_ws('  -  ',horario,nombre_materia)as materia  from materia_curso_horario inner join materia on materia.id=materia_curso_horario.id_materia inner join cursos on cursos.id=materia_curso_horario.id_curso where materia_curso_horario.id_curso=1 and dia='Jueves'";
            jueves = AbstractFindAll();

            return jueves;
        }

        public ArrayList Viernes()
        {
            num = 5;
            ArrayList viernes = new ArrayList();
            commandText = "select concat_ws('  -  ',horario,nombre_materia)as materia  from materia_curso_horario inner join materia on materia.id=materia_curso_horario.id_materia inner join cursos on cursos.id=materia_curso_horario.id_curso where materia_curso_horario.id_curso=1 and dia='Viernes'";
            viernes = AbstractFindAll();

            return viernes;
        }

        public override object DoLoad(System.Data.IDataReader registers)
        {
            HorarioCurso horCurso = new HorarioCurso();

            horCurso.Materia = registers["materia"].ToString();
            
            return horCurso;
        }
        
    }
}
