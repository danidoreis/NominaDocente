using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NominaDocente.Entidades
{
    public class MesaExamen
    {
        string año;
        string materia;
        string docente1;
        string docente2;
        string docente3;
        string fecha;
        string horario;

        public MesaExamen(string año, string materia, string docente1, string docente2, string docente3, string fecha, string horario)
        {
            this.año = año;
            this.materia = materia;
            this.docente1 = docente1;
            this.docente2 = docente2;
            this.docente3 = docente3;
            this.fecha = fecha;
            this.horario = horario;
        }
        public MesaExamen()
        {

        }
        public string Año
        {
            get
            {
                return año;
            }
            set
            {
                año = value;
            }
        }
        public string Materia
        {
            get
            {
                return materia;
            }
            set
            {
                materia = value;
            }
        }
        public string Docente1
        {
            get
            {
                return docente1;
            }
            set
            {
                docente1 = value;
            }
        }
        public string Docente2
        {
            get
            {
                return docente2;
            }
            set
            {
                docente2 = value;
            }
        }
        public string Docente3
        {
            get
            {
                return docente3;
            }
            set
            {
                docente3 = value;
            }
        }
        public string Fecha
        {

            get
            {
                return fecha;
            }
            set
            {
                fecha = value;
            }
        }
        public string Horario
        {
            get
            {
                return horario;
            }
            set
            {
                horario = value;
            }
        }
    }
}
