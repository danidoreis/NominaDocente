using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NominaDocente.Entidades;
using NominaDocente.DAL;
using System.Collections;

namespace NominaDocente.BLL
{
    public class ManagerHorarioCurso
    {
        public ArrayList ConsultaHorarioCurso()
        {
            HorarioCursoDAL horCurDAL = new HorarioCursoDAL();
            ArrayList cursos = new ArrayList();

            cursos=horCurDAL.ConsultaHorarioCurso();
            return cursos;
        }
        public ArrayList Lunes()
        {
            HorarioCursoDAL horCurDal = new HorarioCursoDAL();
            ArrayList lunes = new ArrayList();

            lunes = horCurDal.Lunes();
            return lunes;
        }
        public ArrayList Martes()
        {
            HorarioCursoDAL horCurDal = new HorarioCursoDAL();
            ArrayList martes = new ArrayList();

            martes = horCurDal.Martes();
            return martes;
        }
        public ArrayList Miercoles()
        {
            HorarioCursoDAL horCurDal = new HorarioCursoDAL();
            ArrayList miercoles = new ArrayList();

            miercoles = horCurDal.Miercoles();
            return miercoles;
        }
        public ArrayList Jueves()
        {
            HorarioCursoDAL horCurDal = new HorarioCursoDAL();
            ArrayList jueves = new ArrayList();

            jueves = horCurDal.Jueves();
            return jueves;
        }
        public ArrayList Viernes()
        {
            HorarioCursoDAL horCurDal = new HorarioCursoDAL();
            ArrayList viernes = new ArrayList();

            viernes = horCurDal.Viernes();
            return viernes;
        }
    }
}
