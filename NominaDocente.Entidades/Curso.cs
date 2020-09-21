using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NominaDocente.Entidades
{
    public class Curso
    {
        public string id;
        private string nomCurso;

        public Curso(string id,string nomCurso)
        {
            this.id = id;
            this.nomCurso = nomCurso;
        }
        public Curso()
        {

        }
        public string Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public string NomCurso
        {
            get
            {
                return nomCurso;
            }
            set
            {
                nomCurso = value;
            }
        }
        
    }
}
