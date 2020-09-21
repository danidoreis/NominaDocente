using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NominaDocente.Entidades
{
    public class DocenteConCH:DocenteSinCH
    {

        private string materia;
        private string dia;
        private string horario;
        private string especialidad;
        private string curso;
        private string cant_modulos;


        public DocenteConCH(string nombre, string apellido, string dni, string nroLegajo, string especialidad,string curso, string materia, string dia, string horario,string cant_modulos)
        {
            this.nombre=nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.nroLegajo = nroLegajo;
            this.especialidad = especialidad;
            this.curso = curso;
            this.materia = materia;
            this.dia = dia;
            this.horario = horario;
            this.cant_modulos = cant_modulos;
            
        }

        public DocenteConCH()
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

        public string Dia
        {
            get
            {
                return dia;
            }
            set
            {
                dia = value;
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

        public string Especialidad
        {
            get
            {
                return especialidad;
            }
            set
            {
                especialidad = value;
            }
        }

        public string Curso
        {
            get
            {
                return curso;
            }
            set
            {
                curso = value;
            }
        }

        public string Cant_modulos
        {
            get
            {
                return cant_modulos;
            }
            set
            {
                cant_modulos = value;
            }
        }
    }
}
