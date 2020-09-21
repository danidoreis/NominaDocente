using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NominaDocente.Entidades;
using NominaDocente.DAL;
using System.Collections;

namespace NominaDocente.BLL
{
    public class ManagerCurso
    {
        public ArrayList ConsultaCurso(string especialidad)
        {
            CursoDAL cursoDal = new CursoDAL();
            ArrayList cursos = cursoDal.ConsultaCurso(especialidad);

            return cursos;
        }
        public ArrayList ConsultaAño()
        {
            CursoDAL curDal = new CursoDAL();
            ArrayList años = curDal.ConsultaAño();

            return años;
        }

    }
}
