using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace NominaDocente.Entidades
{
    public class HorarioCurso
    {
        private string materia;
        private string martes;
        private string miercoles;
        private string jueves;
        private string viernes;

        public HorarioCurso(string materia,string martes,string miercoles,string jueves,string viernes)
        {
            this.materia = materia;
            this.martes = martes;
            this.miercoles = miercoles;
            this.jueves = jueves;
            this.viernes = viernes;

        }
        public HorarioCurso()
        { }

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

        public string Martes
        {
            get
            {
                return martes;
            }
            set
            {
                martes = value;
            }
        }

        public string Miercoles
        {
            get
            {
                return miercoles;
            }
            set
            {
                miercoles = value;
            }
        }

        public string Jueves
        {
            get
            {
                return jueves;
            }
            set
            {
                jueves = value;
            }
        }

        public string Viernes
        {
            get
            {
                return viernes;
            }
            set
            {
                viernes = value;
            }
        }
    }
}
