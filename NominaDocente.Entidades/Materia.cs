using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NominaDocente.Entidades
{
    public class Materia
    {
        private string id;
        private string nombreMateria;

        public Materia(string id, string nombreMateria)
        {
            this.id = id;
            this.nombreMateria = nombreMateria;
        }
        public Materia()
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

        public string NombreMateria
        {
            get
            {
                return nombreMateria;
            }
            set
            {
                nombreMateria = value;
            }
        }
    }
}
