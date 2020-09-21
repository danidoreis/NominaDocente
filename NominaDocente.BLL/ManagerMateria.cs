using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NominaDocente.Entidades;
using NominaDocente.DAL;
using System.Collections;

namespace NominaDocente.BLL
{
    public class ManagerMateria
    {
        public ArrayList ConsultaMateria(int curso)
        {
            MateriaDAL materiaDal=new MateriaDAL();
            ArrayList materias=materiaDal.ConsultaMateria(curso);
            
            return materias;
        }
        public ArrayList ConsultaMateriaAño(string año)
        {
            MateriaDAL materiaDal = new MateriaDAL();
            ArrayList materias = materiaDal.ConsultaMateriaAño(año);

            return materias;
        }
    }
}
