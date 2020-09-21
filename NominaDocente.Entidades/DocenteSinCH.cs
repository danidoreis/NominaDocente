using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NominaDocente.Entidades
{
    public class DocenteSinCH
    {
        protected string nombre;
        protected string apellido;
        protected string dni;
        protected string fechaNacimiento;
        protected string nroLegajo;
        protected string telefono;
        protected string domicilio;
        protected string eMail;
        protected string fechaIngDocencia;
        protected string fechaIngEst;

        public DocenteSinCH(string nombre, string apellido, string dni, string fechaNacimiento, string nroLegajo, string telefono, string domicilio, string eMail, string fechaIngDocencia, string fechaIngEst)
        {
            this.nombre=nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.fechaNacimiento = fechaNacimiento;
            this.nroLegajo = nroLegajo;
            this.telefono = telefono;
            this.domicilio = domicilio;
            this.eMail = eMail;
            this.fechaIngDocencia = fechaIngDocencia;
            this.fechaIngEst = fechaIngEst;
        }

        public DocenteSinCH()
        {
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return apellido;
            }
            set
            {
                apellido = value;
            }
        }

        public string Dni
        {
            get
            {
                return dni;
            }
            set
            {
                dni = value;
            }
        }

        public string FechaNacimiento
        {
            get
            {
                return fechaNacimiento;
            }
            set
            {
                fechaNacimiento = value;
            }
        }

        public string NroLegajo
        {
            get
            {
                return nroLegajo;
            }
            set
            {
                nroLegajo = value;
            }
        }

        public string Telefono
        {
            get
            {
                return telefono;
            }
            set
            {
                telefono = value;
            }
        }

        public string Domicilio
        {
            get
            {
                return domicilio;
            }
            set
            {
                domicilio = value;
            }
        }
        public string EMail
        {
            get
            {
                return eMail;
            }
            set
            {
                eMail = value;
            }
        }

        public string FechaIngDocencia
        {
            get
            {
                return fechaIngDocencia;
            }
            set
            {
                fechaIngDocencia = value;
            }
        }


        public string FechaIngEst
        {
            get
            {
                return fechaIngEst;
            }
            set
            {
                fechaIngEst = value;
            }
        }
    }
}
